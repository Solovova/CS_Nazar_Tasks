using Tasks.Interfaces;
using Tasks.Task00;

namespace Tasks.Task01;

public class Task01OutConsole : ITaskOutConsole<Task01Data>{
    private void ToConsole1DimArray(int[] arr){
        foreach (var t in arr){
            Console.Write(t + " ");
        }

        Console.WriteLine();
    }

    private void ToConsoleArrayOfArray(int[][] arr){
        foreach (var t in arr){
            foreach (var t1 in t){
                Console.Write(t1 + " ");
            }
            Console.WriteLine();
        }
    }

    public void ToConsole(Task01Data data){
        if (data.InArr1 == null || data.InArr2 == null || data.OutArr == null){
            throw new ArgumentNullException();
        }

        Console.WriteLine("In data arr1:");
        ToConsole1DimArray(data.InArr1);
        
        Console.WriteLine("In data arr2:");
        ToConsole1DimArray(data.InArr2);

        Console.WriteLine("Out data:");
        ToConsoleArrayOfArray(data.OutArr);
    }
}