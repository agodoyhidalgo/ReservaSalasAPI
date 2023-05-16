using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasAPIDominio.Excepciones
{
    public class DelegacionNotFoundException : Exception

    {
        public DelegacionNotFoundException(string mensaje): base(mensaje) 
        { 

        }
    }
}
