using System;
using System.Collections.Generic;
using System.Linq;
using BlazorPagesTest.Models;

namespace BlazorPagesTest.Data
{
    public static class TestData
    {
        public static ICollection<Student> Students { get; } = Enumerable.Range(1, 10)
           .Select(i => new Student
           {
               Name = $"Name-{i}",
               Surname = $"Surname-{i}",
               Patronymic = $"Patronymic-{i}",
               Birthday = DateTime.Now.Subtract(TimeSpan.FromDays(260 * (i + 18)))
           })
           .ToList();
    }
}
