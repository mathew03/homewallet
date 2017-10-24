using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Dapper;
using HomeWallet.Model;

namespace HomeWallet.Presenter
{
    public class HomeWalletRepository
    {
        string _connString;

        public HomeWalletRepository(string connectionString)
        {
            _connString = connectionString;

            SQLiteConnection.CreateFile("walletdb.db");
        }

        public void CreateDBIfNotExists()
        {
            try
            {
                var dbQuery = "";

                using (var conn = new SQLiteConnection(_connString))
                using (var cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.CommandText = dbQuery;
                    cmd.ExecuteNonQuery();
                }

                CreateTablesIfNotExist();

                GetUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTablesIfNotExist()
        {
            var tableQuery = @"CREATE TABLE Users (
                                ID int,
                                LastName varchar(255),
                                FirstName varchar(255)
                            );";

            var fillQuery = @"INSERT INTO Users(LastName, FirstName) VALUES('Mateusz', 'Borowski');
                            INSERT INTO Users(LastName, FirstName) VALUES('Agata', 'Łodyga');";

            using (var conn = new SQLiteConnection(_connString))
            using (var cmd = new SQLiteCommand(conn))
            {
                conn.Open();
                cmd.CommandText = tableQuery;
                cmd.ExecuteNonQuery();
                cmd.CommandText = fillQuery;
                cmd.ExecuteNonQuery();
            }

        }

        public List<User> GetUsers()
        {
            string tableQuery = "SELECT FirstName, LastName FROM Users";
            using (var conn = new SQLiteConnection(_connString))
            using (var cmd = new SQLiteCommand(conn))
            {
                conn.Open();
                return conn.Query<User>(tableQuery).ToList();
            }
        }
    }
}