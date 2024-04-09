using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Bai04_Student
    {
        public string FullName { get; set; }
        public int ID { get; set; }
        public string PhoneNum { get; set; }
        public float C1 { get; set; }
        public float C2 { get; set; }
        public float C3 { get; set; }
        public float Avg { get; set; }
        public override string ToString()
        {
            return $"FullName: {FullName}\n" +
                   $"ID: {ID}\n" +
                   $"PhoneNum: {PhoneNum}\n" +
                   $"C1: {C1}\n" +
                   $"C2: {C2}\n" +
                   $"C3: {C3}\n" +
                   $"Avg: {Avg}\n";

        }
    }
}
