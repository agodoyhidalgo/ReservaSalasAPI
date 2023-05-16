using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasAPIDomain.Entidades
{
    public class Salas
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public int IdDelegacion { get; set; }

    }
}
