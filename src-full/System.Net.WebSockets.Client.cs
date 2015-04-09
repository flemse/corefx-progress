namespace System.Net.WebSockets {
  public sealed class ClientWebSocket : WebSocket {
    public ClientWebSocket();
    public override Nullable<WebSocketCloseStatus> CloseStatus { get; }
    public override string CloseStatusDescription { get; }
    public ClientWebSocketOptions Options { get; }
    public override WebSocketState State { get; }
    public override string SubProtocol { get; }
    public override void Abort();
    public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);
    public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken);
    public Task ConnectAsync(Uri uri, CancellationToken cancellationToken);
    public override void Dispose();
    public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken);
    public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken);
  }
  public sealed class ClientWebSocketOptions {
    public X509CertificateCollection ClientCertificates { get; set; }
    public CookieContainer Cookies { get; set; }
    public ICredentials Credentials { get; set; }
    public TimeSpan KeepAliveInterval { get; set; }
    public IWebProxy Proxy { get; set; }
    public void AddSubProtocol(string subProtocol);
    public void SetRequestHeader(string headerName, string headerValue);
  }
}
