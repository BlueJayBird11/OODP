using System;

public class Originator
{

    private uint state;

    public void setState(uint state)
    {
        this.state = state;
    }

    public uint getState()
    {
        return this.state;
    }

    public Memento saveToMemento()
    {
        return new Memento(this.getState());
    }

    public void loadFromMemento(Memento memento)
    {
        this.setState(memento.getState());
    }

}

public class Memento
{

	private readonly uint state;

	public Memento(uint stateToSave)
	{
		this.state = stateToSave;
	}

	public uint getState()
    {
        return this.state;
    }

}

public class Caretaker
{

    static void Main(string[] args)
    {

        // make an originator with state 1
        var originator = new Originator();
        originator.setState(1);
        Console.WriteLine("New Originator made with state = " + originator.getState());

        // create a memento of state 1
        var savedState1 = originator.saveToMemento();
        Console.WriteLine("Created a Memento...");

        // edit the state of the originator to state 2
        originator.setState(2);
        Console.WriteLine("Originator state changed to state = " + originator.getState());

        // restore the state of the Originator from the Memento 
        originator.loadFromMemento(savedState1);
        Console.WriteLine("Reading from Memento...");

        // see that the state has returned 
        Console.WriteLine("Originator state changed to state = " + originator.getState());

    }

}