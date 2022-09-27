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
    public class ModelSubMarsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ModelSubMarsController(ApiContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModelSubMar>>> GetModelSubMar()
        {
            return await _context.ModelSubMar.ToListAsync();
        }

   
        [HttpGet("{id}")]
        public async Task<ActionResult<ModelSubMar>> GetModelSubMar(int id)
        {
            var modelSubMar = await _context.ModelSubMar.Where(modelSub => modelSub.IdSubMarca==id).ToListAsync();

            if (modelSubMar == null)
            {
                return NotFound();
            }

            return Ok(modelSubMar);
        }

       
    }
}
