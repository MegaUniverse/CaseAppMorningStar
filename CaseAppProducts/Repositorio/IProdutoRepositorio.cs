using CaseAppProducts.Models;
using System.Collections.Generic;

namespace CaseAppProducts.Repositorio
{
    public interface IProdutoRepositorio
    {
        ProdutoModel ListarPorId (int id);
        List<ProdutoModel> BuscarTodos();
        ProdutoModel Adicionar(ProdutoModel contato);
        ProdutoModel Atualizar (ProdutoModel contato);

        bool Apagar(int id);
        
    }
}
