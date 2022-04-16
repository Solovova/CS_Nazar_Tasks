﻿using Tasks.Interfaces;

namespace Tasks.Task02;

public class Task02Solution : ITaskSolution<Task02Data>{
    public Task02Data Solve(Task02Data data){
        if (data.InArr1 == null || data.InArr2 == null){
            throw new ArgumentNullException();
        }

        for (int len = data.InArr1.Length; len > 0; len--){
            for (int pos1 = 0; pos1 <= data.InArr1.Length-len; pos1++){
                var slice1 = data.InArr1[pos1..(pos1+len)];
                for (int pos2 = 0; pos2 <= data.InArr2.Length-len; pos2++){
                    var slice2 = data.InArr2[pos2..(pos2+len)];
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