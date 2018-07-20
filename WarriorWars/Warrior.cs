using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
	class Warrior
	{
		private int goodGuyStartingHealth;
		private int badGuyStartingHealth;

		private Faction faction;

		private int health;
		private string name;
		private bool isAlive;

		public bool IsAlive
		{
			get
			{
				return isAlive;
			}
		}

		private Weapon weapon;
		private Armor armor;
	}
}
