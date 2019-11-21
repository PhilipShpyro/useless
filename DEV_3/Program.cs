using System;

namespace DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence sequence = new Sequence("qwertyuiopasdfghjklzxcvbnm");
            Console.WriteLine(sequence.GetChangedString());
        }
    }
}
