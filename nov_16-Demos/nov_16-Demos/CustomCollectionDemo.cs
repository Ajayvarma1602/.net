using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_16_Demos
{
    class Player
    {
        int pId; static int count;
        public Player()
        { count++; pId = count; }
        public int PlayerId { get { return pId; } }
        public string PlayerName { get; set; }
        public int RunsScored { get; set; }
    }
    class Team : IEnumerable
    {
        List<Player> players = new List<Player>();
        public void AddPlayer(Player p)
        { players.Add(p); }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
        public IEnumerator GetPlayerNames()
        {
            foreach (Player p in players)
            {
                string[] name = p.PlayerName.Split(' ');
                yield return "FirstName : "+name[0];
                yield return "lastname : " + name[1];
            }
        }
    }
        class CustomCollectionDemo
        {
            static void Main()
            {

                Team india = new Team();
                char answer;
                do
                {
                    Console.WriteLine("Add new Player");
                    Player p = new Player();
                    Console.Write("Enter Player Name = ");
                    p.PlayerName = Console.ReadLine();
                    Console.Write("Enter Runs scored = ");
                    p.RunsScored = Convert.ToInt32(Console.ReadLine());
                    india.AddPlayer(p);
                    Console.WriteLine("Player added with Id : " + p.PlayerId);
                    Console.Write("Do you wish to add another player (y or n): ");
                    answer = Convert.ToChar(Console.ReadLine());
                } while (answer == 'y' || answer == 'Y');
                Console.WriteLine("Players in the team :");
                Console.WriteLine("***********");
                foreach (Player player in india)
                {
                    Console.WriteLine("Id : " + player.PlayerId);
                    Console.WriteLine("Name : " + player.PlayerName);
                    Console.WriteLine("Runs scored : " + player.RunsScored);
                    Console.WriteLine("------------------------------------");
                }
                IEnumerator namesEnumerator = india.GetPlayerNames();
                while (namesEnumerator.MoveNext())
                {
                    Console.WriteLine(namesEnumerator.Current);
                }
                Console.ReadLine();
            }
        }

    }

