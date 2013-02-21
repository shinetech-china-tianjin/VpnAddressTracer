using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shinetech.TianJin.VpnAddress.Tracer
{
    internal class GitHubRawPageProvider : IVpnAddressProvider
    {
        private const string VpnAddressPublishPageUrl = "https://raw.github.com/shinetech-china-tianjin/VpnAddressTracer/master/vpn.address";

        public IPAddress ParseVpnAddress() {
            var request = HttpWebRequest.Create(VpnAddressPublishPageUrl);
            var response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream())) {
                var newestVpnAddressRaw = reader.ReadLine();
                return IPAddress.Parse(newestVpnAddressRaw);
            }
        }
    }
}
