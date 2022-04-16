namespace Tasks.Interfaces;

public interface ITaskSolution<T>{
    public T Solve(T data);
}