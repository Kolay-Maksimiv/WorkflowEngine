
namespace WorkflowEngine
{
    public class WorkFrowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (ITask I in workFlow.GetTasks())
                I.Execude();
        }
    }
}