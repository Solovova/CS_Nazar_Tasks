using Tasks.Interfaces;

namespace Tasks.Task00;

public class Task00Console : ITaskConsole{
    public void Print(TaskData dataIn){
        if (dataIn is not Task00Data data){
            throw new ArgumentException();
        }

        if (data.InArr == null || data.OutArr == null){
            throw new ArgumentNullException();
        }

        Console.WriteLine("In data:");
        ExtFuncs.ToConsole2DimArray(data.InArr);

        Console.WriteLine("Out data:");
        ExtFuncs.ToConsole2DimArray(data.OutArr);
    }
}