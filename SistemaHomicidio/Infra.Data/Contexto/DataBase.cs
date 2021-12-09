using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infra.Data.Contexto
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions options) : base(options) { }

        #region//Tabelas Principais
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Fato> Fatos { get; set; }
        public DbSet<Envolvido> Envolvidos { get; set; }
        public DbSet<EnvolvidoEndereco> Enderecos { get; set; }
        public DbSet<EnvolvidoCriminal> Criminal { get; set; }
        public DbSet<EnvolvidoSaude> Saude { get; set; }
        public DbSet<Inquerito> Inqueritos { get; set; }
        public DbSet<Arquivo> Arquivos { get; set; }
        public DbSet<BoeComplementado> BoeComplementados { get; set; }
        #endregion

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }

        public DbSet<Municipio_Diretoria_AIS_BPM> Municipio_Diretoria_AIS_BPMs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
