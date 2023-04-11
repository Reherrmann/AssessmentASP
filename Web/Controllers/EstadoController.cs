using Assessment.DATA.Models;
using Assessment.DATA.Services;
using Microsoft.AspNetCore.Mvc;


namespace web.Controllers
{
    public class EstadoController : Controller
    {
        private EstadoService oEstadoService = new EstadoService();
        public IActionResult Index()
        {
           List<Estado> oListEstado = oEstadoService.oRepositoryEstado.SelecionarTodos();
            return View(oListEstado);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Estado model)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            oEstadoService.oRepositoryEstado.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Estado oEstado = oEstadoService.oRepositoryEstado.SelecionarPK(id);
            return View(oEstado);
        }

        public IActionResult Edit(int id)
        {
            Estado oEstado = oEstadoService.oRepositoryEstado.SelecionarPK(id);
            return View(oEstado);
        }
        [HttpPost]
        public IActionResult Edit(Estado model)
        {
            Estado oEstado = oEstadoService.oRepositoryEstado.Alterar(model);



            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            oEstadoService.oRepositoryEstado.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}



    