using System;

class Task
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;

    public Task(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
    }

    public void DisplayTask()
    {
        Console.WriteLine($"Task ID: {TaskID}, Name: {TaskName}, Priority: {Priority}, Due Date: {DueDate.ToShortDateString()}");
    }
}

class Node
{
    public Task task;
    public Node next;

    public Node(Task task)
    {
        this.task = task;
        this.next = null;
    }
}

class TaskScheduler
{
    private Node head;
    private Node tail;
    private Node current;

    public TaskScheduler()
    {
        head = null;
        tail = null;
        current = null;
    }

    // Add task at the beginning
    public void AddTaskBeginning(Task task)
    {
        Node newNode = new Node(task);
        if (head == null)
        {
            head = tail = newNode;
            newNode.next = head;
        }
        else
        {
            newNode.next = head;
            tail.next = newNode;
            head = newNode;
        }
    }

    // Add task at the end
    public void AddTaskEnd(Task task)
    {
        Node newNode = new Node(task);
        if (head == null)
        {
            head = tail = newNode;
            newNode.next = head;
        }
        else
        {
            tail.next = newNode;
            newNode.next = head;
            tail = newNode;
        }
    }

    // Add task at a specific position
    public void AddTaskAtPosition(int pos, Task task)
    {
        if (pos <= 1)
        {
            AddTaskBeginning(task);
            return;
        }

        Node newNode = new Node(task);
        Node temp = head;
        int count = 1;

        while (temp.next != head && count < pos - 1)
        {
            temp = temp.next;
            count++;
        }

        newNode.next = temp.next;
        temp.next = newNode;

        if (temp == tail)
            tail = newNode;
    }

    // Remove task by Task ID
    public void RemoveTask(int taskID)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to remove!");
            return;
        }

        Node temp = head, prev = null;
        do
        {
            if (temp.task.TaskID == taskID)
            {
                if (temp == head && temp == tail)
                {
                    head = tail = null;
                }
                else if (temp == head)
                {
                    head = head.next;
                    tail.next = head;
                }
                else if (temp == tail)
                {
                    prev.next = head;
                    tail = prev;
                }
                else
                {
                    prev.next = temp.next;
                }

                Console.WriteLine($"Task {taskID} removed successfully.");
                return;
            }
            prev = temp;
            temp = temp.next;
        } while (temp != head);

        Console.WriteLine("Task not found!");
    }

    // View the current task and move to the next task
    public void ViewNextTask()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available!");
            return;
        }

        if (current == null)
            current = head;

        current.task.DisplayTask();
        current = current.next;
    }

    // Display all tasks
    public void DisplayAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available!");
            return;
        }

        Node temp = head;
        Console.WriteLine("\nAll Tasks:");
        do
        {
            temp.task.DisplayTask();
            temp = temp.next;
        } while (temp != head);
    }

    // Search for a task by priority
    public void SearchTaskByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available!");
            return;
        }

        Node temp = head;
        bool found = false;
        do
        {
            if (temp.task.Priority == priority)
            {
                temp.task.DisplayTask();
                found = true;
            }
            temp = temp.next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No task found with the given priority!");
        }
    }
}

class Program
{
    public static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();
        int choice, taskID, priority;
        string taskName;
        DateTime dueDate;

        do
        {
            Console.WriteLine("\nTask Scheduler System");
            Console.WriteLine("1. Add Task at Beginning");
            Console.WriteLine("2. Add Task at End");
            Console.WriteLine("3. Add Task at Position");
            Console.WriteLine("4. Remove Task");
            Console.WriteLine("5. View Next Task");
            Console.WriteLine("6. Display All Tasks");
            Console.WriteLine("7. Search Task by Priority");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Task ID: ");
                    taskID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    taskName = Console.ReadLine();
                    Console.Write("Enter Priority: ");
                    priority = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (YYYY-MM-DD): ");
                    dueDate = DateTime.Parse(Console.ReadLine());
                    scheduler.AddTaskBeginning(new Task(taskID, taskName, priority, dueDate));
                    break;

                case 2:
                    Console.Write("Enter Task ID: ");
                    taskID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    taskName = Console.ReadLine();
                    Console.Write("Enter Priority: ");
                    priority = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (YYYY-MM-DD): ");
                    dueDate = DateTime.Parse(Console.ReadLine());
                    scheduler.AddTaskEnd(new Task(taskID, taskName, priority, dueDate));
                    break;

                case 3:
                    Console.Write("Enter Position: ");
                    int pos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task ID: ");
                    taskID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Task Name: ");
                    taskName = Console.ReadLine();
                    Console.Write("Enter Priority: ");
                    priority = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Due Date (YYYY-MM-DD): ");
                    dueDate = DateTime.Parse(Console.ReadLine());
                    scheduler.AddTaskAtPosition(pos, new Task(taskID, taskName, priority, dueDate));
                    break;

                case 4:
                    Console.Write("Enter Task ID to Remove: ");
                    taskID = Convert.ToInt32(Console.ReadLine());
                    scheduler.RemoveTask(taskID);
                    break;

                case 5:
                    scheduler.ViewNextTask();
                    break;

                case 6:
                    scheduler.DisplayAllTasks();
                    break;

                case 7:
                    Console.Write("Enter Priority to Search: ");
                    priority = Convert.ToInt32(Console.ReadLine());
                    scheduler.SearchTaskByPriority(priority);
                    break;

                case 8:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        } while (choice != 8);
    }
}
