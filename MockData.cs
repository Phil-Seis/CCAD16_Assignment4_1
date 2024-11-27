using System;
using System.Collections.Generic;

namespace CCAD16_Assignment4_1
{
    public static class MockData
    {
        // Correct static method to create and return data
        public static Dictionary<string, Person> CreateData()
        {
            Dictionary<string, Person> persons = new Dictionary<string, Person>();

            Person person1 = new Person
            {
                FirstName = "Philip",
                LastName = "Seisman",
                MobilePhone = "900-265-2578",
                WorkPhone = "585-551-4045",
                Address = "181 Sycamore Rd."
            };
            persons.Add(person1.FullName, person1);

            Person person2 = new Person
            {
                FirstName = "Jane",
                LastName = "Doe",
                MobilePhone = "850-555-1234",
                WorkPhone = "850-555-5678",
                Address = "123 Main St."
            };
            persons.Add(person2.FullName, person2);

            Person person3 = new Person
            {
                FirstName = "Flavor",
                LastName = "Flav",
                MobilePhone = "900-265-2578",
                WorkPhone = "585-533-4445",
                Address = "184 Sycamore Rd."
            };
            persons.Add(person3.FullName, person3);


            Person person4 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                MobilePhone = "800-555-1234",
                WorkPhone = "800-555-5678",
                Address = "345 Main St."
            };
            persons.Add(person4.FullName, person4);

            return persons;
        }
    }
}
