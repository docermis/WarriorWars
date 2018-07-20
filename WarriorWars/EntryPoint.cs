using System;
using System.Threading;
using WarriorWars.Enum;

namespace WarriorWars
{
	class EntryPoint
	{
		static Random random = new Random();
		static void Main(string[] args)
		{
			Warrior goodGuy = new Warrior("Kirito", Faction.GoodGuy);
			Warrior badGuy = new Warrior("Heithcliff", Faction.BadGuy);

			while (goodGuy.IsAlive && badGuy.IsAlive)
			{
				if (random.Next(0, 100) < 50)
				{
					goodGuy.Attack(badGuy);
				}
				else
				{
					badGuy.Attack(goodGuy);
				}

				Thread.Sleep(200);
			}
		}
	}
}
