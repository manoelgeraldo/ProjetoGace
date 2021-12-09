using Domain.Entities;

namespace Infra.Data.Interfaces
{
    public interface IJWTService
    {
        string GerarToken(Usuario usuario);
    }
}
