using Microsoft.AspNetCore.Mvc;
using Assessment.DATA.Models;
using Assessment.DATA.Services;

namespace Web.Controllers
{
        public class AmigoController : Controller
        {
            private AmigoService oAmigoService = new AmigoService();
            public IActionResult Index()
            {
                List<Amigo> oListAmigo = oAmigoService.oRepositoryAmigo.SelecionarTodos();
                return View(oListAmigo);
            }

            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Create(Amigo model)
            {

                if (!ModelState.IsValid)
                {
                    return View();
                }

                oAmigoService.oRepositoryAmigo.Incluir(model);
                return RedirectToAction("Index");
            }

            public IActionResult Details(int id)
            {
                Amigo oAmigo = oAmigoService.oRepositoryAmigo.SelecionarPK(id);
                return View(oAmigo);
            }

            public IActionResult Edit(int id)
            {
                Amigo oAmigo = oAmigoService.oRepositoryAmigo.SelecionarPK(id);
                return View(oAmigo);
            }
            [HttpPost]
            public IActionResult Edit(Amigo model)
            {
                Amigo oAmigo = oAmigoService.oRepositoryAmigo    .Alterar(model);



                return RedirectToAction("Index");
            }

            public IActionResult Delete(int id)
            {
                oAmigoService.oRepositoryAmigo.Excluir(id);
                return RedirectToAction("Index");
            }

        }
    }


