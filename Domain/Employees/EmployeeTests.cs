﻿using NUnit.Framework;

namespace CleanArchitecture.Core.Domain.Employees
{
    [TestFixture]
    public class EmployeeTests
    {
        private readonly Employee _employee;
        private const int Id = 1;
        private const string Name = "Employee1";

        public EmployeeTests()
        {
            _employee = new Employee();
        }

        [Test]
        public void TestSetAndGetId()
        {
            _employee.Id = Id;

            Assert.That(_employee.Id, Is.EqualTo(Id));
        }

        [Test]
        public void TestSetAndGetName()
        {
            _employee.Name = Name;

            Assert.That(_employee.Name, Is.EqualTo(Name));
        }
    }
}