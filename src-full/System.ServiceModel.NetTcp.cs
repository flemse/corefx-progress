namespace System.ServiceModel {
  public sealed class MessageSecurityOverTcp {
    public MessageSecurityOverTcp();
    public MessageCredentialType ClientCredentialType { get; set; }
  }
  public class NetTcpBinding : Binding {
    public NetTcpBinding();
    public NetTcpBinding(SecurityMode securityMode);
    public NetTcpBinding(string configurationName);
    public EnvelopeVersion EnvelopeVersion { get; }
    public long MaxBufferPoolSize { get; set; }
    public int MaxBufferSize { get; set; }
    public long MaxReceivedMessageSize { get; set; }
    public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
    public override string Scheme { get; }
    public NetTcpSecurity Security { get; set; }
    public TransferMode TransferMode { get; set; }
    public override BindingElementCollection CreateBindingElements();
  }
  public sealed class NetTcpSecurity {
    public NetTcpSecurity();
    public MessageSecurityOverTcp Message { get; set; }
    public SecurityMode Mode { get; set; }
    public TcpTransportSecurity Transport { get; set; }
  }
  public enum TcpClientCredentialType {
    Certificate = 2,
    None = 0,
    Windows = 1,
  }
  public sealed class TcpTransportSecurity {
    public TcpTransportSecurity();
    public TcpClientCredentialType ClientCredentialType { get; set; }
  }
}
namespace System.ServiceModel.Channels {
  public abstract class ConnectionOrientedTransportBindingElement : TransportBindingElement {
    public int ConnectionBufferSize { get; set; }
    public int MaxBufferSize { get; set; }
    public TransferMode TransferMode { get; set; }
    public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
    public override T GetProperty<T>(BindingContext context);
  }
  public class SslStreamSecurityBindingElement : BindingElement {
    public SslStreamSecurityBindingElement();
    public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
    public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
    public override BindingElement Clone();
    public override T GetProperty<T>(BindingContext context);
  }
  public sealed class TcpConnectionPoolSettings {
    public string GroupName { get; set; }
    public TimeSpan IdleTimeout { get; set; }
    public TimeSpan LeaseTimeout { get; set; }
    public int MaxOutboundConnectionsPerEndpoint { get; set; }
  }
  public class TcpTransportBindingElement : ConnectionOrientedTransportBindingElement {
    public TcpTransportBindingElement();
    protected TcpTransportBindingElement(TcpTransportBindingElement elementToBeCloned);
    public TcpConnectionPoolSettings ConnectionPoolSettings { get; }
    public override string Scheme { get; }
    public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
    public override BindingElement Clone();
    public override T GetProperty<T>(BindingContext context);
  }
  public class WindowsStreamSecurityBindingElement : BindingElement {
    public WindowsStreamSecurityBindingElement();
    public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
    public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
    public override BindingElement Clone();
    public override T GetProperty<T>(BindingContext context);
  }
}
