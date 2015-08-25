using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Tutorial.Controllers;
using System.Web.Mvc;

namespace TDD_Tutorial.Specs.TDD_Tutorial.Web.Controllers
{
    [TestFixture]
    public class HomeControllerSpecs
    {
        [Test]
        public void index_action_returns_a_view_result()
        {
            var sut = new HomeController();

            var result = sut.Index();

            Assert.That(result, Is.TypeOf<ViewResult>());

        }

        [Test]
        public void index_action_says_hello_world()
        {
            var sut = new HomeController();

            sut.ViewBag.Message = "Hello World!";

            Assert.That(sut.ViewBag.Message, Is.EqualTo("Hello World!"));

        }
    }
}
