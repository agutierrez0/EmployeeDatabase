using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testProject4.Models;

namespace testProject4.Controllers
{
    [Route("api/Employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly TemplumContext _context;

        public EmployeesController(TemplumContext context)
        {
            _context = context;
            if (_context.TemplumItems.Count() == 0)
            {
                // Create a new TemplumItems if collection is empy,
                // means you can't delete all TemplumItems.
                _context.TemplumItems.Add(new Employees { FirstName = "Item1" });
                _context.SaveChanges();

            }
        }

        // GET api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employees>>> GetEmployees()

        {
            return await _context.TemplumItems.ToListAsync();
        }

        // GET: api/Employee
        [HttpGet("{id}")]
        public async Task<ActionResult<TemplumContext>> GetEmployee(int id)
        {
            var employee = await _context.TemplumItems.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }


        // POST: api/Employees
        [HttpPost]
        public async Task<ActionResult<Employees>> PostEmployee(Employees item)
        {
            _context.TemplumItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployee), new { id = item.Id }, item);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(long id, Employees item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();

        }
/*
        [HttpPost]
        public async Task<ActionResult<Employees>> EditEmployees(Employees item)
        {
            if (ModelState.IsValid)
            {
                Employees employees = new Employees();
                Employees.
            }
            _context.TemplumItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployee), new { id = item.Id }, item);

        }


        // PATCH: /api/Employee
        [HttpPut("{id}")]
        public async Task<ActionResult<Employees>> PutEmployee(Employees item)
        {
            _context.TemplumItems.Remove(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PutEmployee), new { id = item.Id }, item);
        }
        */
    } 
}