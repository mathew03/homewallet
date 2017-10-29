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
        UsersMgrUC _usersMgr;
        CategoriesMgrUC _categoriesMgr;
        GoalsDebtsMgrUC _goalsDebtsMgr;

        public HomeWalletPresenter(IWalletView view, IWalletRepository repository)
        {
            _view = view;
            _repository = repository;
            _dashboardMgr = _view.GetDashboard();
            _usersMgr = _view.GetUsersMgr();
            _categoriesMgr = _view.GetCategoriesMgr();
            _goalsDebtsMgr = _view.GetGoalsDebtsMgr();

            BindEvents();
        }

        private void BindEvents()
        {
            // DASHBOARD
            _dashboardMgr.FillCombos += FillDashboardCombos;
            _dashboardMgr.AddOperation += AddOperation;
            _dashboardMgr.CalculateBalance += CalculateBalance;
            _dashboardMgr.LoadOperations += LoadOperations;
            _dashboardMgr.LoadChartData += LoadChartData;
            // USERS
            _usersMgr.AddUser += AddUser;
            _usersMgr.EditUser += EditUser;
            _usersMgr.DeleteUsers += DeleteUsers;
            _usersMgr.LoadUsers += LoadUsers;
            // CATEGORIES
            _categoriesMgr.LoadCategories += LoadCategories;
            _categoriesMgr.AddCategory += AddCategory;
            _categoriesMgr.EditCategory += EditCategory;
            _categoriesMgr.DeleteCategories += DeleteCategories;
            // GOALSDEBTS
            _goalsDebtsMgr.LoadTargets += LoadTargets;
            _goalsDebtsMgr.AddTarget += AddTarget;
            _goalsDebtsMgr.EditTarget += EditTarget;
            _goalsDebtsMgr.DeleteTargets += DeleteTargets;
        }

        private void FillDashboardCombos(object sender, EventArgs e)
        {
            _dashboardMgr.FillUserCombobox(_repository.GetUsers());
            _dashboardMgr.FillCategoriesCombobox(_repository.GetCategories());
        }

        //************************************************************************************************************************************
        #region DASHBOARD
        private void AddOperation(object sender, EventArgs e)
        {
            
        }

        private void CalculateBalance(object sender, EventArgs e)
        {
            
        }

        private void LoadOperations(object sender, EventArgs e)
        {
           
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
            _usersMgr.ClearTextboxes();
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
            _usersMgr.SetUsers(_repository.GetUsers());
        }
        #endregion
        //************************************************************************************************************************************
        #region CATEGORIES
        private void LoadCategories(object sender, EventArgs e)
        {
           
        }

        private void AddCategory(Category category)
        {
           
        }

        private void EditCategory(Category category)
        {
            
        }

        private void DeleteCategories(List<Category> categories)
        {
           
        }
        #endregion
        //************************************************************************************************************************************
        #region GOALSDEBTS
        private void LoadTargets(object sender, EventArgs e)
        {
            
        }

        private void AddTarget(Target target)
        {
            
        }

        private void EditTarget(Target target)
        {
            
        }

        private void DeleteTargets(List<Target> targets)
        {
            
        }
        #endregion
        //************************************************************************************************************************************
    }
}
