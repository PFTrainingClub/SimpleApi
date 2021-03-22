using System;
using System.ComponentModel.DataAnnotations;

namespace SimpbeApi.Core.Model
{
    public class StudentGrade
    {
        public Student Student { get; set; }

        public Grade Grade { get; set; }

        public RankLevels Rank { get; set; }

    }

    public enum RankLevels
    {
        Excellent = 1,
        Good = 2,
        Fair = 3,
        Weak = 4
    }
}
