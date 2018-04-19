﻿using AutoMoqCore;
using CleanArchitecture.Core.Application.Customers.Queries.GetCustomerList;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Core.Presentation.Admin.Customers
{
    [TestFixture]
    public class CustomersControllerTests
    {
        private CustomersController _controller;
        private AutoMoqer _mocker;
        private CustomerModel _model;

        [SetUp]
        public void SetUp()
        {
            _model = new CustomerModel();

            _mocker = new AutoMoqer();

            _mocker.GetMock<IGetCustomersListQuery>()
                .Setup(p => p.Execute())
                .Returns(new List<CustomerModel> { _model });

            _controller = _mocker.Create<CustomersController>();
        }

        [Test]
        public void TestGetIndexShouldReturnListOfCustomers()
        {
            var viewResult = _controller.Index();

            var result = (List<CustomerModel>)viewResult.Model;

            Assert.That(result.Single(), Is.EqualTo(_model));
        }
    }
}
