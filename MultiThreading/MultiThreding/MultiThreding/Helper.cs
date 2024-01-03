namespace Util;
using System.Threading;

public static class Helper
{
    public static async Task StoreData()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Storing Data into JSON FIle");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        });
    }


    public static async Task GetRemoteData()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Getting Data From External Source");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        });
    }
}