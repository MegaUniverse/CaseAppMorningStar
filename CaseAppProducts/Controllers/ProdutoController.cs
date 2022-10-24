using CaseAppProducts.Models;
using CaseAppProducts.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CaseAppProducts.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtosRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtosRepositorio = produtoRepositorio;
        }
        public IActionResult Index()
        {
            List<ProdutoModel> produto = _produtosRepositorio.BuscarTodos();

            return View(produto);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            ProdutoModel produto = _produtosRepositorio.ListarPorId(id);
            return View(produto);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ProdutoModel produto = _produtosRepositorio.ListarPorId(id);
            return View(produto);
        }

        public IActionResult Apagar(int id)
        {
            _produtosRepositorio.Apagar(id);
            return RedirectToAction("Index"); 
        }

        [HttpPost]  //informando que o metodo é do tipo http post
        public IActionResult Criar(ProdutoModel produto)
        {
            _produtosRepositorio.Adicionar(produto);
            return RedirectToAction("Index"); //redireciona para o Index
        }

        [HttpPost]  //informando que o metodo é do tipo http post
        public IActionResult Alterar(ProdutoModel contato)
        {
            _produtosRepositorio.Atualizar(contato);
            return RedirectToAction("Index"); //redireciona para o Index
        }
    }
}

