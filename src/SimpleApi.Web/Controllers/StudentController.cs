using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpbeApi.Core.DbContexts;
using SimpbeApi.Core.Entities;
using SimpbeApi.Core.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpbeApi.Web.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : Controller
    {
        //test
        private CoreDbContext DbContext { get; }

        public StudentController(CoreDbContext dbContext)
        {
            DbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Core.Entities.Student>>> GetStudentsAsync()
        {
            return await DbContext.Students.ToListAsync();
        }

    }

    interface IRepositoryBase<T>
    {
        public ValueTask<T> GetById(int id);
    }

    class RepositoryBase<T> : IRepositoryBase<T>
    {
        private CoreDbContext DbContext { get; }

        public RepositoryBase(CoreDbContext dbContext)
        {
            DbContext = dbContext;
        }

        //public async ValueTask<T> GetById(Guid id)
        //{
        //    var entity = await DbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
        //    //var model = Mapper
        //    //return;
        //}

        public ValueTask<T> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }

    class GradeRepository<Grade> : RepositoryBase<Grade>
    {
        public GradeRepository(CoreDbContext dbContext) : base(dbContext)
        {
        }
    }

    class StudentRepository<Student> : RepositoryBase<Student>
    {
        public StudentRepository(CoreDbContext dbContext) : base(dbContext)
        {
        }
    }

    class SubjectRepository<Grade> : RepositoryBase<Subject>
    {
        public SubjectRepository(CoreDbContext dbContext) : base(dbContext)
        {
        }


        //[HttpGet, Route("{studentId}/grade")]
        //public async Task<ActionResult<IEnumerable<Core.Model.Student>>> GetStudentByIdAsync(Guid studentId)
        //{
        //    return await DbContext.Students.ToListAsync();
        //}

        //private StudentGrade GetGradeByStudentId(Guid studentId)
        //{
        //    StudentGrade student = GetStudentById(studentId);
            


        //}
    }
}
