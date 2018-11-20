using Microsoft.VisualStudio.TestTools.UnitTesting;
using mscheck2G1;

namespace mscheck2G1UnitTest
{
    [TestClass]
    public class Ex2GUnitTests
    {
        [TestMethod]
        public void TestSwitch01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.Switch01("R"));
        }
        [TestMethod]
        public void TestSwitch01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.Switch01("C"));
        }
        [TestMethod]
        public void TestSwitch01Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.Switch01("Z"));
        }
        [TestMethod]
        public void TestIf01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.IF01("R"));
        }
        [TestMethod]
        public void TestIf01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.IF01("C"));
        }
        [TestMethod]
        public void TestIf01Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.IF01("Z"));
        }
        [TestMethod]
        public void TestElseIf01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.ElseIF01("R"));
        }
        [TestMethod]
        public void TestElseIf01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.ElseIF01("C"));
        }
        [TestMethod]
        public void TestElseIf01Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.ElseIF01("Z"));
        }
        [TestMethod]
        public void TestNestedIfElse01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.NestedIF01("R"));
        }
        [TestMethod]
        public void TestNestedIfElse01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.NestedIF01("C"));
        }
        [TestMethod]
        public void TestNestedIfElse01Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.NestedIF01("Z"));
        }
        [TestMethod]
        public void TestSwitchDefault01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.SwitchDefault01("R"));
        }
        [TestMethod]
        public void TestSwitchDefault01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.SwitchDefault01("C"));
        }
        [TestMethod]
        public void TestSwitchDefault01Z()
        {
            Assert.AreEqual("0.0", Ex2gCalculations.SwitchDefault01("Z"));
        }
        [TestMethod]
        public void TestIfDefault01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.SwitchDefault01("R"));
        }
        [TestMethod]
        public void TestIfDefault01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.SwitchDefault01("C"));
        }
        [TestMethod]
        public void TestIfDefault01Z()
        {
            Assert.AreEqual("0.0", Ex2gCalculations.SwitchDefault01("Z"));
        }
        [TestMethod]
        public void TestElseIfDefault01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.ElseIF02("R"));
        }
        [TestMethod]
        public void TestElseIfDefault01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.ElseIF02("C"));
        }
        [TestMethod]
        public void TestElseIfDefault01Z()
        {
            Assert.AreEqual("0.0", Ex2gCalculations.ElseIF02("Z"));
        }
        [TestMethod]
        public void TestNestedIfElseDefault01R()
        {
            Assert.AreEqual("0.1", Ex2gCalculations.NestedIF02("R"));
        }
        [TestMethod]
        public void TestNestedIfElseDefault01C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.NestedIF02("C"));
        }
        [TestMethod]
        public void TestNestedIfElseDefault01Z()
        {
            Assert.AreEqual("0.0", Ex2gCalculations.NestedIF02("Z"));
        }
        [TestMethod]
        public void TestSwitch02R()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.Switch02("R"));
        }
        [TestMethod]
        public void TestSwitch02C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.Switch02("C"));
        }
        [TestMethod]
        public void TestSwitch02T()
        {
            Assert.AreEqual("0.4", Ex2gCalculations.Switch02("T"));
        }
        [TestMethod]
        public void TestSwitch02Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.Switch02("Z"));
        }
        [TestMethod]
        public void TestIf02R()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.If2("R"));
        }
        [TestMethod]
        public void TestIf02C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.If2("C"));
        }
        [TestMethod]
        public void TestIf02T()
        {
            Assert.AreEqual("0.4", Ex2gCalculations.If2("T"));
        }
        [TestMethod]
        public void TestIf02Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.If2("Z"));
        }
        [TestMethod]
        public void TestElseIf02R()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.ElseIf2("R"));
        }
        [TestMethod]
        public void TestElseIf02C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.ElseIf2("C"));
        }
        [TestMethod]
        public void TestElseIf02T()
        {
            Assert.AreEqual("0.4", Ex2gCalculations.ElseIf2("T"));
        }
        [TestMethod]
        public void TestElseIf02Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.ElseIf2("Z"));
        }
        [TestMethod]
        public void TestNestedIfElse02R()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.NestedIfElse2("R"));
        }
        [TestMethod]
        public void TestNestedIfElse02C()
        {
            Assert.AreEqual("0.2", Ex2gCalculations.NestedIfElse2("C"));
        }
        [TestMethod]
        public void TestNestedIfElse02T()
        {
            Assert.AreEqual("0.4", Ex2gCalculations.NestedIfElse2("T"));
        }
        [TestMethod]
        public void TestNestedIfElse02Z()
        {
            Assert.AreEqual("-1.0", Ex2gCalculations.NestedIfElse2("Z"));
        }
    }
}
