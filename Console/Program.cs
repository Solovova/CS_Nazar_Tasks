using Tasks;

void RunTask(int taskNum, EnGeneratorType enGeneratorType){
    var (taskGenerator, taskSolution, taskOutConsole) = FactoryTasks.GetTaskHandlers(taskNum);
    var data = enGeneratorType switch{
        EnGeneratorType.Prepared => taskGenerator.GetPrepared(),
        EnGeneratorType.Random => taskGenerator.GetRandom(),
        _ => throw new ArgumentOutOfRangeException(nameof(enGeneratorType), enGeneratorType, null)
    };
    data = taskSolution.Solve(data);
    taskOutConsole.Print(data);
}

for (var i = 0; i < 3; i++){
    foreach (var generatorType in Enum.GetValues<EnGeneratorType>()){
        Console.WriteLine($"\nTask{i} for {generatorType.ToString().ToLower()} data");
        RunTask(0,generatorType);
    }
}

internal enum EnGeneratorType{
    Random,
    Prepared
}


