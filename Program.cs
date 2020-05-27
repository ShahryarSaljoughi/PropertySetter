using System;
using GenericRevisedExercise.Models;

namespace GenericRevisedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPet = new Dog()
            {
                Age = 3,
                BirthDate = DateTimeOffset.Now.AddYears(-3),
                OwnerName = "Shahryar Saljoughi",
                Race = Race.Bulldog,
            };
            Utility.SetProperty<Dog>(myPet, "Race", "Doberman");
            Utility.SetProperty(myPet, "OwnerName", "Mohsen"); // type argument can be inferred from parameters, so you don't have to write it.
            Utility.SetProperty(myPet, "Age", "2");
            Utility.SetProperty(myPet, "BirthDate", DateTimeOffset.Now.ToString());
            Utility.SetProperty(myPet, "IsMicrochipped", "true");
        }
    }
}
