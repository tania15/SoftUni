using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Theatre.DataProcessor.ExportDto
{
    [XmlType("Play")]
    public class ExportPlayDto
    {
        [XmlAttribute("FullName")]
        [Required]
        [MinLength(4)]
        [MaxLength(50)]
        public string FullName { get; set; }

        [XmlAttribute("Duration")]
        [RegularExpression(@"\d{2}:\d{2}:\d{2}")]
        public string Duration { get; set; }

        [XmlAttribute("Rating")]
        [Range(0, 10)]
        public float Rating { get; set; }

        [XmlAttribute("Genre")]
        public string Genre { get; set; }

        [XmlArray("Actors")]
        public ExportCastDto[] Actors { get; set; }
    }
}
