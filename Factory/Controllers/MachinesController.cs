using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
    public class MachinesController : Controller
    {
        private readonly FactoryContext _db;

        public MachinesController(FactoryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Machine> model = _db.Machines.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.EngineersId = new SelectList(_db.Engineers, "EngineersId", "EngineerName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Machine machine, int EngineerId)
        {
            _db.Machines.Add(machine);
            if (EngineerId != 0)
            {
                _db.MachineEngineers.Add(new MachineEngineer() { EngineerId = EngineerId, MachineId = machine.MachineId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id, string postAlert)
        {
            var thisMachine = _db.Machines
                .FirstOrDefault(machine => machine.MachineId == id);
            ViewBag.postAlert = postAlert;
            return View(thisMachine);
        }

        public ActionResult Edit(int id)
        {
            var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
            return View(thisMachine);
        }

        [HttpPost]
        public ActionResult Edit(Machine machine)
        {
            _db.Entry(machine).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = machine.MachineId });
        }

        public ActionResult Delete(int id)
        {
            var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
            return View(thisMachine);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
            _db.Machines.Remove(thisMachine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        // ENGINEERS
        public ActionResult AddEngineer(int id)
        {
            var thisMachine = _db.Machines.FirstOrDefault(machines => machines.MachineId == id);
            ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
            return View(thisMachine);
        }
        [HttpPost]
        public ActionResult AddEngineer(Machine machine, int EngineerId)
        {
            if (EngineerId != 0)
            {
                _db.MachineEngineers.Add(new MachineEngineer() { EngineerId = EngineerId, MachineId = machine.MachineId });
            }
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = machine.MachineId });
        }
        [HttpPost]
        public ActionResult DeleteEngineer(int machineId, int joinId)
        {
            var joinEntry = _db.MachineEngineers.FirstOrDefault(entry => entry.MachineEngineerId == joinId);
            _db.MachineEngineers.Remove(joinEntry);
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = machineId });
        }
    }
}