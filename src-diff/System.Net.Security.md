```diff
---lib-full\System.Net.Security.dll
+++lib-oss\System.Net.Security.dll
-namespace System.Net.Security {
- public enum EncryptionPolicy {
-   AllowNoEncryption = 1,
-   NoEncryption = 2,
-   RequireEncryption = 0,
  }
- public delegate X509Certificate LocalCertificateSelectionCallback(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers);
- public delegate bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);
- public class SslStream : Stream {
-   public SslStream(Stream innerStream);
-   public SslStream(Stream innerStream, bool leaveInnerStreamOpen);
-   public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback);
-   public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback);
-   public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback, EncryptionPolicy encryptionPolicy);
-   public override bool CanRead { get; }
-   public override bool CanSeek { get; }
-   public override bool CanTimeout { get; }
-   public override bool CanWrite { get; }
-   public virtual bool CheckCertRevocationStatus { get; }
-   public virtual CipherAlgorithmType CipherAlgorithm { get; }
-   public virtual int CipherStrength { get; }
-   public virtual HashAlgorithmType HashAlgorithm { get; }
-   public virtual int HashStrength { get; }
-   public virtual ExchangeAlgorithmType KeyExchangeAlgorithm { get; }
-   public virtual int KeyExchangeStrength { get; }
-   public override long Length { get; }
-   public virtual X509Certificate LocalCertificate { get; }
-   public override long Position { get; set; }
-   public override int ReadTimeout { get; set; }
-   public virtual X509Certificate RemoteCertificate { get; }
-   public virtual SslProtocols SslProtocol { get; }
-   public TransportContext TransportContext { get; }
-   public override int WriteTimeout { get; set; }
-   public virtual void AuthenticateAsClient(string targetHost);
-   public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
-   public virtual Task AuthenticateAsClientAsync(string targetHost);
-   public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
-   public virtual void AuthenticateAsServer(X509Certificate serverCertificate);
-   public virtual void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
-   public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate);
-   public virtual Task AuthenticateAsServerAsync(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
-   public override void Flush();
-   public override int Read(byte[] buffer, int offset, int count);
-   public override long Seek(long offset, SeekOrigin origin);
-   public override void SetLength(long value);
-   public void Write(byte[] buffer);
-   public override void Write(byte[] buffer, int offset, int count);
  }
 }
-namespace System.Security.Authentication {
- public class AuthenticationException : Exception {
-   public AuthenticationException();
-   public AuthenticationException(string message);
-   public AuthenticationException(string message, Exception innerException);
  }
 }
-namespace System.Security.Authentication.ExtendedProtection {
- public class ExtendedProtectionPolicy {
-   public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement);
-   public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ChannelBinding customChannelBinding);
-   public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ICollection customServiceNames);
-   public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ServiceNameCollection customServiceNames);
-   public ChannelBinding CustomChannelBinding { get; }
-   public ServiceNameCollection CustomServiceNames { get; }
-   public static bool OSSupportsExtendedProtection { get; }
-   public PolicyEnforcement PolicyEnforcement { get; }
-   public ProtectionScenario ProtectionScenario { get; }
-   public override string ToString();
  }
- public enum PolicyEnforcement {
-   Always = 2,
-   Never = 0,
-   WhenSupported = 1,
  }
- public enum ProtectionScenario {
-   TransportSelected = 0,
-   TrustedProxy = 1,
  }
- public class ServiceNameCollection : ICollection, IEnumerable {
-   public ServiceNameCollection(ICollection items);
-   public int Count { get; }
-   bool System.Collections.ICollection.IsSynchronized { get; }
-   object System.Collections.ICollection.SyncRoot { get; }
-   public bool Contains(string searchServiceName);
-   public IEnumerator GetEnumerator();
-   public ServiceNameCollection Merge(IEnumerable serviceNames);
-   public ServiceNameCollection Merge(string serviceName);
-   void System.Collections.ICollection.CopyTo(Array array, int index);
  }
 }
```
