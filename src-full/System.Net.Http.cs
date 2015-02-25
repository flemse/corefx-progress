namespace System.Net.Http {
  public class ByteArrayContent : HttpContent {
    public ByteArrayContent(byte[] content);
    public ByteArrayContent(byte[] content, int offset, int count);
    protected override Task<Stream> CreateContentReadStreamAsync();
    protected override Task SerializeToStreamAsync(Stream stream, TransportContext context);
    protected internal override bool TryComputeLength(out long length);
  }
  public enum ClientCertificateOption {
    Automatic = 1,
    Manual = 0,
  }
  public abstract class DelegatingHandler : HttpMessageHandler {
    protected DelegatingHandler();
    protected DelegatingHandler(HttpMessageHandler innerHandler);
    public HttpMessageHandler InnerHandler { get; set; }
    protected override void Dispose(bool disposing);
    protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
  }
  public class FormUrlEncodedContent : ByteArrayContent {
    public FormUrlEncodedContent(IEnumerable<KeyValuePair<string, string>> nameValueCollection);
  }
  public class HttpClient : HttpMessageInvoker {
    public HttpClient();
    public HttpClient(HttpMessageHandler handler);
    public HttpClient(HttpMessageHandler handler, bool disposeHandler);
    public Uri BaseAddress { get; set; }
    public HttpRequestHeaders DefaultRequestHeaders { get; }
    public long MaxResponseContentBufferSize { get; set; }
    public TimeSpan Timeout { get; set; }
    public void CancelPendingRequests();
    public Task<HttpResponseMessage> DeleteAsync(string requestUri);
    public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken);
    public Task<HttpResponseMessage> DeleteAsync(Uri requestUri);
    public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken);
    protected override void Dispose(bool disposing);
    public Task<HttpResponseMessage> GetAsync(string requestUri);
    public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption);
    public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
    public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken);
    public Task<HttpResponseMessage> GetAsync(Uri requestUri);
    public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption);
    public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
    public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken);
    public Task<byte[]> GetByteArrayAsync(string requestUri);
    public Task<byte[]> GetByteArrayAsync(Uri requestUri);
    public Task<Stream> GetStreamAsync(string requestUri);
    public Task<Stream> GetStreamAsync(Uri requestUri);
    public Task<string> GetStringAsync(string requestUri);
    public Task<string> GetStringAsync(Uri requestUri);
    public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content);
    public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken);
    public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content);
    public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
    public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content);
    public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken);
    public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content);
    public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
    public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
    public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption);
    public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken);
    public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
  }
  public class HttpClientHandler : HttpMessageHandler {
    public HttpClientHandler();
    public bool AllowAutoRedirect { get; set; }
    public DecompressionMethods AutomaticDecompression { get; set; }
    public ClientCertificateOption ClientCertificateOptions { get; set; }
    public CookieContainer CookieContainer { get; set; }
    public ICredentials Credentials { get; set; }
    public int MaxAutomaticRedirections { get; set; }
    public long MaxRequestContentBufferSize { get; set; }
    public bool PreAuthenticate { get; set; }
    public IWebProxy Proxy { get; set; }
    public virtual bool SupportsAutomaticDecompression { get; }
    public virtual bool SupportsProxy { get; }
    public virtual bool SupportsRedirectConfiguration { get; }
    public bool UseCookies { get; set; }
    public bool UseDefaultCredentials { get; set; }
    public bool UseProxy { get; set; }
    protected override void Dispose(bool disposing);
    protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
  }
  public enum HttpCompletionOption {
    ResponseContentRead = 0,
    ResponseHeadersRead = 1,
  }
  public abstract class HttpContent : IDisposable {
    protected HttpContent();
    public HttpContentHeaders Headers { get; }
    public Task CopyToAsync(Stream stream);
    public Task CopyToAsync(Stream stream, TransportContext context);
    protected virtual Task<Stream> CreateContentReadStreamAsync();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public Task LoadIntoBufferAsync();
    public Task LoadIntoBufferAsync(long maxBufferSize);
    public Task<byte[]> ReadAsByteArrayAsync();
    public Task<Stream> ReadAsStreamAsync();
    public Task<string> ReadAsStringAsync();
    protected abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);
    protected internal abstract bool TryComputeLength(out long length);
  }
  public abstract class HttpMessageHandler : IDisposable {
    protected HttpMessageHandler();
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
  }
  public class HttpMessageInvoker : IDisposable {
    public HttpMessageInvoker(HttpMessageHandler handler);
    public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler);
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
  }
  public class HttpMethod : IEquatable<HttpMethod> {
    public HttpMethod(string method);
    public static HttpMethod Delete { get; }
    public static HttpMethod Get { get; }
    public static HttpMethod Head { get; }
    public string Method { get; }
    public static HttpMethod Options { get; }
    public static HttpMethod Post { get; }
    public static HttpMethod Put { get; }
    public static HttpMethod Trace { get; }
    public bool Equals(HttpMethod other);
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static bool operator ==(HttpMethod left, HttpMethod right);
    public static bool operator !=(HttpMethod left, HttpMethod right);
    public override string ToString();
  }
  public class HttpRequestException : Exception {
    public HttpRequestException();
    public HttpRequestException(string message);
    public HttpRequestException(string message, Exception inner);
  }
  public class HttpRequestMessage : IDisposable {
    public HttpRequestMessage();
    public HttpRequestMessage(HttpMethod method, string requestUri);
    public HttpRequestMessage(HttpMethod method, Uri requestUri);
    public HttpContent Content { get; set; }
    public HttpRequestHeaders Headers { get; }
    public HttpMethod Method { get; set; }
    public IDictionary<string, object> Properties { get; }
    public Uri RequestUri { get; set; }
    public Version Version { get; set; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public override string ToString();
  }
  public class HttpResponseMessage : IDisposable {
    public HttpResponseMessage();
    public HttpResponseMessage(HttpStatusCode statusCode);
    public HttpContent Content { get; set; }
    public HttpResponseHeaders Headers { get; }
    public bool IsSuccessStatusCode { get; }
    public string ReasonPhrase { get; set; }
    public HttpRequestMessage RequestMessage { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public Version Version { get; set; }
    public void Dispose();
    protected virtual void Dispose(bool disposing);
    public HttpResponseMessage EnsureSuccessStatusCode();
    public override string ToString();
  }
  public abstract class MessageProcessingHandler : DelegatingHandler {
    protected MessageProcessingHandler();
    protected MessageProcessingHandler(HttpMessageHandler innerHandler);
    protected abstract HttpRequestMessage ProcessRequest(HttpRequestMessage request, CancellationToken cancellationToken);
    protected abstract HttpResponseMessage ProcessResponse(HttpResponseMessage response, CancellationToken cancellationToken);
    protected internal sealed override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
  }
  public class MultipartContent : HttpContent, IEnumerable, IEnumerable<HttpContent> {
    public MultipartContent();
    public MultipartContent(string subtype);
    public MultipartContent(string subtype, string boundary);
    public virtual void Add(HttpContent content);
    protected override void Dispose(bool disposing);
    public IEnumerator<HttpContent> GetEnumerator();
    protected override Task SerializeToStreamAsync(Stream stream, TransportContext context);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    protected internal override bool TryComputeLength(out long length);
  }
  public class MultipartFormDataContent : MultipartContent {
    public MultipartFormDataContent();
    public MultipartFormDataContent(string boundary);
    public override void Add(HttpContent content);
    public void Add(HttpContent content, string name);
    public void Add(HttpContent content, string name, string fileName);
  }
  public class StreamContent : HttpContent {
    public StreamContent(Stream content);
    public StreamContent(Stream content, int bufferSize);
    protected override Task<Stream> CreateContentReadStreamAsync();
    protected override void Dispose(bool disposing);
    protected override Task SerializeToStreamAsync(Stream stream, TransportContext context);
    protected internal override bool TryComputeLength(out long length);
  }
  public class StringContent : ByteArrayContent {
    public StringContent(string content);
    public StringContent(string content, Encoding encoding);
    public StringContent(string content, Encoding encoding, string mediaType);
  }
}
namespace System.Net.Http.Headers {
  public class AuthenticationHeaderValue {
    public AuthenticationHeaderValue(string scheme);
    public AuthenticationHeaderValue(string scheme, string parameter);
    public string Parameter { get; }
    public string Scheme { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static AuthenticationHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue);
  }
  public class CacheControlHeaderValue {
    public CacheControlHeaderValue();
    public ICollection<NameValueHeaderValue> Extensions { get; }
    public Nullable<TimeSpan> MaxAge { get; set; }
    public bool MaxStale { get; set; }
    public Nullable<TimeSpan> MaxStaleLimit { get; set; }
    public Nullable<TimeSpan> MinFresh { get; set; }
    public bool MustRevalidate { get; set; }
    public bool NoCache { get; set; }
    public ICollection<string> NoCacheHeaders { get; }
    public bool NoStore { get; set; }
    public bool NoTransform { get; set; }
    public bool OnlyIfCached { get; set; }
    public bool Private { get; set; }
    public ICollection<string> PrivateHeaders { get; }
    public bool ProxyRevalidate { get; set; }
    public bool Public { get; set; }
    public Nullable<TimeSpan> SharedMaxAge { get; set; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static CacheControlHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out CacheControlHeaderValue parsedValue);
  }
  public class ContentDispositionHeaderValue {
    protected ContentDispositionHeaderValue(ContentDispositionHeaderValue source);
    public ContentDispositionHeaderValue(string dispositionType);
    public Nullable<DateTimeOffset> CreationDate { get; set; }
    public string DispositionType { get; set; }
    public string FileName { get; set; }
    public string FileNameStar { get; set; }
    public Nullable<DateTimeOffset> ModificationDate { get; set; }
    public string Name { get; set; }
    public ICollection<NameValueHeaderValue> Parameters { get; }
    public Nullable<DateTimeOffset> ReadDate { get; set; }
    public Nullable<long> Size { get; set; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static ContentDispositionHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue);
  }
  public class ContentRangeHeaderValue {
    public ContentRangeHeaderValue(long length);
    public ContentRangeHeaderValue(long from, long to);
    public ContentRangeHeaderValue(long from, long to, long length);
    public Nullable<long> From { get; }
    public bool HasLength { get; }
    public bool HasRange { get; }
    public Nullable<long> Length { get; }
    public Nullable<long> To { get; }
    public string Unit { get; set; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static ContentRangeHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue);
  }
  public class EntityTagHeaderValue {
    public EntityTagHeaderValue(string tag);
    public EntityTagHeaderValue(string tag, bool isWeak);
    public static EntityTagHeaderValue Any { get; }
    public bool IsWeak { get; }
    public string Tag { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static EntityTagHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out EntityTagHeaderValue parsedValue);
  }
  public sealed class HttpContentHeaders : HttpHeaders {
    public ICollection<string> Allow { get; }
    public ContentDispositionHeaderValue ContentDisposition { get; set; }
    public ICollection<string> ContentEncoding { get; }
    public ICollection<string> ContentLanguage { get; }
    public Nullable<long> ContentLength { get; set; }
    public Uri ContentLocation { get; set; }
    public byte[] ContentMD5 { get; set; }
    public ContentRangeHeaderValue ContentRange { get; set; }
    public MediaTypeHeaderValue ContentType { get; set; }
    public Nullable<DateTimeOffset> Expires { get; set; }
    public Nullable<DateTimeOffset> LastModified { get; set; }
  }
  public abstract class HttpHeaders : IEnumerable, IEnumerable<KeyValuePair<string, IEnumerable<string>>> {
    protected HttpHeaders();
    public void Add(string name, IEnumerable<string> values);
    public void Add(string name, string value);
    public void Clear();
    public bool Contains(string name);
    public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator();
    public IEnumerable<string> GetValues(string name);
    public bool Remove(string name);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    public override string ToString();
    public bool TryAddWithoutValidation(string name, IEnumerable<string> values);
    public bool TryAddWithoutValidation(string name, string value);
    public bool TryGetValues(string name, out IEnumerable<string> values);
  }
  public sealed class HttpHeaderValueCollection<T> : ICollection<T>, IEnumerable, IEnumerable<T> where T : class {
    public int Count { get; }
    public bool IsReadOnly { get; }
    public void Add(T item);
    public void Clear();
    public bool Contains(T item);
    public void CopyTo(T[] array, int arrayIndex);
    public IEnumerator<T> GetEnumerator();
    public void ParseAdd(string input);
    public bool Remove(T item);
    IEnumerator System.Collections.IEnumerable.GetEnumerator();
    public override string ToString();
    public bool TryParseAdd(string input);
  }
  public sealed class HttpRequestHeaders : HttpHeaders {
    public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept { get; }
    public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptCharset { get; }
    public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptEncoding { get; }
    public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptLanguage { get; }
    public AuthenticationHeaderValue Authorization { get; set; }
    public CacheControlHeaderValue CacheControl { get; set; }
    public HttpHeaderValueCollection<string> Connection { get; }
    public Nullable<bool> ConnectionClose { get; set; }
    public Nullable<DateTimeOffset> Date { get; set; }
    public HttpHeaderValueCollection<NameValueWithParametersHeaderValue> Expect { get; }
    public Nullable<bool> ExpectContinue { get; set; }
    public string From { get; set; }
    public string Host { get; set; }
    public HttpHeaderValueCollection<EntityTagHeaderValue> IfMatch { get; }
    public Nullable<DateTimeOffset> IfModifiedSince { get; set; }
    public HttpHeaderValueCollection<EntityTagHeaderValue> IfNoneMatch { get; }
    public RangeConditionHeaderValue IfRange { get; set; }
    public Nullable<DateTimeOffset> IfUnmodifiedSince { get; set; }
    public Nullable<int> MaxForwards { get; set; }
    public HttpHeaderValueCollection<NameValueHeaderValue> Pragma { get; }
    public AuthenticationHeaderValue ProxyAuthorization { get; set; }
    public RangeHeaderValue Range { get; set; }
    public Uri Referrer { get; set; }
    public HttpHeaderValueCollection<TransferCodingWithQualityHeaderValue> TE { get; }
    public HttpHeaderValueCollection<string> Trailer { get; }
    public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }
    public Nullable<bool> TransferEncodingChunked { get; set; }
    public HttpHeaderValueCollection<ProductHeaderValue> Upgrade { get; }
    public HttpHeaderValueCollection<ProductInfoHeaderValue> UserAgent { get; }
    public HttpHeaderValueCollection<ViaHeaderValue> Via { get; }
    public HttpHeaderValueCollection<WarningHeaderValue> Warning { get; }
  }
  public sealed class HttpResponseHeaders : HttpHeaders {
    public HttpHeaderValueCollection<string> AcceptRanges { get; }
    public Nullable<TimeSpan> Age { get; set; }
    public CacheControlHeaderValue CacheControl { get; set; }
    public HttpHeaderValueCollection<string> Connection { get; }
    public Nullable<bool> ConnectionClose { get; set; }
    public Nullable<DateTimeOffset> Date { get; set; }
    public EntityTagHeaderValue ETag { get; set; }
    public Uri Location { get; set; }
    public HttpHeaderValueCollection<NameValueHeaderValue> Pragma { get; }
    public HttpHeaderValueCollection<AuthenticationHeaderValue> ProxyAuthenticate { get; }
    public RetryConditionHeaderValue RetryAfter { get; set; }
    public HttpHeaderValueCollection<ProductInfoHeaderValue> Server { get; }
    public HttpHeaderValueCollection<string> Trailer { get; }
    public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }
    public Nullable<bool> TransferEncodingChunked { get; set; }
    public HttpHeaderValueCollection<ProductHeaderValue> Upgrade { get; }
    public HttpHeaderValueCollection<string> Vary { get; }
    public HttpHeaderValueCollection<ViaHeaderValue> Via { get; }
    public HttpHeaderValueCollection<WarningHeaderValue> Warning { get; }
    public HttpHeaderValueCollection<AuthenticationHeaderValue> WwwAuthenticate { get; }
  }
  public class MediaTypeHeaderValue {
    protected MediaTypeHeaderValue(MediaTypeHeaderValue source);
    public MediaTypeHeaderValue(string mediaType);
    public string CharSet { get; set; }
    public string MediaType { get; set; }
    public ICollection<NameValueHeaderValue> Parameters { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static MediaTypeHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue);
  }
  public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue {
    public MediaTypeWithQualityHeaderValue(string mediaType);
    public MediaTypeWithQualityHeaderValue(string mediaType, double quality);
    public Nullable<double> Quality { get; set; }
    public static new MediaTypeWithQualityHeaderValue Parse(string input);
    public static bool TryParse(string input, out MediaTypeWithQualityHeaderValue parsedValue);
  }
  public class NameValueHeaderValue {
    protected NameValueHeaderValue(NameValueHeaderValue source);
    public NameValueHeaderValue(string name);
    public NameValueHeaderValue(string name, string value);
    public string Name { get; }
    public string Value { get; set; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static NameValueHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out NameValueHeaderValue parsedValue);
  }
  public class NameValueWithParametersHeaderValue : NameValueHeaderValue {
    protected NameValueWithParametersHeaderValue(NameValueWithParametersHeaderValue source);
    public NameValueWithParametersHeaderValue(string name);
    public NameValueWithParametersHeaderValue(string name, string value);
    public ICollection<NameValueHeaderValue> Parameters { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static new NameValueWithParametersHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out NameValueWithParametersHeaderValue parsedValue);
  }
  public class ProductHeaderValue {
    public ProductHeaderValue(string name);
    public ProductHeaderValue(string name, string version);
    public string Name { get; }
    public string Version { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static ProductHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out ProductHeaderValue parsedValue);
  }
  public class ProductInfoHeaderValue {
    public ProductInfoHeaderValue(ProductHeaderValue product);
    public ProductInfoHeaderValue(string comment);
    public ProductInfoHeaderValue(string productName, string productVersion);
    public string Comment { get; }
    public ProductHeaderValue Product { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static ProductInfoHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out ProductInfoHeaderValue parsedValue);
  }
  public class RangeConditionHeaderValue {
    public RangeConditionHeaderValue(DateTimeOffset date);
    public RangeConditionHeaderValue(EntityTagHeaderValue entityTag);
    public RangeConditionHeaderValue(string entityTag);
    public Nullable<DateTimeOffset> Date { get; }
    public EntityTagHeaderValue EntityTag { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static RangeConditionHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue);
  }
  public class RangeHeaderValue {
    public RangeHeaderValue();
    public RangeHeaderValue(Nullable<long> from, Nullable<long> to);
    public ICollection<RangeItemHeaderValue> Ranges { get; }
    public string Unit { get; set; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static RangeHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out RangeHeaderValue parsedValue);
  }
  public class RangeItemHeaderValue {
    public RangeItemHeaderValue(Nullable<long> from, Nullable<long> to);
    public Nullable<long> From { get; }
    public Nullable<long> To { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public override string ToString();
  }
  public class RetryConditionHeaderValue {
    public RetryConditionHeaderValue(DateTimeOffset date);
    public RetryConditionHeaderValue(TimeSpan delta);
    public Nullable<DateTimeOffset> Date { get; }
    public Nullable<TimeSpan> Delta { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static RetryConditionHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue);
  }
  public class StringWithQualityHeaderValue {
    public StringWithQualityHeaderValue(string value);
    public StringWithQualityHeaderValue(string value, double quality);
    public Nullable<double> Quality { get; }
    public string Value { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static StringWithQualityHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out StringWithQualityHeaderValue parsedValue);
  }
  public class TransferCodingHeaderValue {
    protected TransferCodingHeaderValue(TransferCodingHeaderValue source);
    public TransferCodingHeaderValue(string value);
    public ICollection<NameValueHeaderValue> Parameters { get; }
    public string Value { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static TransferCodingHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out TransferCodingHeaderValue parsedValue);
  }
  public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue {
    public TransferCodingWithQualityHeaderValue(string value);
    public TransferCodingWithQualityHeaderValue(string value, double quality);
    public Nullable<double> Quality { get; set; }
    public static new TransferCodingWithQualityHeaderValue Parse(string input);
    public static bool TryParse(string input, out TransferCodingWithQualityHeaderValue parsedValue);
  }
  public class ViaHeaderValue {
    public ViaHeaderValue(string protocolVersion, string receivedBy);
    public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName);
    public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName, string comment);
    public string Comment { get; }
    public string ProtocolName { get; }
    public string ProtocolVersion { get; }
    public string ReceivedBy { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static ViaHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out ViaHeaderValue parsedValue);
  }
  public class WarningHeaderValue {
    public WarningHeaderValue(int code, string agent, string text);
    public WarningHeaderValue(int code, string agent, string text, DateTimeOffset date);
    public string Agent { get; }
    public int Code { get; }
    public Nullable<DateTimeOffset> Date { get; }
    public string Text { get; }
    public override bool Equals(object obj);
    public override int GetHashCode();
    public static WarningHeaderValue Parse(string input);
    public override string ToString();
    public static bool TryParse(string input, out WarningHeaderValue parsedValue);
  }
}
