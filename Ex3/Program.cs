Console.WriteLine("Введите число от 1 до 7 : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 7){
    Console.WriteLine($"{a} это число больше 7 ");
}
else if (a>5){
    Console.WriteLine($"{a} день недели выходной");
}
else {
    Console.WriteLine($"{a} день недели не является выходным днем");
}