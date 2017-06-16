using BOL;
using DAL;
using System    ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmConfig : Form
    {
        String sPort = "";
        int sType = -1;

        public int Type { set { sType = value; } }
        public string Port { set { sPort = value; } }
     
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void GuardarRegistro_Click(object sender, EventArgs e)
        {
            ConfigBol _configBol = new ConfigBol();
            EConfig config = new EConfig();
            config.Port = tPort.Text;
            if (ckServer.Checked && ckClient.Checked) { config.Type = 0; _configBol.Registrar(config); }
            else if (ckServer.Checked){ config.Type = 1; _configBol.Registrar(config); }
            else if (ckClient.Checked) { config.Type = 2; _configBol.Registrar(config); }
            else { MessageBox.Show("Debe seleccionar al menos una de las dos opciones"); }
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            tPort.Text = sPort;
            switch (sType)
            {
                case 0:
                    ckClient.Checked = true;
                    ckServer.Checked = true;
                    break;
                case 1:
                    ckClient.Checked = false;
                    ckServer.Checked = true;
                    break;
                case 2:
                    ckClient.Checked = true;
                    ckServer.Checked = false;
                    break;
            }
        }
    }
}
