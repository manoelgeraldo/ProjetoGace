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
                                      .ToListAsync()
                                      .ConfigureAwait(false);
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
                                      .SingleOrDefaultAsync(i => i.Id == id)
                                      .ConfigureAwait(false);
        }

        public async Task<Registro> AdicionarRegistro(Registro registro)
        {
            AdicionaEnvolvidoNoRegistro(registro);
            AdicionaBoeComplementadoNoRegistro(registro);
            AdicionaArquivoNoRegistro(registro);
            await _db.Registros.AddAsync(registro).ConfigureAwait(false);
            await _db.SaveChangesAsync().ConfigureAwait(false);
            return registro;
        }
        #region AdicionarRegistro
        private static void AdicionaEnvolvidoNoRegistro(Registro registro)
        {
            registro.Envolvidos = registro.Envolvidos.ConvertAll(envolvido => new Envolvido()
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

            });
        }

        private static void AdicionaBoeComplementadoNoRegistro(Registro registro)
        {
            registro.BoeComplementados = registro.BoeComplementados.ConvertAll(boeComplementado => new BoeComplementado()
            {
                RegistroId = boeComplementado.RegistroId,
                Boe = boeComplementado.Boe,
                DataRegistro = boeComplementado.DataRegistro

            });
        }

        private static void AdicionaArquivoNoRegistro(Registro registro)
        {
            registro.Arquivos = registro.Arquivos.ConvertAll(arquivo => new Arquivo()
            {
                Id = arquivo.Id,
                RegistroId = arquivo.RegistroId,
                NomeArquivo = arquivo.NomeArquivo,
                CriacaoArquivo = arquivo.CriacaoArquivo,
                DadosArquivo = arquivo.DadosArquivo,
                TipoArquivo = arquivo.TipoArquivo
            });
        }
        #endregion

        private async Task<Registro> AdicionarBOEComplementadoAoEditarRegistro(Registro registro)
        {
            foreach (var boeComplementado in registro.BoeComplementados)
            {
                if (boeComplementado.Id == 0)
                {
                    var boeAdicionado = await AdicionarBoeComplementado(boeComplementado).ConfigureAwait(false);
                    registro.BoeComplementados.Remove(boeComplementado);
                    registro.BoeComplementados.Add(boeAdicionado);
                }
            }

            return registro;
        }

        public async Task<BoeComplementado> AdicionarBoeComplementado(BoeComplementado boeComplementado)
        {
            await _db.BoeComplementados.AddAsync(boeComplementado).ConfigureAwait(false);
            await _db.SaveChangesAsync().ConfigureAwait(false);
            return boeComplementado;
        }

        public async Task<Registro> EditarRegistro(Registro registro)
        {
            //registro = await AdicionarBOEComplementadoAoEditarRegistro(registro).ConfigureAwait(false);
            
            var verificaRegistro = await ObterRegistroPorID(registro.Id).ConfigureAwait(false);

            if (verificaRegistro != null)
            {
                registro.DataLancamento = verificaRegistro.DataLancamento;

                _db.Entry(verificaRegistro).CurrentValues.SetValues(registro);
                verificaRegistro.Fato = registro.Fato;
                verificaRegistro.Inquerito = registro.Inquerito;
                EditarEnvolvidoDoRegistro(verificaRegistro, registro);
                EditarBoeComplementadoDoRegistro(verificaRegistro, registro);
                EditarArquivoDoRegistro(verificaRegistro, registro);
                await _db.SaveChangesAsync().ConfigureAwait(false);
                return verificaRegistro;
            }
            return null;
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
            var verificaRegistro = await _db.Registros.FindAsync(id).ConfigureAwait(false);

            if (verificaRegistro != null)
            {
                var registroExcluido = _db.Registros.Remove(verificaRegistro);
                await _db.SaveChangesAsync().ConfigureAwait(false);
                return registroExcluido.Entity;
            }
            return null;
        }
    }
}
