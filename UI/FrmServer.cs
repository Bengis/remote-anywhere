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
    public partial class FrmServer : Form
    {
        private EServer _server;
        private readonly ServerBol _serverBol = new ServerBol();

        public FrmServer()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            try
            {
                if (_server == null) _server = new EServer();

                _server.Name = tName.Text;
                _server.Ip = tIp.Text;
                _server.Port = tPort.Text;
              
                _serverBol.Registrar(_server);

                if (_serverBol.stringBuilder.Length != 0)
                {
                    MessageBox.Show(_serverBol.stringBuilder.ToString(), "Para continuar:");
                }
                else
                {
                    MessageBox.Show("Servidor actualizado con éxito");

                    TraerTodos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void Eliminar(int id)
        {
            try
            {
                _serverBol.Eliminar(id);

                MessageBox.Show("Srvidor eliminado satisfactoriamente");

                TraerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void TraerTodos()
        {
            List<EServer> servers = _serverBol.Todos();

            if (servers.Count > 0)
            {
                Grd.AutoGenerateColumns = false;
                Grd.DataSource = servers;
                Grd.Columns["Id"].DataPropertyName = "Id";
                Grd.Columns["NameServer"].DataPropertyName = "Name";
                Grd.Columns["IpServer"].DataPropertyName = "Ip";
                Grd.Columns["PortServer"].DataPropertyName = "Port";
            }
            else
                MessageBox.Show("No existen servidores registrados");
        }

        private void TraerPorId(int id)
        {
            try
            {
                _server = _serverBol.TraerPorId(id);

                if (_server != null)
                {
                    tName.Text = _server.Name;
                    tIp.Text = _server.Ip;
                    tPort.Text = _server.Port;
                }
                else
                    MessageBox.Show("El servidor solicitado no existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            TraerTodos();
       }

        private void Grd_CurrentCellChanged(object sender, EventArgs e)
        {
            if ((Grd.CurrentCell != null) && (Grd.CurrentCell.RowIndex >= 0) && (Grd.Rows[Grd.CurrentCell.RowIndex].Cells["Id"].Value != null))
            {
                TraerPorId(Convert.ToInt32(Grd.Rows[Grd.CurrentCell.RowIndex].Cells["Id"].Value));
            }
        }

        private void AñadirRegistro_Click(object sender, EventArgs e)
        {
            tName.Text = "";
            tIp.Text = "";
            tPort.Text = "";
        }

        private void GuardarRegistro_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void EliminarRegistro_Click(object sender, EventArgs e)
        {
            if ((Grd.CurrentCell != null) && (Grd.CurrentCell.RowIndex >= 0) && (Grd.Rows[Grd.CurrentCell.RowIndex].Cells["Id"].Value != null))
            {
                Eliminar(Convert.ToInt32(Grd.Rows[Grd.CurrentCell.RowIndex].Cells["Id"].Value));
            }
        }

        public void Conectar(String sIp, String sPort)
        {
            FrmViewer frm = new FrmViewer();
            //TODO Validar las entradas
            frm.Ip = sIp;
            frm.Port = sPort;
            frm.ShowDialog();
        }

        private void Grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String sName = Convert.ToString(Grd.Rows[e.RowIndex].Cells["NameServer"].Value);
            String sIp = Convert.ToString(Grd.Rows[e.RowIndex].Cells["IpServer"].Value);
            String sPort = Convert.ToString(Grd.Rows[Grd.CurrentCell.RowIndex].Cells["PortServer"].Value);
            if (MessageBox.Show("¿Desea conectarse al servidor " + sName + " ?", "RAnywhere", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conectar(sIp, sPort);
            }
        }
    }
}
