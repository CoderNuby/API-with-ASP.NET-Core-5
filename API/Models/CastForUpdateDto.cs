using System.ComponentModel.DataAnnotations;
using System;

namespace API.Models
{
    public class CastForUpdateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
