using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapp_travel_agency.Models
{
    public partial class Package
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Code { get; set; } = null!;
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Category { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [StringLength(50)]
        public string? Image { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Place { get; set; }
        public Customer  cliente{ get; set; }
    }
}
