using ASPNetMVCAppInterboden.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMVCAppInterboden.Controllers
{
    public class WohnungenController : Controller
    {
        private WohnungenContext context;
        public WohnungenController(WohnungenContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var model = context.Wohnungen.Where(w => w.IstInaktiv == false); ;
            return View(model);
        }

        public IActionResult Neu()
        {
            return View(new Wohnung());
        }

        public async Task<IActionResult> ErstellenOderBearbeiten(int? id)
        {
            if (id == null || id == 0)
            {
                return View(new Wohnung());
            }
            else
            {
                var wohnung = await context.Wohnungen.FindAsync(id);
                if (wohnung == null)
                {
                    return NotFound();
                }
                return View(wohnung);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ErstellenOderBearbeiten(int? id, [Bind("Id,Beschreibung,Strasse,Postleitzahl,Ort,IstInaktiv")] Wohnung wohnung)
        {
            if (ModelState.IsValid)
            {
                if (id == null || id == 0)
                {
                    context.Wohnungen.Add(wohnung);
                    await context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        context.Wohnungen.Update(wohnung);
                        await context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!context.Wohnungen.Any(w => w.Id == wohnung.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                // Um im JQuery Script zu unterscheiden, ob die Anfrage gültig ist, Json-Objekt erstellen, mit Gültigkeit und View als Html-String
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_WohnungsUebersicht", context.Wohnungen.Where(w => w.IstInaktiv == false)) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "ErstellenOderBearbeiten", wohnung) });
        }

    }
}
