using System;
using System.ComponentModel.Design;
double a = 0;
double b = 0;
string num1 = " ";
string num2 = " ";
string? Input = " ";
Console.WriteLine("Welcome to C# Calculator!");
Console.WriteLine("It supports basic calculation of two numbers like +,-,*,/.");
Console.WriteLine("Type 'over' to end the application.");
Console.WriteLine("----------------------------------------------------------");//程序初始化及问候语

//输入部分
do
{
    Input = Console.ReadLine();
}
while (Input == null);
//检测部分
int i = 0;
string sign = " ";
do
    i++;
while (Char.IsDigit(Input, i) == false);
int num1start = i - 1;
do
    i++;
while (Char.IsDigit(Input, i) == true);
int length1 = i - num1start;
num1 = Input.Substring(num1start, length1);
a = Convert.ToDouble(num1);//检测第一个数字

do
{
    sign = Input.Substring(i, 1);
    i++;
}
while (sign != "+" && sign != "-" && sign != "*" && sign != "/");//检测符号

do
    i++;
while (Char.IsDigit(Input, i) == false && i < Input.Length);
int num2start = i;
int length2 = 0;
if (i == Input.Length-1)
    length2 = 1;
else
    do
        i++;
    while (Char.IsDigit(Input, i) == true && i < Input.Length);
    length2 = i - num2start + 1;
num2 = Input.Substring(num2start, length2);
b = Convert.ToDouble(num2);//检测第二个数字

//计算部分
double result = 0;
switch (sign)
{
    case "+": result = a + b; break;
    case "-": result = a - b; break;
    case "*": result = a * b; break;
    case "/": result = a / b; break;
}
Console.WriteLine($"The result is {result}");
Console.WriteLine("Press any key to shut down.");
Console.ReadKey();