```diff
---lib-full\System.ServiceModel.Security.dll
+++lib-oss\System.ServiceModel.Security.dll
-namespace System.ServiceModel {
- public class DnsEndpointIdentity : EndpointIdentity {
-   public DnsEndpointIdentity(string dnsName);
  }
- public abstract class MessageSecurityVersion {
-   public abstract BasicSecurityProfileVersion BasicSecurityProfileVersion { get; }
-   public SecureConversationVersion SecureConversationVersion { get; }
-   public abstract SecurityPolicyVersion SecurityPolicyVersion { get; }
-   public SecurityVersion SecurityVersion { get; }
-   public TrustVersion TrustVersion { get; }
-   public static MessageSecurityVersion WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get; }
-   public static MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11 { get; }
-   public static MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get; }
  }
- public class SpnEndpointIdentity : EndpointIdentity {
-   public SpnEndpointIdentity(string spnName);
-   public static TimeSpan SpnLookupTime { get; set; }
  }
- public class UpnEndpointIdentity : EndpointIdentity {
-   public UpnEndpointIdentity(string upnName);
  }
 }
-namespace System.ServiceModel.Channels {
- public sealed class LocalClientSecuritySettings {
-   public LocalClientSecuritySettings();
-   public TimeSpan MaxClockSkew { get; set; }
-   public TimeSpan ReplayWindow { get; set; }
-   public TimeSpan TimestampValidityDuration { get; set; }
-   public LocalClientSecuritySettings Clone();
  }
- public abstract class SecurityBindingElement : BindingElement {
-   public SupportingTokenParameters EndpointSupportingTokenParameters { get; }
-   public bool IncludeTimestamp { get; set; }
-   public LocalClientSecuritySettings LocalClientSettings { get; }
-   public MessageSecurityVersion MessageSecurityVersion { get; set; }
-   public SecurityHeaderLayout SecurityHeaderLayout { get; set; }
-   public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
-   protected abstract IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(BindingContext context);
-   public override bool CanBuildChannelFactory<TChannel>(BindingContext context);
-   public static SecurityBindingElement CreateSecureConversationBindingElement(SecurityBindingElement bootstrapSecurity);
-   public static TransportSecurityBindingElement CreateUserNameOverTransportBindingElement();
-   public override T GetProperty<T>(BindingContext context);
-   public override string ToString();
  }
- public enum SecurityHeaderLayout {
-   Lax = 1,
-   Strict = 0,
  }
- public sealed class TransportSecurityBindingElement : SecurityBindingElement {
-   public TransportSecurityBindingElement();
-   protected override IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(BindingContext context);
-   public override BindingElement Clone();
-   public override T GetProperty<T>(BindingContext context);
  }
 }
-namespace System.ServiceModel.Security {
- public abstract class BasicSecurityProfileVersion {
-   public static BasicSecurityProfileVersion BasicSecurityProfile10 { get; }
  }
- public abstract class SecureConversationVersion {
-   public static SecureConversationVersion Default { get; }
-   public XmlDictionaryString Namespace { get; }
-   public XmlDictionaryString Prefix { get; }
-   public static SecureConversationVersion WSSecureConversationFeb2005 { get; }
  }
- public abstract class SecurityPolicyVersion {
-   public string Namespace { get; }
-   public string Prefix { get; }
-   public static SecurityPolicyVersion WSSecurityPolicy11 { get; }
  }
- public abstract class SecurityVersion {
-   public static SecurityVersion WSSecurity10 { get; }
-   public static SecurityVersion WSSecurity11 { get; }
  }
- public abstract class TrustVersion {
-   public static TrustVersion Default { get; }
-   public XmlDictionaryString Namespace { get; }
-   public XmlDictionaryString Prefix { get; }
-   public static TrustVersion WSTrustFeb2005 { get; }
  }
 }
-namespace System.ServiceModel.Security.Tokens {
- public class SecureConversationSecurityTokenParameters : SecurityTokenParameters {
-   public SecureConversationSecurityTokenParameters();
-   public SecureConversationSecurityTokenParameters(SecurityBindingElement bootstrapSecurityBindingElement);
-   public SecurityBindingElement BootstrapSecurityBindingElement { get; set; }
  }
- public abstract class SecurityTokenParameters {
-   public SecurityTokenParameters Clone();
  }
- public class SupportingTokenParameters {
-   public SupportingTokenParameters();
-   public Collection<SecurityTokenParameters> Endorsing { get; }
-   public Collection<SecurityTokenParameters> SignedEncrypted { get; }
-   public SupportingTokenParameters Clone();
  }
- public class UserNameSecurityTokenParameters : SecurityTokenParameters {
-   public UserNameSecurityTokenParameters();
  }
 }
```
