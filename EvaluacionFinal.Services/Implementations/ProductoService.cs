using EvaluacionFinal.DataAccess.Interfaces;
using EvaluacionFinal.Dto;
using EvaluacionFinal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal.Services.Implemenattions
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository repository)
        {
            this._repository = repository;
        }

        public async Task<ResponseDto<bool>> Create(ProductoDto request)
        {
            return await _repository.Create(request);
        }

        public async Task<ResponseDto<bool>> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<ResponseDto<IEnumerable<ProductoDto>>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<ResponseDto<bool>> Update(ProductoDto request)
        {
            return await _repository.Update(request);
        }
    }
}
