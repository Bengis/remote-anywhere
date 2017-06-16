using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BOL
{
    public class LogBol
    {
        //Instanciamos nuestra clase serverDal para poder utilizar sus miembros
        private LogDal _logDal = new LogDal();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        //
        //Creamos nuestro método para Insertar un nuevo usuario, observe como este método tampoco valida los el contenido
        //de las propiedades, sino que manda a llamar a una Función que tiene como tarea única hacer esta validación
        //
        public void Registrar(ELog log)
        {
            if (Validar(log))
            {
                    _logDal.Insert(log);
            }
        }

        public List<ELog> Todos()
        {
            return _logDal.GetAll();
        }

        private bool Validar(ELog log)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(log.Description)) stringBuilder.Append("El campo Descripcion es obligatorio");
            if (string.IsNullOrEmpty(log.DateInserted)) stringBuilder.Append(Environment.NewLine + "El campo FechaInserccion es obligatorio");
           
            return stringBuilder.Length == 0;
        }
    }
}
