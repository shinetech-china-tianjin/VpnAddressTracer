﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shinetech.TianJin.VpnAddress.Tracer
{
    public interface IVpnAddressProvider
    {
        IPAddress ParseVpnAddress();
    }
}
