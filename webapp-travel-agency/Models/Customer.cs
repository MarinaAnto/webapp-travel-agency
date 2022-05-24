using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapp_travel_agency.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; } = null!;
        [Column("nome")]
        [StringLength(50)]
        [Required]
        public string NumCarta { get; set; } 
        [Column("numerocarta")]
        [StringLength(50)]
        [Required]
        public string Quantita { get; set; } 
        [Column("quantita")]
        [StringLength(50)]
        public string? Nome { get; set; }
        [Column("cognome")]
        [StringLength(50)]
        public string? Cognome { get; set; }
        [Column("cellulare")]
        [StringLength(50)]
        public string? Cellulare { get; set; }
        public List<Package> onecustomerPackages { get; set; }= new List<Package>();

    }
}
