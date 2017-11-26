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
        void CreateCategory(Category cat);
        void UpdateCategory(Category cat);
        void DeleteCategories(string catIds);

        void CreateOperation(Operation op);
        List<Operation> GetOperations();
        List<Operation> GetMonthOperations();
        bool OpsAssignedToCategory(Category categgory);

    }
}
