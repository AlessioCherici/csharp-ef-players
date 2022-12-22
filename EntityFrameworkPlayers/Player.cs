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
    [Table("Player")]
    [Index(nameof(PlayerID), IsUnique = true)]
    public class Player
        {
        [Key]
        public int PlayerID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        public int Score { get; set; }
        public int PlayedGames { get; set; }
        public int WonGames { get; set; }
        }
    }
