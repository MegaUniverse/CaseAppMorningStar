using CaseAppProducts.Data;
using CaseAppProducts.Models;
using System.Collections.Generic;
using System.Linq;

namespace CaseAppProducts.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly BancoContext _context;
        public ProdutoRepositorio(BancoContext bancoContext)
        {
            this._context = bancoContext;
        }

        public ProdutoModel ListarPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(x => x.Id == id);
        }
        public List<ProdutoModel> BuscarTodos()
        {
            return _context.Produtos.ToList();
        }
        public ProdutoModel Adicionar(ProdutoModel produto)
        {
            // gravar no banco
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto;

        }

        public ProdutoModel Atualizar(ProdutoModel contato)
        {
            ProdutoModel produtoBD = ListarPorId(contato.Id);
            if (produtoBD == null) throw new System.Exception("Dados não Gravados");
            produtoBD.Produto = contato.Produto;
            produtoBD.Registro = contato.Registro;
            produtoBD.Fabricante = contato.Fabricante;
            produtoBD.Tipo = contato.Tipo;
            produtoBD.Descricao = contato.Descricao;


            _context.Produtos.Update(produtoBD);
            _context.SaveChanges();
            return produtoBD;

        }

        public bool Apagar(int id)
        {
            ProdutoModel produtoDB = ListarPorId(id);

            if (produtoDB == null) throw new System.Exception("Dados não Deletados");

            _context.Produtos.Remove(produtoDB);
            _context.SaveChanges();
            return true; 

        }
    }
}
