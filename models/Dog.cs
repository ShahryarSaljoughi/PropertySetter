using System;

namespace GenericRevisedExercise.Models
{
    public class Dog
    {
        public Race Race { get; set; }
        public int Age { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string OwnerName { get; set; }
        public bool IsMicrochipped { get; set; }
    }

    public enum Race
    {
        Asian,
        Husky,
        Bulldog,
        Doberman
    }

}