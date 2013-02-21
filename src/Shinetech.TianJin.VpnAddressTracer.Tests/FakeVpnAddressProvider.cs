using Shinetech.TianJin.VpnAddress.Tracer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shinetech.TianJin.VpnAddressTracer.Tests
{
    internal class FakeVpnAddressProvider : IVpnAddressProvider
    {
        public IPAddress ParseVpnAddress() {
            return TestingHelper.FakeVpnAddress;
        }
    }
}
