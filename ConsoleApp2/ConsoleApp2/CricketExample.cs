using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    public class Player
    {
        public int PlayerNo { get; set; }
        public string Name { get; set; }
        public int Average { get; set; }
        public int NoOfMatches { get; set; }
        public int RunRate { get; set; }
    }
    class CricketExample
    {
        static List<Player> players = new List<Player>();
        static void Main(string[] args)
        {
            players.Add(
      new Player { PlayerNo = 18, Name = "kohli", NoOfMatches = 15, RunRate = 90 }
      );
            players.Add(
              new Player { PlayerNo = 7, Name = "Dhoni", NoOfMatches = 20, RunRate = 80 }
              );
            var calPlys = from p in players
                          select new Player
                          {
                              PlayerNo = p.PlayerNo,
                              Name = p.Name,
                              Average = p.NoOfMatches / p.RunRate
                          }; foreach (var item in calPlys)
            {
                Console.WriteLine(item.Average);
            }
            Console.ReadLine();
        }
    }
}
