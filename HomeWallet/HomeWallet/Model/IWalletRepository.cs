using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWallet.Model
{
    public interface IWalletRepository
    {
        void CreateUser(User user);
        List<User> GetUsers();
        void DeleteUsers(string usersIds);
        void UpdateUser(User user);
        List<Category> GetCategories();
    }
}
