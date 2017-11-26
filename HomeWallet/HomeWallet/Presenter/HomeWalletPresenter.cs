using HomeWallet.Model;
using HomeWallet.View;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        List<Operation> loadedOperations;

        public HomeWalletPresenter(IWalletView view, IWalletRepository repository)
        {
            _view = view;
            _repository = repository;
            _dashboardMgr = _view.GetDashboard();
            _settings = _view.GetSettings();
            loadedOperations = new List<Operation>();

            BindEvents();
            LoadUsers(this, null);
            LoadCategories(this, null);
            LoadOperations();
            LoadChartData();
            CalculateBalance();
        }

        private void BindEvents()
        {
            // DASHBOARD
            _dashboardMgr.FillCombos += FillDashboardCombos;
            _dashboardMgr.AddOperation += AddOperation;
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
        private void AddOperation(Operation operation)
        {
            _repository.CreateOperation(operation);
            LoadOperations();
            LoadChartData();

            if (operation.Date.Month == DateTime.Now.Month)
                CalculateBalance();
        }

        private void CalculateBalance()
        {
            List<Operation> ops = _repository.GetMonthOperations();

            float income = ops.Where(x => x.Value > 0).Sum(x => x.Value);
            float outcome = ops.Where(x => x.Value < 0).Sum(x => x.Value);

            _dashboardMgr.SetBalance(income, outcome * (-1));
        }

        private void LoadOperations()
        {
            List<Operation> operations = _repository.GetOperations().OrderByDescending(x => x.Date).ToList();
            List<User> users = _repository.GetUsers();
            List<Category> categories = _repository.GetCategories();

            List<OperationListElement> operationElements = new List<OperationListElement>();
            foreach (var operation in operations)
            {
                User user = users.FirstOrDefault(x => x.ID == operation.UserId);
                OperationListElement ole = new OperationListElement(operation.Title, operation.Description, $"{user?.FirstName} {user?.LastName}", operation.Value, operation.Date, Color.FromArgb(categories.First(x => x.ID == operation.CategoryId).Color));
                operationElements.Add(ole);
            }
            _dashboardMgr.AddOperationElements(operationElements);
        }

        private void LoadChartData()
        {
            var categories = _repository.GetCategories();
            var operations = _repository.GetMonthOperations();
            var chartData = new List<CustomChartData>();
            var colors = new List<Color>();

            foreach (var category in categories)
            {
                if (operations.Where(x => x.CategoryId == category.ID).Count() == 0)
                    continue;
                float sum = operations.Where(x => x.CategoryId == category.ID).Sum(x => x.Value);
                chartData.Add(new CustomChartData(sum, category.Name));
                colors.Add(Color.FromArgb(category.Color));
            }

            _dashboardMgr.SetChartData(colors, chartData);
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
            foreach (var cat in categories)
            {
                if (_repository.OpsAssignedToCategory(cat))
                    return;
            }
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
