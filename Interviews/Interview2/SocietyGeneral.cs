using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interviews.Interview_4
{
    //    Write a program in C#  
    //We have n no.of wires in a box.
    //Each wire having 3 properies : start, end and length.
    //Constraint : Each wire having start/end as male/female and only male to female and its vice-versa is allowed.
    //How to connect wires which will result in longest wire length.

    public enum ConnectorType
    {
        Male,
        Female
    }

    public class Wire
    {
        public string Id { get; set; } = "";
        public ConnectorType Start { get; set; }
        public ConnectorType End { get; set; }
        public int Length { get; set; }
    }

    public class WireProblem
    {
        static int maxLength = 0;
        static List<Wire> bestPath = new();

        public void Main()
        {
            var wires = new List<Wire>
        {
            new() { Id = "W1", Start = ConnectorType.Male,   End = ConnectorType.Female, Length = 10 },
            new() { Id = "W2", Start = ConnectorType.Female, End = ConnectorType.Male,   Length = 15 },
            new() { Id = "W3", Start = ConnectorType.Male,   End = ConnectorType.Female, Length = 20 },
            new() { Id = "W4", Start = ConnectorType.Female, End = ConnectorType.Male,   Length = 25 }
        };

            FindLongestConnection(wires);

            Console.WriteLine($"Maximum Length = {maxLength}");
            Console.WriteLine("Path:");

            foreach (var wire in bestPath)
            {
                Console.WriteLine($"{wire.Id} ({wire.Length})");
            }
        }

        static void FindLongestConnection(List<Wire> wires)
        {
            foreach (var wire in wires)
            {
                var used = new HashSet<string> { wire.Id };
                DFS(wire, wires, used, wire.Length, new List<Wire> { wire });
            }
        }

        static void DFS(
            Wire current,
            List<Wire> wires,
            HashSet<string> used,
            int totalLength,
            List<Wire> path)
        {
            if (totalLength > maxLength)
            {
                maxLength = totalLength;
                bestPath = new List<Wire>(path);
            }

            foreach (var next in wires)
            {
                if (used.Contains(next.Id))
                    continue;

                if (current.End == next.Start)
                {
                    used.Add(next.Id);
                    path.Add(next);

                    DFS(
                        next,
                        wires,
                        used,
                        totalLength + next.Length,
                        path);

                    path.RemoveAt(path.Count - 1);
                    used.Remove(next.Id);
                }
            }
        }
    }
}
