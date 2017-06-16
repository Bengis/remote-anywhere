using BOL;
using DAL;
using System;
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
    public partial class FrmConnect : Form
    {
        private EServer _server=null;
        private readonly ServerBol _serverBol = new ServerBol();

        public FrmConnect()
        {
            InitializeComponent();
        }

        private void ConectarRegistro_Click(object sender, EventArgs e)
        {
            Conectar(tIp.Text, tPort.Text);
        }

        private void GuardarRegistro_Click(object sender, EventArgs e)
        {
            _server.Name = tName.Text;
            _server.Ip = tIp.Text;
            _server.Port = tPort.Text;
            _serverBol.Registrar(_server);
        }

        public void Conectar(String sIp, String sPort)
        {
            FrmViewer frm = new FrmViewer();
            //TODO Validar las entradas
            frm.Ip = sIp;
            frm.Port = sPort;
            frm.ShowDialog();
        }
    }
}
