using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shinetech.TianJin.VpnAddress.Tracer;

namespace Shinetech.TianJin.VpnAddressTracer.Tests
{
    [TestClass]
    public class VpnAddressRetrieverTest
    {
        [TestMethod]
        public void DefaultProviderTest() {
            var retriever = new VpnAddressRetriever();
            var newestIpAddress = retriever.GetVpnAddress();

            Assert.AreEqual(newestIpAddress, TestingHelper.VpnTestAddressOnGitHub);
        }

        [TestMethod]
        public void FakeProviderTest() {
            var retriever = new VpnAddressRetriever(new FakeVpnAddressProviderFactory());

            var newestIpAddress = retriever.GetVpnAddress();

            Assert.AreEqual(newestIpAddress, TestingHelper.FakeVpnAddress);
        }
    }
}
