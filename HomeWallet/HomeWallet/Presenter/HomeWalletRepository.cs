using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Operation> GetOperations() => GetMany<Operation>($"SELECT * FROM Operations");
        public void CreateOperation(Operation op) => Execute($"INSERT INTO Operations (Title, Description, Value, Date, CategoryId, UserId) VALUES ('{op.Title}', '{op.Description}', {op.Value}, '{op.Date}', {op.CategoryId}, {op.UserId});");
        public List<Operation> GetMonthOperations()
        {
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            string sdate = date.ToShortDateString();
            return GetMany<Operation>($"SELECT * FROM Operations WHERE Date > '{sdate}'");
        }
        #endregion
        //************************************************************************************************************************************
        #region USERS
        public List<User> GetUsers() => GetMany<User>("SELECT * FROM Users");
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
        public bool OpsAssignedToCategory(Category categgory) => GetOperations().Where(x => x.CategoryId == categgory.ID).Count() > 0;
        #endregion
        //************************************************************************************************************************************


        string tableCreationQuery = @"
            CREATE TABLE Categories 
            (
	            ID INTEGER CONSTRAINT PK_CATEGORY PRIMARY KEY AUTOINCREMENT,
	            Name VARCHAR(100) NOT NULL,
	            Color INT NOT NULL
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
                Date VARCHAR(300) NOT NULL,
                CategoryId INT CONSTRAINT FK_TRANSACTION_CATEGORY REFERENCES Categories(ID) NOT NULL,
                UserId INT CONSTRAINT FK_TRANSACTION_USER REFERENCES Users(ID) NOT NULL
            );";
    }
}