﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CrudProdutosApiWithAspNetCore.Data.DataContext;
using CrudProdutosApiWithAspNetCore.Dominio.Entidades;
using CrudProdutosApiWithAspNetCore.Dominio.Repositorios;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CrudProdutosApiWithAspNetCore.Data.EF.Repositorios
{
    public class ProdutoRepositorioEF : RepositorioEF<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorioEF(ApiWithAspNetCoreDataContext ctx) : base(ctx)
        {
        }

        public async Task<IEnumerable<Produto>> GetAllWithCategoriaAsync()
        {
            return await _db.Include(p => p.Categoria).ToListAsync();
        }

        public async Task<Produto> GetByIdWithCategoriaAsync(int id)
        {
            return await _db.Include(p => p.Categoria).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> GetByNomeAsync(string name)
        {
            return await _db.Where(p => p.Nome.Contains(name)).ToListAsync();
        }
    }
}
