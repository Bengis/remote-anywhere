namespace UI
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.gParametros = new System.Windows.Forms.GroupBox();
            this.ckClient = new System.Windows.Forms.CheckBox();
            this.ckServer = new System.Windows.Forms.CheckBox();
            this.lPort = new System.Windows.Forms.Label();
            this.tPort = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GuardarRegistro = new System.Windows.Forms.ToolStripButton();
            this.gParametros.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gParametros
            // 
            this.gParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gParametros.Controls.Add(this.ckClient);
            this.gParametros.Controls.Add(this.ckServer);
            this.gParametros.Controls.Add(this.lPort);
            this.gParametros.Controls.Add(this.tPort);
            this.gParametros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gParametros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.gParametros.Location = new System.Drawing.Point(12, 40);
            this.gParametros.Name = "gParametros";
            this.gParametros.Size = new System.Drawing.Size(285, 107);
            this.gParametros.TabIndex = 2;
            this.gParametros.TabStop = false;
            this.gParametros.Text = "Parametros";
            // 
            // ckClient
            // 
            this.ckClient.AutoSize = true;
            this.ckClient.Location = new System.Drawing.Point(153, 74);
            this.ckClient.Name = "ckClient";
            this.ckClient.Size = new System.Drawing.Size(65, 18);
            this.ckClient.TabIndex = 7;
            this.ckClient.Text = "Cliente";
            this.ckClient.UseVisualStyleBackColor = true;
            // 
            // ckServer
            // 
            this.ckServer.AutoSize = true;
            this.ckServer.Location = new System.Drawing.Point(33, 74);
            this.ckServer.Name = "ckServer";
            this.ckServer.Size = new System.Drawing.Size(73, 18);
            this.ckServer.TabIndex = 6;
            this.ckServer.Text = "Servidor";
            this.ckServer.UseVisualStyleBackColor = true;
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(30, 34);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(47, 14);
            this.lPort.TabIndex = 5;
            this.lPort.Text = "Puerto:";
            // 
            // tPort
            // 
            this.tPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.tPort.Location = new System.Drawing.Point(126, 31);
            this.tPort.Name = "tPort";
            this.tPort.Size = new System.Drawing.Size(100, 20);
            this.tPort.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuardarRegistro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(312, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // GuardarRegistro
            // 
            this.GuardarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuardarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("GuardarRegistro.Image")));
            this.GuardarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarRegistro.Name = "GuardarRegistro";
            this.GuardarRegistro.Size = new System.Drawing.Size(23, 22);
            this.GuardarRegistro.Text = "Guardar registro";
            this.GuardarRegistro.ToolTipText = "Guardar";
            this.GuardarRegistro.Click += new System.EventHandler(this.GuardarRegistro_Click);
            // 
            // FrmConfig
            // 
            this.ClientSize = new System.Drawing.Size(312, 159);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gParametros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.gParametros.ResumeLayout(false);
            this.gParametros.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gParametros;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tPort;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton GuardarRegistro;
        private System.Windows.Forms.CheckBox ckClient;
        private System.Windows.Forms.CheckBox ckServer;
    }
}