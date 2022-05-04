//  Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int index = 100;
if (number > index)
{
    string stringNumber = Convert.ToString(number);
    Console.WriteLine(stringNumber[2]);
}
else 
{
    Console.WriteLine("Третьего числа нет");
}