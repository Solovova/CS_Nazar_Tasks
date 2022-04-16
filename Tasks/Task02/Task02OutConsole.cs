using Tasks.Interfaces;

namespace Tasks.Task02;

public class Task02OutConsole : ITaskOutConsole<Task02Data>{
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

    public void ToConsole(Task02Data data){
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