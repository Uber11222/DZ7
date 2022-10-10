Console.WriteLine("введите номер строки");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int b = Convert.ToInt32(Console.ReadLine());
int [,] number = new int [5,5];
for (int i = 0; i < number.GetLength(0); i++)
        {        
            for (int j = 0; j < number.GetLength(1); j++)
            {
                number [i,j] = new Random().Next(0, 100);
            }   
        }
for (int j = 0; j < number.GetLength(1); j++)
{
    double avg =0;
    for (int i = 0; i < number.GetLength(0); i++)
    {
        avg = avg + number[i,j];
    }
    avg = avg/a;
    Console.Write(avg + " | ");

}