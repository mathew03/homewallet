using HomeWallet.View;

namespace HomeWallet.Model
{
    public interface IWalletView
    {
        DashboardUC GetDashboard();
        SettingsUC GetSettings();
    }
}
