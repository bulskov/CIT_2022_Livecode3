using Helper;


static class MyLinq
{
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> collection, Func<T, bool> fn)
    {
        foreach (var element in collection)
        {
            if(fn(element)) yield return element;
        }
    }

    public static IEnumerable<S> MySelect<T, S>(this IEnumerable<T> collection, Func<T, S> fn)
    {
        foreach (var element in collection)
        {
            yield return fn(element);
        }
    }
}

class Pet
{
    public int Id { get; set; }
    public string Kind { get; set; }
}
class Program
{

    static List<Person> people = new()
    {
        new Person { Name = "Peter", Age = 23, Gender = 'm', PetId = 1},
        new Person { Name = "Sue", Age = 21,   Gender = 'f', PetId = 2 },
        new Person { Name = "Kim", Age = 21,   Gender = 'f', PetId = 3 },
        new Person { Name = "Ellen", Age = 22, Gender = 'f', PetId = 2 },
        new Person { Name = "Joe", Age = 23,   Gender = 'm', PetId = 1 },
    };

    private static List<Pet> pets = new List<Pet>
    {
        new Pet { Id = 1, Kind = "Dog" },
        new Pet { Id = 2, Kind = "Cat" },
        new Pet { Id = 3, Kind = "Snake" }
    };

    static int[] numbers = new int[] { 1, 3, 7, 2};
    static int[] numbers2 = new int[] {3, 4, 2, 5};


    public static void Main()
    {

    }
}

