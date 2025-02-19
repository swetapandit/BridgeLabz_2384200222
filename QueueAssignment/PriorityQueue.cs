/*using System;
using System.Collections.Generic;

namespace Collection
{
    public class HospitalTriage
    {
        public static void TreatPatients(List<(string name, int severity)> patients)
        {
            PriorityQueue<(string name, int severity), int> priorityQueue = new PriorityQueue<(string, int), int>();

            foreach (var patient in patients)
            {
                priorityQueue.Enqueue(patient, -patient.severity); // Negative for max-heap
            }

            Console.WriteLine("Order of Treatment:");
            while (priorityQueue.Count > 0)
            {
                var patient = priorityQueue.Dequeue();
                Console.WriteLine(patient.name);
            }
        }

        public static void Main()
        {
            List<(string name, int severity)> patients = new List<(string, int)>
            {
                ("John", 3),
                ("Alice", 5),
                ("Bob", 2)
            };

            TreatPatients(patients);

            Console.ReadLine();
        }
    }
}
*/