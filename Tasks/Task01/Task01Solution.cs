using Tasks.Interfaces;

namespace Tasks.Task01;

public class Task01Solution : ITaskSolution{
    public TaskData Solve(TaskData dataIn){
        if (dataIn is not Task01Data data){
            throw new ArgumentException();
        }

        if (data.InArr1 == null || data.InArr2 == null || data.InArr1.Length != data.InArr2.Length){
            throw new ArgumentException();
        }

        var outList = new List<int[]>{data.InArr1.ToArray()};
        var step = data.InArr1.ToArray();
        for (var i = 0; i < data.InArr1.Length; i++){
            while (step[i] != data.InArr2[i]){
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