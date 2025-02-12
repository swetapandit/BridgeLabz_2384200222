/*using System;
using System.Collections.Generic;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public FriendList Friends; // Each user has a list of friends

    public User(int userId, string name, int age)
    {
        UserId = userId;
        Name = name;
        Age = age;
        Friends = new FriendList();
    }
}

// Linked List Node Class
public class Node
{
    public User Data;
    public Node Next;

    public Node(User user)
    {
        Data = user;
        Next = null;
    }
}

// Friend List using Singly Linked List
public class FriendList
{
    public Node Head;

    public void AddFriend(User user)
    {
        Node newNode = new Node(user);
        if (Head == null)
            Head = newNode;
        else
        {
            Node temp = Head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newNode;
        }
    }

    public void RemoveFriend(int userId)
    {
        if (Head == null) return;

        if (Head.Data.UserId == userId)
        {
            Head = Head.Next;
            return;
        }

        Node temp = Head;
        while (temp.Next != null && temp.Next.Data.UserId != userId)
            temp = temp.Next;

        if (temp.Next != null)
            temp.Next = temp.Next.Next;
    }

    public bool IsFriend(int userId)
    {
        Node temp = Head;
        while (temp != null)
        {
            if (temp.Data.UserId == userId)
                return true;
            temp = temp.Next;
        }
        return false;
    }

    public void DisplayFriends()
    {
        Node temp = Head;
        if (temp == null)
        {
            Console.WriteLine("No Friends Found!");
            return;
        }

        while (temp != null)
        {
            Console.WriteLine($"{temp.Data.Name} (ID: {temp.Data.UserId})");
            temp = temp.Next;
        }
    }

    public int CountFriends()
    {
        int count = 0;
        Node temp = Head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        return count;
    }
}

// Social Network Class (List-Based Storage)
public class SocialNetwork
{
    private List<User> users; // List to store users

    public SocialNetwork()
    {
        users = new List<User>();
    }

    public void AddUser(int userId, string name, int age)
    {
        if (FindUserById(userId) == null)
        {
            users.Add(new User(userId, name, age));
            Console.WriteLine($"{name} added successfully!");
        }
        else
        {
            Console.WriteLine("User ID already exists!");
        }
    }

    private User FindUserById(int userId)
    {
        foreach (User user in users)
        {
            if (user.UserId == userId)
                return user;
        }
        return null;
    }

    public void AddFriendConnection(int userId1, int userId2)
    {
        User user1 = FindUserById(userId1);
        User user2 = FindUserById(userId2);

        if (user1 != null && user2 != null)
        {
            if (!user1.Friends.IsFriend(userId2))
            {
                user1.Friends.AddFriend(user2);
                user2.Friends.AddFriend(user1);
                Console.WriteLine($"Friendship added between {user1.Name} and {user2.Name}");
            }
            else
            {
                Console.WriteLine("They are already friends!");
            }
        }
        else
        {
            Console.WriteLine("One or both users not found!");
        }
    }

    public void RemoveFriendConnection(int userId1, int userId2)
    {
        User user1 = FindUserById(userId1);
        User user2 = FindUserById(userId2);

        if (user1 != null && user2 != null)
        {
            user1.Friends.RemoveFriend(userId2);
            user2.Friends.RemoveFriend(userId1);
            Console.WriteLine($"Friendship removed between {user1.Name} and {user2.Name}");
        }
        else
        {
            Console.WriteLine("One or both users not found!");
        }
    }

    public void FindMutualFriends(int userId1, int userId2)
    {
        User user1 = FindUserById(userId1);
        User user2 = FindUserById(userId2);

        if (user1 != null && user2 != null)
        {
            Node temp1 = user1.Friends.Head;
            HashSet<int> set = new HashSet<int>();

            while (temp1 != null)
            {
                set.Add(temp1.Data.UserId);
                temp1 = temp1.Next;
            }

            Node temp2 = user2.Friends.Head;
            List<int> mutualFriends = new List<int>();

            while (temp2 != null)
            {
                if (set.Contains(temp2.Data.UserId))
                    mutualFriends.Add(temp2.Data.UserId);
                temp2 = temp2.Next;
            }

            if (mutualFriends.Count > 0)
            {
                Console.WriteLine("Mutual Friends:");
                foreach (int friendId in mutualFriends)
                    Console.WriteLine($"{FindUserById(friendId).Name} (ID: {friendId})");
            }
            else
            {
                Console.WriteLine("No mutual friends found.");
            }
        }
        else
        {
            Console.WriteLine("One or both users not found!");
        }
    }

    public void DisplayFriends(int userId)
    {
        User user = FindUserById(userId);
        if (user != null)
        {
            Console.WriteLine($"Friends of {user.Name}:");
            user.Friends.DisplayFriends();
        }
        else
        {
            Console.WriteLine("User not found!");
        }
    }

    // Simplified SearchUser method
    public void SearchUser(string query)
    {
        foreach (User user in users)
        {
            if (user.Name.Contains(query) || user.UserId.ToString() == query)
            {
                Console.WriteLine($"User Found: {user.Name} (ID: {user.UserId}), Age: {user.Age}");
                return;
            }
        }
        Console.WriteLine("User not found!");
    }

    public void CountFriends(int userId)
    {
        User user = FindUserById(userId);
        if (user != null)
        {
            Console.WriteLine($"{user.Name} has {user.Friends.CountFriends()} friends.");
        }
        else
        {
            Console.WriteLine("User not found!");
        }
    }
}

// Driver Code
public class Program
{
    public static void Main()
    {
        SocialNetwork network = new SocialNetwork();

        // Adding Users
        network.AddUser(1, "Aarushi", 22);
        network.AddUser(2, "Rohan", 23);
        network.AddUser(3, "Meera", 21);
        network.AddUser(4, "Aryan", 24);

        // Adding Friendships
        network.AddFriendConnection(1, 2);
        network.AddFriendConnection(1, 3);
        network.AddFriendConnection(2, 4);
        network.AddFriendConnection(3, 4);

        // Displaying Friends
        network.DisplayFriends(1);
        network.DisplayFriends(2);

        // Finding Mutual Friends
        network.FindMutualFriends(1, 4);

        // Searching Users
        network.SearchUser("Meera");

        // Counting Friends
        network.CountFriends(1);

        // Removing Friendship
        network.RemoveFriendConnection(1, 3);
        network.DisplayFriends(1);
        Console.ReadLine();
    }
}
*/