// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели : ");
string dayWeek = Console.ReadLine();

switch (dayWeek)
{
    case "1":
        Console.WriteLine("Поенедельник, опять работать! - нет");
        break;
    case "2":
        Console.WriteLine("Вторник, опять работать! - нет");
        break;
    case "3":
        Console.WriteLine("Среда, опять работать! - нет");
        break;
    case "4":
        Console.WriteLine("Четверг, опять работать! - нет");
        break;
    case "5":
        Console.WriteLine("Пятница, опять работать! - нет");
        break;
    case "6":
        Console.WriteLine("Суббота, кайф - Да");
        break;
    case "7":
        Console.WriteLine("Воскресенье, кайф- Да");
        break;
  default : Console.WriteLine("Такого дня нет") ; break; 
}
