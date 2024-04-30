// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using lastdemo.Models;
// using Microsoft.AspNetCore.Mvc;

// namespace lastdemo.Controllers
// {
//     [ApiController]
//     [Route("api/")]
//     public class DemoController : ControllerBase
//     {
//         //private readonly BoxingContext _context;
//         private readonly TestDemoDbContext dc;

//         public DemoController(TestDemoDbContext dc)
//         {
//             this.dc = dc;
//         //     _context = context;
//         // }

//         [HttpGet("user/viewAdmission")]
//         public List<Admission> Get()
//         {
//             return _context.AdmissionDetails.ToList();
//         }

//         [HttpGet("user/viewAdmission/{admissionId}")]
//         public ActionResult<Admission> Get(int admissionId)
//         {
//             var admission = _context.AdmissionDetails.Find(admissionId);
//             if (admission == null)
//             {
//                 return NotFound();
//             }
//             return admission;
//         }

//         [HttpPost("user/addAdmission")]
//         public ActionResult<string> Post([FromBody] Student s, int courseId, int instituteId)
//         {
//             var admission = new Admission()
//             {
//                 StudentId = s.StudentId,
//                 CourseId = courseId,
//                 InstituteId = instituteId,
//                 DateOfJoining = s.DateOfJoining,
//                 EndDate = s.DateOfJoining.AddMonths(_context.CourseModels.Find(courseId).CourseDuration)
//             };

//             _context.AdmissionDetails.Add(admission);
//             _context.SaveChanges();

//             return "Course enrolled";
//         }

//         [HttpPut("user/editAdmission/{enrollId}")]
//         public ActionResult<string> Put(int enrollId, [FromBody] Admission ad)
//         {
//             var admission = _context.AdmissionDetails.Find(enrollId);
//             if (admission == null)
//             {
//                 return NotFound();
//             }

//             admission.StudentId = ad.StudentId;
//             admission.CourseId = ad.CourseId;
//             admission.InstituteId = ad.InstituteId;
//             admission.DateOfJoining = ad.DateOfJoining;
//             admission.EndDate = ad.EndDate;

//             _context.SaveChanges();

//             return "Admission details edited";
//         }

//         [HttpDelete("user/deleteAdmission/{enrollId}")]
//         public ActionResult<string> Delete(int enrollId)
//         {
//             var admission = _context.AdmissionDetails.Find(enrollId);
//             if (admission == null)
//             {
//                 return NotFound();
//             }

//             _context.AdmissionDetails.Remove(admission);
//             _context.SaveChanges();

//             return "Admission details deleted";
//         }
//     }
// }
