﻿class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("pls Input all town: ");
        int all = int.Parse(Console.ReadLine());
        while(true){
            Console.WriteLine("pls Input : ");
            string town = Console.ReadLine();

            Console.WriteLine("pls Input value: ");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine("pls Input num: ");
            int[] number = new int[value];
                for (int i = 1; i <= value; i++)
                {
                    number[i] = int.Parse(Console.ReadLine());
                }
                
            
        } 

        







    }
}