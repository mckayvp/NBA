using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        [Required, DisplayName("Player ID")]
        public int playerID { get; set; }

        [Required, DisplayName("First Name")]
        [StringLength(50, ErrorMessage = "First Name Cannot Exceed 50 Characters")]
        public String firstName { get; set; }

        [Required, DisplayName("Last Name")]
        [StringLength(50, ErrorMessage = "Last Name Cannot Exceed 50 Characters")]
        public String lastName { get; set; }

        [ForeignKey("Team")]
        [DisplayName("Team ID")]
        public int teamID { get; set; }

        [ForeignKey("Position")]
        [DisplayName("Position Code")]
        [StringLength(2, ErrorMessage = "Position Code Cannot Exceed 2 Characters")]
        public String positionCode { get; set; }

    }
}