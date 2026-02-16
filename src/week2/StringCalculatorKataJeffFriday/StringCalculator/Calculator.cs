
// what 
// "Interface Segregation Principle"
    // you define what you need, don't just use what's available.
    // Instead of creating one large "fat" interface with many methods, you should split it into 
    // smaller, focused interfaces, so that classes only implement what they need.
    // Ex: Separate interfaces for logging results and notifying the help desk.

// Interface: contract that defines what a class must do, BUT not how it does it.
// Key characteristics:
    // 1). Contains a list of requried members:
        // Methods, properties, events, etc.
    // 2). Reference type
    // 3). Blueprint for behavior
    // 4). Not instantiable

// Any class that implements ILogger must provide a "LogAddResults" method.
public interface ILogger
{
    void LogAddResults(string results); // void method that takes in a "string" results and adds it to the log.
}

// Any class that implements INotifyTheHelpDesk must provide a "Notify" method.
public interface INotifyTheHelpDesk
{
    void Notify(string v); // void method that takes in a "string" v and notifies the help desk.
}

// Pass interfaces directly into the Calculator class using method injection
public class Calculator(ILogger _logger, INotifyTheHelpDesk _helpDesk)
{
    // Add method that takes in a string "numbers"
    public int Add(string numbers)
    {

        // Grabs the sum of the strings
        var result = numbers == "" ? 0 : numbers // "1,2,3,4"
            .Split(',', '\n') // ["1", "2", "3", "4"]
            .Select(int.Parse) // [1, 2, 3, 4]
            .Sum(); // 10

        // Do something here
        // this is a "non-functional" or "technical" requirement.
        // Side effect just means that something is happening
        // that doesn't change the observable behavior of the 
        // caller of this method.
        //
        // logging is "leaving the escape room" - leaving the process
        // writing to the file system.

        try
        {
            _logger.LogAddResults(result.ToString());
        }
        catch (Exception)
        {
            // The help desk is notified.
          
          
            // gulp!
        _helpDesk.Notify("Wan't able to log: " + result.ToString());
        }
       
        return result;

    }
}


// Test Double --> 4 different types:
    // Dummy - not really part of the test, just need something so we don't get a NRE

    // *Important ones
    // Stub - a thing that has canned responses to questions. Simulating faults.
        // Provides pre-defined answers to calls made during the test.
        // Used to control inidrect inputs to the system under test.
    // Mock - Record their interactions. 
        // Pre-programmed with expectations.
        // Test verifies behavior automatically: ensuring a specific method was called with certain arguments

    // Fake - We will do this in our API. It's not our code, it's a "stand in" for something