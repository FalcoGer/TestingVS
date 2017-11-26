using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/* make sure to include the tested project as reference in the test project.
to test private methods:
https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.testtools.unittesting.privateobject.aspx

Class target = new Class();
PrivateObject obj = new PrivateObject(target);
var retVal = obj.Invoke("PrivateMethod");
Assert.AreEqual(retVal);
*/
namespace TestingVS.UnitTest
{
    /// <summary>
    /// Class to test the Program class
    /// </summary>
    [TestClass]
    public class ProgramTest
    {
        /// <summary>
        /// Testing the tests
        /// </summary>
        [TestMethod]
        public void When_StateUnderTest_Expect_ExpectedBehavior()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsTrue(true);
        }

        /// <summary>
        /// Tests <see cref="Program.CountTo(int)"/>
        /// </summary>
        [TestMethod]
        public void When_CountingTo25_Expect_ReturnOf25()
        {
            // Arrange
            int expected = 25;
            // Act
            int res = Program.CountTo(expected);
            // Assert
            Assert.AreEqual(expected, res);
        }

        /// <summary>
        /// Tests the static method <see cref="Program.Return4"/>
        /// </summary>
        [TestMethod]
        public void When_CallingPrivateStaticMethodReturn4_Expect_ReturnOf4()
        {
            // Arrange
            PrivateType pt = new PrivateType(typeof(Program));

            int expected = 4;
            // Act
            int res = (int)pt.InvokeStatic("Return4");
            // Assert
            Assert.AreEqual(expected, res);
        }

        /// <summary>
        /// Tests the non-static method <see cref="Program.Return8"/>
        /// </summary>
        [TestMethod]
        public void When_CallingPrivateNonStaticMethodReturn8_Expect_ReturnOf8()
        {
            // Arrange
            Program target = new Program();
            PrivateObject obj = new PrivateObject(target);

            int expected = 8;
            // Act
            int res = (int)obj.Invoke("Return8");
            // Assert
            Assert.AreEqual(expected, res);
        }

        /// <summary>
        /// Tests the overloaded non-static method <see cref="Program.Return8(int)"/>
        /// </summary>
        [TestMethod]
        public void When_CallingOverloadedPrivateNonStaticMethodReturn8_Times2_Expect_ReturnOf16()
        {
            // Arrange
            Program target = new Program();
            PrivateObject obj = new PrivateObject(target);

            int times = 2;
            object[] args = new object[] { times };

            int expected = 16;
            // Act
            int res = (int)obj.Invoke("Return8", args);
            // Assert
            Assert.AreEqual(expected, res);
        }
        /// <summary>
        /// Tests the overloaded non-static method <see cref="Program.Return8(string)"/>
        /// </summary>
        [TestMethod]
        public void When_CallingOverloadedPrivateNonStaticMethodReturn8_String_Expect_ReturnOf16()
        {
            // Arrange
            Program target = new Program();
            PrivateObject obj = new PrivateObject(target);

            string str = "Hi";
            object[] args = new object[] { str };

            string expected = "Eight";
            // Act
            string res = (string)obj.Invoke("Return8", args);
            // Assert
            Assert.AreEqual(expected, res);
        }
    }
}
