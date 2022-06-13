﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
    }
}
