using Util;
using System;
using System.Threading;
using System.Threading.Tasks;

Thread theThread = Thread.CurrentThread;
Console.WriteLine("Main Function thread= " + theThread.ManagedThreadId);



Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
Helper.GetRemoteData();
Helper.StoreData();


