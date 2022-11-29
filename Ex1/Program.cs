//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5

int num = 456;
int num1 = num % 100;
int num2 = num1 / 10;
Console.Write(num2);

// //782 -> 8
// int num = 782;
// int num1 = num % 100;
// int num2 = num1 / 10;
// Console.Write(num2);

// //918 -> 1
// int num = 918;
// int num1 = num % 100;
// int num2 = num1 / 10;
// Console.Write(num2);