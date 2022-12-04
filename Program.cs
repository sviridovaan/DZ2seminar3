//напишите программу, которая на вход принимает число N и выдает таблицу кубов от 1 до N
Console.Clear();
void CubeTab (string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        double cube = Math.Pow(count,3);
        Console.Write(cube + " ");
        count ++;
    }
    Console.WriteLine();
}
CubeTab("Введите число N: ");