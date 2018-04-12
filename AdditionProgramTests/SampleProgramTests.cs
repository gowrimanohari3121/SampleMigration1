using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionProgram.Tests
{
    [TestClass()]
    public class SampleProgramTests
    {
        [TestMethod()]
        public void sumTest()
        {
            SampleProgram sp = new SampleProgram();

            Assert.AreEqual(4, sp.sum(2, 2));

        }
    }
}