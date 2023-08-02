using DataMeshGroup.Fusion;
using DataMeshGroup.Fusion.Model;
using DataMeshGroup.Fusion.Pairing.WinForms;

namespace Pairing
{
    public partial class MainForm : Form
    {
        private FusionClient fusionClient;
        private string saleID;
        private string poiID;
        private string kek;

        public MainForm()
        {
            InitializeComponent();

            fusionClient = CreateFusionClient();
        }

        private FusionClient CreateFusionClient()
        {
            string certificationCode = "98cf9dfc-0db7-4a92-8b8cb66d4d2d7169"; // test environment only - replace for production
            string providerIdentification = "Company A"; // test environment only - replace for production
            string applicationName = "POS Retail"; // test environment only - replace for production
            string softwareVersion = "01.00.00"; // test environment only - replace for production

            return new FusionClient(useTestEnvironment: true)
            {
                LoginRequest = new LoginRequest(providerIdentification, applicationName, softwareVersion, certificationCode)
            };
        }

        private void BtnPairWithTerminal_Click(object sender, EventArgs e)
        {
            PairingDialog pairingDialog = new PairingDialog(fusionClient, kek);
            if (pairingDialog.ShowDialog() == DialogResult.OK)
            {
                saleID = pairingDialog.SaleID;
                poiID = pairingDialog.POIID;
                kek = pairingDialog.KEK;
                // TODO : write credentials to storage
            }
        }
    }
}