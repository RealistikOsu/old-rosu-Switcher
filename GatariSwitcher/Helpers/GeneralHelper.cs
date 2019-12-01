using System.Net;
using System.Threading.Tasks;

namespace KawataSwitcher
{
    static class GeneralHelper
    {
        public async static Task<string> GetKawataAddressAsync()
        {
            using (var webClient = new WebClient())
            {
                string result = string.Empty;
                try
                {
                    var line = await webClient.DownloadStringTaskAsync(Constants.KawataIpApiAddress);
                    result = line;
                }
                catch { }
                return result.Trim();
            }
        }
    }
}