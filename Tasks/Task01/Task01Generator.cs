using Tasks.Interfaces;

namespace Tasks.Task01;

public class Task01Generator : ITaskGenerator{
    public TaskData GetPrepared(){
        return new Task01Data{
            InArr1 = new[]{0, 1, 0, 2, 3, 0, 0},
            InArr2 = new[]{0, 0, 1, 1, 1, 0, 0}
        };
    }
    public TaskData GetRandom(){
        return new Task01Data{
            InArr1 = ExtFuncs.GetArrRandom(7, 0, 3),
            InArr2 = ExtFuncs.GetArrRandom(7, 0, 3)
        };
    }
}