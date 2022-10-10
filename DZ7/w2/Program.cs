Console.WriteLine("введите номер строки");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int b = Convert.ToInt32(Console.ReadLine());
int [,] number = new int [10,10];
for (int i = 0; i < number.GetLength(0); i++)
        {        
            for (int j = 0; j < number.GetLength(1); j++)
            {
                number [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
if (a > number.GetLength(0) || b > number.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {number[a-1,b-1]}");
}
