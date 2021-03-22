using System;
using System.ComponentModel.DataAnnotations;

namespace SimpbeApi.Core.Entities
{
    public class Grade
    {
        [Key]
        public Guid StudentId { get; set; }

        [Key]
        public Guid SubjectId { get; set; }

        public int Value { get; set; }

        public Student Student { get; set; }

        public Subject Subject { get; set; }
    }
}
