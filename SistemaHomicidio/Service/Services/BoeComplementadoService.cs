using AutoMapper;
using Domain.Entities;
using Infra.CrossCutting.ViewModels.Boe;
using Infra.Data.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BoeComplementadoService : IBoeComplementadoService
    {
        private readonly IBoeComplementadoRepository _boeComplementadoRepository;
        private readonly IMapper _mapper;

        public BoeComplementadoService(IBoeComplementadoRepository boeComplementadoRepository, IMapper mapper)
        {
            _boeComplementadoRepository = boeComplementadoRepository;
            _mapper = mapper;
        }

        public async Task<ExibirBoeComplementado> AdicionarBoeComplementado(NovoBoe NovoBoeComplementado)
        {
            var boeComplementado = _mapper.Map<BoeComplementado>(NovoBoeComplementado);
            boeComplementado = await _boeComplementadoRepository.AdicionarBoeComplementado(boeComplementado);
            return _mapper.Map<ExibirBoeComplementado>(boeComplementado);
        }

        public async Task<ExibirBoeComplementado> EditarBoeComplementado(AlterarBoe AlteraBoeComplementado)
        {
            var boeComplementado = _mapper.Map<BoeComplementado>(AlteraBoeComplementado);
            boeComplementado = await _boeComplementadoRepository.EditarBoeComplementado(boeComplementado);
            return _mapper.Map<ExibirBoeComplementado>(boeComplementado);
        }

        public async Task<ExibirBoeComplementado> ExcluirBoeComplementado(int id)
        {
            var boeComplementado = await _boeComplementadoRepository.ExcluirBoeComplementado(id);
            return _mapper.Map<ExibirBoeComplementado>(boeComplementado);
        }

        public async Task<List<ExibirBoeComplementado>> ExibirTodosBoeComplementado()
        {
            var boesComplementares = await _boeComplementadoRepository.ExibirTodosBoeComplementado();
            return _mapper.Map<List<ExibirBoeComplementado>>(boesComplementares);
        }

        public async Task<ExibirBoeComplementado> ObterBoeComplementadoPorID(int id)
        {
            var boeComplementado = await _boeComplementadoRepository.ObterBoeComplementadoPeloId(id);
            return _mapper.Map<ExibirBoeComplementado>(boeComplementado);
        }

        public async Task<ExibirBoeComplementado> ObterBoeComplementadoPorRegistroID(int id)
        {
            var boeComplementado = await _boeComplementadoRepository.ObterBoeComplementadoPeloRegistroId(id);
            return _mapper.Map<ExibirBoeComplementado>(boeComplementado);
        }
    }
}
