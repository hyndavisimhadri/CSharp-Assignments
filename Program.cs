using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IEnumerableExample
{
    class Player
    {
        public string Name { get; set; }
        public int Run { get; set; }
        public Player(string name, int run)
        {
            Name = name;
            Run = run;
        }
    }
    class Team : IEnumerable
    {
        private Player[] playerArray = new Player[4];
        public Team()
        {
            playerArray[0] = new Player("Kohli", 38);
            playerArray[1] = new Player("Sachin", 35);
            playerArray[2] = new Player("Rohit", 56);
            playerArray[3] = new Player("yuvraj", 32);
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Player player in playerArray)
            {
                Console.WriteLine("Name is {0} and Runs is {1}", player.Name, player.Run);
            }
            return playerArray.GetEnumerator();
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Team India = new Team();
            India.GetEnumerator();
            Console.ReadLine();
        }
    }
}


