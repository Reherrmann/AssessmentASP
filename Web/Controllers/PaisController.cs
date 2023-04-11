using Assessment.DATA.Models;
using Assessment.DATA.Services;
using Microsoft.AspNetCore.Mvc;


namespace web.Controllers
{
    public class PaisController : Controller
    {

        private PaisService oPaisService = new PaisService();
        public IActionResult Index()
        {
            List<Pais> oListPais = oPaisService.oRepositoryPais.SelecionarTodos();
            return View(oListPais);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pais model)
        {

            if (!ModelState.IsValid)
            {
                
                return View();
            }

            oPaisService.oRepositoryPais.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Pais oPais = oPaisService.oRepositoryPais.SelecionarPK(id);
            return View(oPais);
        }

        public IActionResult Edit(int id)
        {
            Pais oPais = oPaisService.oRepositoryPais.SelecionarPK(id);
            return View(oPais);
        }
        [HttpPost]
        public IActionResult Edit(Pais model)
        {
            Pais oPais = oPaisService.oRepositoryPais.Alterar(model);



            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            oPaisService.oRepositoryPais.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}



    