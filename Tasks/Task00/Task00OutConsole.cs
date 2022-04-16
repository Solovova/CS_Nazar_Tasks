using Tasks.Interfaces;

namespace Tasks.Task00;

public class Task00OutConsole : ITaskOutConsole<Task00Data>{
    private void ToConsole2DimArray(int[,] arr){
        for (var i = 0; i < arr.GetLength(0); i++){
            for (var j = 0; j < arr.GetLength(1); j++){
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void ToConsole(Task00Data data){
        if (data.InArr == null || data.OutArr == null){
            throw new ArgumentNullException();
        }

        Console.WriteLine("In data:");
        ToConsole2DimArray(data.InArr);

        Console.WriteLine("Out data:");
        ToConsole2DimArray(data.OutArr);
    }
}