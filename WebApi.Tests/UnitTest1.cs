using FluentAssertions;
using System;
using WebApi.Controllers;
using Xunit;

namespace WebApi.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void HiHelloController_should_be_able_to_reply_to_hi_with_hello()
        {
            var hiHelloController = new HiHelloController();
            hiHelloController.Get("hi").Value.Should().Be("hello");
        }

        [Fact]
        public void HiHelloController_should_be_able_to_reply_to_hello_with_hi()
        {
            var hiHelloController = new HiHelloController();
            hiHelloController.Get("hello").Value.Should().Be("hi");
        }
    }
}
