namespace UI
{
    partial class FrmViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewer));
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.Refresco = new System.Windows.Forms.Timer(this.components);
            this.PConexion = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbConexion = new System.Windows.Forms.Label();
            this.PLogin = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.PConexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Imagen
            // 
            this.Imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen.Location = new System.Drawing.Point(0, 0);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(784, 561);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 0;
            this.Imagen.TabStop = false;
            this.Imagen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Imagen_MouseDown);
            this.Imagen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Imagen_MouseMove);
            this.Imagen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Imagen_MouseUp);
            // 
            // PConexion
            // 
            this.PConexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PConexion.Controls.Add(this.pictureBox1);
            this.PConexion.Controls.Add(this.lbConexion);
            this.PConexion.Location = new System.Drawing.Point(232, 126);
            this.PConexion.Name = "PConexion";
            this.PConexion.Size = new System.Drawing.Size(308, 138);
            this.PConexion.TabIndex = 2;
            this.PConexion.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbConexion
            // 
            this.lbConexion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConexion.AutoSize = true;
            this.lbConexion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConexion.Location = new System.Drawing.Point(30, 27);
            this.lbConexion.Name = "lbConexion";
            this.lbConexion.Size = new System.Drawing.Size(246, 24);
            this.lbConexion.TabIndex = 4;
            this.lbConexion.Text = "Conectando al servidor";
            this.lbConexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PLogin
            // 
            this.PLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PLogin.Controls.Add(this.btLogin);
            this.PLogin.Controls.Add(this.tPassword);
            this.PLogin.Controls.Add(this.lbPassword);
            this.PLogin.Controls.Add(this.tUser);
            this.PLogin.Controls.Add(this.lbUser);
            this.PLogin.Location = new System.Drawing.Point(200, 122);
            this.PLogin.Name = "PLogin";
            this.PLogin.Size = new System.Drawing.Size(375, 142);
            this.PLogin.TabIndex = 6;
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(185, 91);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(103, 33);
            this.btLogin.TabIndex = 8;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tPassword
            // 
            this.tPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.Location = new System.Drawing.Point(185, 53);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(167, 32);
            this.tPassword.TabIndex = 7;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(30, 61);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(127, 24);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Contraseña";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tUser
            // 
            this.tUser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUser.Location = new System.Drawing.Point(185, 15);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(167, 32);
            this.tUser.TabIndex = 5;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(30, 15);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(87, 24);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "Usuario";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmViewer
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PLogin);
            this.Controls.Add(this.PConexion);
            this.Controls.Add(this.Imagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmViewer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectando";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmViewer_FormClosing);
            this.Load += new System.EventHandler(this.FrmViewer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmViewer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.PConexion.ResumeLayout(false);
            this.PConexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PLogin.ResumeLayout(false);
            this.PLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Timer Refresco;
        private System.Windows.Forms.Panel PConexion;
        private System.Windows.Forms.Label lbConexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PLogin;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btLogin;
    }
}