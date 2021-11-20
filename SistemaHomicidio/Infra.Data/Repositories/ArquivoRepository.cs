using Domain.Entities;
using Infra.Data.Contexto;
using Infra.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class ArquivoRepository : IArquivoRepository
    {
        private readonly DataBase context;

        public ArquivoRepository(DataBase context)
        {
            this.context = context;
        }

        public async Task<Arquivo> UploadArquivo(Arquivo arquivo)
        {
            await context.Arquivos.AddAsync(arquivo);
            await context.SaveChangesAsync();
            return arquivo;
        }
    }
}
