﻿namespace CrudProdutosApiWithAspNetCore.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }        
    }
}
