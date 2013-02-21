using Shinetech.TianJin.VpnAddressTracer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinetech.TianJin.VpnAddressTracer.Tests
{
    internal class FakeVpnAddressProviderFactory : IVpnAddressProviderFactory
    {
        public IVpnAddressProvider GetVpnAddressProvider() {
            return new FakeVpnAddressProvider();
        }
    }
}
