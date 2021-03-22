using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpbeApi.Core.DbContexts;
using SimpbeApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleApi.Core.Startups
{
    internal static class CoreDbStartup
    {
        private static class InitData
        {
            public static List<Subject> Subjects = new List<Subject>
            {
                new Subject { Id = new Guid("e1857653-45da-4053-ab74-26932cddbc8d"), Title = "Maths" },
                new Subject { Id = new Guid("d6951524-3ce4-43c1-82ec-9ab7c3867c96"), Title = "Art" },
                new Subject { Id = new Guid("f2f29cd5-411e-4668-a4bf-6c655b4aa469"), Title = "History" },
                new Subject { Id = new Guid("4d4057f8-42ba-4ba1-a4de-50c02379a249"), Title = "Science" }
            };
            public static List<Student> Students = new List<Student>
            {
                new Student { Id = new Guid("2ae42565-0b0d-4b04-8bad-db14fede0b65"), Name = "Peter" },
                new Student { Id = new Guid("521d9d76-9cda-4534-b61e-329fdddb64b0"), Name = "Mary" }
            };
        }

        public static async Task MigrateDbAsync(IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<CoreDbContext>();
            await dbContext.Database.MigrateAsync();

            await SetupInitDataAsync(dbContext);
        }

        private static async Task SetupInitDataAsync(CoreDbContext dbContext)
        {
            await InitStudentDataAsync(dbContext);
            await InitSubjectDataAsync(dbContext);
            await InitGradeDataAsync(dbContext);
        }

        private static async Task InitStudentDataAsync(CoreDbContext dbContext)
        {
            var studentsCount = await dbContext.Students.CountAsync();
            if (studentsCount == 0)
            {
                await dbContext.Students.AddRangeAsync(InitData.Students);
                await dbContext.SaveChangesAsync();
            }
        }

        private static async Task InitSubjectDataAsync(CoreDbContext dbContext)
        {
            var subjectsCount = await dbContext.Subjects.CountAsync();
            if (subjectsCount == 0)
            {
                await dbContext.Subjects.AddRangeAsync(InitData.Subjects);
                await dbContext.SaveChangesAsync();
            }
        }

        private static async Task InitGradeDataAsync(CoreDbContext dbContext)
        {
            var gradesCount = await dbContext.Grades.CountAsync();
            if (gradesCount == 0)
            {
                var grades = new List<Grade>();
                var random = new Random();
                foreach (var student in InitData.Students)
                {
                    foreach (var subject in InitData.Subjects)
                    {
                        grades.Add(new Grade
                        {
                            StudentId = student.Id,
                            SubjectId = subject.Id,
                            Value = random.Next(1, 10)
                        });
                    }
                }
                await dbContext.Grades.AddRangeAsync(grades);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
