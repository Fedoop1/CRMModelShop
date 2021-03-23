using Microsoft.VisualStudio.TestTools.UnitTesting;
using crmBI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI.Model.Tests
{
    [TestClass()]
    public class ShopComputerModelTests
    {
        [TestMethod()]
        public void ShopComputerModelTest()
        {
            ShopComputerModel shopComputerModel = new ShopComputerModel();

            shopComputerModel.Start();
        }

        
    }
}