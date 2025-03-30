using CasosUso.DTOs;
using CasosUso.InterfacesCasosUso;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    public class TemasController : Controller
    {
        public IAltaTema CasoUsoAltaTema { get; set; }

        public IListadoTemas CasoUsoListadoTemas { get; set; }

        public TemasController(IAltaTema casoUsoAltaTema, IListadoTemas casoUsoListadoTemas)
        {
            CasoUsoAltaTema = casoUsoAltaTema;
            CasoUsoListadoTemas = casoUsoListadoTemas;
        }

        // GET: TemasController
        public ActionResult Index()
        {
            IEnumerable<TemaDTO> temas = CasoUsoListadoTemas.ObtenerListado();
            return View(temas);
        }

        // GET: TemasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TemasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TemasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TemaDTO dto)
        {
            try
            {
                CasoUsoAltaTema.EjecutarAltaTema(dto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TemasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TemasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TemasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TemasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
