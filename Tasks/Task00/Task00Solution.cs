using Tasks.Interfaces;

namespace Tasks.Task00;

public class Task00Solution : ITaskSolution<Task00Data>{
    private int GetTypeOfCell(int[,] arr, int i, int j){
        var minI = Math.Max(0, i - 1);
        var maxI = Math.Min(i + 1, arr.GetLength(0) - 1) + 1;
        foreach (int ni in Enumerable.Range(minI, maxI - minI)){
            var minJ = Math.Max(0, j - 1);
            var maxJ = Math.Min(j + 1, arr.GetLength(1) - 1) + 1;
            foreach (int nj in Enumerable.Range(minJ, maxJ - minJ)){
                if (ni == i && nj == j){
                    continue;
                }

                if (arr[ni, nj] == 1 && arr[i, j] == 0){
                    return 1;
                }

                if (arr[ni, nj] == 0 && arr[i, j] == 1){
                    return 2;
                }
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