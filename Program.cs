using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reham Ibrahim Gaabub 19254 \n");
            Console.WriteLine("Enter the key");
            string key = Console.ReadLine();
            for(; key.Length != 10;)
            {
               Console.WriteLine("Range Error, Enter the key again");
                break;
            }
            char[] charkey = new char[10];
            charkey = key.ToCharArray();
            int[] intkey = new int[10];
            bool f1 = false;
            for (int i = 0; i < 10; i++)
            {
                intkey[i] = charkey[i]-48;
                if(intkey[i]>9)
                {
                    Console.WriteLine("Character Error");
                    f1 = true;
                    break;
                }
            }
            if(f1==false)
            {
                bool f2 = false;
                for (int i1 = 0; i1 < 9; i1++)
                    for (int i2 = 1; i1 + i2 < 10; i2++)
                    {
                        if (intkey[i1] == intkey[i1 + i2])
                        {
                            Console.WriteLine("Dublicate Error");
                            i1 = 9;
                            f2 = true;
                            break;
                        }
                    }
                if (f2 == false)
                {

                    Console.WriteLine("Enter Message");
                    string message = Console.ReadLine();
                    char[] charmessage = new char[message.Length];
                    charmessage = message.ToCharArray();
                    int[] intmessage = new int[10];
                    bool f3 = false;
                    for (int i = 0; i < 10; i++)
                    {
                        intmessage[i] = charmessage[i] - 48;
                        if (intmessage[i] > 9)
                        {
                            Console.WriteLine("Character Error");
                            f3 = true;
                            break;
                        }
                    }
                    if(f3==false)
                    {
                        for (int x = 0, y = 0, i = 0; i < message.Length; i++)
                        {
                            x = intkey[y];
                            Console.Write(intmessage[x]);
                            if (y == 9)
                                y = 0;
                            y++;
                        }
                    }
                    
                }

            }






        }
    }
}
