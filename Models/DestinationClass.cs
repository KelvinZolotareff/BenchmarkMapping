using System;

namespace BenchmarkMapping.Models
{
    public class DestinationClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }
        public long Count { get; set; }
        public Guid Identifier { get; set; }
        public float Ratio { get; set; }

        public string ExtraInfo { get; set; } = "Default";
    }
}
