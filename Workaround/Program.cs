using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround;
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.NationalId = 12345678910;
        person1.FirstName = "BARIŞ";
        person1.LastName = "BEYTUR";
        person1.DateOfBirthYear = 2002;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
    }
}