using Domain.Entities;
using Infra.Data.Contexto;
using Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class RegistroRepository : IRegistroRepository
    {
        #region Contexto
        private readonly DataBase _db;

        public RegistroRepository(DataBase db)
        {
            _db = db;
        }
        #endregion

        public async Task<List<Registro>> ExibirTodosRegistros()
        {
            return await _db.Registros.AsNoTracking()
                                      .Include(f => f.Fato)
                                      .Include(e => e.Envolvidos)
                                        .ThenInclude(e => e.Endereco)
                                      .Include(e => e.Envolvidos)
                                        .ThenInclude(s => s.Saude)
                                      .Include(e => e.Envolvidos)
                                        .ThenInclude(c => c.Criminal)
                                      .Include(b => b.BoeComplementados)
                                      .Include(a => a.Arquivos)
                                      .Include(i => i.Inquerito)
                                      .ToListAsync();
        }

        public async Task<Registro> ObterRegistroPorID(int id)
        {
            return await _db.Registros.Include(f => f.Fato)
                                      .Include(e => e.Envolvidos)
                                        .ThenInclude(e => e.Endereco)
                                      .Include(e => e.Envolvidos)
                                        .ThenInclude(s => s.Saude)
                                      .Include(e => e.Envolvidos)
                                        .ThenInclude(c => c.Criminal)
                                      .Include(b => b.BoeComplementados)
                                      .Include(a => a.Arquivos)
                                      .Include(i => i.Inquerito)
                                      .SingleOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Registro> AdicionarRegistro(Registro registro)
        {
            AdicionaEnvolvidoNoRegistro(registro);
            AdicionaBoeComplementadoNoRegistro(registro);
            AdicionaArquivoNoRegistro(registro);
            await _db.Registros.AddAsync(registro);
            await _db.SaveChangesAsync();
            return registro;
        }
        #region AdicionarEnvolvido
        private static void AdicionaEnvolvidoNoRegistro(Registro registro)
        {
            registro.Envolvidos = (registro.Envolvidos.Select(envolvido => new Envolvido()
            {
                RegistroId = registro.Id,
                SequencialEnvolvido = envolvido.SequencialEnvolvido,
                TipoEnvolvido = envolvido.TipoEnvolvido,
                Autoria = envolvido.Autoria,
                Turista = envolvido.Turista,
                NomeEnvolvido = envolvido.NomeEnvolvido,
                NomeSocial = envolvido.NomeSocial,
                Vulgo = envolvido.Vulgo,
                NomeGenitora = envolvido.NomeGenitora,
                DataNascimento = envolvido.DataNascimento,
                IdadeExata = envolvido.IdadeExata,
                IdadeAparente = envolvido.IdadeAparente,
                Sexo = envolvido.Sexo,
                IdentidadeGenero = envolvido.IdentidadeGenero,
                OrientacaoSexual = envolvido.OrientacaoSexual,
                DeficienciaFisica = envolvido.DeficienciaFisica,
                CorPele = envolvido.CorPele,
                EstadoCivil = envolvido.EstadoCivil,
                DepedenciaQuimica = envolvido.DepedenciaQuimica,
                ConsumoDrogas = envolvido.ConsumoDrogas,
                ProfissaoEnvolvildo = envolvido.ProfissaoEnvolvildo,
                InformacaoTrabalho = envolvido.InformacaoTrabalho,
                RelacaoAutorVitima = envolvido.RelacaoAutorVitima,
                RelacaoIntraFamiliarVitimaAutor = envolvido.RelacaoIntraFamiliarVitimaAutor,
                InstrumentoUtilizado = envolvido.InstrumentoUtilizado,
                NomeInstrumentoUtilizado = envolvido.NomeInstrumentoUtilizado,
                Flagrante = envolvido.Flagrante,
                Criminal = envolvido.Criminal,
                Endereco = envolvido.Endereco,
                Saude = envolvido.Saude

            })).ToList();
        }

        private static void AdicionaBoeComplementadoNoRegistro(Registro registro)
        {
            registro.BoeComplementados = (registro.BoeComplementados.Select(boeComplementado => new BoeComplementado()
            {
                RegistroId = boeComplementado.RegistroId,
                Boe = boeComplementado.Boe,
                DataRegistro = boeComplementado.DataRegistro

            })).ToList();
        }

        private static void AdicionaArquivoNoRegistro(Registro registro)
        {
            registro.Arquivos = (registro.Arquivos.Select(arquivo => new Arquivo() 
            { 
                RegistroId = arquivo.RegistroId,
                NomeArquivo = arquivo.NomeArquivo

            })).ToList();
        }
        #endregion

        public async Task<Registro> EditarRegistro(Registro registro)
        {
            var verificaRegistro = await ObterRegistroPorID(registro.Id);
            
            if (verificaRegistro == null) { return null; }

            registro.DataLancamento = verificaRegistro.DataLancamento;

            _db.Entry(verificaRegistro).CurrentValues.SetValues(registro);
            verificaRegistro.Fato = registro.Fato;
            verificaRegistro.Inquerito = registro.Inquerito;
            EditarEnvolvidoDoRegistro(verificaRegistro, registro);
            EditarBoeComplementadoDoRegistro(verificaRegistro, registro);
            EditarArquivoDoRegistro(verificaRegistro, registro);
            await _db.SaveChangesAsync();
            return verificaRegistro;

        }
        #region EditarRegistro
        private static void EditarEnvolvidoDoRegistro(Registro verificaRegistro, Registro registro)
        {
            verificaRegistro.Envolvidos.Clear();
            foreach(var envolvido in registro.Envolvidos)
            {
                verificaRegistro.Envolvidos.Add(envolvido);
            }

        }

        private static void EditarArquivoDoRegistro(Registro verificaRegistro, Registro registro)
        {
            verificaRegistro.Arquivos.Clear();
            foreach (var arquivo in registro.Arquivos)
            {
                verificaRegistro.Arquivos.Add(arquivo);
            }

        }
        private static void EditarBoeComplementadoDoRegistro(Registro verificaRegistro, Registro registro)
        {
            verificaRegistro.BoeComplementados.Clear();
            foreach (var boeComplementar in registro.BoeComplementados)
            {
                verificaRegistro.BoeComplementados.Add(boeComplementar);
            }

        }
        #endregion

        public async Task<Registro> ExcluirRegistro(int id)
        {
            var verificaRegistro = await _db.Registros.FindAsync(id);

            if(verificaRegistro == null) { return null; }

            var registroExcluido = _db.Registros.Remove(verificaRegistro);
            await _db.SaveChangesAsync();
            return registroExcluido.Entity;
        }
    }
}
