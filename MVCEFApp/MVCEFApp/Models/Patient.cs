﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEFApp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]       
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 characters")]
        public string Name { get; set; }=string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName ="numeric(18,0)")]
        public long PhoneNumber { get; set; }

    }
}
