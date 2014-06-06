using System;
using System.Linq;

class Program
{
    static int cookieCnt = 0;
    static void Main()
    {
        const double COOKIE_PRICE = 1.79;
        bool paypal = false;

        string[] cookies = new string[16]; 
        for (int i = 0; i < cookies.Length; i++)
        { 
            cookies[i] = Console.ReadLine(); 
        }
   
        string command = "";
        if (command == "paypal")
            paypal = true;
        while (!paypal)
        {
            command = Console.ReadLine();
            if (command == "paypal")
                break;
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            char piece = cookies[row][col];
            int[] pieces = new int[9];

            pieces[0] = col > 0 ? int.Parse(cookies[row][col - 1].ToString()) : 0;
            pieces[1] = col < cookies[row].Length - 1 ? int.Parse(cookies[row][col + 1].ToString()) : 0;
            pieces[2] = row < cookies.Length - 1 ? int.Parse(cookies[row + 1][col].ToString()) : 0;
            pieces[3] = row > 0 ? int.Parse(cookies[row - 1][col].ToString()) : 0;
            pieces[4] = row < cookies.Length - 1 && col > 0 ? int.Parse(cookies[row + 1][col - 1].ToString()) : 0;
            pieces[5] = row < cookies.Length - 1 && col < cookies[row].Length - 1 ? int.Parse(cookies[row + 1][col + 1].ToString()) : 0;
            pieces[6] = row > 0 && col > 0 ? int.Parse(cookies[row - 1][col - 1].ToString()) : 0;
            pieces[7] = row > 0 && col < cookies[row].Length - 1 ? int.Parse(cookies[row - 1][col + 1].ToString()) : 0;

            if (pieces.Sum() == pieces.Length - 1 && piece == '1')
            {
                if (command == "what is")
                    Console.WriteLine("cookies");
                else if (command == "buy")
                    cookieCnt++;
            }
            else if (piece == '1' && pieces.Sum() == 0)
            {
                if (command == "what is")
                    Console.WriteLine("cookie crumb");
                else if (command == "buy")
                    Console.WriteLine("smile");
            }
            else if (piece == '1' && pieces.Sum() > 0)
            {
                if (command == "what is")
                    Console.WriteLine("broken cookie");
                else if (command == "buy")
                    Console.WriteLine("page");
            }
        }
        Console.WriteLine(cookieCnt * COOKIE_PRICE);

    }
}


