using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BOL
{
    public class ConfigBol
    {
        //Instanciamos nuestra clase serverDal para poder utilizar sus miembros
        private ConfigDal _configDal = new ConfigDal();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        //
        //Creamos nuestro método para Insertar un nuevo usuario, observe como este método tampoco valida los el contenido
        //de las propiedades, sino que manda a llamar a una Función que tiene como tarea única hacer esta validación
        //
        public void Registrar(EConfig config)
        {
            if (Validar(config))
            {
                if (_configDal.GetConfig() == null)
                {
                    _configDal.Insert(config);
                }
                else
                {
                    _configDal.Update(config);
                }
            }
        }

        public EConfig ShowConfig()
        {
            return _configDal.GetConfig();
        }

        private bool Validar(EConfig config)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(config.Port)) stringBuilder.Append(Environment.NewLine + "El campo FechaInserccion es obligatorio");
           
            return stringBuilder.Length == 0;
        }
    }
}
