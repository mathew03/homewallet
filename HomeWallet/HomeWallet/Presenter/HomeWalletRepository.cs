using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Dapper;
using HomeWallet.Model;
using System.IO;

namespace HomeWallet.Presenter
{
    public class HomeWalletRepository : IWalletRepository
    {
        string _connString;
        string _dbFile = "wallet.db";

        public HomeWalletRepository(string connectionString)
        {
            _connString = connectionString;
            CreateDBIfNotExists();
        }

        private T GetSingle<T>(string query)
        {
            using (var conn = new SQLiteConnection(_connString))
            {
                conn.Open();
                return conn.Query<T>(query).First();
            }
        }
        private List<T> GetMany<T>(string query)
        {
            using (var conn = new SQLiteConnection(_connString))
            {
                conn.Open();
                return conn.Query<T>(query).ToList();
            }
        }
        private void Execute(string query)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connString))
                {
                    conn.Open();
                    conn.Execute(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CreateDBIfNotExists()
        {
            try
            {
                if(!File.Exists(_dbFile))
                {
                    SQLiteConnection.CreateFile(_dbFile);
                    CreateTables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTables()
        {
            using (var conn = new SQLiteConnection(_connString))
            using (var cmd = new SQLiteCommand(conn))
            {
                conn.Open();
                cmd.CommandText = tableCreationQuery;
                cmd.ExecuteNonQuery();
            }
        }
        //************************************************************************************************************************************
        #region DASHBOARD
        public List<Transaction> GetOperations() => GetMany<Transaction>($"SELECT * FROM Operations");
        public void CreateOperation(Transaction op) => Execute($"INSERT INTO Operations (Title, Description, Value, Date, CategoryId, UserId) VALUES ('{op.Title}', '{op.Description}', {op.Value}, '{op.Date}', {op.CategoryId}, {op.UserId});");
        public List<Transaction> GetMonthOperations()
        {
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            string sdate = date.ToShortDateString();
            return GetMany<Transaction>($"SELECT * FROM Operations WHERE Date > '{sdate}'");
        }
        #endregion
        //************************************************************************************************************************************
        #region USERS
        public List<User> GetUsers() => GetMany<User>("SELECT * FROM Users");
        public User GetUser(int userId) => GetSingle<User>($"SELECT * FROM Users WHERE ID = {userId}");
        public void CreateUser(User user) => Execute($"INSERT INTO Users (FirstName, LastName) VALUES ('{user.FirstName}', '{user.LastName}');");
        public void DeleteUsers(string userIds) => Execute($"DELETE FROM Users WHERE ID IN ({userIds});");
        public void UpdateUser(User user) => Execute($"UPDATE Users SET FirstName = '{user.FirstName}', LastName = '{user.LastName}' WHERE ID = {user.ID};");
        #endregion
        //************************************************************************************************************************************
        #region CATEGORIES
        public List<Category> GetCategories() => GetMany<Category>("SELECT * FROM Categories");
        public void CreateCategory(Category cat) => Execute($"INSERT INTO Categories (Name, Color) VALUES ('{cat.Name}', {cat.Color});");
        public void UpdateCategory(Category cat) => Execute($"UPDATE Categories SET Name = '{cat.Name}', Color = {cat.Color} WHERE ID = {cat.ID};");
        public void DeleteCategories(string catIds) => Execute($"DELETE FROM Categories WHERE ID IN ({catIds});");
        #endregion
        //************************************************************************************************************************************


        string tableCreationQuery = @"
            CREATE TABLE Categories 
            (
	            ID INTEGER CONSTRAINT PK_CATEGORY PRIMARY KEY AUTOINCREMENT,
	            Name VARCHAR(100) NOT NULL,
	            Color INT NOT NULL
            );
            CREATE TABLE Goals
            (
                ID INTEGER CONSTRAINT PK_GOAL PRIMARY KEY AUTOINCREMENT,
                Name VARCHAR(250) NOT NULL,
                Total INT NOT NULL,
                Collected INT NOT NULL
            );
            CREATE TABLE Debts
            (
                ID INTEGER CONSTRAINT PK_DEBT PRIMARY KEY AUTOINCREMENT,
                Name VARCHAR(250) NOT NULL,
                Total INT NOT NULL,
                Repaid INT NOT NULL
            );
            CREATE TABLE Users
            (
                ID INTEGER CONSTRAINT PK_USER PRIMARY KEY AUTOINCREMENT,
                FirstName VARCHAR(250) NOT NULL,
                LastName VARCHAR(250) NOT NULL
            );
            CREATE TABLE Operations
            (
                ID INTEGER CONSTRAINT PK_OPERATION PRIMARY KEY AUTOINCREMENT,
                Title VARCHAR(250),
                Description VARCHAR(250),
                Value FLOAT NOT NULL,
                Date DATE NOT NULL,
                CategoryId INT CONSTRAINT FK_TRANSACTION_CATEGORY REFERENCES Categories(ID) NOT NULL,
                UserId INT CONSTRAINT FK_TRANSACTION_USER REFERENCES Users(ID) NOT NULL
            );
            CREATE TABLE TransactionItems
            (
                ID INTEGER CONSTRAINT PK_GOAL PRIMARY KEY AUTOINCREMENT,
                Name VARCHAR(250) NOT NULL,
                Cost INT NOT NULL,
                TransactionId INT CONSTRAINT FK_TITEM_TRANSACTION REFERENCES Transactions(ID) NOT NULL
            );";
    }
}