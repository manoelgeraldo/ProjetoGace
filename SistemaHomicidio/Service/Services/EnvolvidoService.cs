using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Envolvido;
using Infra.Data.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class EnvolvidoService : IEnvolvidoService
    {
        private readonly IEnvolvidoRepository _envolvidoRepository;
        private readonly IMapper _mapper;

        public EnvolvidoService(IEnvolvidoRepository envolvidoRepository, IMapper mapper)
        {
            _envolvidoRepository = envolvidoRepository;
            _mapper = mapper;
        }

        public async Task<ExibirEnvolvido> AdicionarEnvolvido(NovoEnvolvido novoEnvolvido)
        {
            var envolvido = _mapper.Map<Envolvido>(novoEnvolvido);
            envolvido = await _envolvidoRepository.AdicionarEnvolvido(envolvido);
            return _mapper.Map<ExibirEnvolvido>(envolvido);
        }

        public async Task<ExibirEnvolvido> EditarEnvolvido(AlterarEnvolvido alterarEnvolvido)
        {
            var envolvido = _mapper.Map<Envolvido>(alterarEnvolvido);
            envolvido = await _envolvidoRepository.EditarEnvolvido(envolvido);
            return _mapper.Map<ExibirEnvolvido>(envolvido);
        }

        public async Task<ExibirEnvolvido> ExcluirEnvolvido(int id)
        {
            var envolvido = await _envolvidoRepository.ExcluirEnvolvido(id);
            return _mapper.Map<ExibirEnvolvido>(envolvido);
        }

        public async Task<List<ExibirEnvolvido>> ExibirTodosEnvolvidos()
        {
            var envolvidos = await _envolvidoRepository.ExibirTodosEnvolvidos();
            return _mapper.Map<List<ExibirEnvolvido>>(envolvidos);
        }

        public async Task<ExibirEnvolvido> ObterEnvolvidoPorID(int id)
        {
            var envolvido = await _envolvidoRepository.ObterEnvolvidoPeloId(id);
            return _mapper.Map<ExibirEnvolvido>(envolvido);
        }

        public async Task<ExibirEnvolvido> ObterEnvolvidoPeloNome(string nome)
        {
            var nomeInserido = await _envolvidoRepository.ObterEnvolvidoPeloNome(nome);
            return _mapper.Map<ExibirEnvolvido>(nomeInserido);
        }
    }
}
