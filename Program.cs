int Carre(int i)
{
    return i * i;
}

Console.WriteLine("Saisissez le nombre pour le mettre au carré.");
int res = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Carre(res));