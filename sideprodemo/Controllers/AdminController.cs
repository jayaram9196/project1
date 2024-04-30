using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sideproDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using sideproDemo.Models;

namespace dotnetapp.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly TestDemoDBContext dc;
        public AdminController(TestDemoDBContext dc)
        {
            this.dc = dc;
            
        }

        //Get student details by id
        [HttpGet("ViewStudent")]
        public async Task<IActionResult> viewstudent(int StudentId)
        {

            var student = await dc.StudentModels.FindAsync(StudentId);
            if (student == null)
            {
                return BadRequest("No student found");
            }
            return Ok(student);


        }
        //get all student details
        [HttpGet("GetAllStudents")]
        public async Task<IActionResult> GetAllStuddents()
        {
            var students = await dc.StudentModels.ToListAsync();

            return Ok(students);
        }

        // post student details
        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent(StudentModel student)
        {
            await dc.StudentModels.AddAsync(student);
            await dc.SaveChangesAsync();
            return Ok(student);
        }

        //delete student 
        [HttpDelete("Deletestudent/{studentId}")]
        public async Task<IActionResult> DeleteStudent(int studentId)
        {
            var student = await dc.StudentModels.FindAsync(studentId);
            dc.StudentModels.Remove(student);
            await dc.SaveChangesAsync();
            return Ok(studentId);
        }

        //edit student details
        [HttpPut("EditStudent/{id}")]
        public async Task<IActionResult> EditStudent(int id, StudentModel student)
        {
            var std = await dc.StudentModels.FindAsync(id);
            if (std != null)
            {
                std.StudentName = student.StudentName;
                std.StudentDob = student.StudentDob;
                std.FatherName = student.FatherName;
                std.MotherName = student.MotherName;
                std.Gender = student.Gender;
                std.Age = student.Age;
                std.Mobile = student.Mobile;
                std.AlternateMobile = student.AlternateMobile;
                std.Email = student.Email;
                std.CourseId = student.CourseId;
                std.Address = student.Address;

            }
            dc.StudentModels.Update(std);
            await dc.SaveChangesAsync();
            return Ok(std);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //COURSE

        //Get course details by id
        [HttpGet("ViewCourse")]
        public async Task<IActionResult> viewCourse(int courseId)
        {

            var course = await dc.CourseModels.FindAsync(courseId);
            if (course == null)
            {
                return BadRequest("No student found");
            }
            return Ok(course);


        }
        //get all course details
        [HttpGet("GetAllCourses")]
        public async Task<IActionResult> GetAllCourses()
        {
            var courses = await dc.CourseModels.ToListAsync();

            return Ok(courses);
        }

        // post course details
        [HttpPost("AddCourse")]
        public async Task<IActionResult> AddCourse(CourseModel course)
        {
            await dc.CourseModels.AddAsync(course);
            await dc.SaveChangesAsync();
            return Ok(course);
        }

        //delete Course
        [HttpDelete("DeleteCourse/{courseId}")]
        public async Task<IActionResult> DeleteCourse(int courseId)
        {
            var course = await dc.CourseModels.FindAsync(courseId);
            dc.CourseModels.Remove(course);
            await dc.SaveChangesAsync();
            return Ok(courseId);
        }

        //edit Course details
        [HttpPut("EditCourse/{id}")]
        public async Task<IActionResult> EditCourse(int id, CourseModel course)
        {
            var std = await dc.CourseModels.FindAsync(id);
            if (std != null)
            {
                std.CourseName = course.CourseName;
                std.CourseDescription = course.CourseDescription;
                std.CourseDuration = course.CourseDuration;
                std.CourseTiming = course.CourseTiming;
                std.NumberofStudents = course.NumberofStudents;
                std.InstituteId = course.InstituteId;


            }
            dc.CourseModels.Update(std);
            await dc.SaveChangesAsync();
            return Ok(std);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //isntitute

        // Get institute details by id
        [HttpGet("ViewInstitute/{instituteId}")]
        public async Task<IActionResult> viewInstitute(int instituteId)
        {

            var institute = await dc.InstituteModels.FindAsync(instituteId);
            if (institute == null)
            {
                return BadRequest("No student found");
            }
            return Ok(institute);


        }
        //get all Institute details
        [HttpGet("GetAllInstitutes")]
        public async Task<IActionResult> GetAllInstitutes()
        {
            var institutes = await dc.InstituteModels.ToListAsync();

            return Ok(institutes);
        }

        // post Institute details
        [HttpPost("AddInstitute")]
        public async Task<IActionResult> AddInstitute(InstituteModel institute)
        {
            await dc.InstituteModels.AddAsync(institute);
            await dc.SaveChangesAsync();
            return Ok(institute);
        }

        //delete Institute
        [HttpDelete("DeleteInstitute/{instituteId}")]
        public async Task<IActionResult> DeleteInstitute(int instituteId)
        {
            var institute = await dc.InstituteModels.FindAsync(instituteId);
            dc.InstituteModels.Remove(institute);
            await dc.SaveChangesAsync();
            return Ok(instituteId);
        }

        //edit Institute details
        [HttpPut("EditInstitute/{id}")]
        public async Task<IActionResult> EditInstitute(int id, InstituteModel institute)
        {
            var std = await dc.InstituteModels.FindAsync(id);
            if (std != null)
            {

                std.InstituteName = institute.InstituteName;
                std.InstituteDescription = institute.InstituteDescription;
                std.InstituteAddress = institute.InstituteAddress;
                std.Email = institute.Email;
                std.Mobile = institute.Mobile;
                std.ImageUrl = institute.ImageUrl;


            }
            dc.InstituteModels.Update(std);
            await dc.SaveChangesAsync();
            return Ok(std);
        }

        //////////////////////////////////////////////////////////////////////////////
        //Get courses offered by institute

        [HttpGet("viewcoursebyId")]
        public IActionResult viewcoursebyId(int InstId)
        {
            // var instCourse= await dc.Course.FindAsync(InstituteId);

            // //var users = await dc.Student.ToListAsync();
            // if (institute == null)
            // {
            //     return NotFound();
            // }
            // return Ok(institute);

            var instCourse = (from Inst in dc.InstituteModels
                              from Cour in dc.CourseModels
                              where Inst.InstituteId == Cour.InstituteId && Cour.InstituteId == InstId
                              select new
                              {
                                  cn = Cour.CourseName,
                                  cd = Cour.CourseDescription,
                                  cdd = Cour.CourseDuration,
                                  ct = Cour.CourseTiming,
                                  ns = Cour.NumberofStudents,
                                  iid = Cour.InstituteId


                              }).ToList();

            return Ok(instCourse);
        }

        [HttpPost("AddStudentbycourse")]
        public async Task<IActionResult> AddStudentbycourse(StudentModel student, int courseId)
        {
            student.CourseId = courseId;
            await dc.StudentModels.AddAsync(student);
            await dc.SaveChangesAsync();
            return Ok(student);
        }

        [HttpPut("EditStudentbycourse/{id}/{courseId}")]
        public async Task<IActionResult> EditStudentbycourse(int id, StudentModel student, int courseId)
        {
            var std = await dc.StudentModels.FindAsync(id);
            if (std != null)
            {
                std.StudentName = student.StudentName;
                std.StudentDob = student.StudentDob;
                std.FatherName = student.FatherName;
                std.MotherName = student.MotherName;
                std.Gender = student.Gender;
                std.Age = student.Age;
                std.Mobile = student.Mobile;
                std.AlternateMobile = student.AlternateMobile;
                std.Email = student.Email;
                std.CourseId = courseId;
                std.Address = student.Address;

            }
            dc.StudentModels.Update(std);
            await dc.SaveChangesAsync();
            return Ok(std);
        }








    }
}