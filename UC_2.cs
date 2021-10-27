using System;

namespace SnakeandLadder
{
    class UC_2
    {
        public void DieRoll()
        {
            Random random = new Random();
            int rollCheck = random.Next(1, 7);
            Console.WriteLine("Number got on Die: " + rollCheck);
        }
    }
}
