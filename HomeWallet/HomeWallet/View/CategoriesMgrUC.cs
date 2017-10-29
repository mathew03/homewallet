using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HomeWallet.Model;

namespace HomeWallet.View
{
    public partial class CategoriesMgrUC : UserControl
    {
        public delegate void CategoriesEventHandler(List<Category> categories);
        public delegate void CategoryEventHandler(Category category);

        public event CategoriesEventHandler DeleteCategories;
        public event CategoryEventHandler AddCategory;
        public event CategoryEventHandler EditCategory;
        public event EventHandler LoadCategories;
        public CategoriesMgrUC()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Visible = false;

            LoadCategories?.Invoke(this, null);
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button_color.BackColor = colorDialog1.Color;
        }

        private void Button_AddCategory_Click(object sender, EventArgs e)
        {
            Category newCat = new Category(textBox_catName.Text, button_color.BackColor);
            AddCategory?.Invoke(newCat);
        }

        private void button_EditCategory_Click(object sender, EventArgs e)
        {
            Category cat = (Category)checkedListBox_users.SelectedItem;
            if (cat == null)
                return;

            cat.Name = textBox_catName.Text;
            cat.Color = button_color.BackColor;
            EditCategory?.Invoke(cat);
        }

        private void button_deleteCategory_Click(object sender, EventArgs e)
        {
            if (checkedListBox_users.SelectedItems.Count == 0)
                return;

            List<Category> catToDelete = checkedListBox_users.SelectedItems.Cast<Category>().ToList();
            DeleteCategories?.Invoke(catToDelete);
        }
    }
}
