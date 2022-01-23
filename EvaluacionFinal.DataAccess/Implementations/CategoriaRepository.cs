using EvaluacionFinal.DataAccess.Interfaces;
using EvaluacionFinal.Dto;
using EvaluacionFinal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionFinal.DataAccess.Implementations
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly EvaluacionFinalDbContext _context;

        public CategoriaRepository(EvaluacionFinalDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseDto<bool>> Create(CategoriaDto request)
        {
            var response = new ResponseDto<bool>();

            try
            {
                Categoria entity = new Categoria
                {
                    IdCategoria = 0,
                    Nombre = request.NombreCategoria,
                    Descripcion = request.DescripcionCategoria,
                    Habilitado = request.Habilitado
                };

                await _context.Categorias.AddAsync(entity);
                await _context.SaveChangesAsync();

                response.Result = true;
            }
            catch (Exception ex)
            {
                response.Error(HttpStatusCode.InternalServerError, ex.Message, false);
            }

            return response;
        }

        public async Task<ResponseDto<bool>> Delete(int id)
        {
            var response = new ResponseDto<bool>();

            try
            {
                Categoria entity = await _context.Categorias.FindAsync(id);

                _context.Categorias.Remove(entity);
                await _context.SaveChangesAsync();

                response.Result = true;
            }
            catch (Exception ex)
            {
                response.Error(HttpStatusCode.InternalServerError, ex.Message, false);
            }

            return response;
        }

        public async Task<ResponseDto<IEnumerable<CategoriaDto>>> GetAll()
        {
            var response = new ResponseDto<IEnumerable<CategoriaDto>>();

            try
            {
                response.Result = await _context.Categorias
                    .Select(x => new CategoriaDto
                    {
                        IdCategoria = x.IdCategoria,
                        NombreCategoria = x.Nombre,
                        DescripcionCategoria = x.Descripcion,
                        Habilitado = x.Habilitado
                    }).ToListAsync();
            }
            catch (Exception ex)
            {
                response.Error(HttpStatusCode.InternalServerError, ex.Message, null);
            }

            return response;
        }

        public async Task<ResponseDto<IEnumerable<ListCortoDto>>> GetHabilitados()
        {
            var response = new ResponseDto<IEnumerable<ListCortoDto>>();

            try
            {
                response.Result = await _context.Categorias
                    .Where(x => x.Habilitado)
                    .Select(x => new ListCortoDto
                    {
                        Id = x.IdCategoria,
                        Nombre = x.Nombre,
                    }).ToListAsync();
            }
            catch (Exception ex)
            {
                response.Error(HttpStatusCode.InternalServerError, ex.Message, null);
            }

            return response;
        }

        public async Task<ResponseDto<bool>> Update(CategoriaDto request)
        {
            var response = new ResponseDto<bool>();

            try
            {
                Categoria entity = await _context.Categorias.FindAsync(request.IdCategoria);
                entity.Nombre = request.NombreCategoria;
                entity.Descripcion = request.DescripcionCategoria;
                entity.Habilitado = request.Habilitado;

                await _context.SaveChangesAsync();

                response.Result = true;
            }
            catch (Exception ex)
            {
                response.Error(HttpStatusCode.InternalServerError, ex.Message, false);
            }

            return response;
        }
    }
}
