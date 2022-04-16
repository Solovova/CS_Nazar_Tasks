using Tasks.Interfaces;

namespace Tasks.Task01;

public class Task01Solution : ITaskSolution<Task01Data>{
    public Task01Data Solve(Task01Data data){
        if (data.InArr1 == null || data.InArr2 == null || data.InArr1.Length != data.InArr2.Length){
            throw new ArgumentException();
        }

        var outList = new List<int[]>();
        outList.Add(data.InArr1.ToArray());
        var step = data.InArr1.ToArray();
        for (int i = 0; i < data.InArr1.Length; i++){
            while (step[i]!=data.InArr2[i]){
                if (step[i] < data.InArr2[i]){
                    step[i]++;
                }
                else{
                    step[i]--;
                }
                outList.Add(step.ToArray());
            }
        }

        data.OutArr = outList.ToArray();

        return data;
    }
}