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
    public partial class FrmUser : Form
    {
        private EUser _user;
        private readonly UserBol _userBol = new UserBol();

        public FrmUser()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            try
            {
                if (_user == null) _user = new EUser();

                //_user.Id = Convert.ToInt32(txtId.Text);
                _user.User = tUser.Text;
                _user.Password = tPassword.Text;
          
                _userBol.Registrar(_user);

                if (_userBol.stringBuilder.Length != 0)
                {
                    MessageBox.Show(_userBol.stringBuilder.ToString(), "Para continuar:");
                }
                else
                {
                    MessageBox.Show("Usuario actualizado con éxito");

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
                _userBol.Eliminar(id);

                MessageBox.Show("Usuario eliminado satisfactoriamente");

                TraerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void TraerTodos()
        {
            List<EUser> users = _userBol.Todos();

            if (users.Count > 0)
            {
                Grd.AutoGenerateColumns = false;
                Grd.DataSource = users;
                Grd.Columns["Id"].DataPropertyName = "Id";
                Grd.Columns["User"].DataPropertyName = "User";
                Grd.Columns["Password"].DataPropertyName = "Password";
            }
            else
                MessageBox.Show("No existen usuarios registrados");
        }

        private void TraerPorId(int id)
        {
            try
            {
                _user = _userBol.TraerPorId(id);

                if (_user != null)
                {
                    tUser.Text = _user.User;
                    tPassword.Text = _user.Password;
                }
                else
                    MessageBox.Show("El usuario solicitado no existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            TraerTodos();
       }

        private void Grd_CurrentCellChanged(object sender, EventArgs e)
        {
            if ((Grd.CurrentCell!=null) && (Grd.CurrentCell.RowIndex >= 0) && (Grd.Rows[Grd.CurrentCell.RowIndex].Cells["Id"].Value!=null))
            {
                TraerPorId(Convert.ToInt32(Grd.Rows[Grd.CurrentCell.RowIndex].Cells["Id"].Value));
            }
        }
      
        private void AñadirRegistro_Click(object sender, EventArgs e)
        {
            tUser.Text = "";
            tPassword.Text = "";
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
    }
}
