using HomeWallet.View;

namespace HomeWallet.Model
{
    public interface IWalletView
    {
        DashboardUC GetDashboard();
        UsersMgrUC GetUsersMgr();
        CategoriesMgrUC GetCategoriesMgr();
        GoalsDebtsMgrUC GetGoalsDebtsMgr();
    }
}
