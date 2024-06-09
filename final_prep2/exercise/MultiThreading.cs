using System;
using System.Threading;


namespace ExamPrep;

/*

    Concurrency -> Multiple tasks makig progress concurrently

    Parallelism -> Multiple tasks running at the same time

    MultiThreading -> the general mechanism by which a program
                      simultaneously execute code. 

    Threading -> execution path that can proceed independently of others.
                 MultiTreaded program sharees the same execution environment(mainly memory)
                 One thread can fetch data, while another displays the data as it arrives.
                 That's reffered to as a SHARED STATE.

    Blocking -> A thread is deemed BLOCKED when its execution is paused for some reason,
                such as when Sleeping or waiting for another to end via .Join();
                A blocked thread immediately YIELDS its processor time slice and consumes
                no processor time until its blocking condition is satisfied.  You can test for a thread being blocked via its ThreadState property:


    I/O-bound versus compute-bound -> an operation that spends most of its time waiting for smth to happen
                                      i.e. downloading a web-page or calling Console.ReadLine()
                                      In contrast an operation that spoends most of its time performing CPU-intensive 
                                      work is called COMPUTER-BOUND.

        Blocking vs Spinning: spinning can very vriefly be effective as it is very wasteful on processor.

    Local vs Shared State: 

        • Local State: data that is local to a thred and is not shared with other threads. 
                       Each thread has its own copy of this data, so there is no risk of concurrent access issues.

        • Shared State: shared states must be carefully managed to avoid race conditions, where the outcome of operations
                        depends on the timing of the threads. 


    Thread Safety and Synchronization: 
        • Locking(Monitor): using the "lock" statemetn ensures that a block of code 
                            is executed by only one thread at a time.
        
        • Monitor.Enter(): aquire the monitor lock on the locked object 
        • Monior.Exit(): used to release the lock

        • Mutex, Semaphore, AutoResetEvent: other synchronization primitives used for more complex scenarios. 

        • Thread Pooling and Task Parallel Library (TPL)
            - Task: represent an asych. operation
            - TaskFactory: Provides methods for creating and starting tasks.
            - Parallel Class: Provides support for parallel loops and regions.
            - PLINQ (Parallel LINQ): Parallel implementation of LINQ that can execute queres concurrently.

        • Task.WaitAll: synchronously wait for all task to complete, blocking the main thread until completion
        • Task.WhenAll: Manages multiple tasks asynchronously so the main thread can remain active.  
        • Task.WhenAny: Creates a task that will complete when any of the supplied tasks have complete.d 
        • Parallel.ForEach(): allows all iterations to run concurrently


    Principles of Asynchrony

        Synchronous Operation does its work before retrun to the caller.
            Most of the methos you can call are sync. Examples: 
                - List<T>.Add
                - Console.WriteLine()
                - Thread.Sleep() when you want to block the current thread.
                (await Task.Delay() when you want a logical delay without blocking the current thread.)

        Asynchronous Operation can do (most of its work or all of it)  after
        returning to the caller (also called nonblocjing methods.)
            Most async methods can be desrcribed as general-purpose methods:
                - Thread.Start()
                - Task.Run(): offloads the CPU-bound operation to the thread pool,
                              which helps free up the main thread for other tasks.
                - Methods that attach continuations to tasks

        Principle of Asynch. Programming: you write long-running functions asynchronously.
                                          Concurrency is initiated inside the long-running function
                                          rather than from outside the function. This has two benefits:

                                        • I/O-bound concurrency can be implemented without tying up threads, improving scalability and efficiency.
                                        • Rich-client applications end up with less code on worker threads, simplifying thread safety.        
        
        Async: Declares ass methos as asynchronous.

        Awaiting: Rauses the method execution until the awaited teask completes. 

        AggregateException class: used to consolidate multiple failures into a single, throwable exception object. 


*/


public class MultiThreadingAndConcurrenncy
{

    // Thread start example 

    public static void StartThread()
    {
        Thread t = new Thread(WriteY);
        t.Start();
        t.Join(); // waits for another method to end
        Thread.Sleep(500); // Pauses the thread for a specific period 

        // ThreadState
        bool blocked = (t.ThreadState & ThreadState.WaitSleepJoin) != 0;
    }

    private static void WriteY()
    {
        for (int i = 0; i < 1000; i++) Console.Write("y");
    }



}