using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BOL
{
    public class ServerBol
    {
        //Instanciamos nuestra clase serverDal para poder utilizar sus miembros
        private ServerDal _serverDal = new ServerDal();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        //
        //Creamos nuestro método para Insertar un nuevo usuario, observe como este método tampoco valida los el contenido
        //de las propiedades, sino que manda a llamar a una Función que tiene como tarea única hacer esta validación
        //
        public void Registrar(EServer server)
        {
            if (ValidarUsuario(server))
            {
                if (_serverDal.GetByName(server.Name)==null)
                    _serverDal.Insert(server);
                else
                    _serverDal.Update(server);
            }
        }

        public List<EServer> Todos()
        {
            return _serverDal.GetAll();
        }

        public EServer TraerPorId(int idserver)
        {
            stringBuilder.Clear();

            if (idserver == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return _serverDal.GetByid(idserver);
            }
            return null;
        }

        public void Eliminar(int idProduct)
        {
            stringBuilder.Clear();

            if (idProduct == 0) stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                _serverDal.Delete(idProduct);
            }
        }

        private bool ValidarUsuario(EServer server)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(server.Name)) stringBuilder.Append("El campo Nombre es obligatorio");
            if (string.IsNullOrEmpty(server.Ip)) stringBuilder.Append(Environment.NewLine + "El campo Ip es obligatorio");
            if (string.IsNullOrEmpty(server.Port)) stringBuilder.Append(Environment.NewLine + "El campo  Puerto es obligatorio");

            return stringBuilder.Length == 0;
        }
    }
}
