using CaseAppProducts.Models;
using System.Collections.Generic;

namespace CaseAppProducts.Repositorio
{
    public interface IProdutoRepositorio
    {
        ProdutoModel ListarPorId (int id);
        List<ProdutoModel> BuscarTodos();
        ProdutoModel Adicionar(ProdutoModel produto);
        ProdutoModel Atualizar (ProdutoModel produto);

        bool Apagar(int id);
        
    }
}
