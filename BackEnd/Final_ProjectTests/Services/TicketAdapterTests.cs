using Microsoft.VisualStudio.TestTools.UnitTesting;
using Final_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Final_Project.Repositories;

namespace Final_Project.Services.Tests
{
    [TestClass()]
    public class TicketAdapterTests
    {
        [AssemblyInitialize]
        public static void AssemBlyInitialize(TestContext context)
        {

        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {

        }

        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestMethod()]
        public void BindTest()
        {
            var repositoryMock = new Mock<TicketRepository>();

            repositoryMock.Setup(r => r.Get(1)).Returns(new Models.Ticket { TicketId = 1 });

            var sut = new TicketAdapter(repositoryMock.Object);
        }
    }
}