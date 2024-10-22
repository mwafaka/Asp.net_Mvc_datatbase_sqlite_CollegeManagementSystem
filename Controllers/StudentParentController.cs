using Microsoft.AspNetCore.Mvc;
using CollegeManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using CollegeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CollegeManagementSystem.Controllers
{
    public class StudentParentController(CollegeContext context) : Controller
    {
        private readonly CollegeContext _context = context;
       

        // GET: StudentParentController
        public async Task<IActionResult> Index()
        {
            var parent = _context.StudentParents.Include(e => e.Student).Include(e => e.Course);
            return View(await parent.ToListAsync());
        }

        // GET: Enrollments/Create
        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FirstName");
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Title");
           /*  ViewData["EnrollementId"] = new SelectList(_context.Enrollments, "EnrollmentId", "Grade"); */
            return View();
        }
        // POST: Enrollments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentParentId,StudentId,FirstName,LastName,CourseId")] StudentParent studentParent)
        {
        if (ModelState.IsValid)
            {
                _context.Add(studentParent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "FirstName", studentParent.StudentId);
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Title", studentParent.CourseId);
            /* ViewData["EnrollmentId"] = new SelectList(_context.StudentParents, "EnrollementId", "Grade", studentParent.EnrollementId); */
            return View(studentParent);
        }
    }
}
