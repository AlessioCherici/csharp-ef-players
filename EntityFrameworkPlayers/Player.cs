using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPlayers
    {
    [Table("player")]
    [Index(nameof(PlayerID), IsUnique = true)]
    public class Player
        {
        [Key]
        public int PlayerID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        public string Score { get; set; }
        public string PartiteGiocate { get; set; }
        public string PartiteVinte { get; set; }
        }
    }
