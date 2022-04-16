using Tasks.Interfaces;
using Tasks.Task00;
using Tasks.Task01;
using Tasks.Task02;

namespace Tasks;
public static class FactoryTasks{
    public static (ITaskGenerator<T>, ITaskSolution<T>, ITaskOutConsole<T>) GetTaskHandlers<T>(){
        if (typeof(T) == typeof(Task00Data)){
            return ((ITaskGenerator<T>) new Task00Generator(), (ITaskSolution<T>)new Task00Solution(), (ITaskOutConsole<T>)new Task00OutConsole());
        }
        if (typeof(T) == typeof(Task01Data)){
            return ((ITaskGenerator<T>) new Task01Generator(), (ITaskSolution<T>)new Task01Solution(), (ITaskOutConsole<T>)new Task01OutConsole());
        }
        if (typeof(T) == typeof(Task02Data)){
            return ((ITaskGenerator<T>) new Task02Generator(), (ITaskSolution<T>)new Task02Solution(), (ITaskOutConsole<T>)new Task02OutConsole());
        }
        throw new ArgumentException("Factory tasks: wrong task select");
    }
}