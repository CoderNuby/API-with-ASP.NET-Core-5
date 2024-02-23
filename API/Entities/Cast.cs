using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Cast
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey(nameof(MovieId))]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
