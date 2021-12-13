using E_JOGOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult representa retorno de status HTTP

        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {   
            //View = responsável pela exibição do frontend.
            //bag = Armazenar as informações backend para serem acessadas no frontend.

            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }

        //public IActionResult Cadastrar(IFormCollection form)
        //{

        //}
    }
}
