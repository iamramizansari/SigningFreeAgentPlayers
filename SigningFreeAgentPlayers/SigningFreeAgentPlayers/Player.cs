using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigningFreeAgentPlayers
{
    class Player
    {
        public string name { get; set; }
        public int vorp { get; set; }
        public int cost { get; set; }
        public int position { get; set; }
        public Player()
        {
        }
        public Player(String name,int vorp,int cost) {
            this.name = name;
            this.vorp = vorp;
            this.cost = cost;
        }
        override public String ToString() {
            return "Player Name: " + name + " VORP:" + Convert.ToString(vorp) + " Cost:" + Convert.ToString(cost);
        }
        public void print() {
            Console.WriteLine("Player Name: " + name + " VORP:" + Convert.ToString(vorp) + " Cost:" + Convert.ToString(cost));
        }
    }
}
