using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinetech.TianJin.VpnAddress.Tracer
{
    public interface IVpnAddressProviderFactory
    {
        IVpnAddressProvider GetVpnAddressProvider();
    }
}
