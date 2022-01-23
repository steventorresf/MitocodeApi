using EvaluacionFinal.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal.Services.Interfaces
{
    public interface IProductoService
    {
        Task<ResponseDto<bool>> Create(ProductoDto request);
        Task<ResponseDto<bool>> Delete(int id);
        Task<ResponseDto<IEnumerable<ProductoDto>>> GetAll();
        Task<ResponseDto<bool>> Update(ProductoDto request);
    }
}
