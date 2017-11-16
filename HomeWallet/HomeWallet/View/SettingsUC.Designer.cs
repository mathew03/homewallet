namespace HomeWallet.View
{
    partial class SettingsUC
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
            this.usersMgrUC1 = new HomeWallet.View.UsersMgrUC();
            this.categoriesMgrUC1 = new HomeWallet.View.CategoriesMgrUC();
            this.SuspendLayout();
            // 
            // usersMgrUC1
            // 
            this.usersMgrUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.usersMgrUC1.Location = new System.Drawing.Point(3, 3);
            this.usersMgrUC1.Name = "usersMgrUC1";
            this.usersMgrUC1.Size = new System.Drawing.Size(482, 389);
            this.usersMgrUC1.TabIndex = 0;
            // 
            // categoriesMgrUC1
            // 
            this.categoriesMgrUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.categoriesMgrUC1.Location = new System.Drawing.Point(491, 3);
            this.categoriesMgrUC1.Name = "categoriesMgrUC1";
            this.categoriesMgrUC1.Size = new System.Drawing.Size(505, 389);
            this.categoriesMgrUC1.TabIndex = 1;
            // 
            // SettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoriesMgrUC1);
            this.Controls.Add(this.usersMgrUC1);
            this.Name = "SettingsUC";
            this.Size = new System.Drawing.Size(1005, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private UsersMgrUC usersMgrUC1;
        private CategoriesMgrUC categoriesMgrUC1;
    }
}
