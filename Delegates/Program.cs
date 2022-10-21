class Program
{
    delegate int Transformer(int x);
    delegate double MathWxp(double x);


    private static int[] numbers = new[] { 1, 2, 3, 4, 5 };

    static double mypower(double i)
    {
        return Math.Pow(i, 2);
    }

    public static void Main()
    {
        Transformer fn = Cube;

        //Console.WriteLine(fn(3));

        Compute(numbers, mypower);
        

    }

    static void Compute(int[] array, MathWxp fn)
    {
        foreach (var i in array)
        {
            Console.WriteLine(fn(i));
        }
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








