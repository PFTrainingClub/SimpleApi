using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpbeApi.Core.DbContexts;
using SimpbeApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpbeApi.Web.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : Controller
    {
        private CoreDbContext DbContext { get; }

        public StudentController(CoreDbContext dbContext)
        {
            DbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentsAsync()
        {
            return await DbContext.Students.ToListAsync();
        }
        [HttpGet, Route("{studentId}/grade")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentByIdAsync(Guid studentId)
        {
            return await DbContext.Students.ToListAsync();
        }
    }
}
