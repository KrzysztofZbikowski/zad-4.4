class Zad
{
    static void Main(string[] args)
    {
        int[] tab = new int[100];
        Random rand = new Random();
        for (int i = 0; i < 100; i++)
        {
            tab[i] = rand.Next(1, 1000);
        }
        for (int i = 0; i < 100; i++)
        {
            Console.Write(tab[i] + " ");
        }
        Console.ReadKey();
    }
}