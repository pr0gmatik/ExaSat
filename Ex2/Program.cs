// Console.WriteLine("Задача 10 ");
// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine(stringNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);


//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5
//782 -> 8
//918 -> 1

//int num = new Random().Next(100, 1000);
//Console.WriteLine("Введите число : ");
//int num = new Random().Next(100, 1000);
int num = 5645;
int num1 = num / 100;
if(num1 == 0)
{
    Console.Write("В данном числе, третьей цифры нет");
    
}

else (num1 > 10);
{
    int num2 = num1%10;
    Console.WriteLine($"В числе 645, третье число {num2}");
  
}

Console.WriteLine($"В числе 645, третье число {num1}");
//else Console.Write(num1);
// int num1 = num % 100;
// int num5 = num1 / 10;
// int num2 = num / 100;
// int num3 = num / 10;
// //int num2 = num % 10;
// //Console.Write(num1);
// int num4 = num2 - num3;
//Console.WriteLine(num1);
// Console.WriteLine(num2);
// Console.WriteLine(num3);
// Console.WriteLine(num5);
// Console.Write(num4);