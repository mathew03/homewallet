﻿using System.Drawing;

namespace HomeWallet.View
{
    partial class DashboardUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_balance = new System.Windows.Forms.Panel();
            this.label_minusBalance = new System.Windows.Forms.Label();
            this.label_plusBalance = new System.Windows.Forms.Label();
            this.label_totalBalance = new System.Windows.Forms.Label();
            this.label_monthBalance = new System.Windows.Forms.Label();
            this.panel_dashboard = new System.Windows.Forms.Panel();
            this.groupBox_newOperation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_RUser = new System.Windows.Forms.ComboBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_AddOperation = new System.Windows.Forms.Button();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox_operations = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_operations = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel_newOperation = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel_balance.SuspendLayout();
            this.panel_dashboard.SuspendLayout();
            this.groupBox_newOperation.SuspendLayout();
            this.groupBox_operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Red;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BorderColor = System.Drawing.Color.Empty;
            chartArea6.BorderWidth = 0;
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 79.22356F;
            chartArea6.Position.Width = 94F;
            chartArea6.Position.X = 3F;
            chartArea6.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.IsTextAutoFit = false;
            legend6.MaximumAutoSize = 100F;
            legend6.Name = "Legend1";
            legend6.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(748, 26);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series6.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series6.BackSecondaryColor = System.Drawing.Color.Transparent;
            series6.BorderColor = System.Drawing.Color.Transparent;
            series6.BorderWidth = 0;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Color = System.Drawing.Color.Transparent;
            series6.CustomProperties = "PieLineColor=Transparent, CollectedColor=Transparent";
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            series6.IsValueShownAsLabel = true;
            series6.LabelBorderWidth = 0;
            series6.Legend = "Legend1";
            series6.Name = "IncomeOutgo";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(521, 477);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart_balance";
            // 
            // panel_balance
            // 
            this.panel_balance.Controls.Add(this.label_minusBalance);
            this.panel_balance.Controls.Add(this.label_plusBalance);
            this.panel_balance.Controls.Add(this.label_totalBalance);
            this.panel_balance.Controls.Add(this.label_monthBalance);
            this.panel_balance.Location = new System.Drawing.Point(3, 3);
            this.panel_balance.Name = "panel_balance";
            this.panel_balance.Size = new System.Drawing.Size(355, 166);
            this.panel_balance.TabIndex = 1;
            // 
            // label_minusBalance
            // 
            this.label_minusBalance.AutoSize = true;
            this.label_minusBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_minusBalance.ForeColor = System.Drawing.Color.Red;
            this.label_minusBalance.Location = new System.Drawing.Point(52, 125);
            this.label_minusBalance.Name = "label_minusBalance";
            this.label_minusBalance.Size = new System.Drawing.Size(106, 25);
            this.label_minusBalance.TabIndex = 3;
            this.label_minusBalance.Text = "- $1000.00";
            // 
            // label_plusBalance
            // 
            this.label_plusBalance.AutoSize = true;
            this.label_plusBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_plusBalance.ForeColor = System.Drawing.Color.Lime;
            this.label_plusBalance.Location = new System.Drawing.Point(47, 100);
            this.label_plusBalance.Name = "label_plusBalance";
            this.label_plusBalance.Size = new System.Drawing.Size(111, 25);
            this.label_plusBalance.TabIndex = 2;
            this.label_plusBalance.Text = "+ $5578.89";
            // 
            // label_totalBalance
            // 
            this.label_totalBalance.AutoSize = true;
            this.label_totalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_totalBalance.ForeColor = System.Drawing.Color.Lime;
            this.label_totalBalance.Location = new System.Drawing.Point(20, 58);
            this.label_totalBalance.Name = "label_totalBalance";
            this.label_totalBalance.Size = new System.Drawing.Size(150, 31);
            this.label_totalBalance.TabIndex = 1;
            this.label_totalBalance.Text = "= $4578.89";
            // 
            // label_monthBalance
            // 
            this.label_monthBalance.AutoSize = true;
            this.label_monthBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_monthBalance.ForeColor = System.Drawing.Color.White;
            this.label_monthBalance.Location = new System.Drawing.Point(19, 10);
            this.label_monthBalance.Name = "label_monthBalance";
            this.label_monthBalance.Size = new System.Drawing.Size(123, 39);
            this.label_monthBalance.TabIndex = 0;
            this.label_monthBalance.Text = "Saldo: ";
            // 
            // panel_dashboard
            // 
            this.panel_dashboard.AutoScroll = true;
            this.panel_dashboard.Controls.Add(this.groupBox_newOperation);
            this.panel_dashboard.Controls.Add(this.groupBox_operations);
            this.panel_dashboard.Controls.Add(this.linkLabel_newOperation);
            this.panel_dashboard.Controls.Add(this.panel_balance);
            this.panel_dashboard.Controls.Add(this.chart1);
            this.panel_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dashboard.Location = new System.Drawing.Point(0, 0);
            this.panel_dashboard.Name = "panel_dashboard";
            this.panel_dashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel_dashboard.Size = new System.Drawing.Size(1281, 751);
            this.panel_dashboard.TabIndex = 2;
            this.panel_dashboard.SizeChanged += new System.EventHandler(this.Panel_Dashboard_SizeChanged);
            // 
            // groupBox_newOperation
            // 
            this.groupBox_newOperation.Controls.Add(this.label2);
            this.groupBox_newOperation.Controls.Add(this.comboBox_RUser);
            this.groupBox_newOperation.Controls.Add(this.textBox_Title);
            this.groupBox_newOperation.Controls.Add(this.label1);
            this.groupBox_newOperation.Controls.Add(this.label13);
            this.groupBox_newOperation.Controls.Add(this.button_AddOperation);
            this.groupBox_newOperation.Controls.Add(this.textBox_cost);
            this.groupBox_newOperation.Controls.Add(this.label11);
            this.groupBox_newOperation.Controls.Add(this.richTextBox_description);
            this.groupBox_newOperation.Controls.Add(this.label12);
            this.groupBox_newOperation.Controls.Add(this.comboBox_category);
            this.groupBox_newOperation.Controls.Add(this.label14);
            this.groupBox_newOperation.Controls.Add(this.dateTimePicker_date);
            this.groupBox_newOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_newOperation.ForeColor = System.Drawing.Color.White;
            this.groupBox_newOperation.Location = new System.Drawing.Point(364, 3);
            this.groupBox_newOperation.Name = "groupBox_newOperation";
            this.groupBox_newOperation.Size = new System.Drawing.Size(446, 162);
            this.groupBox_newOperation.TabIndex = 20;
            this.groupBox_newOperation.TabStop = false;
            this.groupBox_newOperation.Text = "Nowa operacja";
            this.groupBox_newOperation.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Użytkownik";
            // 
            // comboBox_RUser
            // 
            this.comboBox_RUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_RUser.Items.AddRange(new object[] {
            "Użytkownik"});
            this.comboBox_RUser.Location = new System.Drawing.Point(300, 53);
            this.comboBox_RUser.Name = "comboBox_RUser";
            this.comboBox_RUser.Size = new System.Drawing.Size(129, 24);
            this.comboBox_RUser.TabIndex = 22;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(83, 22);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(129, 23);
            this.textBox_Title.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tytuł";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(227, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Kategoria";
            // 
            // button_AddOperation
            // 
            this.button_AddOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_AddOperation.FlatAppearance.BorderSize = 0;
            this.button_AddOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddOperation.ForeColor = System.Drawing.Color.White;
            this.button_AddOperation.Location = new System.Drawing.Point(83, 109);
            this.button_AddOperation.Name = "button_AddOperation";
            this.button_AddOperation.Size = new System.Drawing.Size(129, 34);
            this.button_AddOperation.TabIndex = 19;
            this.button_AddOperation.Text = "Zatwierdź";
            this.button_AddOperation.UseVisualStyleBackColor = false;
            this.button_AddOperation.Click += new System.EventHandler(this.Button_AddOperation_Click);
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(83, 51);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(129, 23);
            this.textBox_cost.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(227, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Opis";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(300, 86);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(129, 57);
            this.richTextBox_description.TabIndex = 5;
            this.richTextBox_description.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kwota";
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_category.Items.AddRange(new object[] {
            "Użytkownik"});
            this.comboBox_category.Location = new System.Drawing.Point(300, 23);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(129, 24);
            this.comboBox_category.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(10, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Data";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(83, 80);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(129, 23);
            this.dateTimePicker_date.TabIndex = 11;
            // 
            // groupBox_operations
            // 
            this.groupBox_operations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_operations.Controls.Add(this.flowLayoutPanel_operations);
            this.groupBox_operations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_operations.ForeColor = System.Drawing.Color.White;
            this.groupBox_operations.Location = new System.Drawing.Point(29, 182);
            this.groupBox_operations.Name = "groupBox_operations";
            this.groupBox_operations.Size = new System.Drawing.Size(685, 556);
            this.groupBox_operations.TabIndex = 21;
            this.groupBox_operations.TabStop = false;
            this.groupBox_operations.Text = "Operacje";
            // 
            // flowLayoutPanel_operations
            // 
            this.flowLayoutPanel_operations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_operations.AutoScroll = true;
            this.flowLayoutPanel_operations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_operations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel_operations.Location = new System.Drawing.Point(19, 28);
            this.flowLayoutPanel_operations.Name = "flowLayoutPanel_operations";
            this.flowLayoutPanel_operations.Size = new System.Drawing.Size(648, 508);
            this.flowLayoutPanel_operations.TabIndex = 7;
            this.flowLayoutPanel_operations.WrapContents = false;
            // 
            // linkLabel_newOperation
            // 
            this.linkLabel_newOperation.AutoSize = true;
            this.linkLabel_newOperation.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.linkLabel_newOperation.Location = new System.Drawing.Point(635, 168);
            this.linkLabel_newOperation.Name = "linkLabel_newOperation";
            this.linkLabel_newOperation.Size = new System.Drawing.Size(79, 13);
            this.linkLabel_newOperation.TabIndex = 4;
            this.linkLabel_newOperation.TabStop = true;
            this.linkLabel_newOperation.Text = "Dodaj operację";
            this.linkLabel_newOperation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_NewOperation_LinkClicked);
            // 
            // DashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel_dashboard);
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(1281, 751);
            this.VisibleChanged += new System.EventHandler(this.DashboardUC_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel_balance.ResumeLayout(false);
            this.panel_balance.PerformLayout();
            this.panel_dashboard.ResumeLayout(false);
            this.panel_dashboard.PerformLayout();
            this.groupBox_newOperation.ResumeLayout(false);
            this.groupBox_newOperation.PerformLayout();
            this.groupBox_operations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel_balance;
        private System.Windows.Forms.Label label_monthBalance;
        private System.Windows.Forms.Panel panel_dashboard;
        private System.Windows.Forms.Label label_totalBalance;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_operations;
        private System.Windows.Forms.LinkLabel linkLabel_newOperation;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Button button_AddOperation;
        private System.Windows.Forms.GroupBox groupBox_newOperation;
        private System.Windows.Forms.GroupBox groupBox_operations;
        private System.Windows.Forms.Label label_minusBalance;
        private System.Windows.Forms.Label label_plusBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_RUser;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label1;
    }
}
