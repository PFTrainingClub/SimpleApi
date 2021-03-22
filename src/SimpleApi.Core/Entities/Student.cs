using System;
using System.ComponentModel.DataAnnotations;

namespace SimpbeApi.Core.Entities
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required, MaxLength(125)]
        public string Name { get; set; }
    }
}
