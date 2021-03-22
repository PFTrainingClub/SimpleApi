using SimpleApi.Models.Grades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApi.Core.Mappers
{
    public static class GradeMapper
    {
        public static GradeDTO ToDTO(SimpbeApi.Core.Entities.Grade grade)
        {
            return new GradeDTO();
        }
    }
}
