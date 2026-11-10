using System;
using System.IO;
#if DNXCORE50
using Xunit;
using Test = Xunit.FactAttribute;
using Assert = Newtonsoft.Json.Tests.XUnitAssert;
#else
using NUnit.Framework;
#endif

namespace Newtonsoft.Json.Tests.Issues
{
    [TestFixture]
    public class Issue3118 : TestFixtureBase
    {
        [Test]
        public void Readme_IncludesDotNetMatrixLink()
        {
            string readmePath = ResolvePath("README.md");

            Assert.IsTrue(File.Exists(readmePath), "Expected README.md to be copied to the test output directory.");

            string readme = File.ReadAllText(readmePath);

            Assert.IsTrue(
                readme.IndexOf("https://matrix.dev-team.org/?category=json-serialization&library=Newtonsoft.Json", StringComparison.Ordinal) >= 0,
                "Expected the README to link to the Newtonsoft.Json .NET Matrix comparison.");
        }
    }
}
