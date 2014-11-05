using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mamSearchAndRetrieval;
using mamSearchAndRetrieval.Controllers;
using mamSearchAndRetrieval.Models.Ipmam;
using mamSearchAndRetrieval.Models;
using System.Net.Http;
using System.Web;

namespace mamSearchAndRetrieval.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Auth()
        {
            // Arrange
            const string expectedViewName = "LogIn";
            AuthController controller = new AuthController();

            // Act
            ViewResult result = controller.LogIn("") as ViewResult;

            // Assert
            Assert.IsNotNull(result, "Should have returned a ViewResult");
            Assert.AreEqual(expectedViewName, result.ViewName, "View name should have been {0}", expectedViewName);
        }
        [TestMethod]
        public void Login()
        {
            // Arrange
            //const string expectedViewName = "LogIn";
            var controller = new AuthController();

            //HttpRequest Request = new HttpRequest();
            
            //controller.Request = new HttpRequestMessage();
            //controller.Configuration = new HttpConfiguration();

            LogInModel loginModel = new LogInModel
            {
                Username = "BMcfarland",
                Password = "",
                ReturnUrl = ""
            };

            // Act
            ViewResult result = controller.LogIn(loginModel) as ViewResult;

            // Assert
            //Assert.IsNotNull(result, "Should have returned a ViewResult");
            //Assert.AreEqual(expectedViewName, result.ViewName, "View name should have been {0}", expectedViewName);
        }
    }
}
