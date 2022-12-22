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
    public class BasicInfoesController : Controller
    {
        private readonly testContext _context;

        public BasicInfoesController(testContext context)
        {
            _context = context;
        }

        // GET: BasicInfoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.BasicInfos.ToListAsync());
        }

        // GET: BasicInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BasicInfos == null)
            {
                return NotFound();
            }

            var basicInfo = await _context.BasicInfos
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (basicInfo == null)
            {
                return NotFound();
            }

            return View(basicInfo);
        }

        // GET: BasicInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BasicInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,EmployeePrefix,EmployeeFirstName,EmployeeLastName,EmployeeDesignation,EmployeeDepartment,EmployeeDob,EmployeeAge,EmployeeReligion,EmployeeFatherHusband,EmployeeFatherName,EmployeeHusbandName,EmployeeMaritalStatus,EmployeePhoneNumber,EmployeeMobileNumber,EmployeeEmail,EmployeePermanentAddress,EmployeePermanentVillage,EmployeePermanentTaluka,EmployeePermanentCity,EmployeePermanentDistrict,EmployeePermanentState,EmployeePermanentCountry,EmployeePermanentPincode,EmployeePermanentPostoffice,EmployeePermanentPoliceStation,EmployeeResidentialAddress,EmployeeResidentialCity,EmployeeResidentialState,EmployeeResidentialCountry,EmployeeResidentialPincode,EmployeeBloodGroup,EmployeeTransportRequestStatus,EmployeeTransportPhoneNumber,EmployeeAadhar,EmployeeAadharLinkedPhone,EmployeePancard,CanditateDoj,EnteredBy,EnteredDate,UpdatedBy,UpdateDatetime,Isactive,DeleteFlag,Isaddresssame,Isphonesame,Isaddharnumbersame")] BasicInfo basicInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basicInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(basicInfo);
        }

        // GET: BasicInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BasicInfos == null)
            {
                return NotFound();
            }

            var basicInfo = await _context.BasicInfos.FindAsync(id);
            if (basicInfo == null)
            {
                return NotFound();
            }
            return View(basicInfo);
        }

        // POST: BasicInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,EmployeePrefix,EmployeeFirstName,EmployeeLastName,EmployeeDesignation,EmployeeDepartment,EmployeeDob,EmployeeAge,EmployeeReligion,EmployeeFatherHusband,EmployeeFatherName,EmployeeHusbandName,EmployeeMaritalStatus,EmployeePhoneNumber,EmployeeMobileNumber,EmployeeEmail,EmployeePermanentAddress,EmployeePermanentVillage,EmployeePermanentTaluka,EmployeePermanentCity,EmployeePermanentDistrict,EmployeePermanentState,EmployeePermanentCountry,EmployeePermanentPincode,EmployeePermanentPostoffice,EmployeePermanentPoliceStation,EmployeeResidentialAddress,EmployeeResidentialCity,EmployeeResidentialState,EmployeeResidentialCountry,EmployeeResidentialPincode,EmployeeBloodGroup,EmployeeTransportRequestStatus,EmployeeTransportPhoneNumber,EmployeeAadhar,EmployeeAadharLinkedPhone,EmployeePancard,CanditateDoj,EnteredBy,EnteredDate,UpdatedBy,UpdateDatetime,Isactive,DeleteFlag,Isaddresssame,Isphonesame,Isaddharnumbersame")] BasicInfo basicInfo)
        {
            if (id != basicInfo.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basicInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BasicInfoExists(basicInfo.EmployeeId))
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
            return View(basicInfo);
        }

        // GET: BasicInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BasicInfos == null)
            {
                return NotFound();
            }

            var basicInfo = await _context.BasicInfos
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (basicInfo == null)
            {
                return NotFound();
            }

            return View(basicInfo);
        }

        // POST: BasicInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BasicInfos == null)
            {
                return Problem("Entity set 'testContext.BasicInfos'  is null.");
            }
            var basicInfo = await _context.BasicInfos.FindAsync(id);
            if (basicInfo != null)
            {
                _context.BasicInfos.Remove(basicInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BasicInfoExists(int id)
        {
          return _context.BasicInfos.Any(e => e.EmployeeId == id);
        }
    }
}
