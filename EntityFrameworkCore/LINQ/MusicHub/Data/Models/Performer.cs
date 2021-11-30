using MusicHub.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicHub.Data.Models
{
    public class Performer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.FIRST_NAME_PERFORMER_MAX_LENGTH)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.LAST_NAME_PERFORMER_MAX_LENGTH)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public decimal NetWorth { get; set; }

        public virtual ICollection<SongPerformer> PerformerSongs { get; set; }

        public Performer()
        {
            PerformerSongs = new HashSet<SongPerformer>();
        }

    }
}
