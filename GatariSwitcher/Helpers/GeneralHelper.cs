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
                    result = "95.179.225.194";
                }
                catch { }
                return result.Trim();
            }
        }
    }
}