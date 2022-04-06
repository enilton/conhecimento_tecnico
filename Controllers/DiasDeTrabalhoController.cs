using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IEL_Application.Data;
using IEL_Application.Models;

namespace IEL_Application.Views.Profissionais
{
    public class DiasDeTrabalhoController : Controller
    {
        private readonly IEL_ApplicationContext _context;

        public DiasDeTrabalhoController(IEL_ApplicationContext context)
        {
            _context = context;
        }        

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Profissionais", new { area = "Profissionais" });
        }    

        // GET: DiasDeTrabalho/Create
        public IActionResult Create(string profissionalId)
        {
            ViewData["profissionalId"] = profissionalId;
            ViewData["jornadas"] = _context.DiaDeTrabalho.Where(x => x.Profissional.Id == Guid.Parse(profissionalId)).Include(x => x.Profissional).ToList();
            return View();
        }

        public IActionResult Jornada(string profissionalID, DiaDeTrabalho jornada)
        {



            return View();
        }

        // POST: DiasDeTrabalho/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DiaDeTrabalho diaDeTrabalho)
        {
            if (ModelState.IsValid)
            {
                diaDeTrabalho.Id = Guid.NewGuid();
                _context.Add(diaDeTrabalho);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            ViewData["profissionalId"] = diaDeTrabalho.ProfissionalId;
            ViewData["jornadas"] = _context.DiaDeTrabalho.Where(x => x.Profissional.Id == diaDeTrabalho.ProfissionalId).Include(x => x.Profissional).ToList(); ;
            return RedirectToAction("Create", "DiasDeTrabalho", new { area = "DiasDeTrabalho", profissionalId = diaDeTrabalho.ProfissionalId });
        }

        

        // GET: DiasDeTrabalho/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diaDeTrabalho = await _context.DiaDeTrabalho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diaDeTrabalho == null)
            {
                return NotFound();
            }

            return View(diaDeTrabalho);
        }

        // POST: DiasDeTrabalho/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var diaDeTrabalho = await _context.DiaDeTrabalho.FindAsync(id);
            _context.DiaDeTrabalho.Remove(diaDeTrabalho);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiaDeTrabalhoExists(Guid id)
        {
            return _context.DiaDeTrabalho.Any(e => e.Id == id);
        }

        [HttpGet, ActionName("CalcularCH")]
        private IActionResult CalcularCH(string hs, string hf, string descanso)
        {
            var hInicio = new TimeSpan(Convert.ToInt32(hs.Split(":")[0]), Convert.ToInt32(hs.Split(":")[1]),0);
            var hFim = new TimeSpan(Convert.ToInt32(hf.Split(":")[0]), Convert.ToInt32(hf.Split(":")[1]), 0);           
            return Json( (hFim - hInicio) - new TimeSpan(Convert.ToInt32(descanso), 0, 0));
        }
    }
}
