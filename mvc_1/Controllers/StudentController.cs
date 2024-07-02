using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_1.Data;
using mvc_1.Models;
using mvc_1.Models.Entities;

namespace mvc_1.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
       
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {

            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed,
            };
            await dbContext.Students.AddAsync(student);

            await dbContext.SaveChangesAsync();
            return RedirectToAction("List", "Student");
        }

        [HttpGet]
        
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);
            return View(student);
        }



        [HttpPost]
        
        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await dbContext.Students.FindAsync(viewModel.ID);
            if (student is not null) 
                {
                    student.Name = viewModel.Name;
                    student.Email = viewModel.Email;
                    student.Phone = viewModel.Phone;
                    student.Subscribed = viewModel.Subscribed;

                    await dbContext.SaveChangesAsync();

                }

                return RedirectToAction("List", "Student");
            
        }
        [HttpPost]
        
        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student = await dbContext.Students.AsNoTracking().FirstOrDefaultAsync(x => x.ID == viewModel.ID);
            if (student is not null)
            {
                dbContext.Students.Remove(student);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Student");
        }


    }
}
