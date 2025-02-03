int n = 9; 
for (int i = 1; i <= n; i++)
{
    if (i <= 6)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(i + " ");
        }
    }
    else
    {
        for (int j = 1; j <= (n - i + 1); j++)
        {
            Console.Write(i + " ");
        }
    }
    Console.WriteLine();
}


