using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace KawataSwitcher
{
    class CertificateManager
    {
        public Task<bool> GetStatusAsync()
        {
            return Task.Run<bool>(() => GetStatus());
        }

        public void Install()
        {
            var store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadWrite);

            var certificate = new X509Certificate2(KawataSwitcher.Properties.Resources.cert);
            store.Add(certificate);

            store.Close();
        }

        public void Uninstall()
        {
            X509Store store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadWrite);
                foreach (X509Certificate2 c in store.Certificates.Find(X509FindType.FindBySubjectName, "*.ppy.sh", true))
                    store.Remove(c);
            }
            finally
            {
                store.Close();
            }
        }

        public bool GetStatus()
        {
            var store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            var c = store.Certificates.Find(X509FindType.FindBySubjectName, "*.ppy.sh", true);
            bool result = c.Count >= 1;

            store.Close();

            return result;
        }
    }
}
