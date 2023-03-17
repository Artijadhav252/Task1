//accept any number from user and returnthe factors that number
//1)If user enter 12 then user returnthe factors of that number

Console.WriteLine("please enter any num");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("factores of the number:" + "" + num);


for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        Console.WriteLine(i + "");
    }
}


//2)if users enter number 17 then factors of that number

Console.WriteLine("please enter any number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("factores of the number:" + "" + num1);

for (int i = 1; i <= num1; i++)
{
    if (num1 % i == 0)
    {
        Console.WriteLine(i + "");
    }
}

//2)if user enter number 10 then factors will be

Console.WriteLine("Please enter any number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("factores of the number:" + "" + num2);
for (int i = 1; i <= num2; i++)
{
    if (num2 % i == 0)
    {
        Console.WriteLine(i + "");
    }
}