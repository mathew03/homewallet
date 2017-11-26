using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HomeWallet.Model;
using System.Globalization;
using System.Linq;

namespace HomeWallet.View
{
    public partial class DashboardUC : UserControl
    {
        List<CustomChartData> chartData = new List<CustomChartData>();

        public delegate void OperationEventHandler(Operation operation);
        public event OperationEventHandler AddOperation;
        public event EventHandler FillCombos;


        public DashboardUC()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Visible = false;
            InitChart();
            SetCurrentMonthName();

            dateTimePicker_date.Format = DateTimePickerFormat.Custom;
            dateTimePicker_date.CustomFormat = "dd/MM/yy HH:mm";
        }

        #region PRIVATE HELPERS
        private void SetCurrentMonthName()
        {
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            label_monthBalance.Text += monthName;
        }

        private void InitChart()
        {
            chart1.DataSource = chartData;
            chart1.Series["IncomeOutgo"].XValueMember = "CategoryName";
            chart1.Series["IncomeOutgo"].YValueMembers = "Total";
        }
        #endregion

        #region PUBLIC METHODS
        public void AddOperationElements(List<OperationListElement> data)
        {
            flowLayoutPanel_operations.Controls.Clear();
            foreach (var item in data)
            {
                flowLayoutPanel_operations.Controls.Add(item);
                item.Width = flowLayoutPanel_operations.Width - 30;
            }
        }

        public void SetChartData(List<Color> colors, List<CustomChartData> data)
        {
            chartData.Clear();
            chart1.PaletteCustomColors = colors.ToArray();
            chartData.AddRange(data);
            chart1.DataBind();
        }
        public void FillUserCombobox(List<User> users)
        {
            comboBox_RUser.DataSource = users;
        }
        public void FillCategoriesCombobox(List<Category> cats)
        {
            comboBox_category.DataSource = cats;
        }
        public void SetBalance(float income, float outcome)
        {
            var total = income - outcome;
            if (total < 0)
                label_totalBalance.ForeColor = Color.Red;
            else
                label_totalBalance.ForeColor = Color.Lime;
            label_totalBalance.Text = $"= {total.ToString()} zł";
            label_plusBalance.Text = $"+ {income.ToString()} zł";
            label_minusBalance.Text = $"- {outcome.ToString()} zł";
        }
        #endregion



        private void LinkLabel_NewOperation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox_newOperation.Visible = true;
        }



        private void Button_AddOperation_Click(object sender, EventArgs e)
        {
            if (!ValidateOperation())
                return;
            var value = textBox_cost.Text.Contains("+") ? float.Parse(textBox_cost.Text) : float.Parse("-" + textBox_cost.Text);
            Operation operation = new Operation(textBox_Title.Text, richTextBox_description.Text, value, dateTimePicker_date.Value, (Category)comboBox_category.SelectedItem,  (User)comboBox_RUser.SelectedItem);
            AddOperation?.Invoke(operation);
            groupBox_newOperation.Visible = false;
        }

        private bool ValidateOperation()
        {
            if (string.IsNullOrEmpty(textBox_Title.Text) || !float.TryParse(textBox_cost.Text, out float x))
                return false;
            return true;
        }

        private void Panel_Dashboard_SizeChanged(object sender, EventArgs e)
        {
            if(panel_dashboard.Width > 1200)
            {
                chart1.Location = new Point(1200 - chart1.Width + ((panel_dashboard.Width - 1200) / 2), chart1.Top);
            }
        }

        private void DashboardUC_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                FillCombos?.Invoke(this, null);
            }
        }

    }
}
