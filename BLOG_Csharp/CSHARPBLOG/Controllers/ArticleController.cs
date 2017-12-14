using CSHARPBLOG.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CSHARPBLOG.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            using (var database = new BlogDbContext())
            {
                var articles = database.Articles
                    .Include(a => a.Author)
                    .ToList();

                return View(articles);
            }
                
        }
    }
}