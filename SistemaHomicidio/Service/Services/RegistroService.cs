using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels;
using Infra.Data.Interfaces;
using Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class RegistroService : IRegistroService
    {
        private readonly IRegistroRepository _registroRepository;
        private readonly IMapper _mapper;

        public RegistroService(IRegistroRepository registroRepository, IMapper mapper)
        {
            _registroRepository = registroRepository;
            _mapper = mapper;
        }

        public async Task<List<ExibirRegistro>> ExibirTodosRegistros()
        {
            var registros = await _registroRepository.ExibirTodosRegistros().ConfigureAwait(false);
            return _mapper.Map<List<ExibirRegistro>>(registros);
        }

        public async Task<AlterarRegistro> ExibirRegistroPorId(int id)
        {
            var registro = await _registroRepository.ObterRegistroPorID(id).ConfigureAwait(false);
            return _mapper.Map<AlterarRegistro>(registro);
        }

        public async Task<ExibirRegistro> AdicionarRegistro(NovoRegistro novoRegistro)
        {
            var registro = _mapper.Map<Registro>(novoRegistro);
            registro = await _registroRepository.AdicionarRegistro(registro).ConfigureAwait(false);
            return _mapper.Map<ExibirRegistro>(registro);
        }

        public async Task<ExibirRegistro> EditarRegistro(AlterarRegistro alterarRegistro)
        {
            var registro = _mapper.Map<Registro>(alterarRegistro);
            registro = await _registroRepository.EditarRegistro(registro).ConfigureAwait(false);
            return _mapper.Map<ExibirRegistro>(registro);
        }

        public async Task<ExibirRegistro> ExcluirRegistro(int id)
        {
            var registro = await _registroRepository.ExcluirRegistro(id).ConfigureAwait(false);
            return _mapper.Map<ExibirRegistro>(registro);
        }
    }
}
