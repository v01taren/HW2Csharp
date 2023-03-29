// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine($"В числе нет третьей цифры");
}
else {

int tmp = num;
while (tmp > 1000)
{
    tmp /= 10;
}

int result = tmp % 10;
Console.WriteLine($"Цифра под индексом 3 числа {num} -> {result}");
}
