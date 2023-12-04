using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using System.Linq;

namespace FinalProject.Controllers;

public class EquipmentController : Controller
{
    private readonly EquipmentContext _context;

    public EquipmentController(EquipmentContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var equipment = _context.MyEquipment.ToList();
        return View(equipment);
    }

    // GET: Equipment/Create
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Equipment equipment)
    {
        if (ModelState.IsValid)
        {
            _context.MyEquipment.Add(equipment);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(equipment);
    }
    // GET: Equipment/Edit/5
    public IActionResult Edit(int id)
    {
        var equipment = _context.MyEquipment.FirstOrDefault(e => e.EquipmentId == id);
        if (equipment == null)
        {
            return NotFound();
        }
        return View(equipment);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Equipment equipment)
    {
        if (id != equipment.EquipmentId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _context.Update(equipment);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(equipment);
    }

    public IActionResult Delete(int id)
    {
        var equipment = _context.MyEquipment.FirstOrDefault(e => e.EquipmentId == id);
        if (equipment == null)
        {
            return NotFound();
        }
        return View(equipment);
    }

    // POST: Equipment/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(Equipment equipment)
    {
        _context.MyEquipment.Remove(equipment);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }



    public IActionResult Description()
    {
        return View();
    }
}
