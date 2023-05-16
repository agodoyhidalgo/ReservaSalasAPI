using ReservaSalasAPIDomain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasAPIInfraestructura.Repositorios
{
    public interface IDelegacionRepositorio
    {
        Task<Delegacion> GetDelegacionByIdAsync(int id);
    }
}
