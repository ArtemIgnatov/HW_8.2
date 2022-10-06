using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (true)
        {
            
            Console.WriteLine("Введите номер телефона");
            string number = Console.ReadLine();

            //Организуем выход из цикла через ввод пустрой строки
            if (number == String.Empty) break; 

            Console.WriteLine("Введите ФИО владельца");
            string fio = Console.ReadLine();

            phoneBook.Add(number, fio);
        }
      

        foreach (KeyValuePair<string, string> e in phoneBook)
            Console.WriteLine($"{e} ");
        Console.ReadKey();

        Console.WriteLine("Введите номер телефона для поиска владельца");
        string findNumber = Console.ReadLine();
        string value = "";
        if (phoneBook.TryGetValue(findNumber, out value))
        {
            Console.WriteLine($"Для номера телефона {findNumber}, владелец {value}");
        }
        else
        {
            Console.WriteLine($"Владелец номера телефона {findNumber} не найден");
        }
        Console.ReadKey();
    }

}