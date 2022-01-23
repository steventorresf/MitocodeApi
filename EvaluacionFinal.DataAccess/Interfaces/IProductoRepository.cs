using EvaluacionFinal.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal.DataAccess.Interfaces
{
    public interface IProductoRepository
    {
        Task<ResponseDto<bool>> Create(ProductoDto request);
        Task<ResponseDto<bool>> Delete(int id);
        Task<ResponseDto<IEnumerable<ProductoDto>>> GetAll();
        Task<ResponseDto<bool>> Update(ProductoDto request);
    }
}
