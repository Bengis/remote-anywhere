namespace UI
{
    partial class FrmServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.gListado = new System.Windows.Forms.GroupBox();
            this.Grd = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDetalles = new System.Windows.Forms.GroupBox();
            this.lPort = new System.Windows.Forms.Label();
            this.tPort = new System.Windows.Forms.TextBox();
            this.lIp = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tIp = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AñadirRegistro = new System.Windows.Forms.ToolStripButton();
            this.GuardarRegistro = new System.Windows.Forms.ToolStripButton();
            this.EliminarRegistro = new System.Windows.Forms.ToolStripButton();
            this.gListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            this.gDetalles.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gListado
            // 
            this.gListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gListado.Controls.Add(this.Grd);
            this.gListado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.gListado.Location = new System.Drawing.Point(12, 157);
            this.gListado.Name = "gListado";
            this.gListado.Size = new System.Drawing.Size(648, 392);
            this.gListado.TabIndex = 0;
            this.gListado.TabStop = false;
            this.gListado.Text = "Listado";
            // 
            // Grd
            // 
            this.Grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameServer,
            this.IpServer,
            this.PortServer});
            this.Grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd.Location = new System.Drawing.Point(3, 16);
            this.Grd.Name = "Grd";
            this.Grd.Size = new System.Drawing.Size(642, 373);
            this.Grd.TabIndex = 1;
            this.Grd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_CellDoubleClick);
            this.Grd.CurrentCellChanged += new System.EventHandler(this.Grd_CurrentCellChanged);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // NameServer
            // 
            this.NameServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameServer.HeaderText = "Nombre";
            this.NameServer.Name = "NameServer";
            this.NameServer.Width = 76;
            // 
            // IpServer
            // 
            this.IpServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IpServer.HeaderText = "IP";
            this.IpServer.Name = "IpServer";
            // 
            // PortServer
            // 
            this.PortServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PortServer.HeaderText = "Puerto";
            this.PortServer.Name = "PortServer";
            this.PortServer.Width = 69;
            // 
            // gDetalles
            // 
            this.gDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gDetalles.Controls.Add(this.lPort);
            this.gDetalles.Controls.Add(this.tPort);
            this.gDetalles.Controls.Add(this.lIp);
            this.gDetalles.Controls.Add(this.lName);
            this.gDetalles.Controls.Add(this.tIp);
            this.gDetalles.Controls.Add(this.tName);
            this.gDetalles.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.gDetalles.Location = new System.Drawing.Point(12, 39);
            this.gDetalles.Name = "gDetalles";
            this.gDetalles.Size = new System.Drawing.Size(645, 112);
            this.gDetalles.TabIndex = 1;
            this.gDetalles.TabStop = false;
            this.gDetalles.Text = "Detalles";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(24, 74);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(47, 14);
            this.lPort.TabIndex = 5;
            this.lPort.Text = "Puerto:";
            // 
            // tPort
            // 
            this.tPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.tPort.Location = new System.Drawing.Point(128, 74);
            this.tPort.Name = "tPort";
            this.tPort.Size = new System.Drawing.Size(100, 20);
            this.tPort.TabIndex = 4;
            // 
            // lIp
            // 
            this.lIp.AutoSize = true;
            this.lIp.Location = new System.Drawing.Point(24, 51);
            this.lIp.Name = "lIp";
            this.lIp.Size = new System.Drawing.Size(20, 14);
            this.lIp.TabIndex = 3;
            this.lIp.Text = "Ip:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(24, 25);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(54, 14);
            this.lName.TabIndex = 2;
            this.lName.Text = "Nombre:";
            // 
            // tIp
            // 
            this.tIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.tIp.Location = new System.Drawing.Point(128, 48);
            this.tIp.Name = "tIp";
            this.tIp.Size = new System.Drawing.Size(100, 20);
            this.tIp.TabIndex = 1;
            // 
            // tName
            // 
            this.tName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.tName.Location = new System.Drawing.Point(128, 19);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(100, 20);
            this.tName.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AñadirRegistro,
            this.GuardarRegistro,
            this.EliminarRegistro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AñadirRegistro
            // 
            this.AñadirRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AñadirRegistro.Image = ((System.Drawing.Image)(resources.GetObject("AñadirRegistro.Image")));
            this.AñadirRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AñadirRegistro.Name = "AñadirRegistro";
            this.AñadirRegistro.Size = new System.Drawing.Size(23, 22);
            this.AñadirRegistro.Text = "Añadir registro";
            this.AñadirRegistro.Click += new System.EventHandler(this.AñadirRegistro_Click);
            // 
            // GuardarRegistro
            // 
            this.GuardarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuardarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("GuardarRegistro.Image")));
            this.GuardarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarRegistro.Name = "GuardarRegistro";
            this.GuardarRegistro.Size = new System.Drawing.Size(23, 22);
            this.GuardarRegistro.Text = "Guardar registro";
            this.GuardarRegistro.ToolTipText = "Guardar registro";
            this.GuardarRegistro.Click += new System.EventHandler(this.GuardarRegistro_Click);
            // 
            // EliminarRegistro
            // 
            this.EliminarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EliminarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("EliminarRegistro.Image")));
            this.EliminarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarRegistro.Name = "EliminarRegistro";
            this.EliminarRegistro.Size = new System.Drawing.Size(23, 22);
            this.EliminarRegistro.Text = "Eliminar registro";
            this.EliminarRegistro.Click += new System.EventHandler(this.EliminarRegistro_Click);
            // 
            // FrmServer
            // 
            this.ClientSize = new System.Drawing.Size(672, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gDetalles);
            this.Controls.Add(this.gListado);
            this.Name = "FrmServer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidores";
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.gListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            this.gDetalles.ResumeLayout(false);
            this.gDetalles.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gListado;
        private System.Windows.Forms.GroupBox gDetalles;
        private System.Windows.Forms.TextBox tIp;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label lIp;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AñadirRegistro;
        private System.Windows.Forms.ToolStripButton GuardarRegistro;
        private System.Windows.Forms.ToolStripButton EliminarRegistro;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tPort;
        private System.Windows.Forms.DataGridView Grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortServer;
    }
}