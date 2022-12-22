using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test.Data;

namespace test.Controllers
{
    public class StudentinfoesController : Controller
    {
        private readonly testContext _context;

        public StudentinfoesController(testContext context)
        {
            _context = context;
        }

        // GET: Studentinfoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Studentinfos.ToListAsync());
        }

        // GET: Studentinfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Studentinfos == null)
            {
                return NotFound();
            }

            var studentinfo = await _context.Studentinfos
                .FirstOrDefaultAsync(m => m.CanditateId == id);
            if (studentinfo == null)
            {
                return NotFound();
            }

            return View(studentinfo);
        }

        // GET: Studentinfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studentinfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CanditateId,CanditateFirstName,CanditateLastName,CanditateAadhar,CanditatePancard,CanditateEmail,CanditateGender,CanditateLocation,CanditateMaritialStatus,CanditateDoj,CanditateDepartment,CanditateAddress1,CanditateAltNumber,EnteredBy,EnteredDate,UpdatedBy,UpdatedDate,IsActive,DeleteFlag,CanditateIdNumber,CanditateBaseLocation,CanditateMobile,CanditatePrefix,CanditateAddress2,CanditateAddress3")] Studentinfo studentinfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentinfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentinfo);
        }

        // GET: Studentinfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Studentinfos == null)
            {
                return NotFound();
            }

            var studentinfo = await _context.Studentinfos.FindAsync(id);
            if (studentinfo == null)
            {
                return NotFound();
            }
            return View(studentinfo);
        }

        // POST: Studentinfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CanditateId,CanditateFirstName,CanditateLastName,CanditateAadhar,CanditatePancard,CanditateEmail,CanditateGender,CanditateLocation,CanditateMaritialStatus,CanditateDoj,CanditateDepartment,CanditateAddress1,CanditateAltNumber,EnteredBy,EnteredDate,UpdatedBy,UpdatedDate,IsActive,DeleteFlag,CanditateIdNumber,CanditateBaseLocation,CanditateMobile,CanditatePrefix,CanditateAddress2,CanditateAddress3")] Studentinfo studentinfo)
        {
            if (id != studentinfo.CanditateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentinfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentinfoExists(studentinfo.CanditateId))
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
            return View(studentinfo);
        }

        // GET: Studentinfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Studentinfos == null)
            {
                return NotFound();
            }

            var studentinfo = await _context.Studentinfos
                .FirstOrDefaultAsync(m => m.CanditateId == id);
            if (studentinfo == null)
            {
                return NotFound();
            }

            return View(studentinfo);
        }

        // POST: Studentinfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Studentinfos == null)
            {
                return Problem("Entity set 'testContext.Studentinfos'  is null.");
            }
            var studentinfo = await _context.Studentinfos.FindAsync(id);
            if (studentinfo != null)
            {
                _context.Studentinfos.Remove(studentinfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentinfoExists(int id)
        {
          return _context.Studentinfos.Any(e => e.CanditateId == id);
        }
    }
}
