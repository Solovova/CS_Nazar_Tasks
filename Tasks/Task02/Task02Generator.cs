using Tasks.Interfaces;

namespace Tasks.Task02;

public class Task02Generator : ITaskGenerator{
    public TaskData GetPrepared(){
        return new Task02Data{
            InArr1 = new[]{3, 4, 8, 9, 5, 6, 6},
            InArr2 = new[]{2, 6, 5, 7, 8, 9, 4, 5, 2}
        };
    }

    public TaskData GetRandom(){
        return new Task02Data{
            InArr1 = ExtFuncs.GetArrRandom(7, 0, 9),
            InArr2 = ExtFuncs.GetArrRandom(9, 0, 9)
        };
    }
}