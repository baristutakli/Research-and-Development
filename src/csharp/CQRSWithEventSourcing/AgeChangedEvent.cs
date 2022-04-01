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
public class AgeChangedEvent : Event
{
    // Target
    public Person Target;
    public int oldValue, newValue;

    public AgeChangedEvent(Person target, int oldValue, int newValue)
    {
        Target = target;
        this.oldValue = oldValue;
        this.newValue = newValue;
    }

    public override string ToString()
    {
        return $"Age changed from {oldValue} to {newValue}";
    }
}