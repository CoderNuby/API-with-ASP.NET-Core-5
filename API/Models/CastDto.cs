using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class CastDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
