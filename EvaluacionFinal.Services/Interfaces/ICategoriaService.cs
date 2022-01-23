using EvaluacionFinal.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<ResponseDto<bool>> Create(CategoriaDto request);
        Task<ResponseDto<bool>> Delete(int id);
        Task<ResponseDto<IEnumerable<CategoriaDto>>> GetAll();
        Task<ResponseDto<IEnumerable<ListCortoDto>>> GetHabilitados();
        Task<ResponseDto<bool>> Update(CategoriaDto request);
    }
}
