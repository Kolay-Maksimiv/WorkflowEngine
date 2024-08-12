namespace WorkflowEngine
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            WorkFlow workFrow = new WorkFlow();

            workFrow.Add(new VideoUploader());
            workFrow.Add(new CallWebService());
            workFrow.Add(new SendEmail());
            workFrow.Add(new ChangeStatus());


            var engine = new WorkFrowEngine();

            engine.Run(workFrow);
        }
    }
}
