﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Theatre.DataProcessor.ImportDto
{
    public class ImportTheatreDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [Range(1, 10)]
        public sbyte NumberOfHalls { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string Director { get; set; }

        public ImportTicketDto[] Tickets { get; set; }
    }
}
