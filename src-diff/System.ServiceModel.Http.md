```diff
---lib-full\System.ServiceModel.Http.dll
+++lib-oss\System.ServiceModel.Http.dll
-namespace System.ServiceModel {
- public class BasicHttpBinding : HttpBindingBase {
-   public BasicHttpBinding();
-   public BasicHttpBinding(BasicHttpSecurityMode securityMode);
-   public BasicHttpSecurity Security { get; set; }
-   public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
-   public override BindingElementCollection CreateBindingElements();
  }
- public enum BasicHttpMessageCredentialType {
-   Certificate = 1,
-   UserName = 0,
  }
- public sealed class BasicHttpSecurity {
-   public BasicHttpSecurityMode Mode { get; set; }
-   public HttpTransportSecurity Transport { get; set; }
  }
- public enum BasicHttpSecurityMode {
-   Message = 2,
-   None = 0,
-   Transport = 1,
-   TransportCredentialOnly = 4,
-   TransportWithMessageCredential = 3,
  }
- public abstract class HttpBindingBase : Binding {
-   public bool AllowCookies { get; set; }
-   public EnvelopeVersion EnvelopeVersion { get; }
-   public long MaxBufferPoolSize { get; set; }
-   public int MaxBufferSize { get; set; }
-   public long MaxReceivedMessageSize { get; set; }
-   public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
-   public override string Scheme { get; }
-   public Encoding TextEncoding { get; set; }
-   public TransferMode TransferMode { get; set; }
  }
- public enum HttpClientCredentialType {
-   Basic = 1,
-   Certificate = 5,
-   Digest = 2,
-   InheritedFromHost = 6,
-   None = 0,
-   Ntlm = 3,
-   Windows = 4,
  }
- public sealed class HttpTransportSecurity {
-   public HttpTransportSecurity();
-   public HttpClientCredentialType ClientCredentialType { get; set; }
  }
- public class NetHttpBinding : HttpBindingBase {
-   public NetHttpBinding();
-   public NetHttpBinding(BasicHttpSecurityMode securityMode);
-   public NetHttpBinding(string configurationName);
-   public NetHttpMessageEncoding MessageEncoding { get; set; }
-   public BasicHttpSecurity Security { get; set; }
-   public WebSocketTransportSettings WebSocketSettings { get; }
-   public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
-   public override BindingElementCollection CreateBindingElements();
  }
- public enum NetHttpMessageEncoding {
-   Binary = 0,
-   Mtom = 2,
-   Text = 1,
  }
 }
-namespace System.ServiceModel.Channels {
- public sealed class HttpRequestMessageProperty : IMessageProperty {
-   public HttpRequestMessageProperty();
-   public WebHeaderCollection Headers { get; }
-   public string Method { get; set; }
-   public static string Name { get; }
-   public string QueryString { get; set; }
-   public bool SuppressEntityBody { get; set; }
-   IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy();
  }
- public sealed class HttpResponseMessageProperty : IMessageProperty {
-   public HttpResponseMessageProperty();
-   public WebHeaderCollection Headers { get; }
-   public static string Name { get; }
-   public HttpStatusCode StatusCode { get; set; }
-   public string StatusDescription { get; set; }
-   IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy();
  }
- public class HttpsTransportBindingElement : HttpTransportBindingElement {
-   public HttpsTransportBindingElement();
-   protected HttpsTransportBindingElement(HttpsTransportBindingElement elementToBeCloned);
-   public override string Scheme { get; }
-   public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
-   public override BindingElement Clone();
-   public override T GetProperty<T>(BindingContext context);
  }
- public class HttpTransportBindingElement : TransportBindingElement {
-   public HttpTransportBindingElement();
-   protected HttpTransportBindingElement(HttpTransportBindingElement elementToBeCloned);
-   public bool AllowCookies { get; set; }
-   public AuthenticationSchemes AuthenticationScheme { get; set; }
-   public int MaxBufferSize { get; set; }
-   public override string Scheme { get; }
-   public TransferMode TransferMode { get; set; }
-   public WebSocketTransportSettings WebSocketSettings { get; set; }
-   public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
-   public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
-   public override BindingElement Clone();
-   public override T GetProperty<T>(BindingContext context);
  }
- public interface IHttpCookieContainerManager {
-   CookieContainer CookieContainer { get; set; }
  }
- public sealed class WebSocketTransportSettings : IEquatable<WebSocketTransportSettings> {
-   public const string BinaryMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/onbinarymessage";
-   public const string TextMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/ontextmessage";
-   public WebSocketTransportSettings();
-   public bool DisablePayloadMasking { get; set; }
-   public TimeSpan KeepAliveInterval { get; set; }
-   public string SubProtocol { get; set; }
-   public WebSocketTransportUsage TransportUsage { get; set; }
-   public override bool Equals(object obj);
-   public bool Equals(WebSocketTransportSettings other);
-   public override int GetHashCode();
  }
- public enum WebSocketTransportUsage {
-   Always = 1,
-   Never = 2,
-   WhenDuplex = 0,
  }
 }
```
