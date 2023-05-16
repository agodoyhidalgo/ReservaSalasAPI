
using ReservaSalasAPIAplicacion.Dto;
using ReservaSalasAPIDominio.Excepciones;
using ReservaSalasAPIDominio.Servicios;
using ReservaSalasAPIInfraestructura.Repositorios;

namespace ReservaSalasAPIAplicacion.Servicios
{
    public class DelegacionServicio: IDelegacionServicio
    {
        private readonly IDelegacionRepositorio _delegacionRepositorio;

        public DelegacionServicio(IDelegacionRepositorio delegacionRepositorio) 
        {
            _delegacionRepositorio = delegacionRepositorio;
        }

        public async Task<DelegacionDto>  GetDelegacionByIdAsync(int id) 
        { 
            var delegacion = await _delegacionRepositorio.GetDelegacionByIdAsync(id);

            if (delegacion == null ) 
            {
                throw new DelegacionNotFoundException($"La delegación con el ID {id} no existe");
            }
            return new DelegacionDto
            {
                Id = delegacion.Id,
                Nombre = delegacion.Nombre
            };
        }

    }
}
