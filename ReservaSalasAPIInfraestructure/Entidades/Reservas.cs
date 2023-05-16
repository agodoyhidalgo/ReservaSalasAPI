using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasAPIDomain.Entidades
{
    public class Reservas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public DateTime HoraInicio { get; set; }

        public DateTime HoraFin { get; set; }

        public int IdSala { get; set; }


        public int IdDelegacion { get; set; }

    }
}
