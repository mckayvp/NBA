using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Position")]
    public class Position
    {
        [Key]
        [Required, DisplayName("Position Code")]
        [StringLength(2, ErrorMessage = "Position Code Cannot Exceed 2 Characters")]
        public String positionCode { get; set; }

        [Required, DisplayName("Position Description")]
        [StringLength(20, ErrorMessage = "Position Code Cannot Exceed 20 Characters")]
        public String positionDesc { get; set; }

    }
}