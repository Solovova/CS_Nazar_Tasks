using Tasks;
using Tasks.Task00;
using Tasks.Task01;
using Tasks.Task02;

void RunTaskWithRandomData<T>(){
    var (taskGenerator, taskSolution, taskOutConsole) = FactoryTasks.GetTaskHandlers<T>();

    var data = taskGenerator.GetRandom();
    data = taskSolution.Solve(data);
    taskOutConsole.ToConsole(data);
}

void RunTaskWithPreparedData<T>(){
    var (taskGenerator, taskSolution, taskOutConsole) = FactoryTasks.GetTaskHandlers<T>();

    var data = taskGenerator.GetPrepared();
    data = taskSolution.Solve(data);
    taskOutConsole.ToConsole(data);
}

Console.WriteLine("-----------Task00 Prepared data");
RunTaskWithPreparedData<Task00Data>();
Console.WriteLine("-----------Task00 Random data");
RunTaskWithRandomData<Task00Data>();

Console.WriteLine("-----------Task01 Prepared data");
RunTaskWithPreparedData<Task01Data>();
Console.WriteLine("-----------Task01 Random data");
RunTaskWithRandomData<Task01Data>();

Console.WriteLine("-----------Task02 Prepared data");
RunTaskWithPreparedData<Task02Data>();
Console.WriteLine("-----------Task02 Random data");
RunTaskWithRandomData<Task02Data>();