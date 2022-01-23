using EvaluacionFinal.Dto;
using EvaluacionFinal.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluacionFinal.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _service;

        public ProductoController(IProductoService service)
        {
            this._service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductoDto request)
        {
            var response = await _service.Create(request);
            return Ok(response);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _service.Delete(id);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetAll();
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ProductoDto request)
        {
            var response = await _service.Update(request);
            return Ok(response);
        }
    }
}
