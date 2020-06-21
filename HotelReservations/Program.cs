using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] days = new int[365];
        public static int[] rooms;
        public static int[,] hotel = new int[days.Length, days.Length];
        public static bool slobodno = true; 

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj 1-5 za prikaz testova");
            string caseSwitch = Console.ReadLine(); 
            switch (caseSwitch)
            {
                case "1":
                    //case 1
                    rooms = new int[1];
                    bool case11 = Rezervacije(-4, 2);
                    bool case12 = Rezervacije(200, 400);
                    Console.WriteLine(case11);
                    Console.WriteLine(case12);
                    break;
                case "2":
                    //case 2
                    rooms = new int[3];
                    bool case21 = Rezervacije(0, 5);
                    bool case22 = Rezervacije(7, 13);
                    bool case23 = Rezervacije(3, 9);
                    bool case24 = Rezervacije(5, 7);
                    bool case25 = Rezervacije(6, 6);
                    bool case26 = Rezervacije(0, 4);
                    Console.WriteLine(case21);
                    Console.WriteLine(case22);
                    Console.WriteLine(case23);
                    Console.WriteLine(case24);
                    Console.WriteLine(case25);
                    Console.WriteLine(case26);
                    break;
                case "3":
                    //case 3
                    rooms = new int[3];
                    bool case31 = Rezervacije(1, 3);
                    bool case32 = Rezervacije(2, 5);
                    bool case33 = Rezervacije(1, 9);
                    bool case34 = Rezervacije(0, 15);
                    Console.WriteLine(case31);
                    Console.WriteLine(case32);
                    Console.WriteLine(case33);
                    Console.WriteLine(case34);
                    break;
                case "4":
                    //case 4
                    rooms = new int[3];
                    bool case41 = Rezervacije(1, 3);
                    bool case42 = Rezervacije(0, 15);
                    bool case43 = Rezervacije(1, 9);
                    bool case44 = Rezervacije(2, 5);
                    bool case45 = Rezervacije(4, 9);
                    Console.WriteLine(case41);
                    Console.WriteLine(case42);
                    Console.WriteLine(case43);
                    Console.WriteLine(case44);
                    Console.WriteLine(case45);
                    break;
                case "5":
                    //case 5
                    rooms = new int[2];
                    bool case51 = Rezervacije(1, 3);
                    bool case52 = Rezervacije(0, 4);
                    bool case53 = Rezervacije(2, 3);
                    bool case54 = Rezervacije(5, 5);
                    bool case55 = Rezervacije(4, 10);
                    bool case56 = Rezervacije(10, 10);
                    bool case57 = Rezervacije(6, 7);
                    bool case58 = Rezervacije(8, 10);
                    bool case59 = Rezervacije(8, 9);
                    Console.WriteLine(case51);
                    Console.WriteLine(case52);
                    Console.WriteLine(case53);
                    Console.WriteLine(case54);
                    Console.WriteLine(case55);
                    Console.WriteLine(case56);
                    Console.WriteLine(case57);
                    Console.WriteLine(case58);
                    Console.WriteLine(case59);
                    break;

                default:
                    Console.WriteLine("Unijeli ste broj koji je van opsega 1-5");
                    break;
            }
        }

        public static bool Rezervacije(int start, int end)
        {
            //Ideja je da se prolazi redom kroz sve sobe, i da se popunjava prva soba ukoliko je dostupna za neki od navedenih datuma iz test case-a
            //U petom test case-u =, u tekstu zadatka, sam primjetila da je prvo popunjena druga soba za datum (5,5) pa krajnji rezultat nije isti, jer se 
            //meni automatski popuni prva soba, jer je i ona slobodna za navedeni datum
            for (int p = 0; p < rooms.Length; p++)
            {
                for (int m = start; m <= end; m++)
                {
                    if (start < 0 || end < 0 || end > 365)
                        return false;

                   if (hotel[p, m] == 1)
                    {
                        slobodno = false;
                        continue;
                    }
                }

                if (slobodno == true)
                {
                    for (int m = start; m <= end; m++)
                    {
                        hotel[p, m] = 1;
                    }
                    return true;
                }
                else
                {
                    slobodno = true;
                }
            }
 
            return false;
        }
    }
}