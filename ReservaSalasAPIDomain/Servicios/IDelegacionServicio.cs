using ReservaSalasAPIAplicacion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaSalasAPIDominio.Servicios;

public interface IDelegacionServicio
{
    Task<DelegacionDto> GetDelegacionByIdAsync(int id);

}
