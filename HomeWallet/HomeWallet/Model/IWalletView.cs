using HomeWallet.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWallet.Model
{
    public interface IWalletView
    {
        DashboardUC GetDashboard();
    }
}
