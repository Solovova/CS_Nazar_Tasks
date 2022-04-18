using Tasks.Interfaces;

namespace Tasks.Task02;

public class Task02Solution : ITaskSolution{
    public TaskData Solve(TaskData dataIn){
        if (dataIn is not Task02Data data){
            throw new ArgumentException();
        }

        if (data.InArr1 == null || data.InArr2 == null){
            throw new ArgumentNullException();
        }

        for (var len = data.InArr1.Length; len > 0; len--){
            for (var pos1 = 0; pos1 <= data.InArr1.Length - len; pos1++){
                var slice1 = data.InArr1.AsSpan()[pos1..(pos1 + len)];
                for (var pos2 = 0; pos2 <= data.InArr2.Length - len; pos2++){
                    var slice2 = data.InArr2.AsSpan()[pos2..(pos2 + len)];
                    if (slice1.SequenceEqual(slice2)){
                        data.OutArr = slice1.ToArray();
                        return data;
                    }
                }
            }
        }

        data.OutArr = Array.Empty<int>();
        return data;
    }
}