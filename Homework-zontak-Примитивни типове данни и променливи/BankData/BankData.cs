using System;
using System.Linq;

class BankData
{
    static void Main()
    {
        string firstName = " Kristiyan";
        string middleName = " Plamenov ";
        string lastName = "Petrov";
        string bankName = " First Investment Bank ";
        string IBAN = " BG32 UBBS 7827 1013 6179 05 ";
        int money = 214321;
        string firstCardNumber = " 4236-2123-7523-3468";
        string secondCardNumber = " 4125-4675-3987-3411";
        string thirdCardNumber = " 2131-1142-5567-8412";
        Console.WriteLine(bankName);
        Console.WriteLine(" Account name is: " + firstName + middleName + lastName);
        Console.WriteLine(firstName + " have " + money + " euro ");
        Console.WriteLine(IBAN);
        Console.WriteLine(" Kristiyan Have 3 Credit Card:");
        Console.WriteLine(firstCardNumber);
        Console.WriteLine(secondCardNumber);
        Console.WriteLine(thirdCardNumber);
    }
}

