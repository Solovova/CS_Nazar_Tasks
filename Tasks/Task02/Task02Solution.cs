using Tasks.Interfaces;

namespace Tasks.Task02;

public class Task02Solution : ITaskSolution<Task02Data>{
    public Task02Data Solve(Task02Data data){
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