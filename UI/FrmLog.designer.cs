namespace UI
{
    partial class FrmLog
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
            this.gListado = new System.Windows.Forms.GroupBox();
            this.Grd = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateInserted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
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
            this.gListado.Location = new System.Drawing.Point(12, 12);
            this.gListado.Name = "gListado";
            this.gListado.Size = new System.Drawing.Size(648, 537);
            this.gListado.TabIndex = 0;
            this.gListado.TabStop = false;
            this.gListado.Text = "Listado";
            // 
            // Grd
            // 
            this.Grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.DateInserted});
            this.Grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd.Location = new System.Drawing.Point(3, 16);
            this.Grd.Name = "Grd";
            this.Grd.Size = new System.Drawing.Size(642, 518);
            this.Grd.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            // 
            // DateInserted
            // 
            this.DateInserted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateInserted.HeaderText = "Fecha";
            this.DateInserted.Name = "DateInserted";
            this.DateInserted.Width = 200;
            // 
            // FrmLog
            // 
            this.ClientSize = new System.Drawing.Size(672, 561);
            this.Controls.Add(this.gListado);
            this.Name = "FrmLog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            this.gListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gListado;
        private System.Windows.Forms.DataGridView Grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateInserted;
    }
}