using System;
using System.ComponentModel.DataAnnotations;

namespace SimpbeApi.Core.Model
{
    public class Subject
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
    }
}
