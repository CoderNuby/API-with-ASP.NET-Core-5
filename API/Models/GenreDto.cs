using API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace API.Models
{
    public class GenreDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
