using Tasks.Interfaces;
using Tasks.Task00;

namespace Tasks;
public static class FactoryTasks{
    public static (ITaskGenerator<T>, ITaskSolution<T>, ITaskOutConsole<T>) GetTaskHandlers<T>(){
        if (typeof(T) == typeof(Task00Data)){
            return ((ITaskGenerator<T>) new Task00Generator(), (ITaskSolution<T>)new Task00Solution(), (ITaskOutConsole<T>)new Task00OutConsole());
        }
        
        throw new ArgumentException("Factory tasks: wrong task select");
    }
}