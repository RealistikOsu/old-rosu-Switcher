namespace KawataSwitcher
{
    public class Constants
    {
        // Use this address if we cannot grab from ips.txt
        public const string KawataHardcodedIp = "95.179.225.194";

        // Grab address from here when possible
        public const string KawataIpApiAddress = "https://old.kitosu.cf/ips.php";

        public const string UiInstallCertificate = "Install certificate";

        public const string UiUninstallCertificate = "Uninstall certificate";

        public const string UiYouArePlayingOnKawata = "Connected to RealistikOsu!";

        public const string UiYouArePlayingOnOfficial = "Connected to Bancho";

        public const string UiSwitchToKawata = "Connect to RealistikOsu!";

        public const string UiSwitchToOfficial = "Connect to Bancho!";

        public const string UiUpdatingStatus = "Receiving IP adress of RealistikOsu";
    }
}
