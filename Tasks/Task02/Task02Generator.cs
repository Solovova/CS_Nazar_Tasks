using Tasks.Interfaces;

namespace Tasks.Task02;

public class Task02Generator : ITaskGenerator<Task02Data>{
    public Task02Data GetPrepared(){
        return new Task02Data{
            InArr1 = new[]{3, 4, 8, 9, 5, 6, 6},
            InArr2 = new[]{2, 6, 5, 7, 8, 9, 4, 5, 2}
        };
    }

    public Task02Data GetRandom(){
        return new Task02Data{
            InArr1 = Func.Func.GetArrRandom(7,0,9),
            InArr2 = Func.Func.GetArrRandom(9,0,9)
        };
    }
}