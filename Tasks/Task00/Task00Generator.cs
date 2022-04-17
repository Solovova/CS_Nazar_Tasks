using Tasks.Interfaces;

namespace Tasks.Task00;

public class Task00Generator : ITaskGenerator<Task00Data>{
    public Task00Data GetPrepared(){
        return new Task00Data{
            InArr = new[,]{
                {0, 0, 0, 0, 0, 0, 0},
                {0, 1, 0, 1, 0, 0, 0},
                {0, 1, 0, 0, 0, 0, 0},
                {0, 0, 1, 1, 1, 0, 0},
                {0, 0, 1, 1, 1, 0, 0},
                {0, 0, 1, 1, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0}
            }
        };
    }

    public Task00Data GetRandom(){
        const int mi = 10;
        const int mj = 12;
        var arr = new int[mi, mj];

        var rnd = new Random();
        for (var i = 0; i < arr.GetLength(0); i++){
            for (var j = 0; j < arr.GetLength(1); j++)
                arr[i, j] = rnd.Next(0, 2);
        }

        return new Task00Data{
            InArr = arr
        };
    }
}