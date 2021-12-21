using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infra.Data.Contexto
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions options) : base(options) { }

        #region//Tabelas Principais
        public DbSet<Registro> REGISTROS { get; set; }
        public DbSet<Fato> FATOS { get; set; }
        public DbSet<Envolvido> ENVOLVIDOS { get; set; }
        public DbSet<EnvolvidoEndereco> ENDERECOS { get; set; }
        public DbSet<EnvolvidoCriminal> CRIMINAL { get; set; }
        public DbSet<EnvolvidoSaude> SAUDE { get; set; }
        public DbSet<Inquerito> INQUERITOS { get; set; }
        public DbSet<Arquivo> ARQUIVOS { get; set; }
        public DbSet<BoeComplementado> BOECOMPL { get; set; }
        #endregion

        public DbSet<Usuario> USUARIOS { get; set; }
        public DbSet<Funcao> FUNCOES { get; set; }

        public DbSet<Municipio_Diretoria_AIS_BPM> MUNICIPIOS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
