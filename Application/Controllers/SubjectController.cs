﻿using System;
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

    public class SubjectController : BaseController<SubjectController, SubjectModel>
    {
        //private readonly IBaseRepository<EmployeeModel> _repo;

        public SubjectController(IBaseRepository<SubjectModel> repo) : base(repo)
        {

        }

        // GET: Employee

    }


    //public class SubjectController : Controller
    //{
    //    private readonly IBaseRepository<SubjectModel> _repo;

    //    public SubjectController(IBaseRepository<SubjectModel> repo)
    //    {
    //        _repo = repo;
    //    }

    //    // GET: Student
    //    public async Task<IActionResult> Index()
    //    {
    //        return View(await _repo.GetAll());
    //    }

    //    // GET: Student/Details/5
    //    public async Task<IActionResult> Details(string id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var studentModel = await _repo.Get(id);
    //        if (studentModel == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(studentModel);
    //    }

    //    // GET: Student/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Student/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("ID,SubjectName")] SubjectModel studentModel)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            await _repo.Insert(studentModel);
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(studentModel);
    //    }

    //    // GET: Student/Edit/5
    //    public async Task<IActionResult> Edit(string id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var studentModel = await _repo.Get(id);
    //        if (studentModel == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(studentModel);
    //    }

    //    // POST: Student/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(string id, [Bind("ID,SubjectName")] SubjectModel studentModel)
    //    {
    //        if (id != studentModel.ID)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            await _repo.Update(studentModel);

    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(studentModel);
    //    }

    //    // GET: Student/Delete/5
    //    public async Task<IActionResult> Delete(string id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var studentModel = await _repo.Get(id);
    //        if (studentModel == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(studentModel);
    //    }

    //    // POST: Student/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(string id)
    //    {
    //        await _repo.Delete(id);
    //        return RedirectToAction(nameof(Index));
    //    }


    //}
}
