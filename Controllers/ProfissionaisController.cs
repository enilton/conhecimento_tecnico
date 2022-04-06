using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IEL_Application.Data;
using IEL_Application.Models;
using IEL_Application.Models.Enums;

namespace IEL_Application.Controllers
{
    public class ProfissionaisController : Controller
    {
        private readonly IEL_ApplicationContext _context;

        public ProfissionaisController(IEL_ApplicationContext context)
        {
            _context = context;
        }

        // GET: Profissionais
        public async Task<IActionResult> Index()
        {   ViewData["profissionais"] = await _context.Profissional.ToListAsync();
            return View();
        }

        // GET: Profissionais/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profissional = await _context.Profissional
                .FirstOrDefaultAsync(m => m.Id == Guid.Parse(id));
            if (profissional == null)
            {
                return NotFound();
            }

            var estados = await EnderecoService.GetServiceInstance().GetEstados();
            List<SelectListItem> selectListItemsEstado = new List<SelectListItem>();

            foreach (var estado in estados)
                selectListItemsEstado.Add(new SelectListItem { Text = estado.Sigla, Value = estado.Id.ToString() });

            ViewData["estados"] = selectListItemsEstado;

            return View(profissional);
        }

        // GET: Profissionais/Create
        public async Task<IActionResult> Create()
        {
            var estados = await EnderecoService.GetServiceInstance().GetEstados();
            List<SelectListItem> selectListItemsEstado = new List<SelectListItem>();

            foreach (var estado in estados)
                selectListItemsEstado.Add(new SelectListItem { Text = estado.Sigla, Value = estado.Id.ToString() });

            ViewData["estados"] = selectListItemsEstado;


            return View();
        }

        // POST: Profissionais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Profissional profissional)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profissional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profissional);
        }

        // GET: Profissionais/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profissional = await _context.Profissional.FindAsync(Guid.Parse(id));


            if (profissional == null)
            {
                return NotFound();
            }

            var estados = await EnderecoService.GetServiceInstance().GetEstados();
            List<SelectListItem> selectListItemsEstado = new List<SelectListItem>();

            foreach (var estado in estados)
                selectListItemsEstado.Add(new SelectListItem { Text = estado.Sigla, Value = estado.Id.ToString() });

            ViewData["estados"] = selectListItemsEstado;

            return View(profissional);
        }

        // POST: Profissionais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Profissional profissional)
        {
            if (Guid.Parse(id) != profissional.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profissional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfissionalExists(profissional.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            var estados = await EnderecoService.GetServiceInstance().GetEstados();
            List<SelectListItem> selectListItemsEstado = new List<SelectListItem>();

            foreach (var estado in estados)
                selectListItemsEstado.Add(new SelectListItem { Text = estado.Sigla, Value = estado.Id.ToString() });

            ViewData["estados"] = selectListItemsEstado;

            return View(profissional);
        }

        // GET: Profissionais/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profissional = await _context.Profissional
                .FirstOrDefaultAsync(m => m.Id == Guid.Parse(id));
            if (profissional == null)
            {
                return NotFound();
            }

            return View(profissional);
        }

        // POST: Profissionais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var profissional = await _context.Profissional.FindAsync(id);
            _context.Profissional.Remove(profissional);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfissionalExists(Guid id)
        {
            return _context.Profissional.Any(e => e.Id == id);
        }
        

        [HttpGet, ActionName("ListaCidadeAsync")]
        public async Task<ActionResult> ListaCidadeAsync(string estadoId)
        {
            return Json(await EnderecoService.GetServiceInstance().GetMuniciopiosPorEstado(estadoId));
        }

        [HttpGet, ActionName("BuscaEnderecoAsync")]
        public async Task<ActionResult> BuscaEnderecoAsync(string cep)
        {
            return Json(await EnderecoService.GetServiceInstance().GetEnderecoPorCEP(cep));
        }

        public IActionResult Jornada(string id)
        {
            return RedirectToAction("Create","DiasDeTrabalho", new { area = "DiasDeTrabalho", profissionalId = id});
        }

    }
}
