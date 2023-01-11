﻿using CatalogoApp.Server.Context;
using CatalogoApp.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogoApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly AppDbContext context;

        public CategoriaController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> Get()
        {
            return await context.Categorias.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetCategoria")]
        public async Task<ActionResult<Categoria>> Get(int id)
        {
            return await context.Categorias.FirstOrDefaultAsync(x => x.CategoriaId == id);
        }
        [HttpPost]
        public async Task<ActionResult<Categoria>> Post(Categoria categoria)
        {
            context.Add(categoria);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetCategoria", new { id = categoria.CategoriaId }, categoria);
        }
        [HttpPut]
        public async Task<ActionResult<Categoria>> Put(Categoria categoria)
        {
            context.Entry(categoria).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(categoria);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoria>> Delete(int id)
        {
            var categoria = new Categoria { CategoriaId = id };
            context.Remove(categoria);
            await context.SaveChangesAsync();
            return Ok(categoria);   
        }
    }
}
