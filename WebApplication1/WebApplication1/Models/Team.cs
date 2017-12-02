using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        [Required, DisplayName("Team ID")]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] Use if you want to handle the primary key
        public int teamID { get; set; }

        [Required, DisplayName("Team Name")]
        [StringLength(50, ErrorMessage = "Team Name Cannot Exceed 50 Characters")]
        public String teamName { get; set; }

        [Required, DisplayName("Link to Team Logo")]
        [StringLength(50, ErrorMessage = "URL Cannot Exceed 50 Characters")]
        public String teamLogo { get; set; }


    }
}