﻿using MusicHub.Common;
using MusicHub.Data.Models.Enums;
using System;
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicHub.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(ValidationConstants.SONG_NAME_MAX_LENGTH)]
        [Required]
        public string Name { get; set; }

        //[Required]
        public TimeSpan Duration { get; set; }

        //[Required] - required by default
        public DateTime CreatedOn { get; set; }

        public Genre Genre { get; set; }

        [ForeignKey(nameof(Album))]
        public int? AlbumId { get; set; }  // by default: nullable
        public virtual Album Album { get; set; }

        [ForeignKey(nameof(Writer))]
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
        public decimal Price { get; set; }

        // Many-to-Many
        public virtual ICollection<SongPerformer> SongPerformers { get; set; }

        public Song()
        {
            SongPerformers = new HashSet<SongPerformer>();
        }
    }
}
