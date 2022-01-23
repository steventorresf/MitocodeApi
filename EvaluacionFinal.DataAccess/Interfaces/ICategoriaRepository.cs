using EvaluacionFinal.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal.DataAccess.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<ResponseDto<bool>> Create(CategoriaDto request);
        Task<ResponseDto<bool>> Delete(int id);
        Task<ResponseDto<IEnumerable<CategoriaDto>>> GetAll();
        Task<ResponseDto<IEnumerable<ListCortoDto>>> GetHabilitados();
        Task<ResponseDto<bool>> Update(CategoriaDto request);
    }
}
