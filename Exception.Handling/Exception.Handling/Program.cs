using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    //static void Main(string[] args)
    //{
    //    try
    //    {
    //        Console.WriteLine($"Faktoria ededi yoxlamaq ucun eded daxil edin");
    //        int number = int.Parse(Console.ReadLine());

    //        long factorial = FactorialCalculator.CalculateFactorial(number);
    //        Console.WriteLine($"Ededin Faktoriali {number} = {factorial}");
    //    }
    //    catch (FormatException)
    //    {
    //        Console.WriteLine("Sef eded taxil edildi");
    //    }
    //    catch (NegativeNumberException ex)
    //    {
    //        Console.WriteLine($"Sef bas verdi {ex.Message}");
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"Sef bas verdi {ex.Message}");
    //    }
    //}

    ///////////////////////////////////////////////////////////////
    static void Main(/*string[] args*/)
    {

        //try
        //{
        //    Console.Write("Email: ");
        //    string email = Console.ReadLine();

        //    Console.Write("Password: ");
        //    string password = Console.ReadLine();

        //    // LoginService Ekzemplari
        //    LoginService loginService = new LoginService();
        //    loginService.Login(email, password);
        //}
        //catch (InvalidCredentialsException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (WeakPasswordException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}



        //_______________________________________________


        Dictionary<string, int> users = new Dictionary<string, int>();
        users.Add("Vasif", 20);
        users.Add("Talib", 25);
        users.Add("Rafael", 33);
        users.Add("Memmednise", 52);
        users.Add("Tofiq", 20);
        users.Add("Medine", 64);
        users.Add("Xadice", 19);

        foreach (var pair in users.OrderByAge())
        {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }


    }

}

