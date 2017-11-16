using System.Windows.Forms;

namespace HomeWallet.View
{
    public partial class SettingsUC : UserControl
    {
        public SettingsUC()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Visible = false;
        }

        public CategoriesMgrUC Cattegories => categoriesMgrUC1;

        public UsersMgrUC Users => usersMgrUC1;
    }
}
