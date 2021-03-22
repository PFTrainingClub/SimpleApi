using System;
using System.ComponentModel.DataAnnotations;

namespace SimpbeApi.Core.Model
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
