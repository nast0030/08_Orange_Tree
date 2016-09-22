using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        public int Age;
        public int Height;
        public bool TreeAlive;
        public int NumOranges;
        public int OrangesEaten;
     

        public  OrangeTree(int treeage, int treeheight)
        {
            Age = treeage;
            Height = treeheight;
            bool TreeAlive = false;
        
        }

        public void OneYearPasses()
        {
            Age++;
            Height += 2;

            if (Age == 80)
            {
                TreeAlive = false;
                return;

           }

            if (Age == 2)
            {
                NumOranges = 5;
                return;
            
            }

            if (Age > 0)
            {
                NumOranges += 5;
            }
        }

        public void EatOrange(int antalappelsiner)
        {
            if (NumOranges >= antalappelsiner)
            {
                NumOranges -= antalappelsiner;
                OrangesEaten += antalappelsiner;
                return;
            }

            else
            {
                

                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            
            }
        }
    }
}