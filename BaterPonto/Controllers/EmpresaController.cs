using BaterPonto.Models;
using BaterPonto.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace BaterPonto.Controllers
{
    // O controlador como o próprio nome diz é: A parte de controle do software a ser criado, onde ela recebe as requisição e envia as respostas
    //Aqui chamamos as nossas respostas de View e Metodos
    public class EmpresaController : Controller
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;
        public EmpresaController(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }
        public IActionResult Index()
        {
            List<EmpresModel> empresa = _empresaRepositorio.BuscarTodos();
            return View(empresa);
        }

        

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            EmpresModel Empresa = _empresaRepositorio.ListPorId(id);
            return View(Empresa);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            EmpresModel Empresa = _empresaRepositorio.ListPorId(id);
            return View(Empresa);
        }

        public IActionResult Apagar(int id)
        {
            _empresaRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Create(EmpresModel Empresa)
        {
            
                _empresaRepositorio.Adicioar(Empresa);
                return RedirectToAction("Index");           

        }

        [HttpPost]

        public IActionResult Alterar(EmpresModel Empresa)
        {
            _empresaRepositorio.Atualizar(Empresa);
            return RedirectToAction("Index");
        }
    }
}
