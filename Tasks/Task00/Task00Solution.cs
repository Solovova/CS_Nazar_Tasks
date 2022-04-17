using Tasks.Interfaces;

namespace Tasks.Task00;

public class Task00Solution : ITaskSolution<Task00Data>{
    private int GetTypeOfCell(int[,] arr, int i, int j){
        var neighborCells = ExtFuncs.GetNeighborCells(i, j, 
            0, arr.GetLength(0) - 1, 
            0, arr.GetLength(1) - 1);
        foreach (var (ni,nj) in neighborCells){
                if (arr[ni, nj] == 1 && arr[i, j] == 0){
                    return 1;
                }
                if (arr[ni, nj] == 0 && arr[i, j] == 1){
                    return 2;
                }
        }

        return arr[i, j] switch{
            0 => 0,
            1 => 3,
            _ => throw new Exception("Illegal data in")
        };
    }

    public Task00Data Solve(Task00Data data){
        if (data.InArr == null){
            throw new ArgumentNullException();
        }

        data.OutArr = new int[data.InArr.GetLength(0), data.InArr.GetLength(1)];
        for (var i = 0; i < data.InArr.GetLength(0); i++){
            for (var j = 0; j < data.InArr.GetLength(1); j++){
                data.OutArr[i, j] = GetTypeOfCell(data.InArr, i, j);
            }
        }

        return data;
    }
}