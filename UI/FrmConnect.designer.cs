namespace UI
{
    partial class FrmConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnect));
            this.gParametros = new System.Windows.Forms.GroupBox();
            this.lPort = new System.Windows.Forms.Label();
            this.tPort = new System.Windows.Forms.TextBox();
            this.lIp = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tIp = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LimpiarRegistro = new System.Windows.Forms.ToolStripButton();
            this.GuardarRegistro = new System.Windows.Forms.ToolStripButton();
            this.ConectarRegistro = new System.Windows.Forms.ToolStripButton();
            this.gParametros.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gParametros
            // 
            this.gParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gParametros.Controls.Add(this.lPort);
            this.gParametros.Controls.Add(this.tPort);
            this.gParametros.Controls.Add(this.lIp);
            this.gParametros.Controls.Add(this.lName);
            this.gParametros.Controls.Add(this.tIp);
            this.gParametros.Controls.Add(this.tName);
            this.gParametros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gParametros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.gParametros.Location = new System.Drawing.Point(12, 40);
            this.gParametros.Name = "gParametros";
            this.gParametros.Size = new System.Drawing.Size(279, 112);
            this.gParametros.TabIndex = 2;
            this.gParametros.TabStop = false;
            this.gParametros.Text = "Parametros";
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
            this.LimpiarRegistro,
            this.GuardarRegistro,
            this.ConectarRegistro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(306, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LimpiarRegistro
            // 
            this.LimpiarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LimpiarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarRegistro.Image")));
            this.LimpiarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LimpiarRegistro.Name = "LimpiarRegistro";
            this.LimpiarRegistro.Size = new System.Drawing.Size(23, 22);
            this.LimpiarRegistro.Text = "Añadir registro";
            this.LimpiarRegistro.ToolTipText = "Limpiar";
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
            // ConectarRegistro
            // 
            this.ConectarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConectarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("ConectarRegistro.Image")));
            this.ConectarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConectarRegistro.Name = "ConectarRegistro";
            this.ConectarRegistro.Size = new System.Drawing.Size(23, 22);
            this.ConectarRegistro.Text = "Conectar";
            this.ConectarRegistro.Click += new System.EventHandler(this.ConectarRegistro_Click);
            // 
            // FrmConnect
            // 
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gParametros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConnect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectar a";
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
        private System.Windows.Forms.Label lIp;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tIp;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LimpiarRegistro;
        private System.Windows.Forms.ToolStripButton GuardarRegistro;
        private System.Windows.Forms.ToolStripButton ConectarRegistro;
    }
}