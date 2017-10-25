using HomeWallet.Presenter;
using System;
using System.Windows.Forms;

namespace HomeWallet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm wallet = new MainForm();
            HomeWalletPresenter presenter = new HomeWalletPresenter(wallet, new HomeWalletRepository("Data Source=wallet.db;Version=3"));
            Application.Run(wallet);
        }
    }
}
