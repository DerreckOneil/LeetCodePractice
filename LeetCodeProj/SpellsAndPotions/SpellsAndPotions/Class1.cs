using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpellsAndPotions
{
    internal class Class1
    {
        public static void Main(string[]args)
        {
            int[] a = {3,1,2 };
            int[] b = {8,5,8};

            SortTheArrays(b); //this should sort only b
            Console.WriteLine("[{0}]", string.Join(", ", a));
            Console.WriteLine("[{0}]", string.Join(", ", b));

            int[] solution = SuccessfulPairs(a, b, 16);
            Console.WriteLine("[{0}]", string.Join(", ", solution));
        }

        private static void SortTheArrays(int[] b )
        {
            Array.Sort(b);
        }
        public static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            List<int> listOfValues = new List<int>();

            for(int i =0; i < spells.Length; i++)
            {

                int potionIndex = (int)MathF.Ceiling(success / spells[i]);
                Console.WriteLine((int)MathF.Ceiling(success / spells[i]));
                if(potionIndex < 0 || potionIndex > potions.Length)
                {
                    Console.WriteLine("Skip this number: " + spells[i]);
                    listOfValues.Add(0);
                    continue;
                }
                
                Console.WriteLine("What number does this even give?: " + potionIndex);

                listOfValues.Add(potions.Length - potionIndex);
            
            }

            return listOfValues.ToArray();
        }
        
    }
}
