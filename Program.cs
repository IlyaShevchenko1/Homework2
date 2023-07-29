// Homework 2

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*
int DozenIndicator (int number)
{
    int lastTwoDigits = number % 100;
    int secondDigit = lastTwoDigits / 10;
    return secondDigit;
}

Console.Write("Input a number from 100 till 999: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = DozenIndicator(number);

Console.Write($"Second digit of your number {number} is {secondDigit}");

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// ( или -1, если третьей цифры нет).

/*

int ThirdDigitOfNumber (int number)
{
    int res = 0;

    if (number < 100 )
    {
        res = - 1;
        return res;
    }
    else 
    {
    while (number >= 1000)
    {
        number = number / 10;
    }
    res = number % 10;
    return res;
    }    
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = ThirdDigitOfNumber(number);

if (thirdDigit == -1) Console.WriteLine("There is no third digit in this number");
else Console.WriteLine($"Third digit of the number {number} is {thirdDigit}");

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

/*
bool WeekendCheck (int dayNumber)
{
    return dayNumber == 6 || dayNumber == 7;
     
}

Console.Write("Input a day number of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
bool check = WeekendCheck(dayNumber);
if (check) Console.WriteLine("Yes!!! It is a weekend!");
else Console.WriteLine("No. It is not a weekend.");
*/
