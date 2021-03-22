using SimpleApi.Models.Subjects;

namespace SimpleApi.Models.Grades
{
    public class GradeDTO
    {
        public SubjectDTO Subject { get; set; }
        public int Value { get; set; }
    }
}
