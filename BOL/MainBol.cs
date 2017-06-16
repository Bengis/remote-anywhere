using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DAL;

namespace BOL
{
    public class MainBol
    {
        MainDal _mainDal = new MainDal();
       
        public void revisarBBDD()
        {
            //Si no existe la BBDD la crea y la llena de datos
          if (!_mainDal.existeBBDD())
            {
                _mainDal.crearBBDD();
                _mainDal.rellenarBBDD();
            }
        }

        public String dameIpExterna()
        {
            string myIp = new WebClient().DownloadString(@"http://icanhazip.com").Trim();
            return myIp;
        }

        public String dameIpInterna()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

    }
}
