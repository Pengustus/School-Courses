namespace MonsterExtermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> armor = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> attack = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            int kills = 0;
            List<int> remaining = new List<int>();

            while (armor.Any() && attack.Any())
            {
                int currentArmor = armor.First();
                int currentAttack = attack.Last();

                if (currentAttack >= currentArmor)
                {
                    kills++;

                    if (attack.Count > 1)
                    {
                        attack[attack.Count - 2] += currentAttack - currentArmor;
                    }
                }
                else
                {
                    armor[0] -= currentAttack;
                    remaining.Insert(0, attack.Last());
                }

                armor.RemoveAt(0);
                attack.RemoveAt(attack.Count - 1);
            }

            if (remaining.Count == 0)
            {
                Console.WriteLine("All monsters have been killed!");
            }
            else
            {
                Console.WriteLine("The soldier has been defeated.");
            }

            Console.WriteLine($"Total monsters killed: {kills}");
        }
    }
}