/* Задача 10: Напишите программу, которая принимает на вход трёхзначное
 число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */

Console.Write("Введите 3-х значное число");
int num = Convert.ToInt32(Console.ReadLine());
int Length = num.ToString().Length;
if (Length == 3)
{
    int result = (num/10) % 10;
    Console.WriteLine("Вторая цифра введенного числа " + result);
}
else
{
    Console.WriteLine("Введено не 3-х значное число");
}