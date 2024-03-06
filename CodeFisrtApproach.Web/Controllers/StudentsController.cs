using CodeFirstApproach.Web.Data;
using CodeFirstApproach.Web.Models;
using CodeFirstApproach.Web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CodeFirstApproach.Web.Controllers
{
    public class StudentsController : Controller
    {
        public readonly ApplicationDbContext DbContext;
        public StudentsController(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
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
                Subscribed = viewModel.Subscribed
            };
            await DbContext.Students.AddAsync(student);
            await DbContext.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            using (var context = new DbContext())
            {
                var students = context.Students();
                // Process the retrieved Students
            }
            var students = await List<Student>DbContext.GetStudents();
            return View(students);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await DbContext.Students.FindAsync(id);
            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await DbContext.Students.FindAsync(viewModel.Id);
            if (student is not null)
            {
                student.Name = viewModel.Name;
                student.Email = viewModel.Email;
                student.Phone = viewModel.Phone;
                student.Subscribed = viewModel.Subscribed;

                await DbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Students");
        }
        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student = await DbContext.Students.FindAsync(viewModel.Id);
            if (student is not null)
            {
                DbContext.Students.Remove(student);
                await DbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Students");

        }
    }
}