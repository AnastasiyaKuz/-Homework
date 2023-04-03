/* Задача 13: Напишите программу, которая выводит третью цифру заданного
 числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int Length = num.ToString().Length;
if (Length >= 3)
{
    while (num > 999)
    {
        num = num /10;
    }
    int result = num % 10;
    Console.WriteLine("Третья цифра введенного числа " + result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}