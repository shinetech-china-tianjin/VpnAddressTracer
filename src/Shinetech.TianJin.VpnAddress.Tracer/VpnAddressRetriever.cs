using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shinetech.TianJin.VpnAddress.Tracer
{
    public class VpnAddressRetriever
    {
        private IVpnAddressProviderFactory providerFactory;
        public VpnAddressRetriever(IVpnAddressProviderFactory vpnAddressProviderFactory = null) {
            providerFactory = vpnAddressProviderFactory ?? new DefaultVpnAddressProviderFactory();
        }

        public IPAddress GetVpnAddress() {
            var provider = providerFactory.GetVpnAddressProvider();
            return provider.ParseVpnAddress();
        }
    }
}
