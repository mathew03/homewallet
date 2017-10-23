using System.Drawing;

namespace HomeWallet
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_sideMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_sideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_sideMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1415, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_sideMenu
            // 
            this.panel_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel_sideMenu.Controls.Add(this.button4);
            this.panel_sideMenu.Controls.Add(this.button3);
            this.panel_sideMenu.Controls.Add(this.button2);
            this.panel_sideMenu.Controls.Add(this.button1);
            this.panel_sideMenu.Controls.Add(this.button_dashboard);
            this.panel_sideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sideMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_sideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_sideMenu.Name = "panel_sideMenu";
            this.panel_sideMenu.Size = new System.Drawing.Size(200, 661);
            this.panel_sideMenu.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(0, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "O programie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseEnter += new System.EventHandler(this.navigation_buttons_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.navigation_buttons_MouseLeave);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(0, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Zadłużenia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseEnter += new System.EventHandler(this.navigation_buttons_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.navigation_buttons_MouseLeave);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(0, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kategorie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseEnter += new System.EventHandler(this.navigation_buttons_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.navigation_buttons_MouseLeave);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(0, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Użytkownicy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseEnter += new System.EventHandler(this.navigation_buttons_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.navigation_buttons_MouseLeave);
            // 
            // button_dashboard
            // 
            this.button_dashboard.FlatAppearance.BorderSize = 0;
            this.button_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_dashboard.Location = new System.Drawing.Point(0, 9);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(200, 44);
            this.button_dashboard.TabIndex = 0;
            this.button_dashboard.Text = "Panel główny";
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            this.button_dashboard.MouseEnter += new System.EventHandler(this.navigation_buttons_MouseEnter);
            this.button_dashboard.MouseLeave += new System.EventHandler(this.navigation_buttons_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 655);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1415, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Home wallet";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_sideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_sideMenu;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

