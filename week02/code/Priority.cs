using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Bob 2, Tim 5, And Sue 3.
        // Expected Result: Tim, Sue, Bob, Error, Error
        Console.WriteLine("Test 1");
        var players = new PriorityQueue();
        players.Enqueue("Bob", 2);
        players.Enqueue("Tim", 5);
        players.Enqueue("Sue", 3);
        for (int i = 0; i < 5; i++) {
            Console.WriteLine(players.Dequeue());
        }
        // Defect(s) Found: didn't remove items

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Bob 5, Tim 5, And Sue 6.
        // Expected Result: Sue, Bob, Tim
        Console.WriteLine("Test 2");
        players.Enqueue("Bob", 5);
        players.Enqueue("Tim", 5);
        players.Enqueue("Sue", 6);
        for (int i = 0; i < 3; i++) {
            Console.WriteLine(players.Dequeue());
        }
        // Defect(s) Found: Players Displayed In Incorrect Order

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}