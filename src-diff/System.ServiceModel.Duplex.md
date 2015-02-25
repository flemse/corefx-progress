```diff
---lib-full\System.ServiceModel.Duplex.dll
+++lib-oss\System.ServiceModel.Duplex.dll
-namespace System.ServiceModel {
- public sealed class CallbackBehaviorAttribute : Attribute, IEndpointBehavior {
-   public CallbackBehaviorAttribute();
-   public bool AutomaticSessionShutdown { get; set; }
-   public bool UseSynchronizationContext { get; set; }
-   void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection parameters);
-   void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime clientRuntime);
-   void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher);
-   void System.ServiceModel.Description.IEndpointBehavior.Validate(ServiceEndpoint serviceEndpoint);
  }
- public class DuplexChannelFactory<TChannel> : ChannelFactory<TChannel> {
-   public DuplexChannelFactory(InstanceContext callbackInstance, Binding binding);
-   public DuplexChannelFactory(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress);
-   public DuplexChannelFactory(InstanceContext callbackInstance, Binding binding, string remoteAddress);
-   public DuplexChannelFactory(InstanceContext callbackInstance, string endpointConfigurationName);
-   public DuplexChannelFactory(InstanceContext callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress);
-   public override TChannel CreateChannel(EndpointAddress address, Uri via);
-   public TChannel CreateChannel(InstanceContext callbackInstance);
-   public TChannel CreateChannel(InstanceContext callbackInstance, EndpointAddress address);
-   public virtual TChannel CreateChannel(InstanceContext callbackInstance, EndpointAddress address, Uri via);
  }
- public abstract class DuplexClientBase<TChannel> : ClientBase<TChannel> where TChannel : class {
-   protected DuplexClientBase(InstanceContext callbackInstance);
-   protected DuplexClientBase(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress);
-   protected DuplexClientBase(InstanceContext callbackInstance, string endpointConfigurationName);
-   protected DuplexClientBase(InstanceContext callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress);
-   protected DuplexClientBase(InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress);
  }
- public sealed class InstanceContext : CommunicationObject, IExtensibleObject<InstanceContext> {
-   public InstanceContext(object implementation);
-   protected override TimeSpan DefaultCloseTimeout { get; }
-   protected override TimeSpan DefaultOpenTimeout { get; }
-   public SynchronizationContext SynchronizationContext { get; set; }
-   IExtensionCollection<InstanceContext> System.ServiceModel.IExtensibleObject<System.ServiceModel.InstanceContext>.Extensions { get; }
-   public object GetServiceInstance(Message message);
-   protected override void OnAbort();
-   protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state);
-   protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state);
-   protected override void OnClose(TimeSpan timeout);
-   protected override void OnClosed();
-   protected override void OnEndClose(IAsyncResult result);
-   protected override void OnEndOpen(IAsyncResult result);
-   protected override void OnFaulted();
-   protected override void OnOpen(TimeSpan timeout);
-   protected override void OnOpened();
-   protected override void OnOpening();
  }
 }
```
