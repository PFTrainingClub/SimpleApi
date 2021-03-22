using SimpbeApi.Core.DbContexts;
using SimpbeApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace SimpleApi.Core.Services
{
    public class StudentService : IStudentService
    {
        CoreDbContext Ctx { get; }

        public StudentService(CoreDbContext ctx)
        {
            Ctx = ctx;
        }

        public async ValueTask<(Student stu, double av)> GetGradeById(Guid id)
        {
            var entity = await Ctx.Students.Where(q => q.Id == id).FirstOrDefaultAsync();
            var grades = await Ctx.Grades.Where(q => q.StudentId == entity.Id).ToListAsync();
            double avg = 0;
            foreach (var grade in grades)
            {
                avg += (double)grade.Value;
            }
            avg = avg / grades.Count();
            return (entity, avg);
        }


    }
}
