using HomeWallet.Model;
using HomeWallet.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWallet.Presenter
{
    public class HomeWalletPresenter
    {
        IWalletRepository _repository;
        IWalletView _view;

        DashboardUC _dashboardMgr;
        SettingsUC _settings;

        List<Transaction> loadedOperations;

        public HomeWalletPresenter(IWalletView view, IWalletRepository repository)
        {
            _view = view;
            _repository = repository;
            _dashboardMgr = _view.GetDashboard();
            _settings = _view.GetSettings();
            loadedOperations = new List<Transaction>();

            BindEvents();
            LoadUsers(this, null);
            LoadCategories(this, null);
        }

        private void BindEvents()
        {
            // DASHBOARD
            _dashboardMgr.FillCombos += FillDashboardCombos;
            _dashboardMgr.AddOperation += AddOperation;
            _dashboardMgr.CalculateBalance += CalculateBalance;
            _dashboardMgr.LoadOperations += LoadOperations;
            _dashboardMgr.LoadChartData += LoadChartData;
            // SETTINGS
            _settings.Users.AddUser += AddUser;
            _settings.Users.EditUser += EditUser;
            _settings.Users.DeleteUsers += DeleteUsers;
            _settings.Cattegories.AddCategory += AddCategory;
            _settings.Cattegories.EditCategory += EditCategory;
            _settings.Cattegories.DeleteCategories += DeleteCategories;
        }

        private void FillDashboardCombos(object sender, EventArgs e)
        {
            _dashboardMgr.FillUserCombobox(_repository.GetUsers());
            _dashboardMgr.FillCategoriesCombobox(_repository.GetCategories());
        }

        //************************************************************************************************************************************
        #region DASHBOARD
        private void AddOperation(Transaction operation)
        {
            _repository.CreateOperation(operation);
            // TODO: dodac operacje do listy
            OperationListElement opEl = new OperationListElement();

            if (operation.Date.Month == DateTime.Now.Month)
                CalculateBalance(this, null);
        }

        private void CalculateBalance(object sender, EventArgs e)
        {
            List<Transaction> ops = _repository.GetMonthOperations();

            float income = ops.Where(x => x.Value > 0).Sum(x => x.Value);
            float outcome = ops.Where(x => x.Value < 0).Sum(x => x.Value);

            _dashboardMgr.SetBalance(income, outcome);
        }

        private void LoadOperations(object sender, EventArgs e)
        {
            List<Transaction> operations = _repository.GetOperations();
            // TODO: dodac operacje do listy
        }

        private void LoadChartData(object sender, EventArgs e)
        {
            
        }
        #endregion
        //************************************************************************************************************************************
        #region USERS
        private void AddUser(User user)
        {
            _repository.CreateUser(user);
            _settings.Users.ClearTextboxes();
            LoadUsers(this, null);
        }

        private void EditUser(User user)
        {
            _repository.UpdateUser(user);
            LoadUsers(this, null);
        }

        private void DeleteUsers(List<User> users)
        {
            string userIds = users[0].ID.ToString();
            for (int i = 1; i < users.Count; i++)
                userIds += $", {users[i].ID}";

            _repository.DeleteUsers(userIds);
            LoadUsers(this, null);
        }

        private void LoadUsers(object sender, EventArgs e)
        {
            _settings.Users.SetUsers(_repository.GetUsers());
        }
        #endregion
        //************************************************************************************************************************************
        #region CATEGORIES
        private void LoadCategories(object sender, EventArgs e)
        {
            _settings.Cattegories.SetCategories(_repository.GetCategories());
        }

        private void AddCategory(Category category)
        {
            _repository.CreateCategory(category);
            _settings.Cattegories.ClearTextboxes();
            LoadCategories(this, null);
        }

        private void EditCategory(Category category)
        {
            _repository.UpdateCategory(category);
            LoadCategories(this, null);
        }

        private void DeleteCategories(List<Category> categories)
        {
            string catsIds = categories[0].ID.ToString();
            for (int i = 1; i < categories.Count; i++)
                catsIds += $", {categories[i].ID}";

            _repository.DeleteCategories(catsIds);
            LoadCategories(this, null);
        }
        #endregion
        //************************************************************************************************************************************
    }
}
