using BOL;
using DAL;
using WCFServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UI
{
    public partial class FrmMain : Form
    {
        public String sInternIp = "";
        private String sExternIp = "";
        public String sPort = "";
        public int iType = -1;
        private MyServiceHost _svcHost;
       
        public FrmMain()
        {
            //Este es el formulario que se carga al arrancar el proyecto de la capa de presentacion
            InitializeComponent();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crea un formulario modal de ese tipo y lo muestra
            FrmServer frm = new FrmServer();
            frm.ShowDialog();
        }

        private void registroDeAccesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crea un formulario modal de ese tipo y lo muestra
            FrmLog frm = new FrmLog();
            frm.ShowDialog();
        }

        private void conectarAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crea un formulario modal de ese tipo y lo muestra
            FrmConnect frm = new FrmConnect();
            frm.ShowDialog();
        }

        //Llamamos a las clases Server, Main y Counter de la capa logica porque se usaran funciones de los mismos
        private readonly ServerBol _serverBol = new ServerBol();
        private readonly MainBol _mainBol = new MainBol();
        private readonly Counter _counter = new Counter();

        private void TraerTodos()
        {
            //Solicita a la capa logica los datos de los servidores
            List<EServer> servers = _serverBol.Todos();

            if (servers.Count > 0)
            {
                //Rellena el grid con los datos recibidos
                Grd.AutoGenerateColumns = false;
                Grd.DataSource = servers;
                Grd.Columns["Id"].DataPropertyName = "Id";
                Grd.Columns["NameServer"].DataPropertyName = "Name";
                Grd.Columns["IpServer"].DataPropertyName = "Ip";
                Grd.Columns["PortServer"].DataPropertyName = "Port";
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Si no existe la BBDD la crea y la llena de datos
            _mainBol.revisarBBDD();
            //Arranco los contadores
            Thread threadClient = new Thread(_counter.GetCounter);
            threadClient.Start();
            _counter.cpuUpdated += new Counter.CounterCPUUpdateHandler(cpuUpdated);
            //Configura el tipo de la aplicación
            configApp();
        }

        private void cpuUpdated(String salida)
        {
            this.status.Invoke((MethodInvoker)delegate
            {
                this.statusCounter.Text = salida;
            });
        }

        public void configApp()
        {
            EConfig config = new EConfig();
            ConfigBol _configBol = new ConfigBol();
            config=_configBol.ShowConfig();
            if (config == null) { return; }
            sPort = config.Port;
            iType = config.Type;
            if (iType == 0) //Both
            {
                this.Width = 800;
                this.Text = "Remote Anywhere";
                TLP.RowStyles[0].SizeType = SizeType.Absolute;
                TLP.RowStyles[0].Height = 174;
                TLP.ColumnStyles[0].SizeType = SizeType.Percent;
                TLP.ColumnStyles[0].Width = 50;
                TLP.ColumnStyles[1].SizeType = SizeType.Percent;
                TLP.ColumnStyles[1].Width = 50;
                TLPClient.Visible = true;
                TLPServer.Visible = true;
                lbPort.Text = "Puerto del servidor: " + sPort;
                //Me da la direccion ip interna
                sInternIp = _mainBol.dameIpInterna();
                lbInternIp.Text = "Su ip interna: " + sInternIp;
                //Arranco el Servicio WCF
                if (!(_svcHost == null)) { _svcHost.StopService(); }
                _svcHost = new MyServiceHost();
                new Thread(WCFStart).Start();
                //Me da la direccion ip externa
                sExternIp = _mainBol.dameIpExterna();
                lbExternIp.Text = "Su ip externa: " + sExternIp;
                //Llena el grid de servidores con los datos de lo servidores
                TraerTodos();
            }
            if (iType == 1) //Server
            {
                //Modifico el formulario
                this.Width = 400;
                this.Text = "RAnywhere Server";
                TLP.RowStyles[0].SizeType = SizeType.Absolute;
                TLP.RowStyles[0].Height = 87;
                TLP.ColumnStyles[1].SizeType = SizeType.Absolute;
                TLP.ColumnStyles[1].Width = 0;
                TLPClient.Visible = false;
                clientToolStripMenuItem.Visible = false;
                lbPort.Text = "Puerto del servidor: " + sPort;
                //Me da la direccion ip interna
                sInternIp = ""; 
                //_mainBol.dameIpInterna();
                lbInternIp.Text = "Su ip interna: " + sInternIp;
                //Arranco el Servicio WCF
                _svcHost = new MyServiceHost();
                new Thread(WCFStart).Start();
                //Me da la direccion ip externa
                sExternIp = _mainBol.dameIpExterna();
                lbExternIp.Text = "Su ip externa: " + sExternIp;
            }
            if (iType == 2) //Client
            {
                //Modifico el formulario
                this.Width = 400;
                this.Text = "RAnywhere Client";
                TLP.RowStyles[0].SizeType = SizeType.Absolute;
                TLP.RowStyles[0].Height = 87;
                TLP.ColumnStyles[0].SizeType = SizeType.Absolute;
                TLP.ColumnStyles[0].Width = 0;
                TLPServer.Visible = false;
                serverToolStripMenuItem.Visible = false;
                if (!(_svcHost == null)) { _svcHost.StopService(); }
                //Llena el grid de servidores con los datos de lo servidores
                TraerTodos();
            }
        }

        public void WCFStart()
        {
            _svcHost.StartService(sInternIp, sPort);
          }

        public void WCFStop()
        {
            _svcHost.StopService();
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

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crea un formulario modal de ese tipo y lo muestra
            FrmUser frm = new FrmUser();
            frm.ShowDialog();
        }

        private void salirStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crea un formulario modal de ese tipo y lo muestra
            FrmConfig frm = new FrmConfig();
            frm.Port = sPort;
            frm.Type = iType;
            frm.ShowDialog();
            configApp();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _counter.end = true;
        }
    }
}
