using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HeroesofCodeandLogicVII
{
    class Program
    
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> HitPointsHero = new Dictionary<string, int>();
            Dictionary<string, int> ManaPointsHero = new Dictionary<string, int>();

            //Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string Command1 = Console.ReadLine();
                string[] ArrCmd = Command1.Split(" ").ToArray();
                string heroName = ArrCmd[0];
                int HP = int.Parse(ArrCmd[1]);
                int MP = int.Parse(ArrCmd[2]);

                HitPointsHero.Add(heroName, HP);
                ManaPointsHero.Add(heroName, MP);

            }

            string Command2 = String.Empty;
            
            while ((Command2 = Console.ReadLine()) != "End")
            {
                
                //  string[] CmdArr = Command2.Split(new char[] {'-',' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] CmdArr = Command2.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string CurrentCmd = CmdArr[0];
                string HeroName1 = CmdArr[1];

                if (CurrentCmd == "CastSpell")
                {
                    int MPNeeded = int.Parse(CmdArr[2]);
                    string SpellName = CmdArr[3];

                    if (ManaPointsHero[HeroName1] >= MPNeeded)
                    {
                        ManaPointsHero[HeroName1] -= MPNeeded;
                        int CurrentManaPoints = ManaPointsHero[HeroName1];
                        Console.WriteLine($"{HeroName1} has successfully cast {SpellName} and now has {CurrentManaPoints} MP!");

                    }
                    else

                        Console.WriteLine($"{HeroName1} does not have enough MP to cast {SpellName}!");
                }

            
                else if (CurrentCmd == "TakeDamage")
            {
                int Damage = int.Parse(CmdArr[2]);
                string attacker = CmdArr[3];

                    HitPointsHero[HeroName1] -= Damage;
                    int CurrentHP = HitPointsHero[HeroName1];
                    if (CurrentHP >0)
                    {
                        Console.WriteLine($"{HeroName1} was hit for {Damage} HP by {attacker} and now has {CurrentHP} HP left!");
                    }
                    else
                    {
                        HitPointsHero.Remove(HeroName1);
                        ManaPointsHero.Remove(HeroName1);
                        Console.WriteLine($"{HeroName1} has been killed by {attacker}!");

                    }

            }
            else if (CurrentCmd == "Recharge")
            {
                int AmountMP = int.Parse(CmdArr[2]);

                    RechargeMethod(ManaPointsHero, CmdArr[2], HeroName1);

                    //int currentManaPoint = ManaPointsHero[HeroName1] + AmountMP; 
                    //if (currentManaPoint >200)
                    //{
                    //    AmountMP = 200 - ManaPointsHero[HeroName1];
                       
                    //}
                    //ManaPointsHero[HeroName1] += AmountMP;
                    //Console.WriteLine($"{HeroName1} recharged for {AmountMP} MP!");

            }
            else if (CurrentCmd == "Heal")
            {
                int Amount = int.Parse(CmdArr[2]);

                   
                    int CurrentHp = HitPointsHero[HeroName1] + Amount;
                    if (CurrentHp >100)
                    {
                        
                        Amount = 100 - HitPointsHero[HeroName1];
                        
                    }
                    HitPointsHero[HeroName1] += Amount;
                    Console.WriteLine($"{HeroName1} healed for {Amount} HP!");
            }
        }

            
            foreach (var item in HitPointsHero)
            {
                int manapoint3 = ManaPointsHero[item.Key];
                Console.WriteLine(item.Key);
                Console.WriteLine($" HP: {item.Value}");
                Console.WriteLine($" MP: {manapoint3}");
            }


        }
        static void RechargeMethod(Dictionary<string, int> ManaPointsHero, string Cmd, string HeroName1)
        {
            int AmountMP = int.Parse(Cmd);

            int currentManaPoint = ManaPointsHero[HeroName1] + AmountMP;
            if (currentManaPoint > 200)
            {
                AmountMP = 200 - ManaPointsHero[HeroName1];

            }
            ManaPointsHero[HeroName1] += AmountMP;
            Console.WriteLine($"{HeroName1} recharged for {AmountMP} MP!");

        }
    }
    
}
