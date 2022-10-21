using Helper;

var people = new List<Person>
{
    new Person { Name = "Peter", Age = 23 },
    new Person { Name = "Sue", Age = 21 },
    new Person { Name = "Kim", Age = 24 },
    new Person { Name = "Ellen", Age = 22 },
    new Person { Name = "Joe", Age = 23 },
};

var numbers = new int[] { 1, 3, 7, 2, 3, 4, 2, 5, 6 };


//foreach (var i in numbers.Distinct().OrderBy(x => x))
//{
//    Console.WriteLine(i);
//}


//var result = new List<Person>();
//foreach (var person in people)
//{
//    if (person.Age < 23)
//    {
//        result.Add(person);
//    }
//}


//var res = people.Where(x => x.Age > 23);

foreach (var person in people.OrderByDescending(person => person.Age).ThenBy(person => person.Name))
{
    Console.WriteLine(person);
}

