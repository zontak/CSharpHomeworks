using System;
class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhone = Console.ReadLine();
        string companyFax = Console.ReadLine();
        string companySite = Console.ReadLine();

        string managerFName = Console.ReadLine();
        string managerLName = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();
        string managerFullName = managerFName + " " + managerLName;

        Console.WriteLine("[Company: Name:{0}, Address:{1}, Phone:{2}, Fax:{3}, WebSite:{4}]", companyName, companyAddress, companyPhone, companyFax, companySite);
        Console.WriteLine("[Manager: Name:{0}, Age:{1}, Phone:{2}]", managerFullName, managerAge, managerPhone);
    }
}
