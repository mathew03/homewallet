using System.Drawing;

namespace HomeWallet.View
{
    partial class UsersMgrUC
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
            this.checkedListBox_users = new System.Windows.Forms.CheckedListBox();
            this.button_deleteUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.button_EditUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox_users
            // 
            this.checkedListBox_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.checkedListBox_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_users.ForeColor = System.Drawing.Color.White;
            this.checkedListBox_users.FormattingEnabled = true;
            this.checkedListBox_users.Location = new System.Drawing.Point(40, 58);
            this.checkedListBox_users.Name = "checkedListBox_users";
            this.checkedListBox_users.Size = new System.Drawing.Size(253, 167);
            this.checkedListBox_users.TabIndex = 0;
            this.checkedListBox_users.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_users_SelectedIndexChanged);
            // 
            // button_deleteUser
            // 
            this.button_deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_deleteUser.FlatAppearance.BorderSize = 0;
            this.button_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteUser.ForeColor = System.Drawing.Color.White;
            this.button_deleteUser.Location = new System.Drawing.Point(299, 58);
            this.button_deleteUser.Name = "button_deleteUser";
            this.button_deleteUser.Size = new System.Drawing.Size(122, 34);
            this.button_deleteUser.TabIndex = 1;
            this.button_deleteUser.Text = "Usuń";
            this.button_deleteUser.UseVisualStyleBackColor = true;
            this.button_deleteUser.Click += new System.EventHandler(this.Button_deleteUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(139, 251);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(154, 20);
            this.textBox_FirstName.TabIndex = 4;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(139, 283);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(154, 20);
            this.textBox_LastName.TabIndex = 5;
            // 
            // button_AddUser
            // 
            this.button_AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_AddUser.FlatAppearance.BorderSize = 0;
            this.button_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddUser.ForeColor = System.Drawing.Color.White;
            this.button_AddUser.Location = new System.Drawing.Point(139, 309);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(72, 23);
            this.button_AddUser.TabIndex = 6;
            this.button_AddUser.Text = "Dodaj";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.Button_AddUser_Click);
            // 
            // button_EditUser
            // 
            this.button_EditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_EditUser.FlatAppearance.BorderSize = 0;
            this.button_EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditUser.ForeColor = System.Drawing.Color.White;
            this.button_EditUser.Location = new System.Drawing.Point(217, 309);
            this.button_EditUser.Name = "button_EditUser";
            this.button_EditUser.Size = new System.Drawing.Size(76, 23);
            this.button_EditUser.TabIndex = 7;
            this.button_EditUser.Text = "Edytuj";
            this.button_EditUser.UseVisualStyleBackColor = true;
            this.button_EditUser.Click += new System.EventHandler(this.Button_EditUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Użytkownicy";
            // 
            // UsersMgrUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_EditUser);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_deleteUser);
            this.Controls.Add(this.checkedListBox_users);
            this.Name = "UsersMgrUC";
            this.Size = new System.Drawing.Size(482, 389);
            this.VisibleChanged += new System.EventHandler(this.UsersMgrUC_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_users;
        private System.Windows.Forms.Button button_deleteUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.Button button_EditUser;
        private System.Windows.Forms.Label label3;
    }
}
