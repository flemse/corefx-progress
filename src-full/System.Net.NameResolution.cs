namespace System.Net {
  public static class Dns {
    public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress);
    public static Task<IPHostEntry> GetHostEntryAsync(IPAddress address);
    public static Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress);
    public static string GetHostName();
  }
  public class IPHostEntry {
    public IPHostEntry();
    public IPAddress[] AddressList { get; set; }
    public string[] Aliases { get; set; }
    public string HostName { get; set; }
  }
}
