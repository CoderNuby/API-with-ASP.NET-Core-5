using System.ComponentModel.DataAnnotations;
using System;

namespace API.Models
{
    public class CastForCreationDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
