using System;
using System.Collections.Generic;

using BenchmarkMapping.Models;

namespace BenchmarkMapping
{
    public static class DataGenerator
    {
        public static List<SourceClass> GenerateSources(int count)
        {
            var list = new List<SourceClass>(count);
            for (int i = 0; i < count; i++)
            {
                list.Add(new SourceClass
                {
                    Id = i,
                    Name = $"Name {i}",
                    Value = i * 0.5,
                    CreatedAt = DateTime.Now,
                    IsActive = i % 2 == 0,
                    Price = i * 10,
                    Count = i * 100,
                    Identifier = Guid.NewGuid(),
                    Ratio = i / 100f,
                    Description = $"Description {i}"
                });
            }
            return list;
        }
    }
}
