using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWallet.View;
using HomeWallet.Model;

namespace HomeWallet
{
    public partial class MainForm : Form, IWalletView
    {
        DashboardUC _dashboard;
        UsersMgrUC _usersMgr;
        CategoriesMgrUC _categoriesMgr;
        GoalsDebtsMgrUC _goalsDebtsMgr;

        public MainForm()
        {
            InitializeComponent();
            _dashboard = new DashboardUC();
            _usersMgr = new UsersMgrUC();
            _categoriesMgr = new CategoriesMgrUC();
            _goalsDebtsMgr = new GoalsDebtsMgrUC();

            panel1.Controls.Add(_dashboard);
            panel1.Controls.Add(_usersMgr);
            panel1.Controls.Add(_categoriesMgr);
            panel1.Controls.Add(_goalsDebtsMgr);

            ShowTab(_dashboard);
        }

        private void ShowTab(Control tab)
        {
            _dashboard.Visible = tab is DashboardUC;
            _usersMgr.Visible = tab is UsersMgrUC;
            _categoriesMgr.Visible = tab is CategoriesMgrUC;
            _goalsDebtsMgr.Visible = tab is GoalsDebtsMgrUC;
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
        public UsersMgrUC GetUsersMgr()
        {
            return _usersMgr;
        }
        public CategoriesMgrUC GetCategoriesMgr()
        {
            return _categoriesMgr;
        }
        public GoalsDebtsMgrUC GetGoalsDebtsMgr()
        {
            return _goalsDebtsMgr;
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            ShowTab(_dashboard);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowTab(_usersMgr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowTab(_categoriesMgr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowTab(_goalsDebtsMgr);
        }
    }
}
