namespace CSharpOOPs_Application
{
    public class AsyncTest
    {
        public static void DoActions()
        {
            List<Task> tasks = new List<Task>
            {
                Task1(),
                Task2()
            };
            Task.WaitAll(tasks.ToArray());
            //do
            //{
            //}while(!t.IsCompleted);
        }
        private static async Task Task1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"From Task 1  Entry >>>>>>>>> {i} <<<<<<<<<<");
                await Task.Run(() =>
            {
                Console.WriteLine($"From Task 1  {DateTime.Now} >>>>>>>>> {i} <<<<<<<<<<");

                Thread.Sleep(2000);
            });
                Console.WriteLine($"From Task 1  Exit >>>>>>>>> {i} <<<<<<<<<<");
            }
        }
        private static async Task Task2()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"From Task 2  {DateTime.Now}");
                Thread.Sleep(3000);
            }
        }
    }
}
