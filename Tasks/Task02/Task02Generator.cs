using Tasks.Interfaces;

namespace Tasks.Task02;

public class Task02Generator : ITaskGenerator<Task02Data>{
    public Task02Data GetPrepared(){
        return new Task02Data{
            InArr1 = new[]{0, 1, 0, 2, 3, 0, 0},
            InArr2 = new[]{0, 0, 1, 1, 1, 0, 0}
        };
    }

    public Task02Data GetRandom(){
        return GetPrepared();
    }
}