using System.Collections.Specialized;

var numbers = new int[] {1,2,3,4,5,6,7,8,9};


static IEnumerable<int> oddNumbers(int count)
{
    int i = 1;
    while (true)
    {
        if (i % 2 != 0)
        {
            yield return i;
            if(count-- <= 0) yield break;
        }

        i++;
    }
}


static IEnumerable<int> getNumber()
{
    yield return 1;
    yield return 2;
    yield return 3;
}

foreach (var i in oddNumbers(5))
{
    Console.WriteLine(i);
}

//var it = numbers.GetEnumerator();


//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//while (it.MoveNext())
//{
//    Console.WriteLine(it.Current);
//}





