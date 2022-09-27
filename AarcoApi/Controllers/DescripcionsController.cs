using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AarcoApi.Models.Context;
using AarcoApi.Models.entities;

namespace AarcoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescripcionsController : ControllerBase
    {
        private readonly ApiContext _context;

        public DescripcionsController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Descripcions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Descripcion>>> GetDescripcion()
        {
            return await _context.Descripcion.ToListAsync();
        }

        // GET: api/Descripcions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Descripcion>> GetDescripcion(int id)
        {
            var descripcion = await _context.Descripcion.Where(descr => descr.IdModeloSubM == id).ToListAsync();

            if (descripcion == null)
            {
                return NotFound();
            }

            return Ok(descripcion);
        }

        
    }
}
