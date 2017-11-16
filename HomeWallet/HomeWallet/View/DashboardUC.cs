using System;
using System.Collections.Generic;
using System.Drawing;
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

        List<Transaction> chartData = new List<Transaction>();

        public delegate void OperationEventHandler(Transaction operation);
        public event EventHandler LoadOperations;
        public event EventHandler LoadChartData;
        public event EventHandler CalculateBalance;
        public event OperationEventHandler AddOperation;
        public event EventHandler FillCombos;


        public DashboardUC()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Visible = false;
            InitChart();
            SetCurrentMonthName();
            LoadOperations?.Invoke(this, null);
            LoadChartData?.Invoke(this, null);
            CalculateBalance?.Invoke(this, null);
        }

        #region PRIVATE HELPERS
        private void SetCurrentMonthName()
        {
            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            label_monthBalance.Text += monthName;
        }

        private void InitChart()
        {
            chart1.PaletteCustomColors = CUSTOM_CHART_COLORS;
            chart1.DataSource = chartData;
            chart1.Series["IncomeOutgo"].XValueMember = "Title";
            chart1.Series["IncomeOutgo"].YValueMembers = "Value";
        }
        #endregion

        #region PUBLIC METHODS
        public void AddOperationElements(List<OperationListElement> data)
        {
            foreach (var item in data)
            {
                flowLayoutPanel_operations.Controls.Add(item);
                item.Width = flowLayoutPanel_operations.Width - 20;
            }
        }
        public void AddChartData(List<Transaction> data)
        {
            chartData.AddRange(data);
            chart1.DataBind();
        }
        public void SetChartData(List<Transaction> data)
        {
            chartData.Clear();
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
            Transaction operation = new Transaction(textBox_Title.Text, richTextBox_description.Text, float.Parse(textBox_cost.Text), dateTimePicker_date.Value, (Category)comboBox_category.SelectedItem,  (User)comboBox_RUser.SelectedItem);
            AddOperation?.Invoke(operation);
            groupBox_newOperation.Visible = false;
        }

        private bool ValidateOperation()
        {
            if (string.IsNullOrEmpty(textBox_Title.Text) || string.IsNullOrEmpty(richTextBox_description.Text) || !float.TryParse(textBox_cost.Text, out float x))
                return false;
            return true;
        }

        private void Panel_Dashboard_SizeChanged(object sender, EventArgs e)
        {
            if(panel_dashboard.Width > 1300)
            {
                chart1.Location = new Point(1300 - chart1.Width + ((panel_dashboard.Width - 1300) / 2), chart1.Top);
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
