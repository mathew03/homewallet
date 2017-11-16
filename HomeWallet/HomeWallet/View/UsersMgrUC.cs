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

namespace HomeWallet.View
{
    public partial class UsersMgrUC : UserControl
    {
        public delegate void UsersEventHandler(List<User> users);
        public delegate void UserEventHandler(User users);

        public event UsersEventHandler DeleteUsers;
        public event UserEventHandler AddUser;
        public event UserEventHandler EditUser;
        public event EventHandler LoadUsers;

        List<User> users;
        public UsersMgrUC()
        {
            InitializeComponent();
            LoadUsers?.Invoke(this, null);
        }

        public void ClearTextboxes()
        {
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
        }

        public void SetUsers(List<User> users)
        {
            this.users = users;
            checkedListBox_users.Items.Clear();
            checkedListBox_users.Items.AddRange(this.users.ToArray());
        }

        private void Button_deleteUser_Click(object sender, EventArgs e)
        {
            if (checkedListBox_users.CheckedItems.Count == 0)
                return;
            
            List<User> usersToDelete = checkedListBox_users.CheckedItems.Cast<User>().ToList();
            DeleteUsers?.Invoke(usersToDelete);
        }

        private void Button_AddUser_Click(object sender, EventArgs e)
        {
            User newUser = new User(textBox_FirstName.Text, textBox_LastName.Text);
            AddUser?.Invoke(newUser);
        }

        private void Button_EditUser_Click(object sender, EventArgs e)
        {
            User userEdit = (User)checkedListBox_users.SelectedItem;
            userEdit.FirstName = textBox_FirstName.Text;
            userEdit.LastName = textBox_LastName.Text;
            EditUser?.Invoke(userEdit);
        }

        private void UsersMgrUC_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                LoadUsers?.Invoke(this, null);
        }

        private void checkedListBox_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = (User)checkedListBox_users.SelectedItem;
            if (selectedUser != null)
            {
                textBox_FirstName.Text = selectedUser.FirstName;
                textBox_LastName.Text = selectedUser.LastName;
            }
            else
                ClearTextboxes();
        }
    }
}