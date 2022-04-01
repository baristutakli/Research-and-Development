// See https://aka.ms/new-console-template for more information
// CQRS
// Event Sourcing
// All the changes are encapsulates as event
// https://www.youtube.com/watch?v=Q0Bz-O67_nI
/**
 * Command ~ do/change
 * Query ~ 
 */






// in real world
public class Person
{
    private int age;
    EventBroker _broker;
    public Person(EventBroker broker)
    {
       _broker = broker;
        broker.Commands += BrokerOnCommands;
        broker.Queries += BrokerOnQueries;
    }

    private void BrokerOnQueries(object? sender, Query query)
    {
        var ac = query as AgeQuery;
        if (ac != null && ac.Target ==this)
        {
            ac.Result = age;
        }
    }

    private void BrokerOnCommands(object? sender, Command command)
    {
        var cac = command as ChangeAgeCommand;
        if (cac!=null&& cac.Target==this)
        {
            if (cac.Register) _broker.AllEvents.Add(new AgeChangedEvent(this, age, cac.Age));
            age = cac.Age;
        }
    }
    // additional mechanism
    public bool CanVote => age >= 16;
}
