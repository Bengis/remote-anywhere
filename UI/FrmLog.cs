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
    public partial class FrmLog : Form
    {
        private readonly LogBol _logBol = new LogBol();

        public FrmLog()
        {
            InitializeComponent();
        }

        private void TraerTodos()
        {
            List<ELog> logs = _logBol.Todos();

            if (logs.Count > 0)
            {
                Grd.AutoGenerateColumns = false;
                Grd.DataSource = logs;
                Grd.Columns["Id"].DataPropertyName = "Id";
                Grd.Columns["Description"].DataPropertyName = "Description";
                Grd.Columns["DateInserted"].DataPropertyName = "DateInserted";
            }
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }
    }
}
