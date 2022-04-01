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
public class EventBroker
{
    // All event that happend
    public IList<Event> AllEvents = new List<Event>();
    // Commands
    public event EventHandler<Command> Commands;
    // Queries
    public event EventHandler<Query> Queries;

    // İnvoke a command
    public void Command(Command command)
    {
        Commands.Invoke(this,command);
    }

    public T Query<T>(Query query)
    {
        Queries?.Invoke(this, query);
        return (T)query.Result;
    }
    public void UndoLast()
    {
        var e = AllEvents.LastOrDefault();
        var ac = e as AgeChangedEvent;
        if (ac != null)
        {
            // invoke the command 
            Command(new ChangeAgeCommand(ac.Target, ac.oldValue) { Register=false});
            AllEvents.Remove(e);
        }
    }
}
