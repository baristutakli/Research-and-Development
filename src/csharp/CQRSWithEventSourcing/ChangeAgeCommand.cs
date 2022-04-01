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
public class ChangeAgeCommand:Command
{
    public Person Target;
    // İn real world example, you keep the ıd and query the target by this Id
    public int TargetId;
    public int Age;
    public ChangeAgeCommand(Person target, int age)
    {
        Target = target;
        Age = age;
    }
}
