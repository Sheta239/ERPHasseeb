using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERPHasseb.DAL.Entities;
using ERPHasseb.DAL.Repository.Interface;

namespace ERPHasseeb.Web.Controllers
{
    public class AccountNaturesController : Controller
    {
        private readonly IAccountNature _accounNature;


        public AccountNaturesController(IAccountNature accounNature)
        {
            _accounNature = accounNature;
        }

        // GET: AccountNatures
        public IActionResult Index()
        {
            return View(_accounNature.GetAll());
        }

        //// GET: AccountNatures/Details/5
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountNature = _accounNature.GetByID(id);
            if (accountNature == null)
            {
                return NotFound();
}

            return View(accountNature);
        }

        //// GET: AccountNatures/Create
        public IActionResult Create()
        {
            return View();
        }

        //// POST: AccountNatures/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("AccountNatureID,AccountNatureName")] AccountNature accountNature)
        {
            if (ModelState.IsValid)
            {
                _accounNature.Insert(accountNature);
                return RedirectToAction(nameof(Index));
            }
            return View(accountNature);
        }

        //// GET: AccountNatures/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountNature = _accounNature.GetByID(id);
            if (accountNature == null)
            {
                return NotFound();
            }
            return View(accountNature);
        }

        //// POST: AccountNatures/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("AccountNatureID,AccountNatureName")] AccountNature accountNature)
        {
           
  
                
                    _accounNature.Update(accountNature);
                
                return RedirectToAction(nameof(Index));
            
        }

        //// GET: AccountNatures/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountNature = _accounNature.GetByID(id);
            if (accountNature == null)
            {
                return NotFound();
            }

            return View(accountNature);
        }

        //// POST: AccountNatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var accountNature = _accounNature.GetByID(id);
            _accounNature.Delete(accountNature);
            return RedirectToAction(nameof(Index));
        }

        //private bool AccountNatureExists(int id)
        //{
        //    return _context.AccountNatures.Any(e => e.AccountNatureID == id);
        //}
    }
}
