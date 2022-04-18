namespace Tasks.Interfaces;

public interface ITaskGenerator{
    public TaskData GetPrepared();
    public TaskData GetRandom();
}