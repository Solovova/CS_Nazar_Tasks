using Tasks;
using Tasks.Task00;

void RunTask<T>(){
    var (taskGenerator, taskSolution, taskOutConsole) = FactoryTasks.GetTaskHandlers<T>();

    var data = taskGenerator.GetRandom();
    data = taskSolution.Solve(data);
    taskOutConsole.ToConsole(data);
}

RunTask<Task00Data>();
