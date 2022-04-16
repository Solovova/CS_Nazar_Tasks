namespace Tasks.Interfaces;

public interface ITaskGenerator<out T>{
    public T GetPrepared();
    public T GetRandom();
}