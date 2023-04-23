// Задача 4: Напишите программу,
 // которая принимает на вход три числа и 
 // выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число : ");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int b= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число : ");
int c= Convert.ToInt32(Console.ReadLine());

if(a>b){
    Console.WriteLine($"Максимальное из этих чисел = {a}");
}
else if(b>c){
    Console.WriteLine($"Максимальное из этих чисел = {b}");
}
else{
    Console.WriteLine($"Максимальное из этих чисел = {c}");
}