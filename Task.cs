
void Download()
{
    Thread thread1 = new Thread(() =>
    {
        for (int i = 1; i <=5; i++)
        {
            Console.WriteLine("Downloading file...");
        }
    });
    thread1.Start();
    thread1.Join();
}
void Check()
{
    Thread thread2 = new Thread(() =>
    {
        for (int i = 1; i <=5; i++)
        {
            Console.WriteLine("Checking data...");
        }
    });
    thread2.Start();
    thread2.Join();
}
Download();
Check();
Console.WriteLine("All operations completed");