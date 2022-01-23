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
    public class ProductoRepository : IProductoRepository
    {
        private readonly EvaluacionFinalDbContext _context;

        public ProductoRepository(EvaluacionFinalDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseDto<bool>> Create(ProductoDto request)
        {
            var response = new ResponseDto<bool>();

            try
            {
                Producto entity = new Producto
                {
                    IdProducto = 0,
                    IdCategoria = request.IdCategoria,
                    Nombre = request.NombreProducto,
                    PrecioUnitario = request.PrecioUnitario,
                    Habilitado = request.Habilitado
                };

                await _context.Productos.AddAsync(entity);
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
                Producto entity = await _context.Productos.FindAsync(id);

                _context.Productos.Remove(entity);
                await _context.SaveChangesAsync();

                response.Result = true;
            }
            catch (Exception ex)
            {
                response.Error(HttpStatusCode.InternalServerError, ex.Message, false);
            }

            return response;
        }

        public async Task<ResponseDto<IEnumerable<ProductoDto>>> GetAll()
        {
            var response = new ResponseDto<IEnumerable<ProductoDto>>();

            try
            {
                response.Result = await (from pr in _context.Productos
                                         join ca in _context.Categorias on pr.IdCategoria equals ca.IdCategoria
                                         select new ProductoDto
                                         {
                                             IdProducto = pr.IdProducto,
                                             IdCategoria = ca.IdCategoria,
                                             NombreCategoria = ca.Nombre,
                                             NombreProducto = pr.Nombre,
                                             PrecioUnitario = pr.PrecioUnitario,
                                             Habilitado = pr.Habilitado
                                         }).ToListAsync();
            }
            catch (Exception ex)
            {
                response.Error(HttpStatusCode.InternalServerError, ex.Message, null);
            }

            return response;
        }

        public async Task<ResponseDto<bool>> Update(ProductoDto request)
        {
            var response = new ResponseDto<bool>();

            try
            {
                Producto entity = await _context.Productos.FindAsync(request.IdProducto);
                entity.Nombre = request.NombreProducto;
                entity.IdCategoria = request.IdCategoria;
                entity.Habilitado = request.Habilitado;
                entity.PrecioUnitario = request.PrecioUnitario;

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
