using System;
using System.ComponentModel.DataAnnotations;

namespace SimpbeApi.Core.Entities
{
    public class Subject
    {
        [Key]
        public Guid Id { get; set; }

        public string Title { get; set; }
    }
}
