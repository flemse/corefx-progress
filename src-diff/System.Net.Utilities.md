```diff
---lib-full\System.Net.Utilities.dll
+++lib-oss\System.Net.Utilities.dll
-namespace System.Net.NetworkInformation {
- public enum IPStatus {
-   BadDestination = 11018,
-   BadHeader = 11042,
-   BadOption = 11007,
-   BadRoute = 11012,
-   DestinationHostUnreachable = 11003,
-   DestinationNetworkUnreachable = 11002,
-   DestinationPortUnreachable = 11005,
-   DestinationProhibited = 11004,
-   DestinationProtocolUnreachable = 11004,
-   DestinationScopeMismatch = 11045,
-   DestinationUnreachable = 11040,
-   HardwareError = 11008,
-   IcmpError = 11044,
-   NoResources = 11006,
-   PacketTooBig = 11009,
-   ParameterProblem = 11015,
-   SourceQuench = 11016,
-   Success = 0,
-   TimedOut = 11010,
-   TimeExceeded = 11041,
-   TtlExpired = 11013,
-   TtlReassemblyTimeExceeded = 11014,
-   Unknown = -1,
-   UnrecognizedNextHeader = 11043,
  }
- public class Ping : IDisposable {
-   public Ping();
-   public void Dispose();
-   protected virtual void Dispose(bool disposing);
-   public PingReply Send(IPAddress address);
-   public PingReply Send(IPAddress address, int timeout);
-   public PingReply Send(IPAddress address, int timeout, byte[] buffer);
-   public PingReply Send(IPAddress address, int timeout, byte[] buffer, PingOptions options);
-   public PingReply Send(string hostNameOrAddress);
-   public PingReply Send(string hostNameOrAddress, int timeout);
-   public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer);
-   public PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options);
-   public Task<PingReply> SendPingAsync(IPAddress address);
-   public Task<PingReply> SendPingAsync(IPAddress address, int timeout);
-   public Task<PingReply> SendPingAsync(IPAddress address, int timeout, byte[] buffer);
-   public Task<PingReply> SendPingAsync(IPAddress address, int timeout, byte[] buffer, PingOptions options);
-   public Task<PingReply> SendPingAsync(string hostNameOrAddress);
-   public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout);
-   public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer);
-   public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options);
  }
- public class PingException : InvalidOperationException {
-   public PingException(string message);
-   public PingException(string message, Exception innerException);
  }
- public class PingOptions {
-   public PingOptions();
-   public PingOptions(int ttl, bool dontFragment);
-   public bool DontFragment { get; set; }
-   public int Ttl { get; set; }
  }
- public class PingReply {
-   public IPAddress Address { get; }
-   public byte[] Buffer { get; }
-   public PingOptions Options { get; }
-   public long RoundtripTime { get; }
-   public IPStatus Status { get; }
  }
 }
```
