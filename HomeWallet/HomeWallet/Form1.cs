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
        public MainForm()
        {
            InitializeComponent();
            _dashboard = new DashboardUC();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void navigation_buttons_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(0x22, 0x22, 0x22);
        }

        private void navigation_buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(20, 140, 255);
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(new DashboardUC());
        }

        public DashboardUC GetDashboard()
        {
            return _dashboard;
        }
    }
}
