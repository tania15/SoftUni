using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Theatre.Data.Models.Enums;

namespace Theatre.Data.Models
{
    public class Play
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title  { get; set; }

        [Required]
        public TimeSpan Duration  { get; set; }
        
        [Range(0, 10)]
        public float Rating  { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [MaxLength(700)]
        public string Description  { get; set; }

        [Required]
        [MaxLength(30)]
        public string Screenwriter  { get; set; }

        public virtual ICollection<Cast> Casts  { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        public Play()
        {
            Casts = new HashSet<Cast>();
            Tickets = new HashSet<Ticket>();
        }
    }
}
