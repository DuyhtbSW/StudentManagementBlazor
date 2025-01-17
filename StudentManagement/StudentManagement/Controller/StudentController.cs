﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Client.Repository;
using StudentManagement.Data;
using StudentManagement.Shared.Models;

namespace StudentManagement.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ApplicationDbContext _context;
        public StudentController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }


        [HttpGet("All-Students")]
        public async Task<ActionResult<List<Student>>> GetAllStudentsAsync()
        {
            var students = await _studentRepository.GetAllStudentsAsync();
            return Ok(students);
        }


        [HttpGet("Single-Student/{id}")]
        public async Task<ActionResult<Student>> GetSingleStudentAsync(int id)
        {
            var student = await _studentRepository.GetStudentByIdAsync(id);

            return Ok(student);
        }

        [HttpPost("Add-Student")]
        public async Task<ActionResult<Student>> AddNewStudentAsync(Student student)
        {
            var newstudent = await _studentRepository.AddStudentAsync(student);

            return Ok(newstudent);
        }


        [HttpDelete("Delete-Student/{id}")]
        public async Task<ActionResult<Student>> DeleteStudentAsync(int id)
        {
            

         
            var deletestudent = await _studentRepository.DeleteStudentAsync(id);
            if (deletestudent== null)
            {
                return NotFound();
            }

           _context.Students.Remove(deletestudent);
            await _context.SaveChangesAsync();

          
            return Ok(deletestudent);
        }


        [HttpPost("Update-Student")]
        public async Task<ActionResult<Student>> UpdateStudentAsync(Student student)
        {
            var updatestudent = await _studentRepository.UpdateStudentAsync(student);

            return Ok(updatestudent);
        }
      

    }
}
