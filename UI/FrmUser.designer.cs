namespace UI
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.gListado = new System.Windows.Forms.GroupBox();
            this.Grd = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDetalles = new System.Windows.Forms.GroupBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
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
            this.gListado.Location = new System.Drawing.Point(12, 130);
            this.gListado.Name = "gListado";
            this.gListado.Size = new System.Drawing.Size(648, 419);
            this.gListado.TabIndex = 0;
            this.gListado.TabStop = false;
            this.gListado.Text = "Listado";
            // 
            // Grd
            // 
            this.Grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.User,
            this.Password});
            this.Grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd.Location = new System.Drawing.Point(3, 16);
            this.Grd.Name = "Grd";
            this.Grd.Size = new System.Drawing.Size(642, 400);
            this.Grd.TabIndex = 0;
            this.Grd.CurrentCellChanged += new System.EventHandler(this.Grd_CurrentCellChanged);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.HeaderText = "Usuario";
            this.User.Name = "User";
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Password.HeaderText = "Contraseña";
            this.Password.Name = "Password";
            this.Password.Width = 96;
            // 
            // gDetalles
            // 
            this.gDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gDetalles.Controls.Add(this.lPassword);
            this.gDetalles.Controls.Add(this.lUser);
            this.gDetalles.Controls.Add(this.tPassword);
            this.gDetalles.Controls.Add(this.tUser);
            this.gDetalles.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.gDetalles.Location = new System.Drawing.Point(12, 39);
            this.gDetalles.Name = "gDetalles";
            this.gDetalles.Size = new System.Drawing.Size(645, 85);
            this.gDetalles.TabIndex = 1;
            this.gDetalles.TabStop = false;
            this.gDetalles.Text = "Detalles";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(24, 51);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(74, 14);
            this.lPassword.TabIndex = 3;
            this.lPassword.Text = "Contraseña:";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(24, 25);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(52, 14);
            this.lUser.TabIndex = 2;
            this.lUser.Text = "Usuario:";
            // 
            // tPassword
            // 
            this.tPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.tPassword.Location = new System.Drawing.Point(128, 48);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(100, 20);
            this.tPassword.TabIndex = 1;
            // 
            // tUser
            // 
            this.tUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.tUser.Location = new System.Drawing.Point(128, 19);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(100, 20);
            this.tUser.TabIndex = 0;
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
            // FrmUser
            // 
            this.ClientSize = new System.Drawing.Size(672, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gDetalles);
            this.Controls.Add(this.gListado);
            this.Name = "FrmUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUser_Load);
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
        private System.Windows.Forms.DataGridView Grd;
        private System.Windows.Forms.GroupBox gDetalles;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AñadirRegistro;
        private System.Windows.Forms.ToolStripButton GuardarRegistro;
        private System.Windows.Forms.ToolStripButton EliminarRegistro;
    }
}