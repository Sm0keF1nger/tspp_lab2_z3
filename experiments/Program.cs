class Program
{ // генератор даних
    static void ValsGenerator(int[] Vals)
    {
        // Random - клас для генерації випадкових чисел
        Random aRand = new Random();
        // заповнення масиву
        for (int i = 0; i < Vals.Length; i++)
            Vals[i] = aRand.Next(100);
    }
    static void Main(string[] args)
    {
        const int N = 10;
        int[] Data = new int[N];
        ValsGenerator(Data);
        Array.Sort(Data);
        Console.WriteLine("Друк відсортованих даних");
        for (int i = 0; i < Data.Length; i++)
            Console.WriteLine("Data[" + i + "] = " + Data[i]);
        Console.ReadLine();
    }
}