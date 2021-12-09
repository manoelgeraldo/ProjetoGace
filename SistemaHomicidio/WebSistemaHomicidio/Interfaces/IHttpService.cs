using System.Threading.Tasks;

namespace WebSistemaHomicidio.Interfaces
{
    public interface IHttpService
    {
        Task<T> Get<T>(string uri);
        Task<T> Post<T>(string uri, object value);
    }
}
