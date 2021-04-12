using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Application.Models;
using Data;

namespace Application.Controllers
{

    public class TeacherController : BaseController<TeacherController, TeacherModel>
    {
        //private readonly IBaseRepository<EmployeeModel> _repo;

        public TeacherController(IBaseRepository<TeacherModel> repo) : base(repo)
        {

        }

        // GET: Employee

    }

    //    public class TeacherController : Controller
    //    {
    //        private readonly Data.AppContext _context;

    //        public TeacherController(Data.AppContext context)
    //        {
    //            _context = context;
    //        }

    //        // GET: TeacherModels
    //        public async Task<IActionResult> Index()
    //        {
    //            return View(await _context.TeacherModel.ToListAsync());
    //        }

    //        // GET: TeacherModels/Details/5
    //        public async Task<IActionResult> Details(string id)
    //        {
    //            if (id == null)
    //            {
    //                return NotFound();
    //            }

    //            var teacherModel = await _context.TeacherModel
    //                .FirstOrDefaultAsync(m => m.ID == id);
    //            if (teacherModel == null)
    //            {
    //                return NotFound();
    //            }

    //            return View(teacherModel);
    //        }

    //        // GET: TeacherModels/Create
    //        public IActionResult Create()
    //        {
    //            return View();
    //        }

    //        // POST: TeacherModels/Create
    //        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //        [HttpPost]
    //        [ValidateAntiForgeryToken]
    //        public async Task<IActionResult> Create([Bind("ID,TeacherName")] TeacherModel teacherModel)
    //        {
    //            if (ModelState.IsValid)
    //            {
    //                _context.Add(teacherModel);
    //                await _context.SaveChangesAsync();
    //                return RedirectToAction(nameof(Index));
    //            }
    //            return View(teacherModel);
    //        }

    //        // GET: TeacherModels/Edit/5
    //        public async Task<IActionResult> Edit(string id)
    //        {
    //            if (id == null)
    //            {
    //                return NotFound();
    //            }

    //            var teacherModel = await _context.TeacherModel.FindAsync(id);
    //            if (teacherModel == null)
    //            {
    //                return NotFound();
    //            }
    //            return View(teacherModel);
    //        }

    //        // POST: TeacherModels/Edit/5
    //        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //        [HttpPost]
    //        [ValidateAntiForgeryToken]
    //        public async Task<IActionResult> Edit(string id, [Bind("ID,TeacherName")] TeacherModel teacherModel)
    //        {
    //            if (id != teacherModel.ID)
    //            {
    //                return NotFound();
    //            }

    //            if (ModelState.IsValid)
    //            {
    //                try
    //                {
    //                    _context.Update(teacherModel);
    //                    await _context.SaveChangesAsync();
    //                }
    //                catch (DbUpdateConcurrencyException)
    //                {
    //                    if (!TeacherModelExists(teacherModel.ID))
    //                    {
    //                        return NotFound();
    //                    }
    //                    else
    //                    {
    //                        throw;
    //                    }
    //                }
    //                return RedirectToAction(nameof(Index));
    //            }
    //            return View(teacherModel);
    //        }

    //        // GET: TeacherModels/Delete/5
    //        public async Task<IActionResult> Delete(string id)
    //        {
    //            if (id == null)
    //            {
    //                return NotFound();
    //            }

    //            var teacherModel = await _context.TeacherModel
    //                .FirstOrDefaultAsync(m => m.ID == id);
    //            if (teacherModel == null)
    //            {
    //                return NotFound();
    //            }

    //            return View(teacherModel);
    //        }

    //        // POST: TeacherModels/Delete/5
    //        [HttpPost, ActionName("Delete")]
    //        [ValidateAntiForgeryToken]
    //        public async Task<IActionResult> DeleteConfirmed(string id)
    //        {
    //            var teacherModel = await _context.TeacherModel.FindAsync(id);
    //            _context.TeacherModel.Remove(teacherModel);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }

    //        private bool TeacherModelExists(string id)
    //        {
    //            return _context.TeacherModel.Any(e => e.ID == id);
    //        }
    //    }
}
