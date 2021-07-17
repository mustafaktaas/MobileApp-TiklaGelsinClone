using Microsoft.VisualStudio.TestTools.UnitTesting;
using xamarintiklagelsin.ViewModels;

namespace TestTiklaGelsin
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ///Arrange
            var vm = new LoginViewModel();
            vm.Username = "admin";

            //Act

            vm.LoginCommand.Execute(null);


            // Assert

            Assert.IsTrue(vm.Username == "admin1", "Hata");
        }
    }
}
