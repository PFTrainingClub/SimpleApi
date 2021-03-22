using SimpleApi.Models.Enums;
using SimpleApi.Models.Grades;
using SimpleApi.Models.Students;
using SimpleApi.Models.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApi.Models.StudentDetails
{
    public class StudenDetailDTO
    {
        public StudentDTO Student { get; set; }
        public GradeDTO Grade { get; set; }
        public RankLevels RankLevels { get; set; }
    }
}
