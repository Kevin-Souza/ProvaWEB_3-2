using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaWeb3_2.Data;

namespace ProvaWeb3_2.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AppCont _appCont;

        public ProdutoController(AppCont appCont)
        {
            _appCont = appCont;
        }


        public IActionResult Index()
        {
            return View();
        }


        //GET: Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _appCont.produtos
                .FirstOrDefaultAsync(m => m.id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }


        //Post: Delete  
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _appCont.produtos.FindAsync(id);
            _appCont.produtos.Remove(produto);
            await _appCont.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
