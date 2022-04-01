// See https://aka.ms/new-console-template for more information
// CQRS
// Event Sourcing
// All the changes are encapsulates as event
// https://www.youtube.com/watch?v=Q0Bz-O67_nI
/**
 * Command ~ do/change
 * Query ~ 
 */
Console.WriteLine("Hello, World!");




var ebroker = new EventBroker();
var p = new Person(ebroker
    );
ebroker.Command(new ChangeAgeCommand(p, 123));
int age;
 age= ebroker.Query<int>(new AgeQuery { Target=p});
Console.WriteLine($"Age: {age}");
foreach (var e in ebroker.AllEvents)
{
    Console.WriteLine(e);
}

ebroker.UndoLast();
foreach (var e in ebroker.AllEvents)
{
    Console.WriteLine("-"+e);
}
age = ebroker.Query<int>(new AgeQuery { Target = p });
Console.WriteLine($"Age: {age}");

// in real world
public class PersonStorage
{
    Dictionary<int, Person> people;
}
