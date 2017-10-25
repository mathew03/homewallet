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

        public List<User> GetUsers()
        {
            using (var conn = new SQLiteConnection(_connString))
            {
                conn.Open();
                return conn.Query<User>("SELECT * FROM Users").ToList();
            }
        }
        public User GetUser(int userId)
        {
            using (var conn = new SQLiteConnection(_connString))
            {
                conn.Open();
                return conn.Query<User>($"SELECT * FROM Users WHERE ID = {userId}").First();
            }
        }
        public void CreateUser(User user)
        {
            using (var conn = new SQLiteConnection(_connString))
            {
                conn.Open();
                var query = $"INSERT INTO Users (FirstName, LastName, Salary) VALUES ('{user.FirstName}', '{user.LastName}', {user.Salary});";
                conn.Execute(query);
            }
        }
        public void DeleteUser(int userId)
        {
            using (var conn = new SQLiteConnection(_connString))
            {
                conn.Open();
                conn.Execute($"DELETE FROM Users WHERE ID = {userId};");
            }
        }
        public void UpdateUser(User user)
        {
            using (var conn = new SQLiteConnection(_connString))
            {
                conn.Open();
                conn.Execute($"UPDATE Users SET FirstName = '{user.FirstName}', LastName = '{user.LastName}', Salary = {user.Salary} WHERE ID = {user.ID};");
            }
        }


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
                LastName VARCHAR(250) NOT NULL,
                Salary INT NOT NULL
            );
            CREATE TABLE Transactions
            (
                ID INTEGER CONSTRAINT PK_TRANSACTION PRIMARY KEY AUTOINCREMENT,
                Description VARCHAR(250),
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