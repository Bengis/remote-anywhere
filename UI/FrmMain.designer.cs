namespace UI
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.TLPServer = new System.Windows.Forms.TableLayoutPanel();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbExternIp = new System.Windows.Forms.Label();
            this.lbInternIp = new System.Windows.Forms.Label();
            this.lbServer = new System.Windows.Forms.Label();
            this.TLPClient = new System.Windows.Forms.TableLayoutPanel();
            this.Grd = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IpServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbClient = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu.SuspendLayout();
            this.TLP.SuspendLayout();
            this.TLPServer.SuspendLayout();
            this.TLPClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(784, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectToToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientToolStripMenuItem.Text = "Clientes";
            // 
            // conectToToolStripMenuItem
            // 
            this.conectToToolStripMenuItem.Name = "conectToToolStripMenuItem";
            this.conectToToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.conectToToolStripMenuItem.Text = "Conectar a";
            this.conectToToolStripMenuItem.Click += new System.EventHandler(this.conectarAToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.modifyToolStripMenuItem.Text = "Modificar";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permissionsToolStripMenuItem,
            this.accessLogsToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.serverToolStripMenuItem.Text = "Servidor";
            // 
            // permissionsToolStripMenuItem
            // 
            this.permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            this.permissionsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.permissionsToolStripMenuItem.Text = "Permisos";
            this.permissionsToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // accessLogsToolStripMenuItem
            // 
            this.accessLogsToolStripMenuItem.Name = "accessLogsToolStripMenuItem";
            this.accessLogsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.accessLogsToolStripMenuItem.Text = "Registro de accesos";
            this.accessLogsToolStripMenuItem.Click += new System.EventHandler(this.registroDeAccesosToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.helpToolStripMenuItem.Text = "Ayuda";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configToolStripMenuItem.Text = "Configuracion";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "Acerca de";
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitStripMenuItem.Text = "Salir";
            this.exitStripMenuItem.Click += new System.EventHandler(this.salirStripMenuItem_Click);
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 2;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP.Controls.Add(this.TLPServer, 0, 1);
            this.TLP.Controls.Add(this.TLPClient, 1, 1);
            this.TLP.Controls.Add(this.pBox, 0, 0);
            this.TLP.Controls.Add(this.status, 0, 3);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 24);
            this.TLP.Margin = new System.Windows.Forms.Padding(0);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 4;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP.Size = new System.Drawing.Size(784, 537);
            this.TLP.TabIndex = 1;
            // 
            // TLPServer
            // 
            this.TLPServer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TLPServer.ColumnCount = 1;
            this.TLPServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPServer.Controls.Add(this.lbPort, 0, 3);
            this.TLPServer.Controls.Add(this.lbExternIp, 0, 2);
            this.TLPServer.Controls.Add(this.lbInternIp, 0, 1);
            this.TLPServer.Controls.Add(this.lbServer, 0, 0);
            this.TLPServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPServer.Location = new System.Drawing.Point(3, 183);
            this.TLPServer.Name = "TLPServer";
            this.TLPServer.RowCount = 4;
            this.TLP.SetRowSpan(this.TLPServer, 2);
            this.TLPServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPServer.Size = new System.Drawing.Size(386, 330);
            this.TLPServer.TabIndex = 4;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPort.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(5, 248);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(376, 80);
            this.lbPort.TabIndex = 3;
            this.lbPort.Text = "Sin puerto";
            this.lbPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbExternIp
            // 
            this.lbExternIp.AutoSize = true;
            this.lbExternIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbExternIp.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExternIp.Location = new System.Drawing.Point(5, 166);
            this.lbExternIp.Name = "lbExternIp";
            this.lbExternIp.Size = new System.Drawing.Size(376, 80);
            this.lbExternIp.TabIndex = 2;
            this.lbExternIp.Text = "Sin ip externa";
            this.lbExternIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbInternIp
            // 
            this.lbInternIp.AutoSize = true;
            this.lbInternIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInternIp.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternIp.Location = new System.Drawing.Point(5, 84);
            this.lbInternIp.Name = "lbInternIp";
            this.lbInternIp.Size = new System.Drawing.Size(376, 80);
            this.lbInternIp.TabIndex = 1;
            this.lbInternIp.Text = "Sin ip interna";
            this.lbInternIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbServer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.Location = new System.Drawing.Point(5, 2);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(376, 80);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Permitir el control remoto";
            this.lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TLPClient
            // 
            this.TLPClient.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TLPClient.ColumnCount = 1;
            this.TLPClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPClient.Controls.Add(this.Grd, 0, 1);
            this.TLPClient.Controls.Add(this.lbClient, 0, 0);
            this.TLPClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPClient.Location = new System.Drawing.Point(395, 183);
            this.TLPClient.Name = "TLPClient";
            this.TLPClient.RowCount = 2;
            this.TLP.SetRowSpan(this.TLPClient, 2);
            this.TLPClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TLPClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPClient.Size = new System.Drawing.Size(386, 330);
            this.TLPClient.TabIndex = 3;
            // 
            // Grd
            // 
            this.Grd.AllowUserToAddRows = false;
            this.Grd.AllowUserToDeleteRows = false;
            this.Grd.AllowUserToResizeColumns = false;
            this.Grd.AllowUserToResizeRows = false;
            this.Grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd.ColumnHeadersVisible = false;
            this.Grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameServer,
            this.IpServer,
            this.PortServer});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grd.DefaultCellStyle = dataGridViewCellStyle1;
            this.Grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd.Location = new System.Drawing.Point(5, 71);
            this.Grd.MultiSelect = false;
            this.Grd.Name = "Grd";
            this.Grd.RowHeadersVisible = false;
            this.Grd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd.ShowCellErrors = false;
            this.Grd.ShowCellToolTips = false;
            this.Grd.ShowEditingIcon = false;
            this.Grd.ShowRowErrors = false;
            this.Grd.Size = new System.Drawing.Size(376, 254);
            this.Grd.TabIndex = 2;
            this.Grd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_CellDoubleClick);
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
            this.NameServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameServer.HeaderText = "Nombre";
            this.NameServer.Name = "NameServer";
            // 
            // IpServer
            // 
            this.IpServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IpServer.HeaderText = "IP";
            this.IpServer.Name = "IpServer";
            this.IpServer.Visible = false;
            // 
            // PortServer
            // 
            this.PortServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PortServer.HeaderText = "Puerto";
            this.PortServer.Name = "PortServer";
            this.PortServer.Visible = false;
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClient.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClient.Location = new System.Drawing.Point(5, 2);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(376, 64);
            this.lbClient.TabIndex = 1;
            this.lbClient.Text = "Controlar remotamente";
            this.lbClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TLP.SetColumnSpan(this.pBox, 2);
            this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox.Image = global::UI.Properties.Resources.LogoE;
            this.pBox.Location = new System.Drawing.Point(0, 0);
            this.pBox.Margin = new System.Windows.Forms.Padding(0);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(784, 180);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox.TabIndex = 5;
            this.pBox.TabStop = false;
            // 
            // status
            // 
            this.TLP.SetColumnSpan(this.status, 2);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusCounter});
            this.status.Location = new System.Drawing.Point(0, 516);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(784, 21);
            this.status.TabIndex = 6;
            this.status.Text = "statusStrip1";
            // 
            // statusCounter
            // 
            this.statusCounter.Name = "statusCounter";
            this.statusCounter.Size = new System.Drawing.Size(769, 16);
            this.statusCounter.Spring = true;
            this.statusCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TLP);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Anywhere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.TLP.ResumeLayout(false);
            this.TLP.PerformLayout();
            this.TLPServer.ResumeLayout(false);
            this.TLPServer.PerformLayout();
            this.TLPClient.ResumeLayout(false);
            this.TLPClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.TableLayoutPanel TLPClient;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.DataGridView Grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortServer;
        private System.Windows.Forms.TableLayoutPanel TLPServer;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbExternIp;
        private System.Windows.Forms.Label lbInternIp;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusCounter;
    }
}