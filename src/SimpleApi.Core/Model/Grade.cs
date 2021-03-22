using System;
using System.ComponentModel.DataAnnotations;

namespace SimpbeApi.Core.Model
{
    public class Grade
    {
        public Guid StudentId { get; set; }

        public Guid SubjectId { get; set; }

        public int Value { get; set; }

        public Student Student { get; set; }

        public Subject Subject { get; set; }
    }
}
