using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    class ReferenceTypeTests
    {
        [TestMethod]
        public void variablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Scott's Grade Book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
