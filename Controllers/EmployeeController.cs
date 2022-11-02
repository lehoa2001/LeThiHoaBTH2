using LeThiHoaBTH2.Data;
using LeThiHoaBTH2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeThiHoa.Controllers
{
    
    public class EmployeeController : Controller
    {
        //khai bao Dbcontext de lam viec voi database
        private readonly ApplicationDbContext _context;
        public EmployeeController (ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: Employee
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee.ToListAsync());
        }
        private async bool EmployeeExists(String id)
        {
            return _context.Employee.Any(e => e.eEmpID == id);
        }
    }
}