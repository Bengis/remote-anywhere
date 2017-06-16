using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BOL
{
    public class UserBol
    {
        //Instanciamos nuestra clase UserDal para poder utilizar sus miembros
        private UserDal _userDal = new UserDal();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        //
        //Creamos nuestro método para Insertar un nuevo usuario, observe como este método tampoco valida los el contenido
        //de las propiedades, sino que manda a llamar a una Función que tiene como tarea única hacer esta validación
        //
        public void Registrar(EUser user)
        {
            if (ValidarUsuario(user))
            {
                if (_userDal.GetByUser(user.User)==null)
                    _userDal.Insert(user);
                else
                    _userDal.Update(user);
            }
        }

        public List<EUser> Todos()
        {
            return _userDal.GetAll();
        }

        public EUser TraerPorId(int idUser)
        {
            stringBuilder.Clear();

            if (idUser == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return _userDal.GetById(idUser);
            }
            return null;
        }

        public void Eliminar(int idProduct)
        {
            stringBuilder.Clear();

            if (idProduct == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                _userDal.Delete(idProduct);
            }
        }

        public bool ValidarUsuario(EUser user)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(user.User)) stringBuilder.Append("El campo Usuario es obligatorio");
            if (string.IsNullOrEmpty(user.Password)) stringBuilder.Append(Environment.NewLine + "El campo Contraseña es obligatorio");
         
            return stringBuilder.Length == 0;
        }

        public bool LoginUsuario(String name, String password)
        {
            bool bLogin = false;
            EUser user =_userDal.GetByUser(name);
            if (user== null)
            {
                bLogin = false;
            }
            else
            {
                if (user.Password.Equals(password))
                {
                    bLogin = true;
                }
            }
                return bLogin;
        }
    }
}
