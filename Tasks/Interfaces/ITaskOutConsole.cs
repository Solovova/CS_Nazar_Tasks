namespace Tasks.Interfaces;

public interface ITaskOutConsole<in T>{
    public void ToConsole(T data);
}