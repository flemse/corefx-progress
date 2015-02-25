```diff
---lib-full\System.ServiceModel.Primitives.dll
+++lib-oss\System.ServiceModel.Primitives.dll
-namespace System.ServiceModel {
- public class ActionNotSupportedException : CommunicationException {
-   public ActionNotSupportedException();
-   public ActionNotSupportedException(string message);
-   public ActionNotSupportedException(string message, Exception innerException);
  }
- public abstract class ChannelFactory : CommunicationObject, IChannelFactory, ICommunicationObject, IDisposable {
-   protected ChannelFactory();
-   public ClientCredentials Credentials { get; }
-   protected override TimeSpan DefaultCloseTimeout { get; }
-   protected override TimeSpan DefaultOpenTimeout { get; }
-   public ServiceEndpoint Endpoint { get; }
-   protected virtual void ApplyConfiguration(string configurationName);
-   protected abstract ServiceEndpoint CreateDescription();
-   protected virtual IChannelFactory CreateFactory();
-   protected internal void EnsureOpened();
-   public T GetProperty<T>() where T : class;
-   protected void InitializeEndpoint(Binding binding, EndpointAddress address);
-   protected void InitializeEndpoint(ServiceEndpoint endpoint);
-   protected void InitializeEndpoint(string configurationName, EndpointAddress address);
-   protected override void OnAbort();
-   protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
-   protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
-   protected override void OnClose(TimeSpan timeout);
-   protected override void OnEndClose(IAsyncResult result);
-   protected override void OnEndOpen(IAsyncResult result);
-   protected override void OnOpen(TimeSpan timeout);
-   protected override void OnOpened();
-   protected override void OnOpening();
-   void System.IDisposable.Dispose();
  }
- public class ChannelFactory<TChannel> : ChannelFactory, IChannelFactory, IChannelFactory<TChannel>, ICommunicationObject {
-   public ChannelFactory(Binding binding, EndpointAddress remoteAddress);
-   public ChannelFactory(string endpointConfigurationName);
-   public ChannelFactory(string endpointConfigurationName, EndpointAddress remoteAddress);
-   protected ChannelFactory(Type channelType);
-   public TChannel CreateChannel();
-   public TChannel CreateChannel(EndpointAddress address);
-   public virtual TChannel CreateChannel(EndpointAddress address, Uri via);
-   protected override ServiceEndpoint CreateDescription();
  }
- public abstract class ClientBase<TChannel> : ICommunicationObject where TChannel : class {
-   protected ClientBase();
-   protected ClientBase(Binding binding, EndpointAddress remoteAddress);
-   protected ClientBase(string endpointConfigurationName);
-   protected ClientBase(string endpointConfigurationName, EndpointAddress remoteAddress);
-   protected ClientBase(string endpointConfigurationName, string remoteAddress);
-   protected TChannel Channel { get; }
-   public ChannelFactory<TChannel> ChannelFactory { get; }
-   public ClientCredentials ClientCredentials { get; }
-   public ServiceEndpoint Endpoint { get; }
-   public IClientChannel InnerChannel { get; }
-   public CommunicationState State { get; }
-   event EventHandler System.ServiceModel.ICommunicationObject.Closed;
-   event EventHandler System.ServiceModel.ICommunicationObject.Closing;
-   event EventHandler System.ServiceModel.ICommunicationObject.Faulted;
-   event EventHandler System.ServiceModel.ICommunicationObject.Opened;
-   event EventHandler System.ServiceModel.ICommunicationObject.Opening;
-   public void Abort();
-   protected virtual TChannel CreateChannel();
-   protected T GetDefaultValueForInitialization<T>();
-   protected void InvokeAsync(ClientBase<TChannel>.BeginOperationDelegate beginOperationDelegate, object[] inValues, ClientBase<TChannel>.EndOperationDelegate endOperationDelegate, SendOrPostCallback operationCompletedCallback, object userState);
-   IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(AsyncCallback callback, object state);
-   IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
-   IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(AsyncCallback callback, object state);
-   IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
-   void System.ServiceModel.ICommunicationObject.Close();
-   void System.ServiceModel.ICommunicationObject.Close(TimeSpan timeout);
-   void System.ServiceModel.ICommunicationObject.EndClose(IAsyncResult result);
-   void System.ServiceModel.ICommunicationObject.EndOpen(IAsyncResult result);
-   void System.ServiceModel.ICommunicationObject.Open();
-   void System.ServiceModel.ICommunicationObject.Open(TimeSpan timeout);
-   protected delegate IAsyncResult BeginOperationDelegate(object[] inValues, AsyncCallback asyncCallback, object state);
-   protected class ChannelBase<T> : IChannel, IClientChannel, ICommunicationObject, IContextChannel, IDisposable, IExtensibleObject<IContextChannel>, IOutputChannel, IRequestChannel where T : class {
-     protected ChannelBase(ClientBase<T> client);
-     EndpointAddress System.ServiceModel.Channels.IOutputChannel.RemoteAddress { get; }
-     Uri System.ServiceModel.Channels.IOutputChannel.Via { get; }
-     EndpointAddress System.ServiceModel.Channels.IRequestChannel.RemoteAddress { get; }
-     Uri System.ServiceModel.Channels.IRequestChannel.Via { get; }
-     bool System.ServiceModel.IClientChannel.AllowInitializationUI { get; set; }
-     bool System.ServiceModel.IClientChannel.DidInteractiveInitialization { get; }
-     Uri System.ServiceModel.IClientChannel.Via { get; }
-     CommunicationState System.ServiceModel.ICommunicationObject.State { get; }
-     bool System.ServiceModel.IContextChannel.AllowOutputBatching { get; set; }
-     IInputSession System.ServiceModel.IContextChannel.InputSession { get; }
-     EndpointAddress System.ServiceModel.IContextChannel.LocalAddress { get; }
-     TimeSpan System.ServiceModel.IContextChannel.OperationTimeout { get; set; }
-     IOutputSession System.ServiceModel.IContextChannel.OutputSession { get; }
-     EndpointAddress System.ServiceModel.IContextChannel.RemoteAddress { get; }
-     string System.ServiceModel.IContextChannel.SessionId { get; }
-     IExtensionCollection<IContextChannel> System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel>.Extensions { get; }
-     event EventHandler<UnknownMessageReceivedEventArgs> System.ServiceModel.IClientChannel.UnknownMessageReceived;
-     event EventHandler System.ServiceModel.ICommunicationObject.Closed;
-     event EventHandler System.ServiceModel.ICommunicationObject.Closing;
-     event EventHandler System.ServiceModel.ICommunicationObject.Faulted;
-     event EventHandler System.ServiceModel.ICommunicationObject.Opened;
-     event EventHandler System.ServiceModel.ICommunicationObject.Opening;
-     protected IAsyncResult BeginInvoke(string methodName, object[] args, AsyncCallback callback, object state);
-     protected object EndInvoke(string methodName, object[] args, IAsyncResult result);
-     void System.IDisposable.Dispose();
-     TProperty System.ServiceModel.Channels.IChannel.GetProperty<TProperty>();
-     IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(Message message, AsyncCallback callback, object state);
-     IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(Message message, TimeSpan timeout, AsyncCallback callback, object state);
-     void System.ServiceModel.Channels.IOutputChannel.EndSend(IAsyncResult result);
-     void System.ServiceModel.Channels.IOutputChannel.Send(Message message);
-     void System.ServiceModel.Channels.IOutputChannel.Send(Message message, TimeSpan timeout);
-     IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(Message message, AsyncCallback callback, object state);
-     IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(Message message, TimeSpan timeout, AsyncCallback callback, object state);
-     Message System.ServiceModel.Channels.IRequestChannel.EndRequest(IAsyncResult result);
-     Message System.ServiceModel.Channels.IRequestChannel.Request(Message message);
-     Message System.ServiceModel.Channels.IRequestChannel.Request(Message message, TimeSpan timeout);
-     IAsyncResult System.ServiceModel.IClientChannel.BeginDisplayInitializationUI(AsyncCallback callback, object state);
-     void System.ServiceModel.IClientChannel.DisplayInitializationUI();
-     void System.ServiceModel.IClientChannel.EndDisplayInitializationUI(IAsyncResult result);
-     void System.ServiceModel.ICommunicationObject.Abort();
-     IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(AsyncCallback callback, object state);
-     IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
-     IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(AsyncCallback callback, object state);
-     IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
-     void System.ServiceModel.ICommunicationObject.Close();
-     void System.ServiceModel.ICommunicationObject.Close(TimeSpan timeout);
-     void System.ServiceModel.ICommunicationObject.EndClose(IAsyncResult result);
-     void System.ServiceModel.ICommunicationObject.EndOpen(IAsyncResult result);
-     void System.ServiceModel.ICommunicationObject.Open();
-     void System.ServiceModel.ICommunicationObject.Open(TimeSpan timeout);
    }
-   protected delegate object[] EndOperationDelegate(IAsyncResult result);
-   protected class InvokeAsyncCompletedEventArgs : AsyncCompletedEventArgs {
-     public object[] Results { get; }
    }
  }
- public class CommunicationException : Exception {
-   public CommunicationException();
-   public CommunicationException(string message);
-   public CommunicationException(string message, Exception innerException);
  }
- public class CommunicationObjectAbortedException : CommunicationException {
-   public CommunicationObjectAbortedException();
-   public CommunicationObjectAbortedException(string message);
-   public CommunicationObjectAbortedException(string message, Exception innerException);
  }
- public class CommunicationObjectFaultedException : CommunicationException {
-   public CommunicationObjectFaultedException();
-   public CommunicationObjectFaultedException(string message);
-   public CommunicationObjectFaultedException(string message, Exception innerException);
  }
- public enum CommunicationState {
-   Closed = 4,
-   Closing = 3,
-   Created = 0,
-   Faulted = 5,
-   Opened = 2,
-   Opening = 1,
  }
- public sealed class DataContractFormatAttribute : Attribute {
-   public DataContractFormatAttribute();
-   public OperationFormatStyle Style { get; set; }
  }
- public class EndpointAddress {
-   public EndpointAddress(string uri);
-   public EndpointAddress(Uri uri, params AddressHeader[] addressHeaders);
-   public EndpointAddress(Uri uri, EndpointIdentity identity, params AddressHeader[] addressHeaders);
-   public static Uri AnonymousUri { get; }
-   public AddressHeaderCollection Headers { get; }
-   public EndpointIdentity Identity { get; }
-   public bool IsAnonymous { get; }
-   public bool IsNone { get; }
-   public static Uri NoneUri { get; }
-   public Uri Uri { get; }
-   public void ApplyTo(Message message);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public static bool operator ==(EndpointAddress address1, EndpointAddress address2);
-   public static bool operator !=(EndpointAddress address1, EndpointAddress address2);
-   public static EndpointAddress ReadFrom(AddressingVersion addressingVersion, XmlDictionaryReader reader);
-   public override string ToString();
-   public void WriteContentsTo(AddressingVersion addressingVersion, XmlDictionaryWriter writer);
  }
- public class EndpointAddressBuilder {
-   public EndpointAddressBuilder();
-   public EndpointAddressBuilder(EndpointAddress address);
-   public Collection<AddressHeader> Headers { get; }
-   public EndpointIdentity Identity { get; set; }
-   public Uri Uri { get; set; }
-   public EndpointAddress ToEndpointAddress();
  }
- public abstract class EndpointIdentity {
-   protected EndpointIdentity();
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public override string ToString();
  }
- public class EndpointNotFoundException : CommunicationException {
-   public EndpointNotFoundException(string message);
-   public EndpointNotFoundException(string message, Exception innerException);
  }
- public sealed class EnvelopeVersion {
-   public string NextDestinationActorValue { get; }
-   public static EnvelopeVersion None { get; }
-   public static EnvelopeVersion Soap11 { get; }
-   public static EnvelopeVersion Soap12 { get; }
-   public string[] GetUltimateDestinationActorValues();
-   public override string ToString();
  }
- public class ExceptionDetail {
-   public ExceptionDetail(Exception exception);
-   public string HelpLink { get; set; }
-   public ExceptionDetail InnerException { get; set; }
-   public string Message { get; set; }
-   public string StackTrace { get; set; }
-   public string Type { get; set; }
-   public override string ToString();
  }
- public class FaultCode {
-   public FaultCode(string name);
-   public FaultCode(string name, FaultCode subCode);
-   public FaultCode(string name, string ns);
-   public FaultCode(string name, string ns, FaultCode subCode);
-   public bool IsPredefinedFault { get; }
-   public bool IsReceiverFault { get; }
-   public bool IsSenderFault { get; }
-   public string Name { get; }
-   public string Namespace { get; }
-   public FaultCode SubCode { get; }
-   public static FaultCode CreateSenderFaultCode(FaultCode subCode);
  }
- public sealed class FaultContractAttribute : Attribute {
-   public FaultContractAttribute(Type detailType);
-   public string Action { get; set; }
-   public Type DetailType { get; }
-   public string Name { get; set; }
-   public string Namespace { get; set; }
  }
- public class FaultException : CommunicationException {
-   public FaultException();
-   public FaultException(MessageFault fault, string action);
-   public FaultException(FaultReason reason, FaultCode code, string action);
-   public string Action { get; }
-   public FaultCode Code { get; }
-   public override string Message { get; }
-   public FaultReason Reason { get; }
-   public static FaultException CreateFault(MessageFault messageFault, string action, params Type[] faultDetailTypes);
-   public static FaultException CreateFault(MessageFault messageFault, params Type[] faultDetailTypes);
-   public virtual MessageFault CreateMessageFault();
  }
- public class FaultException<TDetail> : FaultException {
-   public FaultException(TDetail detail, FaultReason reason, FaultCode code, string action);
-   public TDetail Detail { get; }
-   public override MessageFault CreateMessageFault();
-   public override string ToString();
  }
- public class FaultReason {
-   public FaultReason(IEnumerable<FaultReasonText> translations);
-   public FaultReason(FaultReasonText translation);
-   public FaultReason(string text);
-   public FaultReasonText GetMatchingTranslation();
-   public FaultReasonText GetMatchingTranslation(CultureInfo cultureInfo);
-   public override string ToString();
  }
- public class FaultReasonText {
-   public FaultReasonText(string text);
-   public FaultReasonText(string text, string xmlLang);
-   public string Text { get; }
-   public string XmlLang { get; }
-   public bool Matches(CultureInfo cultureInfo);
  }
- public interface IClientChannel : IChannel, ICommunicationObject, IContextChannel, IDisposable, IExtensibleObject<IContextChannel> {
-   bool AllowInitializationUI { get; set; }
-   bool DidInteractiveInitialization { get; }
-   Uri Via { get; }
-   event EventHandler<UnknownMessageReceivedEventArgs> UnknownMessageReceived;
-   IAsyncResult BeginDisplayInitializationUI(AsyncCallback callback, object state);
-   void DisplayInitializationUI();
-   void EndDisplayInitializationUI(IAsyncResult result);
  }
- public interface ICommunicationObject {
-   CommunicationState State { get; }
-   event EventHandler Closed;
-   event EventHandler Closing;
-   event EventHandler Faulted;
-   event EventHandler Opened;
-   event EventHandler Opening;
-   void Abort();
-   IAsyncResult BeginClose(AsyncCallback callback, object state);
-   IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
-   IAsyncResult BeginOpen(AsyncCallback callback, object state);
-   IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
-   void Close();
-   void Close(TimeSpan timeout);
-   void EndClose(IAsyncResult result);
-   void EndOpen(IAsyncResult result);
-   void Open();
-   void Open(TimeSpan timeout);
  }
- public interface IContextChannel : IChannel, ICommunicationObject, IExtensibleObject<IContextChannel> {
-   bool AllowOutputBatching { get; set; }
-   IInputSession InputSession { get; }
-   EndpointAddress LocalAddress { get; }
-   TimeSpan OperationTimeout { get; set; }
-   IOutputSession OutputSession { get; }
-   EndpointAddress RemoteAddress { get; }
-   string SessionId { get; }
  }
- public interface IDefaultCommunicationTimeouts {
-   TimeSpan CloseTimeout { get; }
-   TimeSpan OpenTimeout { get; }
-   TimeSpan ReceiveTimeout { get; }
-   TimeSpan SendTimeout { get; }
  }
- public interface IExtensibleObject<T> where T : IExtensibleObject<T> {
-   IExtensionCollection<T> Extensions { get; }
  }
- public interface IExtension<T> where T : IExtensibleObject<T> {
-   void Attach(T owner);
-   void Detach(T owner);
  }
- public interface IExtensionCollection<T> : ICollection<IExtension<T>>, IEnumerable, IEnumerable<IExtension<T>> where T : IExtensibleObject<T> {
-   E Find<E>();
-   Collection<E> FindAll<E>();
  }
- public class InvalidMessageContractException : Exception {
-   public InvalidMessageContractException();
-   public InvalidMessageContractException(string message);
-   public InvalidMessageContractException(string message, Exception innerException);
  }
- public class MessageBodyMemberAttribute : MessageContractMemberAttribute {
-   public MessageBodyMemberAttribute();
-   public int Order { get; set; }
  }
- public sealed class MessageContractAttribute : Attribute {
-   public MessageContractAttribute();
-   public bool IsWrapped { get; set; }
-   public string WrapperName { get; set; }
-   public string WrapperNamespace { get; set; }
  }
- public abstract class MessageContractMemberAttribute : Attribute {
-   protected MessageContractMemberAttribute();
-   public string Name { get; set; }
-   public string Namespace { get; set; }
  }
- public enum MessageCredentialType {
-   Certificate = 3,
-   IssuedToken = 4,
-   None = 0,
-   UserName = 2,
-   Windows = 1,
  }
- public class MessageHeader<T> {
-   public MessageHeader();
-   public MessageHeader(T content);
-   public MessageHeader(T content, bool mustUnderstand, string actor, bool relay);
-   public string Actor { get; set; }
-   public T Content { get; set; }
-   public bool MustUnderstand { get; set; }
-   public bool Relay { get; set; }
-   public MessageHeader GetUntypedHeader(string name, string ns);
  }
- public class MessageHeaderException : ProtocolException {
-   public MessageHeaderException(string message);
-   public MessageHeaderException(string message, bool isDuplicate);
-   public MessageHeaderException(string message, Exception innerException);
-   public MessageHeaderException(string message, string headerName, string ns);
-   public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate);
-   public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate, Exception innerException);
-   public MessageHeaderException(string message, string headerName, string ns, Exception innerException);
-   public string HeaderName { get; }
-   public string HeaderNamespace { get; }
-   public bool IsDuplicate { get; }
  }
- public sealed class MessageParameterAttribute : Attribute {
-   public MessageParameterAttribute();
-   public string Name { get; set; }
  }
- public sealed class OperationContext : IExtensibleObject<OperationContext> {
-   public OperationContext(IContextChannel channel);
-   public static OperationContext Current { get; set; }
-   public IExtensionCollection<OperationContext> Extensions { get; }
-   public MessageHeaders IncomingMessageHeaders { get; }
-   public MessageProperties IncomingMessageProperties { get; }
-   public MessageVersion IncomingMessageVersion { get; }
-   public bool IsUserContext { get; }
-   public MessageHeaders OutgoingMessageHeaders { get; }
-   public MessageProperties OutgoingMessageProperties { get; }
-   public RequestContext RequestContext { get; set; }
-   public event EventHandler OperationCompleted;
  }
- public sealed class OperationContextScope : IDisposable {
-   public OperationContextScope(IContextChannel channel);
-   public OperationContextScope(OperationContext context);
-   public void Dispose();
  }
- public sealed class OperationContractAttribute : Attribute {
-   public OperationContractAttribute();
-   public string Action { get; set; }
-   public bool AsyncPattern { get; set; }
-   public bool IsOneWay { get; set; }
-   public string Name { get; set; }
-   public string ReplyAction { get; set; }
  }
- public enum OperationFormatStyle {
-   Document = 0,
-   Rpc = 1,
  }
- public class ProtocolException : CommunicationException {
-   public ProtocolException(string message);
-   public ProtocolException(string message, Exception innerException);
  }
- public class QuotaExceededException : Exception {
-   public QuotaExceededException(string message);
-   public QuotaExceededException(string message, Exception innerException);
  }
- public enum SecurityMode {
-   Message = 2,
-   None = 0,
-   Transport = 1,
-   TransportWithMessageCredential = 3,
  }
- public class ServerTooBusyException : CommunicationException {
-   public ServerTooBusyException(string message);
-   public ServerTooBusyException(string message, Exception innerException);
  }
- public class ServiceActivationException : CommunicationException {
-   public ServiceActivationException(string message);
-   public ServiceActivationException(string message, Exception innerException);
  }
- public sealed class ServiceContractAttribute : Attribute {
-   public ServiceContractAttribute();
-   public Type CallbackContract { get; set; }
-   public string ConfigurationName { get; set; }
-   public string Name { get; set; }
-   public string Namespace { get; set; }
  }
- public sealed class ServiceKnownTypeAttribute : Attribute {
-   public ServiceKnownTypeAttribute(string methodName);
-   public ServiceKnownTypeAttribute(string methodName, Type declaringType);
-   public ServiceKnownTypeAttribute(Type type);
-   public Type DeclaringType { get; }
-   public string MethodName { get; }
-   public Type Type { get; }
  }
- public enum TransferMode {
-   Buffered = 0,
-   Streamed = 1,
-   StreamedRequest = 2,
-   StreamedResponse = 3,
  }
- public sealed class UnknownMessageReceivedEventArgs : EventArgs {
-   public Message Message { get; }
  }
- public sealed class XmlSerializerFormatAttribute : Attribute {
-   public XmlSerializerFormatAttribute();
-   public OperationFormatStyle Style { get; set; }
-   public bool SupportFaults { get; set; }
  }
 }
-namespace System.ServiceModel.Channels {
- public abstract class AddressHeader {
-   protected AddressHeader();
-   public abstract string Name { get; }
-   public abstract string Namespace { get; }
-   public static AddressHeader CreateAddressHeader(string name, string ns, object value);
-   public static AddressHeader CreateAddressHeader(string name, string ns, object value, XmlObjectSerializer serializer);
-   public override bool Equals(object obj);
-   public virtual XmlDictionaryReader GetAddressHeaderReader();
-   public override int GetHashCode();
-   public T GetValue<T>();
-   public T GetValue<T>(XmlObjectSerializer serializer);
-   protected abstract void OnWriteAddressHeaderContents(XmlDictionaryWriter writer);
-   protected virtual void OnWriteStartAddressHeader(XmlDictionaryWriter writer);
-   public MessageHeader ToMessageHeader();
-   public void WriteAddressHeader(XmlDictionaryWriter writer);
-   public void WriteAddressHeader(XmlWriter writer);
-   public void WriteAddressHeaderContents(XmlDictionaryWriter writer);
-   public void WriteStartAddressHeader(XmlDictionaryWriter writer);
  }
- public sealed class AddressHeaderCollection : ReadOnlyCollection<AddressHeader> {
-   public AddressHeaderCollection();
-   public AddressHeaderCollection(IEnumerable<AddressHeader> addressHeaders);
-   public void AddHeadersTo(Message message);
-   public AddressHeader[] FindAll(string name, string ns);
-   public AddressHeader FindHeader(string name, string ns);
  }
- public sealed class AddressingVersion {
-   public static AddressingVersion None { get; }
-   public static AddressingVersion WSAddressing10 { get; }
-   public override string ToString();
  }
- public sealed class BinaryMessageEncodingBindingElement : MessageEncodingBindingElement {
-   public BinaryMessageEncodingBindingElement();
-   public CompressionFormat CompressionFormat { get; set; }
-   public int MaxSessionSize { get; set; }
-   public override MessageVersion MessageVersion { get; set; }
-   public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
-   public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
-   public override BindingElement Clone();
-   public override MessageEncoderFactory CreateMessageEncoderFactory();
-   public override T GetProperty<T>(BindingContext context);
  }
- public abstract class Binding : IDefaultCommunicationTimeouts {
-   protected Binding();
-   protected Binding(string name, string ns);
-   public TimeSpan CloseTimeout { get; set; }
-   public MessageVersion MessageVersion { get; }
-   public string Name { get; set; }
-   public string Namespace { get; set; }
-   public TimeSpan OpenTimeout { get; set; }
-   public TimeSpan ReceiveTimeout { get; set; }
-   public abstract string Scheme { get; }
-   public TimeSpan SendTimeout { get; set; }
-   public IChannelFactory<TChannel> BuildChannelFactory<TChannel>(params object[] parameters);
-   public virtual IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingParameterCollection parameters);
-   public bool CanBuildChannelFactory<TChannel>(params object[] parameters);
-   public virtual bool CanBuildChannelFactory<TChannel>(BindingParameterCollection parameters);
-   public abstract BindingElementCollection CreateBindingElements();
-   public T GetProperty<T>(BindingParameterCollection parameters) where T : class;
  }
- public class BindingContext {
-   public BindingContext(CustomBinding binding, BindingParameterCollection parameters);
-   public CustomBinding Binding { get; }
-   public BindingParameterCollection BindingParameters { get; }
-   public BindingElementCollection RemainingBindingElements { get; }
-   public IChannelFactory<TChannel> BuildInnerChannelFactory<TChannel>();
-   public bool CanBuildInnerChannelFactory<TChannel>();
-   public BindingContext Clone();
-   public T GetInnerProperty<T>() where T : class;
  }
- public abstract class BindingElement {
-   protected BindingElement();
-   protected BindingElement(BindingElement elementToBeCloned);
-   public virtual IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
-   public virtual bool CanBuildChannelFactory<TChannel>(BindingContext context);
-   public abstract BindingElement Clone();
-   public abstract T GetProperty<T>(BindingContext context) where T : class;
  }
- public class BindingElementCollection : Collection<BindingElement> {
-   public BindingElementCollection();
-   public BindingElementCollection(IEnumerable<BindingElement> elements);
-   public BindingElementCollection(BindingElement[] elements);
-   public void AddRange(params BindingElement[] elements);
-   public BindingElementCollection Clone();
-   public bool Contains(Type bindingElementType);
-   public T Find<T>();
-   public Collection<T> FindAll<T>();
-   protected override void InsertItem(int index, BindingElement item);
-   public T Remove<T>();
-   public Collection<T> RemoveAll<T>();
-   protected override void SetItem(int index, BindingElement item);
  }
- public class BindingParameterCollection : KeyedCollection<Type, object> {
-   public BindingParameterCollection();
-   protected override Type GetKeyForItem(object item);
-   protected override void InsertItem(int index, object item);
-   protected override void SetItem(int index, object item);
  }
- public abstract class BodyWriter {
-   protected BodyWriter(bool isBuffered);
-   public bool IsBuffered { get; }
-   public BodyWriter CreateBufferedCopy(int maxBufferSize);
-   protected virtual BodyWriter OnCreateBufferedCopy(int maxBufferSize);
-   protected abstract void OnWriteBodyContents(XmlDictionaryWriter writer);
-   public void WriteBodyContents(XmlDictionaryWriter writer);
  }
- public abstract class BufferManager {
-   protected BufferManager();
-   public abstract void Clear();
-   public static BufferManager CreateBufferManager(long maxBufferPoolSize, int maxBufferSize);
-   public abstract void ReturnBuffer(byte[] buffer);
-   public abstract byte[] TakeBuffer(int bufferSize);
  }
- public abstract class ChannelBase : CommunicationObject, IChannel, ICommunicationObject, IDefaultCommunicationTimeouts {
-   protected ChannelBase(ChannelManagerBase channelManager);
-   protected override TimeSpan DefaultCloseTimeout { get; }
-   protected override TimeSpan DefaultOpenTimeout { get; }
-   protected TimeSpan DefaultReceiveTimeout { get; }
-   protected TimeSpan DefaultSendTimeout { get; }
-   protected ChannelManagerBase Manager { get; }
-   TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get; }
-   TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get; }
-   TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get; }
-   TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get; }
-   public virtual T GetProperty<T>() where T : class;
-   protected override void OnClosed();
  }
- public abstract class ChannelFactoryBase : ChannelManagerBase, IChannelFactory, ICommunicationObject {
-   protected ChannelFactoryBase();
-   protected ChannelFactoryBase(IDefaultCommunicationTimeouts timeouts);
-   protected override TimeSpan DefaultCloseTimeout { get; }
-   protected override TimeSpan DefaultOpenTimeout { get; }
-   protected override TimeSpan DefaultReceiveTimeout { get; }
-   protected override TimeSpan DefaultSendTimeout { get; }
-   public virtual T GetProperty<T>() where T : class;
-   protected override void OnAbort();
-   protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
-   protected override void OnClose(TimeSpan timeout);
-   protected override void OnEndClose(IAsyncResult result);
  }
- public abstract class ChannelFactoryBase<TChannel> : ChannelFactoryBase, IChannelFactory, IChannelFactory<TChannel>, ICommunicationObject {
-   protected ChannelFactoryBase();
-   protected ChannelFactoryBase(IDefaultCommunicationTimeouts timeouts);
-   public TChannel CreateChannel(EndpointAddress address);
-   public TChannel CreateChannel(EndpointAddress address, Uri via);
-   protected override void OnAbort();
-   protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
-   protected override void OnClose(TimeSpan timeout);
-   protected abstract TChannel OnCreateChannel(EndpointAddress address, Uri via);
-   protected override void OnEndClose(IAsyncResult result);
-   protected void ValidateCreateChannel();
  }
- public abstract class ChannelManagerBase : CommunicationObject, IDefaultCommunicationTimeouts {
-   protected ChannelManagerBase();
-   protected abstract TimeSpan DefaultReceiveTimeout { get; }
-   protected abstract TimeSpan DefaultSendTimeout { get; }
-   TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get; }
-   TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get; }
-   TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get; }
-   TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get; }
  }
- public class ChannelParameterCollection : Collection<object> {
-   public ChannelParameterCollection();
-   public ChannelParameterCollection(IChannel channel);
-   protected virtual IChannel Channel { get; }
-   protected override void ClearItems();
-   protected override void InsertItem(int index, object item);
-   public void PropagateChannelParameters(IChannel innerChannel);
-   protected override void RemoveItem(int index);
-   protected override void SetItem(int index, object item);
  }
- public abstract class CommunicationObject : ICommunicationObject {
-   protected CommunicationObject();
-   protected CommunicationObject(object mutex);
-   protected abstract TimeSpan DefaultCloseTimeout { get; }
-   protected abstract TimeSpan DefaultOpenTimeout { get; }
-   protected bool IsDisposed { get; }
-   public CommunicationState State { get; }
-   protected object ThisLock { get; }
-   public event EventHandler Closed;
-   public event EventHandler Closing;
-   public event EventHandler Faulted;
-   public event EventHandler Opened;
-   public event EventHandler Opening;
-   public void Abort();
-   public IAsyncResult BeginClose(AsyncCallback callback, object state);
-   public IAsyncResult BeginClose(TimeSpan timeout, AsyncCallback callback, object state);
-   public IAsyncResult BeginOpen(AsyncCallback callback, object state);
-   public IAsyncResult BeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
-   public void Close();
-   public void Close(TimeSpan timeout);
-   public void EndClose(IAsyncResult result);
-   public void EndOpen(IAsyncResult result);
-   protected void Fault();
-   protected virtual Type GetCommunicationObjectType();
-   protected abstract void OnAbort();
-   protected abstract IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
-   protected abstract IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
-   protected abstract void OnClose(TimeSpan timeout);
-   protected virtual void OnClosed();
-   protected virtual void OnClosing();
-   protected abstract void OnEndClose(IAsyncResult result);
-   protected abstract void OnEndOpen(IAsyncResult result);
-   protected virtual void OnFaulted();
-   protected abstract void OnOpen(TimeSpan timeout);
-   protected virtual void OnOpened();
-   protected virtual void OnOpening();
-   public void Open();
-   public void Open(TimeSpan timeout);
  }
- public enum CompressionFormat {
-   Deflate = 2,
-   GZip = 1,
-   None = 0,
  }
- public class CustomBinding : Binding {
-   public CustomBinding();
-   public CustomBinding(IEnumerable<BindingElement> bindingElementsInTopDownChannelStackOrder);
-   public CustomBinding(Binding binding);
-   public CustomBinding(params BindingElement[] bindingElementsInTopDownChannelStackOrder);
-   public CustomBinding(string name, string ns, params BindingElement[] bindingElementsInTopDownChannelStackOrder);
-   public BindingElementCollection Elements { get; }
-   public override string Scheme { get; }
-   public override BindingElementCollection CreateBindingElements();
  }
- public abstract class FaultConverter {
-   protected FaultConverter();
-   public static FaultConverter GetDefaultFaultConverter(MessageVersion version);
-   protected abstract bool OnTryCreateException(Message message, MessageFault fault, out Exception exception);
-   protected abstract bool OnTryCreateFaultMessage(Exception exception, out Message message);
-   public bool TryCreateException(Message message, MessageFault fault, out Exception exception);
  }
- public interface IChannel : ICommunicationObject {
-   T GetProperty<T>() where T : class;
  }
- public interface IChannelFactory : ICommunicationObject {
-   T GetProperty<T>() where T : class;
  }
- public interface IChannelFactory<TChannel> : IChannelFactory, ICommunicationObject {
-   TChannel CreateChannel(EndpointAddress to);
-   TChannel CreateChannel(EndpointAddress to, Uri via);
  }
- public interface IDuplexChannel : IChannel, ICommunicationObject, IInputChannel, IOutputChannel {
  }
- public interface IDuplexSession : IInputSession, IOutputSession, ISession {
-   IAsyncResult BeginCloseOutputSession(AsyncCallback callback, object state);
-   IAsyncResult BeginCloseOutputSession(TimeSpan timeout, AsyncCallback callback, object state);
-   void CloseOutputSession();
-   void CloseOutputSession(TimeSpan timeout);
-   void EndCloseOutputSession(IAsyncResult result);
  }
- public interface IDuplexSessionChannel : IChannel, ICommunicationObject, IDuplexChannel, IInputChannel, IOutputChannel, ISessionChannel<IDuplexSession> {
  }
- public interface IInputChannel : IChannel, ICommunicationObject {
-   EndpointAddress LocalAddress { get; }
-   IAsyncResult BeginReceive(AsyncCallback callback, object state);
-   IAsyncResult BeginReceive(TimeSpan timeout, AsyncCallback callback, object state);
-   IAsyncResult BeginTryReceive(TimeSpan timeout, AsyncCallback callback, object state);
-   IAsyncResult BeginWaitForMessage(TimeSpan timeout, AsyncCallback callback, object state);
-   Message EndReceive(IAsyncResult result);
-   bool EndTryReceive(IAsyncResult result, out Message message);
-   bool EndWaitForMessage(IAsyncResult result);
-   Message Receive();
-   Message Receive(TimeSpan timeout);
-   bool TryReceive(TimeSpan timeout, out Message message);
-   bool WaitForMessage(TimeSpan timeout);
  }
- public interface IInputSession : ISession {
  }
- public interface IInputSessionChannel : IChannel, ICommunicationObject, IInputChannel, ISessionChannel<IInputSession> {
  }
- public interface IMessageProperty {
-   IMessageProperty CreateCopy();
  }
- public interface IOutputChannel : IChannel, ICommunicationObject {
-   EndpointAddress RemoteAddress { get; }
-   Uri Via { get; }
-   IAsyncResult BeginSend(Message message, AsyncCallback callback, object state);
-   IAsyncResult BeginSend(Message message, TimeSpan timeout, AsyncCallback callback, object state);
-   void EndSend(IAsyncResult result);
-   void Send(Message message);
-   void Send(Message message, TimeSpan timeout);
  }
- public interface IOutputSession : ISession {
  }
- public interface IOutputSessionChannel : IChannel, ICommunicationObject, IOutputChannel, ISessionChannel<IOutputSession> {
  }
- public interface IRequestChannel : IChannel, ICommunicationObject {
-   EndpointAddress RemoteAddress { get; }
-   Uri Via { get; }
-   IAsyncResult BeginRequest(Message message, AsyncCallback callback, object state);
-   IAsyncResult BeginRequest(Message message, TimeSpan timeout, AsyncCallback callback, object state);
-   Message EndRequest(IAsyncResult result);
-   Message Request(Message message);
-   Message Request(Message message, TimeSpan timeout);
  }
- public interface IRequestSessionChannel : IChannel, ICommunicationObject, IRequestChannel, ISessionChannel<IOutputSession> {
  }
- public interface ISession {
-   string Id { get; }
  }
- public interface ISessionChannel<TSession> where TSession : ISession {
-   TSession Session { get; }
  }
- public abstract class Message : IDisposable {
-   protected Message();
-   public abstract MessageHeaders Headers { get; }
-   protected bool IsDisposed { get; }
-   public virtual bool IsEmpty { get; }
-   public virtual bool IsFault { get; }
-   public abstract MessageProperties Properties { get; }
-   public MessageState State { get; }
-   public abstract MessageVersion Version { get; }
-   public void Close();
-   public MessageBuffer CreateBufferedCopy(int maxBufferSize);
-   public static Message CreateMessage(MessageVersion version, string action);
-   public static Message CreateMessage(MessageVersion version, string action, object body);
-   public static Message CreateMessage(MessageVersion version, string action, object body, XmlObjectSerializer serializer);
-   public static Message CreateMessage(MessageVersion version, string action, BodyWriter body);
-   public static Message CreateMessage(MessageVersion version, string action, XmlDictionaryReader body);
-   public static Message CreateMessage(MessageVersion version, string action, XmlReader body);
-   public static Message CreateMessage(XmlDictionaryReader envelopeReader, int maxSizeOfHeaders, MessageVersion version);
-   public static Message CreateMessage(XmlReader envelopeReader, int maxSizeOfHeaders, MessageVersion version);
-   public T GetBody<T>();
-   public T GetBody<T>(XmlObjectSerializer serializer);
-   public string GetBodyAttribute(string localName, string ns);
-   public XmlDictionaryReader GetReaderAtBodyContents();
-   protected virtual void OnBodyToString(XmlDictionaryWriter writer);
-   protected virtual void OnClose();
-   protected virtual MessageBuffer OnCreateBufferedCopy(int maxBufferSize);
-   protected virtual T OnGetBody<T>(XmlDictionaryReader reader);
-   protected virtual string OnGetBodyAttribute(string localName, string ns);
-   protected virtual XmlDictionaryReader OnGetReaderAtBodyContents();
-   protected abstract void OnWriteBodyContents(XmlDictionaryWriter writer);
-   protected virtual void OnWriteMessage(XmlDictionaryWriter writer);
-   protected virtual void OnWriteStartBody(XmlDictionaryWriter writer);
-   protected virtual void OnWriteStartEnvelope(XmlDictionaryWriter writer);
-   protected virtual void OnWriteStartHeaders(XmlDictionaryWriter writer);
-   void System.IDisposable.Dispose();
-   public override string ToString();
-   public void WriteBody(XmlDictionaryWriter writer);
-   public void WriteBody(XmlWriter writer);
-   public void WriteBodyContents(XmlDictionaryWriter writer);
-   public void WriteMessage(XmlDictionaryWriter writer);
-   public void WriteMessage(XmlWriter writer);
-   public void WriteStartBody(XmlDictionaryWriter writer);
-   public void WriteStartBody(XmlWriter writer);
-   public void WriteStartEnvelope(XmlDictionaryWriter writer);
  }
- public abstract class MessageBuffer : IDisposable {
-   protected MessageBuffer();
-   public abstract int BufferSize { get; }
-   public virtual string MessageContentType { get; }
-   public abstract void Close();
-   public abstract Message CreateMessage();
-   void System.IDisposable.Dispose();
-   public virtual void WriteMessage(Stream stream);
  }
- public abstract class MessageEncoder {
-   protected MessageEncoder();
-   public abstract string ContentType { get; }
-   public abstract string MediaType { get; }
-   public abstract MessageVersion MessageVersion { get; }
-   public virtual T GetProperty<T>() where T : class;
-   public virtual bool IsContentTypeSupported(string contentType);
-   public Message ReadMessage(ArraySegment<byte> buffer, BufferManager bufferManager);
-   public abstract Message ReadMessage(ArraySegment<byte> buffer, BufferManager bufferManager, string contentType);
-   public Message ReadMessage(Stream stream, int maxSizeOfHeaders);
-   public abstract Message ReadMessage(Stream stream, int maxSizeOfHeaders, string contentType);
-   public override string ToString();
-   public ArraySegment<byte> WriteMessage(Message message, int maxMessageSize, BufferManager bufferManager);
-   public abstract ArraySegment<byte> WriteMessage(Message message, int maxMessageSize, BufferManager bufferManager, int messageOffset);
-   public abstract void WriteMessage(Message message, Stream stream);
  }
- public abstract class MessageEncoderFactory {
-   protected MessageEncoderFactory();
-   public abstract MessageEncoder Encoder { get; }
-   public abstract MessageVersion MessageVersion { get; }
-   public virtual MessageEncoder CreateSessionEncoder();
  }
- public abstract class MessageEncodingBindingElement : BindingElement {
-   protected MessageEncodingBindingElement();
-   protected MessageEncodingBindingElement(MessageEncodingBindingElement elementToBeCloned);
-   public abstract MessageVersion MessageVersion { get; set; }
-   public abstract MessageEncoderFactory CreateMessageEncoderFactory();
-   public override T GetProperty<T>(BindingContext context);
  }
- public abstract class MessageFault {
-   protected MessageFault();
-   public virtual string Actor { get; }
-   public abstract FaultCode Code { get; }
-   public abstract bool HasDetail { get; }
-   public virtual string Node { get; }
-   public abstract FaultReason Reason { get; }
-   public static MessageFault CreateFault(Message message, int maxBufferSize);
-   public T GetDetail<T>();
-   public T GetDetail<T>(XmlObjectSerializer serializer);
-   public XmlDictionaryReader GetReaderAtDetailContents();
-   protected virtual XmlDictionaryReader OnGetReaderAtDetailContents();
-   protected virtual void OnWriteDetail(XmlDictionaryWriter writer, EnvelopeVersion version);
-   protected abstract void OnWriteDetailContents(XmlDictionaryWriter writer);
-   protected virtual void OnWriteStartDetail(XmlDictionaryWriter writer, EnvelopeVersion version);
  }
- public abstract class MessageHeader : MessageHeaderInfo {
-   protected MessageHeader();
-   public override string Actor { get; }
-   public override bool IsReferenceParameter { get; }
-   public override bool MustUnderstand { get; }
-   public override bool Relay { get; }
-   public static MessageHeader CreateHeader(string name, string ns, object value);
-   public static MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand);
-   public static MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor);
-   public static MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor, bool relay);
-   public static MessageHeader CreateHeader(string name, string ns, object value, XmlObjectSerializer serializer);
-   public static MessageHeader CreateHeader(string name, string ns, object value, XmlObjectSerializer serializer, bool mustUnderstand);
-   public static MessageHeader CreateHeader(string name, string ns, object value, XmlObjectSerializer serializer, bool mustUnderstand, string actor);
-   public static MessageHeader CreateHeader(string name, string ns, object value, XmlObjectSerializer serializer, bool mustUnderstand, string actor, bool relay);
-   public virtual bool IsMessageVersionSupported(MessageVersion messageVersion);
-   protected abstract void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion);
-   protected virtual void OnWriteStartHeader(XmlDictionaryWriter writer, MessageVersion messageVersion);
-   public override string ToString();
-   public void WriteHeader(XmlDictionaryWriter writer, MessageVersion messageVersion);
-   public void WriteHeader(XmlWriter writer, MessageVersion messageVersion);
-   protected void WriteHeaderAttributes(XmlDictionaryWriter writer, MessageVersion messageVersion);
-   public void WriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion);
-   public void WriteStartHeader(XmlDictionaryWriter writer, MessageVersion messageVersion);
  }
- public abstract class MessageHeaderInfo {
-   protected MessageHeaderInfo();
-   public abstract string Actor { get; }
-   public abstract bool IsReferenceParameter { get; }
-   public abstract bool MustUnderstand { get; }
-   public abstract string Name { get; }
-   public abstract string Namespace { get; }
-   public abstract bool Relay { get; }
  }
- public sealed class MessageHeaders : IEnumerable, IEnumerable<MessageHeaderInfo> {
-   public MessageHeaders(MessageHeaders collection);
-   public MessageHeaders(MessageVersion version);
-   public MessageHeaders(MessageVersion version, int initialSize);
-   public string Action { get; set; }
-   public int Count { get; }
-   public EndpointAddress FaultTo { get; set; }
-   public EndpointAddress From { get; set; }
-   public UniqueId MessageId { get; set; }
-   public MessageVersion MessageVersion { get; }
-   public UniqueId RelatesTo { get; set; }
-   public EndpointAddress ReplyTo { get; set; }
-   public MessageHeaderInfo this[int index] { get; }
-   public Uri To { get; set; }
-   public void Add(MessageHeader header);
-   public void Clear();
-   public void CopyHeaderFrom(Message message, int headerIndex);
-   public void CopyHeaderFrom(MessageHeaders collection, int headerIndex);
-   public void CopyHeadersFrom(Message message);
-   public void CopyHeadersFrom(MessageHeaders collection);
-   public void CopyTo(MessageHeaderInfo[] array, int index);
-   public int FindHeader(string name, string ns);
-   public int FindHeader(string name, string ns, params string[] actors);
-   public IEnumerator<MessageHeaderInfo> GetEnumerator();
-   public T GetHeader<T>(int index);
-   public T GetHeader<T>(int index, XmlObjectSerializer serializer);
-   public T GetHeader<T>(string name, string ns);
-   public T GetHeader<T>(string name, string ns, XmlObjectSerializer serializer);
-   public T GetHeader<T>(string name, string ns, params string[] actors);
-   public XmlDictionaryReader GetReaderAtHeader(int headerIndex);
-   public bool HaveMandatoryHeadersBeenUnderstood();
-   public bool HaveMandatoryHeadersBeenUnderstood(params string[] actors);
-   public void Insert(int headerIndex, MessageHeader header);
-   public void RemoveAll(string name, string ns);
-   public void RemoveAt(int headerIndex);
-   public void SetAction(XmlDictionaryString action);
-   IEnumerator System.Collections.IEnumerable.GetEnumerator();
-   public void WriteHeader(int headerIndex, XmlDictionaryWriter writer);
-   public void WriteHeader(int headerIndex, XmlWriter writer);
-   public void WriteHeaderContents(int headerIndex, XmlDictionaryWriter writer);
-   public void WriteHeaderContents(int headerIndex, XmlWriter writer);
-   public void WriteStartHeader(int headerIndex, XmlDictionaryWriter writer);
-   public void WriteStartHeader(int headerIndex, XmlWriter writer);
  }
- public sealed class MessageProperties : ICollection<KeyValuePair<string, object>>, IDictionary<string, object>, IDisposable, IEnumerable, IEnumerable<KeyValuePair<string, object>> {
-   public MessageProperties();
-   public MessageProperties(MessageProperties properties);
-   public bool AllowOutputBatching { get; set; }
-   public int Count { get; }
-   public MessageEncoder Encoder { get; set; }
-   public bool IsFixedSize { get; }
-   public ICollection<string> Keys { get; }
-   bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }
-   public object this[string name] { get; set; }
-   public ICollection<object> Values { get; }
-   public Uri Via { get; set; }
-   public void Add(string name, object property);
-   public void Clear();
-   public bool ContainsKey(string name);
-   public void CopyProperties(MessageProperties properties);
-   public void Dispose();
-   public bool Remove(string name);
-   void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> pair);
-   bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> pair);
-   void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int index);
-   bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> pair);
-   IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator();
-   IEnumerator System.Collections.IEnumerable.GetEnumerator();
-   public bool TryGetValue(string name, out object value);
  }
- public enum MessageState {
-   Closed = 4,
-   Copied = 3,
-   Created = 0,
-   Read = 1,
-   Written = 2,
  }
- public sealed class MessageVersion {
-   public AddressingVersion Addressing { get; }
-   public static MessageVersion Default { get; }
-   public EnvelopeVersion Envelope { get; }
-   public static MessageVersion None { get; }
-   public static MessageVersion Soap11 { get; }
-   public static MessageVersion Soap12WSAddressing10 { get; }
-   public static MessageVersion CreateVersion(EnvelopeVersion envelopeVersion);
-   public static MessageVersion CreateVersion(EnvelopeVersion envelopeVersion, AddressingVersion addressingVersion);
-   public override bool Equals(object obj);
-   public override int GetHashCode();
-   public override string ToString();
  }
- public abstract class RequestContext : IDisposable {
-   protected RequestContext();
-   public abstract Message RequestMessage { get; }
-   public abstract void Abort();
-   public abstract IAsyncResult BeginReply(Message message, AsyncCallback callback, object state);
-   public abstract IAsyncResult BeginReply(Message message, TimeSpan timeout, AsyncCallback callback, object state);
-   public abstract void Close();
-   public abstract void Close(TimeSpan timeout);
-   protected virtual void Dispose(bool disposing);
-   public abstract void EndReply(IAsyncResult result);
-   public abstract void Reply(Message message);
-   public abstract void Reply(Message message, TimeSpan timeout);
-   void System.IDisposable.Dispose();
  }
- public sealed class TextMessageEncodingBindingElement : MessageEncodingBindingElement {
-   public TextMessageEncodingBindingElement();
-   public TextMessageEncodingBindingElement(MessageVersion messageVersion, Encoding writeEncoding);
-   public override MessageVersion MessageVersion { get; set; }
-   public XmlDictionaryReaderQuotas ReaderQuotas { get; set; }
-   public Encoding WriteEncoding { get; set; }
-   public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context);
-   public override BindingElement Clone();
-   public override MessageEncoderFactory CreateMessageEncoderFactory();
-   public override T GetProperty<T>(BindingContext context);
  }
- public abstract class TransportBindingElement : BindingElement {
-   protected TransportBindingElement();
-   protected TransportBindingElement(TransportBindingElement elementToBeCloned);
-   public virtual bool ManualAddressing { get; set; }
-   public virtual long MaxReceivedMessageSize { get; set; }
-   public abstract string Scheme { get; }
-   public override T GetProperty<T>(BindingContext context);
  }
 }
-namespace System.ServiceModel.Description {
- public class ClientCredentials : IEndpointBehavior {
-   public ClientCredentials();
-   protected ClientCredentials(ClientCredentials other);
-   public HttpDigestClientCredential HttpDigest { get; }
-   public UserNamePasswordClientCredential UserName { get; }
-   public WindowsClientCredential Windows { get; }
-   public virtual void ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior);
-   public ClientCredentials Clone();
-   protected virtual ClientCredentials CloneCore();
-   void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection bindingParameters);
-   void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
-   void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
  }
- public class ContractDescription {
-   public ContractDescription(string name);
-   public ContractDescription(string name, string ns);
-   public Type CallbackContractType { get; set; }
-   public string ConfigurationName { get; set; }
-   public KeyedCollection<Type, IContractBehavior> ContractBehaviors { get; }
-   public Type ContractType { get; set; }
-   public string Name { get; set; }
-   public string Namespace { get; set; }
-   public OperationDescriptionCollection Operations { get; }
  }
- public class DataContractSerializerOperationBehavior : IOperationBehavior {
-   public DataContractSerializerOperationBehavior(OperationDescription operation);
-   public DataContractSerializerOperationBehavior(OperationDescription operation, DataContractFormatAttribute dataContractFormatAttribute);
-   public DataContractFormatAttribute DataContractFormatAttribute { get; }
-   public DataContractResolver DataContractResolver { get; set; }
-   public int MaxItemsInObjectGraph { get; set; }
-   public virtual XmlObjectSerializer CreateSerializer(Type type, string name, string ns, IList<Type> knownTypes);
-   public virtual XmlObjectSerializer CreateSerializer(Type type, XmlDictionaryString name, XmlDictionaryString ns, IList<Type> knownTypes);
-   void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(OperationDescription description, BindingParameterCollection parameters);
-   void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(OperationDescription description, ClientOperation proxy);
-   void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(OperationDescription description, DispatchOperation dispatch);
-   void System.ServiceModel.Description.IOperationBehavior.Validate(OperationDescription description);
  }
- public class FaultDescription {
-   public FaultDescription(string action);
-   public string Action { get; }
-   public Type DetailType { get; set; }
-   public string Name { get; set; }
-   public string Namespace { get; set; }
  }
- public class FaultDescriptionCollection : Collection<FaultDescription> {
  }
- public interface IContractBehavior {
-   void AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
-   void ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime);
-   void ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime);
-   void Validate(ContractDescription contractDescription, ServiceEndpoint endpoint);
  }
- public interface IEndpointBehavior {
-   void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters);
-   void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime);
-   void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher);
-   void Validate(ServiceEndpoint endpoint);
  }
- public interface IOperationBehavior {
-   void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters);
-   void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation);
-   void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation);
-   void Validate(OperationDescription operationDescription);
  }
- public class MessageBodyDescription {
-   public MessageBodyDescription();
-   public MessagePartDescriptionCollection Parts { get; }
-   public MessagePartDescription ReturnValue { get; set; }
-   public string WrapperName { get; set; }
-   public string WrapperNamespace { get; set; }
  }
- public class MessageDescription {
-   public MessageDescription(string action, MessageDirection direction);
-   public string Action { get; }
-   public MessageBodyDescription Body { get; }
-   public MessageDirection Direction { get; }
-   public MessageHeaderDescriptionCollection Headers { get; }
-   public Type MessageType { get; set; }
-   public MessagePropertyDescriptionCollection Properties { get; }
  }
- public class MessageDescriptionCollection : Collection<MessageDescription> {
-   public MessageDescription Find(string action);
-   public Collection<MessageDescription> FindAll(string action);
  }
- public enum MessageDirection {
-   Input = 0,
-   Output = 1,
  }
- public class MessageHeaderDescription : MessagePartDescription {
-   public MessageHeaderDescription(string name, string ns);
-   public string Actor { get; set; }
-   public bool MustUnderstand { get; set; }
-   public bool Relay { get; set; }
-   public bool TypedHeader { get; set; }
  }
- public class MessageHeaderDescriptionCollection : KeyedCollection<XmlQualifiedName, MessageHeaderDescription> {
-   protected override XmlQualifiedName GetKeyForItem(MessageHeaderDescription item);
  }
- public class MessagePartDescription {
-   public MessagePartDescription(string name, string ns);
-   public int Index { get; set; }
-   public MemberInfo MemberInfo { get; set; }
-   public bool Multiple { get; set; }
-   public string Name { get; }
-   public string Namespace { get; }
-   public Type Type { get; set; }
  }
- public class MessagePartDescriptionCollection : KeyedCollection<XmlQualifiedName, MessagePartDescription> {
-   protected override XmlQualifiedName GetKeyForItem(MessagePartDescription item);
  }
- public class MessagePropertyDescription : MessagePartDescription {
-   public MessagePropertyDescription(string name);
  }
- public class MessagePropertyDescriptionCollection : KeyedCollection<string, MessagePropertyDescription> {
-   protected override string GetKeyForItem(MessagePropertyDescription item);
  }
- public class OperationDescription {
-   public OperationDescription(string name, ContractDescription declaringContract);
-   public ContractDescription DeclaringContract { get; set; }
-   public FaultDescriptionCollection Faults { get; }
-   public bool IsOneWay { get; }
-   public Collection<Type> KnownTypes { get; }
-   public MessageDescriptionCollection Messages { get; }
-   public string Name { get; }
-   public KeyedCollection<Type, IOperationBehavior> OperationBehaviors { get; }
-   public MethodInfo TaskMethod { get; set; }
  }
- public class OperationDescriptionCollection : Collection<OperationDescription> {
-   public OperationDescription Find(string name);
-   public Collection<OperationDescription> FindAll(string name);
-   protected override void InsertItem(int index, OperationDescription item);
-   protected override void SetItem(int index, OperationDescription item);
  }
- public class ServiceEndpoint {
-   public ServiceEndpoint(ContractDescription contract);
-   public ServiceEndpoint(ContractDescription contract, Binding binding, EndpointAddress address);
-   public EndpointAddress Address { get; set; }
-   public Binding Binding { get; set; }
-   public ContractDescription Contract { get; set; }
-   public KeyedCollection<Type, IEndpointBehavior> EndpointBehaviors { get; }
-   public string Name { get; set; }
  }
 }
-namespace System.ServiceModel.Dispatcher {
- public sealed class ClientOperation {
-   public ClientOperation(ClientRuntime parent, string name, string action);
-   public ClientOperation(ClientRuntime parent, string name, string action, string replyAction);
-   public string Action { get; }
-   public ICollection<IParameterInspector> ClientParameterInspectors { get; }
-   public bool DeserializeReply { get; set; }
-   public IClientMessageFormatter Formatter { get; set; }
-   public bool IsOneWay { get; set; }
-   public string Name { get; }
-   public ClientRuntime Parent { get; }
-   public string ReplyAction { get; }
-   public bool SerializeRequest { get; set; }
-   public MethodInfo TaskMethod { get; set; }
-   public Type TaskTResult { get; set; }
  }
- public sealed class ClientRuntime {
-   public ICollection<IClientMessageInspector> ClientMessageInspectors { get; }
-   public ICollection<ClientOperation> ClientOperations { get; }
-   public Type ContractClientType { get; set; }
-   public string ContractName { get; }
-   public string ContractNamespace { get; }
-   public bool ManualAddressing { get; set; }
-   public int MaxFaultSize { get; set; }
-   public IClientOperationSelector OperationSelector { get; set; }
-   public ClientOperation UnhandledClientOperation { get; }
-   public Uri Via { get; set; }
  }
- public sealed class DispatchOperation {
-   public DispatchOperation(DispatchRuntime parent, string name, string action);
-   public string Action { get; }
-   public bool AutoDisposeParameters { get; set; }
-   public bool DeserializeRequest { get; set; }
-   public bool IsOneWay { get; }
-   public string Name { get; }
-   public DispatchRuntime Parent { get; }
-   public bool SerializeReply { get; set; }
  }
- public sealed class DispatchRuntime {
  }
- public class EndpointDispatcher {
  }
- public interface IClientMessageFormatter {
-   object DeserializeReply(Message message, object[] parameters);
-   Message SerializeRequest(MessageVersion messageVersion, object[] parameters);
  }
- public interface IClientMessageInspector {
-   void AfterReceiveReply(ref Message reply, object correlationState);
-   object BeforeSendRequest(ref Message request, IClientChannel channel);
  }
- public interface IClientOperationSelector {
-   bool AreParametersRequiredForSelection { get; }
-   string SelectOperation(MethodBase method, object[] parameters);
  }
- public interface IParameterInspector {
-   void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState);
-   object BeforeCall(string operationName, object[] inputs);
  }
 }
-namespace System.ServiceModel.Security {
- public sealed class HttpDigestClientCredential {
-   public NetworkCredential ClientCredential { get; set; }
  }
- public class MessageSecurityException : CommunicationException {
-   public MessageSecurityException(string message);
-   public MessageSecurityException(string message, Exception innerException);
  }
- public class SecurityAccessDeniedException : CommunicationException {
-   public SecurityAccessDeniedException(string message);
-   public SecurityAccessDeniedException(string message, Exception innerException);
  }
- public sealed class UserNamePasswordClientCredential {
-   public string Password { get; set; }
-   public string UserName { get; set; }
  }
- public sealed class WindowsClientCredential {
-   public TokenImpersonationLevel AllowedImpersonationLevel { get; set; }
-   public NetworkCredential ClientCredential { get; set; }
  }
 }
```
