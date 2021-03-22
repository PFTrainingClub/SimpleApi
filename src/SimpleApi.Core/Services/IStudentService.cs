using SimpbeApi.Core.Entities;
using System;
using System.Threading.Tasks;

namespace SimpleApi.Core.Services
{
    public interface IStudentService
    {
        ValueTask<(Student stu, double av)> GetGradeById(Guid id);
    }
}