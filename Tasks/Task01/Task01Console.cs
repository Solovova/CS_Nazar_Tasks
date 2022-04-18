using Tasks.Interfaces;

namespace Tasks.Task01;

public class Task01Console : ITaskConsole{
    public void Print(TaskData dataIn){
        if (dataIn is not Task01Data data){
            throw new ArgumentException();
        }
        
        if (data.InArr1 == null || data.InArr2 == null || data.OutArr == null){
            throw new ArgumentNullException();
        }

        Console.WriteLine("In data arr1:");
        ExtFuncs.ToConsole1DimArray(data.InArr1);
        
        Console.WriteLine("In data arr2:");
        ExtFuncs.ToConsole1DimArray(data.InArr2);

        Console.WriteLine("Out data:");
        ExtFuncs.ToConsoleArrayOfArray(data.OutArr);
    }
}