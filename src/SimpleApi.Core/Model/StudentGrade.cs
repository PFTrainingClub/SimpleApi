﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SimpbeApi.Core.Model
{
    public class StudenGrade
    {
        public Student Student { get; set; }

        public Grade Grade { get; set; }

        public int Rank { get; set; }

    }
}