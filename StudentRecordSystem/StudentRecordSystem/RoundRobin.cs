/*using System;

class Process
{
    public int ProcessID;
    public int BurstTime;
    public int RemainingTime;
    public int WaitingTime;
    public int TurnAroundTime;
    public Process Next;

    public Process(int id, int burstTime)
    {
        ProcessID = id;
        BurstTime = burstTime;
        RemainingTime = burstTime;
        WaitingTime = 0;
        TurnAroundTime = 0;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private Process head;
    private Process tail;
    private int processCount;

    public RoundRobinScheduler()
    {
        head = null;
        tail = null;
        processCount = 0;
    }

    // Add a new process at the end (circular linked list)
    public void AddProcess(int id, int burstTime)
    {
        Process newProcess = new Process(id, burstTime);
        if (head == null)
        {
            head = newProcess;
            tail = newProcess;
            newProcess.Next = head; // Circular linking
        }
        else
        {
            tail.Next = newProcess;
            newProcess.Next = head;
            tail = newProcess;
        }
        processCount++;
    }

    // Remove a process by ID
    public void RemoveProcess(int id)
    {
        if (head == null) return;

        Process temp = head, prev = null;

        // If the process to be removed is the head
        if (temp.ProcessID == id)
        {
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail.Next = head.Next;
                head = head.Next;
            }
            processCount--;
            return;
        }

        // Search for the process in the circular linked list
        do
        {
            prev = temp;
            temp = temp.Next;
            if (temp.ProcessID == id)
            {
                prev.Next = temp.Next;
                if (temp == tail) tail = prev;
                processCount--;
                return;
            }
        } while (temp != head);
    }

    // Simulate the Round Robin Scheduling Algorithm
    public void Execute(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        int totalTime = 0;
        int totalWaitingTime = 0, totalTurnAroundTime = 0;
        Process temp = head;

        Console.WriteLine("\nExecuting Processes with Time Quantum = " + timeQuantum);

        while (processCount > 0)
        {
            if (temp.RemainingTime > 0)
            {
                if (temp.RemainingTime > timeQuantum)
                {
                    totalTime += timeQuantum;
                    temp.RemainingTime -= timeQuantum;
                }
                else
                {
                    totalTime += temp.RemainingTime;
                    temp.TurnAroundTime = totalTime;
                    temp.WaitingTime = temp.TurnAroundTime - temp.BurstTime;
                    totalWaitingTime += temp.WaitingTime;
                    totalTurnAroundTime += temp.TurnAroundTime;
                    Console.WriteLine($"Process {temp.ProcessID} completed. Turnaround Time: {temp.TurnAroundTime}, Waiting Time: {temp.WaitingTime}");
                    int idToRemove = temp.ProcessID;
                    temp = temp.Next;
                    RemoveProcess(idToRemove);
                    continue;
                }
            }
            temp = temp.Next;
        }

        int processCompleted = totalTurnAroundTime > 0 ? totalTurnAroundTime / timeQuantum : 0;
        double avgWaitingTime = processCompleted > 0 ? (double)totalWaitingTime / processCompleted : 0;
        double avgTurnAroundTime = processCompleted > 0 ? (double)totalTurnAroundTime / processCompleted : 0;

        Console.WriteLine($"\nAverage Waiting Time: {avgWaitingTime:F2}");
        Console.WriteLine($"Average Turnaround Time: {avgTurnAroundTime:F2}");
    }

    // Display the list of processes
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        Process temp = head;
        Console.WriteLine("\nProcesses in Circular Queue:");
        do
        {
            Console.WriteLine($"Process ID: {temp.ProcessID}, Burst Time: {temp.BurstTime}, Remaining Time: {temp.RemainingTime}");
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    public static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();
        int choice, id, burstTime, quantum;

        do
        {
            Console.WriteLine("\nRound Robin CPU Scheduling");
            Console.WriteLine("1. Add Process");
            Console.WriteLine("2. Display Processes");
            Console.WriteLine("3. Execute Scheduling");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Process ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Burst Time: ");
                    burstTime = Convert.ToInt32(Console.ReadLine());
                    scheduler.AddProcess(id, burstTime);
                    break;

                case 2:
                    scheduler.DisplayProcesses();
                    break;

                case 3:
                    Console.Write("Enter Time Quantum: ");
                    quantum = Convert.ToInt32(Console.ReadLine());
                    scheduler.Execute(quantum);
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        } while (choice != 4);
    }
}
*/