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
    public class SubMarcasController : ControllerBase
    {
        private readonly ApiContext _context;

        public SubMarcasController(ApiContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubMarca>>> GetSubMarca()
        {
            return await _context.SubMarca.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubMarca>> GetSubMarca(int id)
        {
            var subMarca = await _context.SubMarca.Where(subMar => subMar.IdMarcas == id).ToListAsync();

            if (subMarca == null)
            {
                return NotFound();
            }

            return Ok(subMarca);
        }
    }
}
