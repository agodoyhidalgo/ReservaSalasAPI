using Microsoft.EntityFrameworkCore;
using ReservaSalasAPIDomain.Entidades;
using ReservaSalasAPIDominio.Excepciones;
using ReservaSalasAPIInfraestructura.Data;


namespace ReservaSalasAPIInfraestructura.Repositorios;

public class DelegacionRepositorio : IDelegacionRepositorio
{
    private readonly DelegacionContext _context;

    public DelegacionRepositorio(DelegacionContext context) 
    { 
        _context = context;
    }
    public async Task<Delegacion> GetDelegacionByIdAsync(int id)
    {
        var delegacion = await _context.Delegaciones.FirstOrDefaultAsync(x => x.Id == id);

        if (delegacion == null)
        {
            throw new DelegacionNotFoundException($"La delegación con el ID {id} no existe");
        }

        return delegacion;
    }
}
