using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractices.Data
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public int PersonId { get; set; }
        public PersonRole PersonRole { get; set; }




        public static IEnumerable<Person> GetPeopleData()
        {
            var collection = new List<Person>();

            collection.Add(new Person()
            {
                FirstName = "Thomas",
                PersonRole = PersonRole.Developer,
                Email = "test@test.com",
                IsActive = true,
                LastName = "Test",
                PersonId = 23,
                PhoneNumber = "111-111-1111"
            });

            collection.Add(new Person()
            {
                FirstName = "Sally",
                PersonRole = PersonRole.Customer,
                Email = "sally@test.com",
                IsActive = true,
                LastName = "Test",
                PersonId = 21,
                PhoneNumber = "222-111-1111"
            });

            collection.Add(new Person()
            {
                FirstName = "John",
                PersonRole = PersonRole.Doctor,
                Email = "John@test.com",
                IsActive = false,
                LastName = "Test",
                PersonId = 18,
                PhoneNumber = "222-333-1111"
            });

            collection.Add(new Person()
            {
                FirstName = "Sheng",
                PersonRole = PersonRole.Doctor,
                Email = "Shen@test.com",
                IsActive = false,
                LastName = "Test",
                PersonId = 16,
                PhoneNumber = "222-333-5555"
            });

            collection.Add(new Person()
            {
                FirstName = "Thomas",
                PersonRole = PersonRole.Developer,
                Email = "test@test.com",
                IsActive = true,
                LastName = "Test",
                PersonId = 23,
                PhoneNumber = "111-111-1111"
            });

            collection.Add(new Person()
            {
                FirstName = "Sally",
                PersonRole = PersonRole.Customer,
                Email = "sally@test.com",
                IsActive = true,
                LastName = "Test",
                PersonId = 21,
                PhoneNumber = "222-111-1111"
            });

            collection.Add(new Person()
            {
                FirstName = "John",
                PersonRole = PersonRole.Doctor,
                Email = "John@test.com",
                IsActive = false,
                LastName = "Test",
                PersonId = 18,
                PhoneNumber = "222-333-1111"
            });

            collection.Add(new Person()
            {
                FirstName = "Sheng",
                PersonRole = PersonRole.Doctor,
                Email = "Shen@test.com",
                IsActive = false,
                LastName = "Test",
                PersonId = 16,
                PhoneNumber = "222-333-5555"
            });

            return collection;



        }





    }

    public enum PersonRole
    {
        Doctor,
        Developer,
        Customer

    }




}
