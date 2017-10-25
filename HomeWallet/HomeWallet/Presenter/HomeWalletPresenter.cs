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

        public HomeWalletPresenter(IWalletView view, IWalletRepository repository)
        {
            _view = view;
            _repository = repository;

            BindEvents();
        }

        private void BindEvents()
        {
            DashboardUC dashboard = _view.GetDashboard();
        }
    }
}
