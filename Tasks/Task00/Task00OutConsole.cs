using Tasks.Interfaces;

namespace Tasks.Task00;

public class Task00OutConsole : ITaskOutConsole<Task00Data>{
    public void ToConsole(Task00Data data){
        if (data.InArr == null || data.OutArr == null){
            throw new ArgumentNullException();
        }

        Console.WriteLine("In data:");
        ExtFuncs.ToConsole2DimArray(data.InArr);

        Console.WriteLine("Out data:");
        ExtFuncs.ToConsole2DimArray(data.OutArr);
    }
}