using EvaluacionFinal.DataAccess.Interfaces;
using EvaluacionFinal.Dto;
using EvaluacionFinal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal.Services.Implementations
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            this._repository = repository;
        }

        public async Task<ResponseDto<bool>> Create(CategoriaDto request)
        {
            return await _repository.Create(request);
        }

        public async Task<ResponseDto<bool>> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<ResponseDto<IEnumerable<CategoriaDto>>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<ResponseDto<IEnumerable<ListCortoDto>>> GetHabilitados()
        {
            return await _repository.GetHabilitados();
        }

        public async Task<ResponseDto<bool>> Update(CategoriaDto request)
        {
            return await _repository.Update(request);
        }
    }
}
