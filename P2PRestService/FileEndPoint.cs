using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2PRestService
{
    public class FileEndPoint
    {
		private string _ip_adress;

		public string Ip_adress
		{
			get { return _ip_adress; }
			set { _ip_adress = value; }
		}

		private int _Portnr;

		public int PortNr
		{
			get { return _Portnr; }
			set { _Portnr = value; }
		}

        public FileEndPoint(string ipAdress, int portnr)
        {
            _ip_adress = ipAdress;
            _Portnr = portnr;
        }

        public FileEndPoint()
        {
            
        }

        

	}
}
