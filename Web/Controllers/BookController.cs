using Assessment.DATA.Models;
using Assessment.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    
    public class BookController : Controller
    {
        private BookService oBookService = new BookService();

        public object Id { get; private set; }

        public IActionResult Index()
        {
            List<Book> oListBook = oBookService.oRepositoyLista.SelecionarTodos();
            return View(oListBook);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book model)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            oBookService.oRepositoyLista.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Book oBook = oBookService.oRepositoyLista.SelecionarPK(id);
            return View(oBook);
        }

        public IActionResult Edit(int id)
        {
            Book oBook = oBookService.oRepositoyLista.SelecionarPK(id);
            return View(oBook);
        }
        [HttpPost]
        public IActionResult Edit(Book model)
        {
           Book oBook =  oBookService.oRepositoyLista.Alterar(model);

            

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            oBookService.oRepositoyLista.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
