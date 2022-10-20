class Program
{
    delegate int Transformer(int x);

    private static int[] numbers = new[] { 1, 2, 3, 4, 5 };

    public static void Main()
    {


    }


    static int Square(int num)
    {
        return num * num;
    }

    static int Cube(int num)
    {
        return num * num * num;
    }
}








