using System.Drawing;

namespace HomeWallet.View
{
    partial class GoalsDebtsMgrUC
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
            this.button_EditGoal = new System.Windows.Forms.Button();
            this.button_AddGoal = new System.Windows.Forms.Button();
            this.textBox_GoalName = new System.Windows.Forms.TextBox();
            this.label_catName = new System.Windows.Forms.Label();
            this.button_deleteGoals = new System.Windows.Forms.Button();
            this.checkedListBox_Goals = new System.Windows.Forms.CheckedListBox();
            this.button_EditDebt = new System.Windows.Forms.Button();
            this.button_AddDebt = new System.Windows.Forms.Button();
            this.textBox_DebtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DeleteDebts = new System.Windows.Forms.Button();
            this.checkedListBox_Debts = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_GoalValue = new System.Windows.Forms.TextBox();
            this.textBox_DebtValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_EditGoal
            // 
            this.button_EditGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_EditGoal.FlatAppearance.BorderSize = 0;
            this.button_EditGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditGoal.ForeColor = System.Drawing.Color.White;
            this.button_EditGoal.Location = new System.Drawing.Point(215, 327);
            this.button_EditGoal.Name = "button_EditGoal";
            this.button_EditGoal.Size = new System.Drawing.Size(76, 25);
            this.button_EditGoal.TabIndex = 22;
            this.button_EditGoal.Text = "Edytuj";
            this.button_EditGoal.UseVisualStyleBackColor = true;
            this.button_EditGoal.Click += new System.EventHandler(this.button_EditGoal_Click);
            // 
            // button_AddGoal
            // 
            this.button_AddGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_AddGoal.FlatAppearance.BorderSize = 0;
            this.button_AddGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddGoal.ForeColor = System.Drawing.Color.White;
            this.button_AddGoal.Location = new System.Drawing.Point(137, 327);
            this.button_AddGoal.Name = "button_AddGoal";
            this.button_AddGoal.Size = new System.Drawing.Size(72, 25);
            this.button_AddGoal.TabIndex = 21;
            this.button_AddGoal.Text = "Dodaj";
            this.button_AddGoal.UseVisualStyleBackColor = true;
            this.button_AddGoal.Click += new System.EventHandler(this.button_AddGoal_Click);
            // 
            // textBox_GoalName
            // 
            this.textBox_GoalName.Location = new System.Drawing.Point(137, 273);
            this.textBox_GoalName.Name = "textBox_GoalName";
            this.textBox_GoalName.Size = new System.Drawing.Size(154, 20);
            this.textBox_GoalName.TabIndex = 20;
            // 
            // label_catName
            // 
            this.label_catName.AutoSize = true;
            this.label_catName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_catName.ForeColor = System.Drawing.Color.White;
            this.label_catName.Location = new System.Drawing.Point(34, 271);
            this.label_catName.Name = "label_catName";
            this.label_catName.Size = new System.Drawing.Size(64, 22);
            this.label_catName.TabIndex = 19;
            this.label_catName.Text = "Nazwa";
            // 
            // button_deleteGoals
            // 
            this.button_deleteGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_deleteGoals.FlatAppearance.BorderSize = 0;
            this.button_deleteGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteGoals.ForeColor = System.Drawing.Color.White;
            this.button_deleteGoals.Location = new System.Drawing.Point(297, 80);
            this.button_deleteGoals.Name = "button_deleteGoals";
            this.button_deleteGoals.Size = new System.Drawing.Size(122, 34);
            this.button_deleteGoals.TabIndex = 18;
            this.button_deleteGoals.Text = "Usuń";
            this.button_deleteGoals.UseVisualStyleBackColor = true;
            this.button_deleteGoals.Click += new System.EventHandler(this.button_deleteGoals_Click);
            // 
            // checkedListBox_Goals
            // 
            this.checkedListBox_Goals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.checkedListBox_Goals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_Goals.ForeColor = System.Drawing.Color.White;
            this.checkedListBox_Goals.FormattingEnabled = true;
            this.checkedListBox_Goals.Location = new System.Drawing.Point(38, 80);
            this.checkedListBox_Goals.Name = "checkedListBox_Goals";
            this.checkedListBox_Goals.Size = new System.Drawing.Size(253, 167);
            this.checkedListBox_Goals.TabIndex = 17;
            // 
            // button_EditDebt
            // 
            this.button_EditDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_EditDebt.FlatAppearance.BorderSize = 0;
            this.button_EditDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditDebt.ForeColor = System.Drawing.Color.White;
            this.button_EditDebt.Location = new System.Drawing.Point(653, 327);
            this.button_EditDebt.Name = "button_EditDebt";
            this.button_EditDebt.Size = new System.Drawing.Size(76, 25);
            this.button_EditDebt.TabIndex = 29;
            this.button_EditDebt.Text = "Edytuj";
            this.button_EditDebt.UseVisualStyleBackColor = true;
            this.button_EditDebt.Click += new System.EventHandler(this.button_EditDebt_Click);
            // 
            // button_AddDebt
            // 
            this.button_AddDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_AddDebt.FlatAppearance.BorderSize = 0;
            this.button_AddDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddDebt.ForeColor = System.Drawing.Color.White;
            this.button_AddDebt.Location = new System.Drawing.Point(575, 327);
            this.button_AddDebt.Name = "button_AddDebt";
            this.button_AddDebt.Size = new System.Drawing.Size(72, 25);
            this.button_AddDebt.TabIndex = 28;
            this.button_AddDebt.Text = "Dodaj";
            this.button_AddDebt.UseVisualStyleBackColor = true;
            this.button_AddDebt.Click += new System.EventHandler(this.button_AddDebt_Click);
            // 
            // textBox_DebtName
            // 
            this.textBox_DebtName.Location = new System.Drawing.Point(575, 273);
            this.textBox_DebtName.Name = "textBox_DebtName";
            this.textBox_DebtName.Size = new System.Drawing.Size(154, 20);
            this.textBox_DebtName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nazwa";
            // 
            // button_DeleteDebts
            // 
            this.button_DeleteDebts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_DeleteDebts.FlatAppearance.BorderSize = 0;
            this.button_DeleteDebts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteDebts.ForeColor = System.Drawing.Color.White;
            this.button_DeleteDebts.Location = new System.Drawing.Point(735, 80);
            this.button_DeleteDebts.Name = "button_DeleteDebts";
            this.button_DeleteDebts.Size = new System.Drawing.Size(122, 34);
            this.button_DeleteDebts.TabIndex = 25;
            this.button_DeleteDebts.Text = "Usuń";
            this.button_DeleteDebts.UseVisualStyleBackColor = true;
            this.button_DeleteDebts.Click += new System.EventHandler(this.button_DeleteDebts_Click);
            // 
            // checkedListBox_Debts
            // 
            this.checkedListBox_Debts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.checkedListBox_Debts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_Debts.ForeColor = System.Drawing.Color.White;
            this.checkedListBox_Debts.FormattingEnabled = true;
            this.checkedListBox_Debts.Location = new System.Drawing.Point(476, 80);
            this.checkedListBox_Debts.Name = "checkedListBox_Debts";
            this.checkedListBox_Debts.Size = new System.Drawing.Size(253, 167);
            this.checkedListBox_Debts.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cele";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(472, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Zadłużenia";
            // 
            // textBox_GoalValue
            // 
            this.textBox_GoalValue.Location = new System.Drawing.Point(137, 299);
            this.textBox_GoalValue.Name = "textBox_GoalValue";
            this.textBox_GoalValue.Size = new System.Drawing.Size(154, 20);
            this.textBox_GoalValue.TabIndex = 33;
            // 
            // textBox_DebtValue
            // 
            this.textBox_DebtValue.Location = new System.Drawing.Point(575, 299);
            this.textBox_DebtValue.Name = "textBox_DebtValue";
            this.textBox_DebtValue.Size = new System.Drawing.Size(154, 20);
            this.textBox_DebtValue.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Kwota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(472, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Kwota";
            // 
            // GoalsDebtsMgrUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_DebtValue);
            this.Controls.Add(this.textBox_GoalValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_EditDebt);
            this.Controls.Add(this.button_AddDebt);
            this.Controls.Add(this.textBox_DebtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_DeleteDebts);
            this.Controls.Add(this.checkedListBox_Debts);
            this.Controls.Add(this.button_EditGoal);
            this.Controls.Add(this.button_AddGoal);
            this.Controls.Add(this.textBox_GoalName);
            this.Controls.Add(this.label_catName);
            this.Controls.Add(this.button_deleteGoals);
            this.Controls.Add(this.checkedListBox_Goals);
            this.Name = "GoalsDebtsMgrUC";
            this.Size = new System.Drawing.Size(1029, 567);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_EditGoal;
        private System.Windows.Forms.Button button_AddGoal;
        private System.Windows.Forms.TextBox textBox_GoalName;
        private System.Windows.Forms.Label label_catName;
        private System.Windows.Forms.Button button_deleteGoals;
        private System.Windows.Forms.CheckedListBox checkedListBox_Goals;
        private System.Windows.Forms.Button button_EditDebt;
        private System.Windows.Forms.Button button_AddDebt;
        private System.Windows.Forms.TextBox textBox_DebtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DeleteDebts;
        private System.Windows.Forms.CheckedListBox checkedListBox_Debts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_GoalValue;
        private System.Windows.Forms.TextBox textBox_DebtValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
