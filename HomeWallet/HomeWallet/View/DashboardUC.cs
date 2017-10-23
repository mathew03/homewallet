using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWallet.Model;
using System.Globalization;

namespace HomeWallet.View
{
    public partial class DashboardUC : UserControl
    {
        Color[] CUSTOM_CHART_COLORS = {
            Color.FromArgb(0,130,255),
            Color.FromArgb(36, 100, 166),
            Color.FromArgb(130, 190, 255),
            Color.FromArgb(30, 230, 255),
            Color.FromArgb(0, 165, 185),
            Color.FromArgb(85, 90, 255)
        };
        List<BudgetElement> data = new List<BudgetElement>();
        public DashboardUC()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            chart1.PaletteCustomColors = CUSTOM_CHART_COLORS;
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            label1.Text += monthName;

           

            data.Add(new BudgetElement
            {
                ID = 1,
                Title = "Paliwo",
                Value = 450,
                Type = 1,
                 ProductListId = 1,
                 UserId = 1
            });
            data.Add(new BudgetElement
            {
                ID = 1,
                Title = "Zakupy",
                Value = 300,
                Type = 1,
                ProductListId = 2,
                UserId = 1
            });
            data.Add(new BudgetElement
            {
                ID = 1,
                Title = "Kosmetyki",
                Value = 378,
                Type = 1,
                ProductListId = 2,
                UserId = 1
            });
            data.Add(new BudgetElement
            {
                ID = 1,
                Title = "Słodycze",
                Value = 130,
                Type = 1,
                ProductListId = 2,
                UserId = 1
            });

            chart1.DataSource = data;

            chart1.Series["IncomeOutgo"].XValueMember = "Title";
            chart1.Series["IncomeOutgo"].YValueMembers = "Value";

            flowLayoutPanel1.Controls.Add(new OperationListElement());
            flowLayoutPanel1.Controls.Add(new OperationListElement());
            flowLayoutPanel1.Controls.Add(new OperationListElement());
            flowLayoutPanel1.Controls.Add(new OperationListElement());
            flowLayoutPanel1.Controls.Add(new OperationListElement());
            flowLayoutPanel1.Controls.Add(new OperationListElement());
            flowLayoutPanel1.Controls.Add(new OperationListElement());
            flowLayoutPanel1.Controls.Add(new OperationListElement());
            flowLayoutPanel1.Controls.Add(new OperationListElement());
            flowLayoutPanel1.Controls.Add(new OperationListElement());
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                item.Width = flowLayoutPanel1.Width - 25;
            }
        }

        private void flowLayoutPanel1_SizeChanged_1(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = true;
            data.Add(new BudgetElement
            {
                ID = 1,
                Title = "Słodycze",
                Value = 130,
                Type = 1,
                ProductListId = 2,
                UserId = 1
            });


            chart1.DataBind();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void chart1_PostPaint(object sender, System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e)
        {

        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            if(panel2.Width > 1300)
            {
                chart1.Location = new Point(1300 - chart1.Width + ((panel2.Width - 1300) / 2), chart1.Top);
                groupBox1.Location = new Point(1300 - groupBox1.Width + ((panel2.Width - 1300) / 2), groupBox1.Top);
            }
        }
    }
}
