using System;
using System.Drawing;
using System.Windows.Forms;
using HomeWallet.View;
using HomeWallet.Model;

namespace HomeWallet
{
    public partial class HomeWalletForm : Form, IWalletView
    {
        DashboardUC _dashboard;
        SettingsUC _settings;

        public HomeWalletForm()
        {
            InitializeComponent();
            _dashboard = new DashboardUC();
            _settings = new SettingsUC();

            panel1.Controls.Add(_dashboard);
            panel1.Controls.Add(_settings);

            ShowTab(_dashboard);
        }

        private void ShowTab(Control tab)
        {
            _dashboard.Visible = tab is DashboardUC;
            _settings.Visible = tab is SettingsUC;
        }

        private void navigation_buttons_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(0x22, 0x22, 0x22);
        }

        private void navigation_buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(20, 140, 255);
        }

        public DashboardUC GetDashboard()
        {
            return _dashboard;
        }
        public SettingsUC GetSettings()
        {
            return _settings;
        }


        private void button_dashboard_Click(object sender, EventArgs e)
        {
            ShowTab(_dashboard);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowTab(_settings);
        }
    }
}
