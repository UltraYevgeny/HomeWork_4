/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
void RaisingNumber(int numberA, int numberB)
{
    double raisingNumber = Math.Pow(numberA, numberB);
    Console.WriteLine(raisingNumber);
}

void EnterNumber()
{
    Console.Write("Enter number A: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    RaisingNumber(numberA, numberB);
}


bool Question()
{
    Console.Write("Want to enter a number (Y/N): ");
    string yesNo = Console.ReadLine();
    if (yesNo == "Y" || yesNo == "y")
    {
        EnterNumber();
        return false;
    }
    else if (yesNo == "N" || yesNo == "n")
    {
        Console.Write("End program");
        return true;
    }
    else return false;
}

bool question = false;
while (question == false)
{
    question = Question();
}
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int Rank(int number)
{   
    int sum = number;
    int rankNumber = 1;
    while (sum > 9)
    {
        sum = sum / 10;
        rankNumber += 1;
    }
    return rankNumber;
}

void SumDigit(int number)
{
    int rankNumber = Rank(number);
    int sum = 0;
    int ten = 1;
        for (int i = 1; i <= rankNumber; i++)
    {
        sum = sum + (number / ten)%10;
        ten = ten * 10;
        
    }
    Console.WriteLine($"Summa of digit: {sum}");
}

Console.Write("Enter 2-digit number minimum: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number < 10)
{
    Console.Write("Number less then 2-digit!");
}
else SumDigit(user_number);
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 
элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


using System.Collections;
using System.ComponentModel;

void Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter number {i+1} : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("");
    Console.Write("This is your array: [");
    for (int j = 0; j < size-1; j++)
    {
        Console.Write($"{array[j]}, ");
    }
    Console.WriteLine($"{array[size-1]}]");
}


Console.Write("Size of array: ");
Array(Convert.ToInt32(Console.ReadLine()));
