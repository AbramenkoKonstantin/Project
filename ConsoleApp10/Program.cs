using System;

namespace individual_project
{
    class Program
    {
        static void Main(string[] args)
        {
            returnProgram:
            GetInfo info = new GetInfo();
            info.GetInformation();
            Console.ReadKey();
            int returnProg;
            Console.WriteLine("1. Повторить?\n2. Завершить");
            returnProg = Convert.ToInt32(Console.ReadLine());
            if (returnProg == 1)
            {
                goto returnProgram;
            }
        }

    }
}