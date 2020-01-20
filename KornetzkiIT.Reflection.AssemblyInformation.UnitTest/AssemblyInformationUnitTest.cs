using System;
using System.Reflection;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using KornetzkiIT.Reflection.AssemblyInformation;

namespace KornetzkiIT.Reflection.AssemblyInformation.UnitTest
{
    [TestClass]
    public class AssemblyInformationUnitTest
    {
        [TestMethod]
        public void EntryAssemblyTest()
        {
            Assert.AreEqual(
                Assembly.GetEntryAssembly(),
                AssemblyInformation.EntryAssembly.TargetAssembly,
                "EntryAssembly returns the entry assembly."
            );
        }

        [TestMethod]
        public void CallingAssemblyTest()
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();

            Assert.AreEqual(
                thisAssembly,
                (new AssemblyInformation()).TargetAssembly,
                "new AssemblyInformation() target assembly is correct."
            );

            Assert.AreEqual(
                thisAssembly,
                (new AssemblyInformation(thisAssembly)).TargetAssembly,
                "new AssemblyInformation(Assembly) target assembly is correct."
            );
        }

        [TestMethod]
        public void PropertiesTest()
        {
            AssemblyInformation info = new AssemblyInformation();

            Assert.AreEqual(
                new Guid("4ee3d577-3c6e-41bf-a897-5d61fa2338de"),
                info.Guid,
                "Returns expected value for Guid"
            );

            Assert.AreEqual(
                "KornetzkiIT.Reflection.AssemblyInformation",
                info.Product,
                "Returns expected value for Product"
            );

            Assert.AreEqual(
                "KornetzkiIT.Reflection.AssemblyInformation.UnitTest",
                info.Title,
                "Returns expected value for Title"
            );

            Assert.AreEqual(
                "Unit tests for KornetzkiIT.Reflection.AssemblyInformation",
                info.Description,
                "Returns expected value for Description"
            );

            Assert.AreEqual(
                "Kornetzki IT",
                info.Company,
                "Returns expected value for Company"
            );

            Assert.AreEqual(
                "Copyright © 2019-2020 Sören Kornetzki",
                info.Copyright,
                "Returns expected value for Copyright"
            );

            Assert.AreEqual(
                "",
                info.Trademark,
                "Returns expected value for Trademark"
            );

            Assert.AreEqual(
                null,
                info.Culture,
                "Returns expected value for Culture"
            );

            Assert.AreEqual(
                new CultureInfo("en-US"),
                info.NeutralResourcesLanguage,
                "Returns expected value for Culture"
            );

            Assert.IsNotNull(
                info.Configuration,
                "Returns expected value for Configuration"
            );

            Assert.AreEqual(
                false,
                info.ComVisible,
                "Returns expected value for ComVisible"
            );

            Assert.AreEqual(
                false,
                info.CLSCompliant,
                "Returns expected value for CLSCompliant"
            );

            Assert.AreEqual(
                new Version("0.1.0.2"),
                info.Version,
                "Returns expected value for Version"
            );

            Assert.AreEqual(
                new Version("0.1.0.2"),
                info.FileVersion,
                "Returns expected value for FileVersion"
            );

            Assert.AreEqual(
                "0.1.0-alpha.2",
                info.InformationalVersion,
                "Returns expected value for InformationalVersion"
            );

        }
    }
}
