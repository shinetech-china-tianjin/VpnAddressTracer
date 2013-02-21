using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinetech.TianJin.VpnAddress.Tracer
{
    internal class DefaultVpnAddressProviderFactory: IVpnAddressProviderFactory
    {
        public IVpnAddressProvider GetVpnAddressProvider() {
            return new GitHubRawPageProvider();
        }
    }
}
