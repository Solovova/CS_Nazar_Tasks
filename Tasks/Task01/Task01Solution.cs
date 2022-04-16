using Tasks.Interfaces;

namespace Tasks.Task01;

public class Task01Solution : ITaskSolution<Task01Data>{
    public Task01Data Solve(Task01Data data){
        if (data.InArr1 == null || data.InArr2 == null){
            throw new ArgumentNullException();
        }

        var outList = new List<int[]>();
        outList.Add(data.InArr1.ToArray());
        outList.Add(data.InArr2.ToArray());

        data.OutArr = outList.ToArray();

        return data;
    }
}