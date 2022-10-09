// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизнаное число: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[5];
string result;
if (number < 10000 || number > 99999)
{
    result = "Ошибка! Введено не пятизначное число!";
}
else
{
    for(int i = 0; i < 5; i++)
    {
        array[i] = number%10;
        number = number / 10;
    }
    if((array[0] == array[4]) && (array[1] == array[3]))
    {
        result = "Число является палиндромом";
    }
    else
    {
        result = "Число не является палиндромом";
    }
}
Console.WriteLine(result);