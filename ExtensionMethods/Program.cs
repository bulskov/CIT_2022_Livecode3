
using System.Text;

static class MyExt
{
    public static string FlipCase(this string s)
    {
        var sb = new StringBuilder();
        foreach (var c in s)
        {
            if (char.IsUpper(c))
            {
                sb.Append(char.ToLower(c));
            }
            else
            {
                sb.Append(char.ToUpper(c));
            }
        }
        return sb.ToString();
    }
}


class Program
{
    public static void Main()
    {
        var msg = "Hello, World!";
        Console.WriteLine(msg.FlipCase());
    }

    

    
}


