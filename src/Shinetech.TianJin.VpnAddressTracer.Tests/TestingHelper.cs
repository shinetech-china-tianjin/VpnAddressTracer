using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shinetech.TianJin.VpnAddressTracer.Tests
{
    public class TestingHelper
    {
        public static IPAddress VpnTestAddressOnGitHub {
            get {
                return IPAddress.Parse("10.10.10.98");
            }
        }

        public static IPAddress FakeVpnAddress {
            get {
                return IPAddress.Parse("192.168.123.114");
            }
        }
    }
}
