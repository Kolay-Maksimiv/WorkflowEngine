

namespace WorkflowEngine
{
    public interface IWorkFlow
    {
        void Add(ITask task);
        IEnumerable<ITask> GetTasks();
        void Remove(ITask task);
    }
}