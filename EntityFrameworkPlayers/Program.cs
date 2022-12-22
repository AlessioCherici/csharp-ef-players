using EntityFrameworkPlayers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

using (TeamContext db = new TeamContext()) 
     { 
    Random RandomNum = new Random();
int punteggio = RandomNum.Next(1,10 +1);
int NumeroRandomGiocate = RandomNum.Next(1, 100 +1);
int NumeroRandomVinte = RandomNum.Next(1, NumeroRandomGiocate + 1);
   
    // Milestone 0 
Player Giocatore1 = new Player
    {
    Nome = "Gianni",
    Cognome = "Morandi",
    Score = punteggio,
    PlayedGames = NumeroRandomGiocate,
    WonGames = NumeroRandomVinte
    };

    //Milestone 1
    Console.WriteLine("Inserimento nuovo giocatore");
    db.Add(Giocatore1);
    db.SaveChanges();

    Console.WriteLine("Modifico nome e congome del giocatore1");
    Giocatore1.Nome = "Francesco";
    Giocatore1.Cognome = "Micheli";
    db.SaveChanges();




    }




