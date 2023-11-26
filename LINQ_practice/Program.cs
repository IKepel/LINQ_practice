using LINQ_practice;

var array = new List<int>();

for (int i = 1; i <= 100; i++)
{
    array.Add(i);
}

var oddNumbers = array.Where(x => x % 2 != 0).ToList();

Console.WriteLine("Odd numbers: ");
foreach (var num in oddNumbers)
{
    Console.Write($"{num} ");
}

var squares = array.Select(x => x * x).ToList();

Console.WriteLine("\n\nThe squares of numbers: ");
foreach (var square in squares)
{
    Console.Write($"{square} ");
}

var sum =  array.Sum();
Console.WriteLine($"\n\nSum = {sum}");

var people = new List<Person>();

for (int i = 0; i < 20; i++)
{
    Person person = new Person($"Person{i + 1}", i + 1, 12 + i);
    people.Add(person);
}

var peopleOlderThan20 = people.Where(person => person.Age > 20);

Console.WriteLine("\nThe names of people over the age of 20: ");
foreach (var person in peopleOlderThan20)
{
    Console.WriteLine(person.Name);
}

var filteredPeople = people
    .Where(person => person.Age > 20)
    .Select(person => new { Id = person.Id, Name = person.Name })
    .OrderBy(person => person.Name)
    .ToList();

Console.WriteLine("\nFiltered and sorted people over the age of 20: ");
foreach (var personInfo in filteredPeople)
{
    Console.WriteLine($"Id: {personInfo.Id}, Name: {personInfo.Name}");
}

Console.WriteLine($"\nvalue = {array.Penultimate()}");