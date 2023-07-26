Console.WriteLine("Домашнее задание №2");
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Задание №1");
Console.Write("Введите число а: ");
int num = Convert.ToInt32 (Console.ReadLine ());
int sym;
if (100>num || num>999) {
  Console.WriteLine("Число не трехзначное");  
}
else 
{   sym=num/10%10; 
Console.WriteLine("Вторая цифра числа " + num + ": " + sym);
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Задание №2");
Console.Write("Введите число а:");
int num2 = Convert.ToInt32 (Console.ReadLine ());
int sym2;
if (100>num2) {
  Console.WriteLine("Третьей цифры нет!");  
}
else {
  if (num2<999) {
  sym2 = num2/100;
}
else {while (num2>999){
  num2 = num2/10; 
}
sym2 = num2%10;
}
Console.WriteLine("Третья цифра числа " + num2 + ": " + sym2);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Задание №3");
Console.Write("Введите порядковый номер дня недели:");
int num3 = Convert.ToInt32 (Console.ReadLine ());

if (1 > num3 || num3 > 7) {
  Console.WriteLine("Введен некорректный порядковый номер дня недели! ");  
}
else 
{   
    if (num3<5) {Console.WriteLine("Нет");}
    else {Console.WriteLine("Да");}
}}
