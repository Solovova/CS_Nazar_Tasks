using Tasks.Interfaces;
using Tasks.Task00;
using Tasks.Task01;
using Tasks.Task02;

namespace Tasks;

public static class FactoryTasks{
    public static (ITaskGenerator, ITaskSolution, ITaskConsole) GetTaskHandlers(int n){
        return n switch{
            0 => (new Task00Generator(), new Task00Solution(), new Task00Console()),
            1 => (new Task01Generator(), new Task01Solution(), new Task01Console()),
            2 => (new Task02Generator(), new Task02Solution(), new Task02Console()),
            _ => throw new ArgumentException("Factory tasks: wrong task select")
        };
    }
}