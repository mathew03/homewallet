using System.Drawing;

namespace HomeWallet.View
{
    partial class CategoriesMgrUC
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
            this.button_EditCategory = new System.Windows.Forms.Button();
            this.button_AddCategory = new System.Windows.Forms.Button();
            this.textBox_catName = new System.Windows.Forms.TextBox();
            this.label_catName = new System.Windows.Forms.Label();
            this.button_deleteCategory = new System.Windows.Forms.Button();
            this.checkedListBox_users = new System.Windows.Forms.CheckedListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_color = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_EditCategory
            // 
            this.button_EditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_EditCategory.FlatAppearance.BorderSize = 0;
            this.button_EditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditCategory.ForeColor = System.Drawing.Color.White;
            this.button_EditCategory.Location = new System.Drawing.Point(218, 306);
            this.button_EditCategory.Name = "button_EditCategory";
            this.button_EditCategory.Size = new System.Drawing.Size(76, 25);
            this.button_EditCategory.TabIndex = 15;
            this.button_EditCategory.Text = "Edytuj";
            this.button_EditCategory.UseVisualStyleBackColor = true;
            this.button_EditCategory.Click += new System.EventHandler(this.button_EditCategory_Click);
            // 
            // button_AddCategory
            // 
            this.button_AddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_AddCategory.FlatAppearance.BorderSize = 0;
            this.button_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddCategory.ForeColor = System.Drawing.Color.White;
            this.button_AddCategory.Location = new System.Drawing.Point(140, 306);
            this.button_AddCategory.Name = "button_AddCategory";
            this.button_AddCategory.Size = new System.Drawing.Size(72, 25);
            this.button_AddCategory.TabIndex = 14;
            this.button_AddCategory.Text = "Dodaj";
            this.button_AddCategory.UseVisualStyleBackColor = true;
            this.button_AddCategory.Click += new System.EventHandler(this.Button_AddCategory_Click);
            // 
            // textBox_catName
            // 
            this.textBox_catName.Location = new System.Drawing.Point(140, 252);
            this.textBox_catName.Name = "textBox_catName";
            this.textBox_catName.Size = new System.Drawing.Size(154, 20);
            this.textBox_catName.TabIndex = 12;
            // 
            // label_catName
            // 
            this.label_catName.AutoSize = true;
            this.label_catName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_catName.ForeColor = System.Drawing.Color.White;
            this.label_catName.Location = new System.Drawing.Point(37, 250);
            this.label_catName.Name = "label_catName";
            this.label_catName.Size = new System.Drawing.Size(64, 22);
            this.label_catName.TabIndex = 10;
            this.label_catName.Text = "Nazwa";
            // 
            // button_deleteCategory
            // 
            this.button_deleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_deleteCategory.FlatAppearance.BorderSize = 0;
            this.button_deleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteCategory.ForeColor = System.Drawing.Color.White;
            this.button_deleteCategory.Location = new System.Drawing.Point(300, 59);
            this.button_deleteCategory.Name = "button_deleteCategory";
            this.button_deleteCategory.Size = new System.Drawing.Size(122, 34);
            this.button_deleteCategory.TabIndex = 9;
            this.button_deleteCategory.Text = "Usuń";
            this.button_deleteCategory.UseVisualStyleBackColor = true;
            this.button_deleteCategory.Click += new System.EventHandler(this.button_deleteCategory_Click);
            // 
            // checkedListBox_users
            // 
            this.checkedListBox_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.checkedListBox_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_users.ForeColor = System.Drawing.Color.White;
            this.checkedListBox_users.FormattingEnabled = true;
            this.checkedListBox_users.Location = new System.Drawing.Point(41, 59);
            this.checkedListBox_users.Name = "checkedListBox_users";
            this.checkedListBox_users.Size = new System.Drawing.Size(253, 167);
            this.checkedListBox_users.TabIndex = 8;
            // 
            // button_color
            // 
            this.button_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_color.FlatAppearance.BorderSize = 0;
            this.button_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color.ForeColor = System.Drawing.Color.White;
            this.button_color.Location = new System.Drawing.Point(140, 275);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(154, 25);
            this.button_color.TabIndex = 16;
            this.button_color.Text = "Kolor";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kategorie";
            // 
            // CategoriesMgrUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_color);
            this.Controls.Add(this.button_EditCategory);
            this.Controls.Add(this.button_AddCategory);
            this.Controls.Add(this.textBox_catName);
            this.Controls.Add(this.label_catName);
            this.Controls.Add(this.button_deleteCategory);
            this.Controls.Add(this.checkedListBox_users);
            this.Name = "CategoriesMgrUC";
            this.Size = new System.Drawing.Size(493, 378);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_EditCategory;
        private System.Windows.Forms.Button button_AddCategory;
        private System.Windows.Forms.TextBox textBox_catName;
        private System.Windows.Forms.Label label_catName;
        private System.Windows.Forms.Button button_deleteCategory;
        private System.Windows.Forms.CheckedListBox checkedListBox_users;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Label label2;
    }
}
