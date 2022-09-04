/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

void secondNumber(){
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Number is - " + num);
    int a = num / 10;
    int b  = a % 10;
    Console.WriteLine("The second number  - " + b);
}
secondNumber();

*/


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645 -> 5
78 -> третьей цифры нет
32679 -> 6



int thirdNumber(int Number){
    string numberTxt = Convert.ToString(Number);
    if (numberTxt.Length > 2){
    Console.WriteLine("Третья цифра введенного числа " + numberTxt[2]);
    }
    else {

    Console.WriteLine("Третьей цифры не существует");
    }
      return Number;
    }
 
Console.Write("Введи ваще любое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
thirdNumber(Number);
*/



/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


void dayNumber (int num){
    if (num == 6 || num == 7 ){
        Console.WriteLine ("Это выходной день! Можешь отдохнуть!");
    }
    else if(num < 1 || num >7){
        Console.WriteLine ("Такой цифры, которая бы обозначала день недели, не существует!");
    }
    else {
        Console.WriteLine ("Это будний день иди работай!!!");
    }
}
Console.WriteLine ("Введи цифру обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());
dayNumber(num);
*/