namespace Microsoft.SqlServer.Server {
  public class SqlDataRecord {
    public SqlDataRecord(params SqlMetaData[] metaData);
    public virtual int FieldCount { get; }
    public virtual object this[int ordinal] { get; }
    public virtual object this[string name] { get; }
    public virtual bool GetBoolean(int ordinal);
    public virtual byte GetByte(int ordinal);
    public virtual long GetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length);
    public virtual char GetChar(int ordinal);
    public virtual long GetChars(int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length);
    public virtual string GetDataTypeName(int ordinal);
    public virtual DateTime GetDateTime(int ordinal);
    public virtual DateTimeOffset GetDateTimeOffset(int ordinal);
    public virtual decimal GetDecimal(int ordinal);
    public virtual double GetDouble(int ordinal);
    public virtual Type GetFieldType(int ordinal);
    public virtual float GetFloat(int ordinal);
    public virtual Guid GetGuid(int ordinal);
    public virtual short GetInt16(int ordinal);
    public virtual int GetInt32(int ordinal);
    public virtual long GetInt64(int ordinal);
    public virtual string GetName(int ordinal);
    public virtual int GetOrdinal(string name);
    public virtual SqlBinary GetSqlBinary(int ordinal);
    public virtual SqlBoolean GetSqlBoolean(int ordinal);
    public virtual SqlByte GetSqlByte(int ordinal);
    public virtual SqlBytes GetSqlBytes(int ordinal);
    public virtual SqlChars GetSqlChars(int ordinal);
    public virtual SqlDateTime GetSqlDateTime(int ordinal);
    public virtual SqlDecimal GetSqlDecimal(int ordinal);
    public virtual SqlDouble GetSqlDouble(int ordinal);
    public virtual Type GetSqlFieldType(int ordinal);
    public virtual SqlGuid GetSqlGuid(int ordinal);
    public virtual SqlInt16 GetSqlInt16(int ordinal);
    public virtual SqlInt32 GetSqlInt32(int ordinal);
    public virtual SqlInt64 GetSqlInt64(int ordinal);
    public virtual SqlMetaData GetSqlMetaData(int ordinal);
    public virtual SqlMoney GetSqlMoney(int ordinal);
    public virtual SqlSingle GetSqlSingle(int ordinal);
    public virtual SqlString GetSqlString(int ordinal);
    public virtual object GetSqlValue(int ordinal);
    public virtual int GetSqlValues(object[] values);
    public virtual SqlXml GetSqlXml(int ordinal);
    public virtual string GetString(int ordinal);
    public virtual TimeSpan GetTimeSpan(int ordinal);
    public virtual object GetValue(int ordinal);
    public virtual int GetValues(object[] values);
    public virtual bool IsDBNull(int ordinal);
    public virtual void SetBoolean(int ordinal, bool value);
    public virtual void SetByte(int ordinal, byte value);
    public virtual void SetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length);
    public virtual void SetChar(int ordinal, char value);
    public virtual void SetChars(int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length);
    public virtual void SetDateTime(int ordinal, DateTime value);
    public virtual void SetDateTimeOffset(int ordinal, DateTimeOffset value);
    public virtual void SetDBNull(int ordinal);
    public virtual void SetDecimal(int ordinal, decimal value);
    public virtual void SetDouble(int ordinal, double value);
    public virtual void SetFloat(int ordinal, float value);
    public virtual void SetGuid(int ordinal, Guid value);
    public virtual void SetInt16(int ordinal, short value);
    public virtual void SetInt32(int ordinal, int value);
    public virtual void SetInt64(int ordinal, long value);
    public virtual void SetSqlBinary(int ordinal, SqlBinary value);
    public virtual void SetSqlBoolean(int ordinal, SqlBoolean value);
    public virtual void SetSqlByte(int ordinal, SqlByte value);
    public virtual void SetSqlBytes(int ordinal, SqlBytes value);
    public virtual void SetSqlChars(int ordinal, SqlChars value);
    public virtual void SetSqlDateTime(int ordinal, SqlDateTime value);
    public virtual void SetSqlDecimal(int ordinal, SqlDecimal value);
    public virtual void SetSqlDouble(int ordinal, SqlDouble value);
    public virtual void SetSqlGuid(int ordinal, SqlGuid value);
    public virtual void SetSqlInt16(int ordinal, SqlInt16 value);
    public virtual void SetSqlInt32(int ordinal, SqlInt32 value);
    public virtual void SetSqlInt64(int ordinal, SqlInt64 value);
    public virtual void SetSqlMoney(int ordinal, SqlMoney value);
    public virtual void SetSqlSingle(int ordinal, SqlSingle value);
    public virtual void SetSqlString(int ordinal, SqlString value);
    public virtual void SetSqlXml(int ordinal, SqlXml value);
    public virtual void SetString(int ordinal, string value);
    public virtual void SetTimeSpan(int ordinal, TimeSpan value);
    public virtual void SetValue(int ordinal, object value);
    public virtual int SetValues(params object[] values);
  }
  public sealed class SqlMetaData {
    public SqlMetaData(string name, SqlDbType dbType);
    public SqlMetaData(string name, SqlDbType dbType, bool useServerDefault, bool isUniqueKey, SortOrder columnSortOrder, int sortOrdinal);
    public SqlMetaData(string name, SqlDbType dbType, byte precision, byte scale);
    public SqlMetaData(string name, SqlDbType dbType, byte precision, byte scale, bool useServerDefault, bool isUniqueKey, SortOrder columnSortOrder, int sortOrdinal);
    public SqlMetaData(string name, SqlDbType dbType, long maxLength);
    public SqlMetaData(string name, SqlDbType dbType, long maxLength, bool useServerDefault, bool isUniqueKey, SortOrder columnSortOrder, int sortOrdinal);
    public SqlMetaData(string name, SqlDbType dbType, long maxLength, byte precision, byte scale, long locale, SqlCompareOptions compareOptions, Type userDefinedType);
    public SqlMetaData(string name, SqlDbType dbType, long maxLength, byte precision, byte scale, long localeId, SqlCompareOptions compareOptions, Type userDefinedType, bool useServerDefault, bool isUniqueKey, SortOrder columnSortOrder, int sortOrdinal);
    public SqlMetaData(string name, SqlDbType dbType, long maxLength, long locale, SqlCompareOptions compareOptions);
    public SqlMetaData(string name, SqlDbType dbType, long maxLength, long locale, SqlCompareOptions compareOptions, bool useServerDefault, bool isUniqueKey, SortOrder columnSortOrder, int sortOrdinal);
    public SqlMetaData(string name, SqlDbType dbType, string database, string owningSchema, string objectName);
    public SqlMetaData(string name, SqlDbType dbType, string database, string owningSchema, string objectName, bool useServerDefault, bool isUniqueKey, SortOrder columnSortOrder, int sortOrdinal);
    public SqlCompareOptions CompareOptions { get; }
    public bool IsUniqueKey { get; }
    public long LocaleId { get; }
    public static long Max { get; }
    public long MaxLength { get; }
    public string Name { get; }
    public byte Precision { get; }
    public byte Scale { get; }
    public SortOrder SortOrder { get; }
    public int SortOrdinal { get; }
    public SqlDbType SqlDbType { get; }
    public string TypeName { get; }
    public bool UseServerDefault { get; }
    public string XmlSchemaCollectionDatabase { get; }
    public string XmlSchemaCollectionName { get; }
    public string XmlSchemaCollectionOwningSchema { get; }
    public bool Adjust(bool value);
    public byte Adjust(byte value);
    public byte[] Adjust(byte[] value);
    public char Adjust(char value);
    public char[] Adjust(char[] value);
    public SqlBinary Adjust(SqlBinary value);
    public SqlBoolean Adjust(SqlBoolean value);
    public SqlByte Adjust(SqlByte value);
    public SqlBytes Adjust(SqlBytes value);
    public SqlChars Adjust(SqlChars value);
    public SqlDateTime Adjust(SqlDateTime value);
    public SqlDecimal Adjust(SqlDecimal value);
    public SqlDouble Adjust(SqlDouble value);
    public SqlGuid Adjust(SqlGuid value);
    public SqlInt16 Adjust(SqlInt16 value);
    public SqlInt32 Adjust(SqlInt32 value);
    public SqlInt64 Adjust(SqlInt64 value);
    public SqlMoney Adjust(SqlMoney value);
    public SqlSingle Adjust(SqlSingle value);
    public SqlString Adjust(SqlString value);
    public SqlXml Adjust(SqlXml value);
    public DateTime Adjust(DateTime value);
    public DateTimeOffset Adjust(DateTimeOffset value);
    public decimal Adjust(decimal value);
    public double Adjust(double value);
    public Guid Adjust(Guid value);
    public short Adjust(short value);
    public int Adjust(int value);
    public long Adjust(long value);
    public object Adjust(object value);
    public float Adjust(float value);
    public string Adjust(string value);
    public TimeSpan Adjust(TimeSpan value);
    public static SqlMetaData InferFromValue(object value, string name);
  }
}
namespace System.Data {
  public enum SqlDbType {
    BigInt = 0,
    Binary = 1,
    Bit = 2,
    Char = 3,
    Date = 31,
    DateTime = 4,
    DateTime2 = 33,
    DateTimeOffset = 34,
    Decimal = 5,
    Float = 6,
    Image = 7,
    Int = 8,
    Money = 9,
    NChar = 10,
    NText = 11,
    NVarChar = 12,
    Real = 13,
    SmallDateTime = 15,
    SmallInt = 16,
    SmallMoney = 17,
    Structured = 30,
    Text = 18,
    Time = 32,
    Timestamp = 19,
    TinyInt = 20,
    Udt = 29,
    UniqueIdentifier = 14,
    VarBinary = 21,
    VarChar = 22,
    Variant = 23,
    Xml = 25,
  }
  public sealed class StatementCompletedEventArgs : EventArgs {
    public StatementCompletedEventArgs(int recordCount);
    public int RecordCount { get; }
  }
  public delegate void StatementCompletedEventHandler(object sender, StatementCompletedEventArgs e);
}
namespace System.Data.SqlClient {
  public enum ApplicationIntent {
    ReadOnly = 1,
    ReadWrite = 0,
  }
  public enum SortOrder {
    Ascending = 0,
    Descending = 1,
    Unspecified = -1,
  }
  public sealed class SqlClientFactory : DbProviderFactory {
    public static readonly SqlClientFactory Instance;
    public override DbCommand CreateCommand();
    public override DbConnection CreateConnection();
    public override DbConnectionStringBuilder CreateConnectionStringBuilder();
    public override DbParameter CreateParameter();
  }
  public sealed class SqlCommand : DbCommand {
    public SqlCommand();
    public SqlCommand(string cmdText);
    public SqlCommand(string cmdText, SqlConnection connection);
    public SqlCommand(string cmdText, SqlConnection connection, SqlTransaction transaction);
    public override string CommandText { get; set; }
    public override int CommandTimeout { get; set; }
    public override CommandType CommandType { get; set; }
    public SqlConnection Connection { get; set; }
    protected override DbConnection DbConnection { get; set; }
    protected override DbParameterCollection DbParameterCollection { get; }
    protected override DbTransaction DbTransaction { get; set; }
    public override bool DesignTimeVisible { get; set; }
    public SqlParameterCollection Parameters { get; }
    public SqlTransaction Transaction { get; set; }
    public override UpdateRowSource UpdatedRowSource { get; set; }
    public event StatementCompletedEventHandler StatementCompleted;
    public override void Cancel();
    protected override DbParameter CreateDbParameter();
    public SqlParameter CreateParameter();
    protected override void Dispose(bool disposing);
    protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior);
    protected override Task<DbDataReader> ExecuteDbDataReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken);
    public override int ExecuteNonQuery();
    public override Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken);
    public SqlDataReader ExecuteReader();
    public SqlDataReader ExecuteReader(CommandBehavior behavior);
    public Task<SqlDataReader> ExecuteReaderAsync();
    public Task<SqlDataReader> ExecuteReaderAsync(CommandBehavior behavior);
    public Task<SqlDataReader> ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken);
    public Task<SqlDataReader> ExecuteReaderAsync(CancellationToken cancellationToken);
    public override object ExecuteScalar();
    public override Task<object> ExecuteScalarAsync(CancellationToken cancellationToken);
    public XmlReader ExecuteXmlReader();
    public Task<XmlReader> ExecuteXmlReaderAsync();
    public Task<XmlReader> ExecuteXmlReaderAsync(CancellationToken cancellationToken);
    public override void Prepare();
  }
  public sealed class SqlConnection : DbConnection {
    public SqlConnection();
    public SqlConnection(string connectionString);
    public Guid ClientConnectionId { get; }
    public override string ConnectionString { get; set; }
    public override int ConnectionTimeout { get; }
    public override string Database { get; }
    public override string DataSource { get; }
    protected override DbProviderFactory DbProviderFactory { get; }
    public bool FireInfoMessageEventOnUserErrors { get; set; }
    public int PacketSize { get; }
    public override string ServerVersion { get; }
    public override ConnectionState State { get; }
    public bool StatisticsEnabled { get; set; }
    public string WorkstationId { get; }
    public event SqlInfoMessageEventHandler InfoMessage;
    protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);
    public SqlTransaction BeginTransaction();
    public SqlTransaction BeginTransaction(IsolationLevel iso);
    public SqlTransaction BeginTransaction(IsolationLevel iso, string transactionName);
    public SqlTransaction BeginTransaction(string transactionName);
    public override void ChangeDatabase(string database);
    public static void ClearAllPools();
    public static void ClearPool(SqlConnection connection);
    public override void Close();
    public SqlCommand CreateCommand();
    protected override DbCommand CreateDbCommand();
    protected override void Dispose(bool disposing);
    public override void Open();
    public override Task OpenAsync(CancellationToken cancellationToken);
    public void ResetStatistics();
    public IDictionary RetrieveStatistics();
  }
  public sealed class SqlConnectionStringBuilder : DbConnectionStringBuilder {
    public SqlConnectionStringBuilder();
    public SqlConnectionStringBuilder(string connectionString);
    public ApplicationIntent ApplicationIntent { get; set; }
    public string ApplicationName { get; set; }
    public string AttachDBFilename { get; set; }
    public int ConnectRetryCount { get; set; }
    public int ConnectRetryInterval { get; set; }
    public int ConnectTimeout { get; set; }
    public string CurrentLanguage { get; set; }
    public string DataSource { get; set; }
    public bool Encrypt { get; set; }
    public string FailoverPartner { get; set; }
    public string InitialCatalog { get; set; }
    public bool IntegratedSecurity { get; set; }
    public override ICollection Keys { get; }
    public int LoadBalanceTimeout { get; set; }
    public int MaxPoolSize { get; set; }
    public int MinPoolSize { get; set; }
    public bool MultipleActiveResultSets { get; set; }
    public bool MultiSubnetFailover { get; set; }
    public int PacketSize { get; set; }
    public string Password { get; set; }
    public bool PersistSecurityInfo { get; set; }
    public bool Pooling { get; set; }
    public bool Replication { get; set; }
    public override object this[string keyword] { get; set; }
    public bool TrustServerCertificate { get; set; }
    public string TypeSystemVersion { get; set; }
    public string UserID { get; set; }
    public bool UserInstance { get; set; }
    public override ICollection Values { get; }
    public string WorkstationID { get; set; }
    public override void Clear();
    public override bool ContainsKey(string keyword);
    public override bool Remove(string keyword);
    public override bool ShouldSerialize(string keyword);
    public override bool TryGetValue(string keyword, out object value);
  }
  public class SqlDataReader : DbDataReader, IDisposable {
    protected SqlConnection Connection { get; }
    public override int Depth { get; }
    public override int FieldCount { get; }
    public override bool HasRows { get; }
    public override bool IsClosed { get; }
    public override int RecordsAffected { get; }
    public override object this[int i] { get; }
    public override object this[string name] { get; }
    public override int VisibleFieldCount { get; }
    public override bool GetBoolean(int i);
    public override byte GetByte(int i);
    public override long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length);
    public override char GetChar(int i);
    public override long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length);
    public override string GetDataTypeName(int i);
    public override DateTime GetDateTime(int i);
    public virtual DateTimeOffset GetDateTimeOffset(int i);
    public override decimal GetDecimal(int i);
    public override double GetDouble(int i);
    public override IEnumerator GetEnumerator();
    public override Type GetFieldType(int i);
    public override T GetFieldValue<T>(int i);
    public override Task<T> GetFieldValueAsync<T>(int i, CancellationToken cancellationToken);
    public override float GetFloat(int i);
    public override Guid GetGuid(int i);
    public override short GetInt16(int i);
    public override int GetInt32(int i);
    public override long GetInt64(int i);
    public override string GetName(int i);
    public override int GetOrdinal(string name);
    public override Type GetProviderSpecificFieldType(int i);
    public override object GetProviderSpecificValue(int i);
    public override int GetProviderSpecificValues(object[] values);
    public virtual SqlBinary GetSqlBinary(int i);
    public virtual SqlBoolean GetSqlBoolean(int i);
    public virtual SqlByte GetSqlByte(int i);
    public virtual SqlBytes GetSqlBytes(int i);
    public virtual SqlChars GetSqlChars(int i);
    public virtual SqlDateTime GetSqlDateTime(int i);
    public virtual SqlDecimal GetSqlDecimal(int i);
    public virtual SqlDouble GetSqlDouble(int i);
    public virtual SqlGuid GetSqlGuid(int i);
    public virtual SqlInt16 GetSqlInt16(int i);
    public virtual SqlInt32 GetSqlInt32(int i);
    public virtual SqlInt64 GetSqlInt64(int i);
    public virtual SqlMoney GetSqlMoney(int i);
    public virtual SqlSingle GetSqlSingle(int i);
    public virtual SqlString GetSqlString(int i);
    public virtual object GetSqlValue(int i);
    public virtual int GetSqlValues(object[] values);
    public virtual SqlXml GetSqlXml(int i);
    public override Stream GetStream(int i);
    public override string GetString(int i);
    public override TextReader GetTextReader(int i);
    public virtual TimeSpan GetTimeSpan(int i);
    public override object GetValue(int i);
    public override int GetValues(object[] values);
    public virtual XmlReader GetXmlReader(int i);
    public override bool IsDBNull(int i);
    public override Task<bool> IsDBNullAsync(int i, CancellationToken cancellationToken);
    public override bool NextResult();
    public override Task<bool> NextResultAsync(CancellationToken cancellationToken);
    public override bool Read();
    public override Task<bool> ReadAsync(CancellationToken cancellationToken);
  }
  public sealed class SqlError {
    public byte Class { get; }
    public int LineNumber { get; }
    public string Message { get; }
    public int Number { get; }
    public string Procedure { get; }
    public string Server { get; }
    public string Source { get; }
    public byte State { get; }
    public override string ToString();
  }
  public sealed class SqlErrorCollection : ICollection, IEnumerable {
    public int Count { get; }
    bool System.Collections.ICollection.IsSynchronized { get; }
    object System.Collections.ICollection.SyncRoot { get; }
    public SqlError this[int index] { get; }
    public void CopyTo(Array array, int index);
    public void CopyTo(SqlError[] array, int index);
    public IEnumerator GetEnumerator();
  }
  public sealed class SqlException : DbException {
    public byte Class { get; }
    public Guid ClientConnectionId { get; }
    public SqlErrorCollection Errors { get; }
    public int LineNumber { get; }
    public int Number { get; }
    public string Procedure { get; }
    public string Server { get; }
    public override string Source { get; }
    public byte State { get; }
    public override string ToString();
  }
  public sealed class SqlInfoMessageEventArgs : EventArgs {
    public SqlErrorCollection Errors { get; }
    public string Message { get; }
    public string Source { get; }
    public override string ToString();
  }
  public delegate void SqlInfoMessageEventHandler(object sender, SqlInfoMessageEventArgs e);
  public sealed class SqlParameter : DbParameter {
    public SqlParameter();
    public SqlParameter(string parameterName, SqlDbType dbType);
    public SqlParameter(string parameterName, SqlDbType dbType, int size);
    public SqlParameter(string parameterName, SqlDbType dbType, int size, string sourceColumn);
    public SqlParameter(string parameterName, object value);
    public SqlCompareOptions CompareInfo { get; set; }
    public override DbType DbType { get; set; }
    public override ParameterDirection Direction { get; set; }
    public override bool IsNullable { get; set; }
    public int LocaleId { get; set; }
    public int Offset { get; set; }
    public override string ParameterName { get; set; }
    public byte Precision { get; set; }
    public byte Scale { get; set; }
    public override int Size { get; set; }
    public override string SourceColumn { get; set; }
    public override bool SourceColumnNullMapping { get; set; }
    public SqlDbType SqlDbType { get; set; }
    public object SqlValue { get; set; }
    public string TypeName { get; set; }
    public override object Value { get; set; }
    public string XmlSchemaCollectionDatabase { get; set; }
    public string XmlSchemaCollectionName { get; set; }
    public string XmlSchemaCollectionOwningSchema { get; set; }
    public override void ResetDbType();
    public void ResetSqlDbType();
    public override string ToString();
  }
  public sealed class SqlParameterCollection : DbParameterCollection {
    public override int Count { get; }
    public override object SyncRoot { get; }
    public SqlParameter this[int index] { get; set; }
    public SqlParameter this[string parameterName] { get; set; }
    public SqlParameter Add(SqlParameter value);
    public override int Add(object value);
    public SqlParameter Add(string parameterName, SqlDbType sqlDbType);
    public SqlParameter Add(string parameterName, SqlDbType sqlDbType, int size);
    public override void AddRange(Array values);
    public void AddRange(SqlParameter[] values);
    public SqlParameter AddWithValue(string parameterName, object value);
    public override void Clear();
    public bool Contains(SqlParameter value);
    public override bool Contains(object value);
    public override bool Contains(string value);
    public override void CopyTo(Array array, int index);
    public void CopyTo(SqlParameter[] array, int index);
    public override IEnumerator GetEnumerator();
    protected override DbParameter GetParameter(int index);
    protected override DbParameter GetParameter(string parameterName);
    public int IndexOf(SqlParameter value);
    public override int IndexOf(object value);
    public override int IndexOf(string parameterName);
    public void Insert(int index, SqlParameter value);
    public override void Insert(int index, object value);
    public void Remove(SqlParameter value);
    public override void Remove(object value);
    public override void RemoveAt(int index);
    public override void RemoveAt(string parameterName);
    protected override void SetParameter(int index, DbParameter value);
    protected override void SetParameter(string parameterName, DbParameter value);
  }
  public sealed class SqlTransaction : DbTransaction {
    public SqlConnection Connection { get; }
    protected override DbConnection DbConnection { get; }
    public override IsolationLevel IsolationLevel { get; }
    public override void Commit();
    protected override void Dispose(bool disposing);
    public override void Rollback();
    public void Rollback(string transactionName);
    public void Save(string savePointName);
  }
}
namespace System.Data.SqlTypes {
  public interface INullable {
    bool IsNull { get; }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlBinary : IComparable, INullable {
    public static readonly SqlBinary Null;
    public SqlBinary(byte[] value);
    public bool IsNull { get; }
    public int Length { get; }
    public byte this[int index] { get; }
    public byte[] Value { get; }
    public static SqlBinary Add(SqlBinary x, SqlBinary y);
    public int CompareTo(SqlBinary value);
    public int CompareTo(object value);
    public static SqlBinary Concat(SqlBinary x, SqlBinary y);
    public static SqlBoolean Equals(SqlBinary x, SqlBinary y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlBinary x, SqlBinary y);
    public static SqlBoolean GreaterThanOrEqual(SqlBinary x, SqlBinary y);
    public static SqlBoolean LessThan(SqlBinary x, SqlBinary y);
    public static SqlBoolean LessThanOrEqual(SqlBinary x, SqlBinary y);
    public static SqlBoolean NotEquals(SqlBinary x, SqlBinary y);
    public static SqlBinary operator +(SqlBinary x, SqlBinary y);
    public static SqlBoolean operator ==(SqlBinary x, SqlBinary y);
    public static explicit operator byte[] (SqlBinary x);
    public static explicit operator SqlBinary (SqlGuid x);
    public static SqlBoolean operator >(SqlBinary x, SqlBinary y);
    public static SqlBoolean operator >=(SqlBinary x, SqlBinary y);
    public static implicit operator SqlBinary (byte[] x);
    public static SqlBoolean operator !=(SqlBinary x, SqlBinary y);
    public static SqlBoolean operator <(SqlBinary x, SqlBinary y);
    public static SqlBoolean operator <=(SqlBinary x, SqlBinary y);
    public SqlGuid ToSqlGuid();
    public override string ToString();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlBoolean : IComparable, INullable {
    public static readonly SqlBoolean False;
    public static readonly SqlBoolean Null;
    public static readonly SqlBoolean One;
    public static readonly SqlBoolean True;
    public static readonly SqlBoolean Zero;
    public SqlBoolean(bool value);
    public SqlBoolean(int value);
    public byte ByteValue { get; }
    public bool IsFalse { get; }
    public bool IsNull { get; }
    public bool IsTrue { get; }
    public bool Value { get; }
    public static SqlBoolean And(SqlBoolean x, SqlBoolean y);
    public int CompareTo(SqlBoolean value);
    public int CompareTo(object value);
    public static SqlBoolean Equals(SqlBoolean x, SqlBoolean y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean GreaterThanOrEquals(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean LessThan(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean LessThanOrEquals(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean NotEquals(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean OnesComplement(SqlBoolean x);
    public static SqlBoolean operator &(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean operator |(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean operator ==(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean operator ^(SqlBoolean x, SqlBoolean y);
    public static explicit operator bool (SqlBoolean x);
    public static explicit operator SqlBoolean (SqlByte x);
    public static explicit operator SqlBoolean (SqlDecimal x);
    public static explicit operator SqlBoolean (SqlDouble x);
    public static explicit operator SqlBoolean (SqlInt16 x);
    public static explicit operator SqlBoolean (SqlInt32 x);
    public static explicit operator SqlBoolean (SqlInt64 x);
    public static explicit operator SqlBoolean (SqlMoney x);
    public static explicit operator SqlBoolean (SqlSingle x);
    public static explicit operator SqlBoolean (SqlString x);
    public static bool operator false(SqlBoolean x);
    public static SqlBoolean operator >(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean operator >=(SqlBoolean x, SqlBoolean y);
    public static implicit operator SqlBoolean (bool x);
    public static SqlBoolean operator !=(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean operator <(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean operator <=(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean operator !(SqlBoolean x);
    public static SqlBoolean operator ~(SqlBoolean x);
    public static bool operator true(SqlBoolean x);
    public static SqlBoolean Or(SqlBoolean x, SqlBoolean y);
    public static SqlBoolean Parse(string s);
    public SqlByte ToSqlByte();
    public SqlDecimal ToSqlDecimal();
    public SqlDouble ToSqlDouble();
    public SqlInt16 ToSqlInt16();
    public SqlInt32 ToSqlInt32();
    public SqlInt64 ToSqlInt64();
    public SqlMoney ToSqlMoney();
    public SqlSingle ToSqlSingle();
    public SqlString ToSqlString();
    public override string ToString();
    public static SqlBoolean Xor(SqlBoolean x, SqlBoolean y);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlByte : IComparable, INullable {
    public static readonly SqlByte MaxValue;
    public static readonly SqlByte MinValue;
    public static readonly SqlByte Null;
    public static readonly SqlByte Zero;
    public SqlByte(byte value);
    public bool IsNull { get; }
    public byte Value { get; }
    public static SqlByte Add(SqlByte x, SqlByte y);
    public static SqlByte BitwiseAnd(SqlByte x, SqlByte y);
    public static SqlByte BitwiseOr(SqlByte x, SqlByte y);
    public int CompareTo(SqlByte value);
    public int CompareTo(object value);
    public static SqlByte Divide(SqlByte x, SqlByte y);
    public static SqlBoolean Equals(SqlByte x, SqlByte y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlByte x, SqlByte y);
    public static SqlBoolean GreaterThanOrEqual(SqlByte x, SqlByte y);
    public static SqlBoolean LessThan(SqlByte x, SqlByte y);
    public static SqlBoolean LessThanOrEqual(SqlByte x, SqlByte y);
    public static SqlByte Mod(SqlByte x, SqlByte y);
    public static SqlByte Modulus(SqlByte x, SqlByte y);
    public static SqlByte Multiply(SqlByte x, SqlByte y);
    public static SqlBoolean NotEquals(SqlByte x, SqlByte y);
    public static SqlByte OnesComplement(SqlByte x);
    public static SqlByte operator +(SqlByte x, SqlByte y);
    public static SqlByte operator &(SqlByte x, SqlByte y);
    public static SqlByte operator |(SqlByte x, SqlByte y);
    public static SqlByte operator /(SqlByte x, SqlByte y);
    public static SqlBoolean operator ==(SqlByte x, SqlByte y);
    public static SqlByte operator ^(SqlByte x, SqlByte y);
    public static explicit operator SqlByte (SqlBoolean x);
    public static explicit operator byte (SqlByte x);
    public static explicit operator SqlByte (SqlDecimal x);
    public static explicit operator SqlByte (SqlDouble x);
    public static explicit operator SqlByte (SqlInt16 x);
    public static explicit operator SqlByte (SqlInt32 x);
    public static explicit operator SqlByte (SqlInt64 x);
    public static explicit operator SqlByte (SqlMoney x);
    public static explicit operator SqlByte (SqlSingle x);
    public static explicit operator SqlByte (SqlString x);
    public static SqlBoolean operator >(SqlByte x, SqlByte y);
    public static SqlBoolean operator >=(SqlByte x, SqlByte y);
    public static implicit operator SqlByte (byte x);
    public static SqlBoolean operator !=(SqlByte x, SqlByte y);
    public static SqlBoolean operator <(SqlByte x, SqlByte y);
    public static SqlBoolean operator <=(SqlByte x, SqlByte y);
    public static SqlByte operator %(SqlByte x, SqlByte y);
    public static SqlByte operator *(SqlByte x, SqlByte y);
    public static SqlByte operator ~(SqlByte x);
    public static SqlByte operator -(SqlByte x, SqlByte y);
    public static SqlByte Parse(string s);
    public static SqlByte Subtract(SqlByte x, SqlByte y);
    public SqlBoolean ToSqlBoolean();
    public SqlDecimal ToSqlDecimal();
    public SqlDouble ToSqlDouble();
    public SqlInt16 ToSqlInt16();
    public SqlInt32 ToSqlInt32();
    public SqlInt64 ToSqlInt64();
    public SqlMoney ToSqlMoney();
    public SqlSingle ToSqlSingle();
    public SqlString ToSqlString();
    public override string ToString();
    public static SqlByte Xor(SqlByte x, SqlByte y);
  }
  public sealed class SqlBytes : INullable {
    public SqlBytes();
    public SqlBytes(byte[] buffer);
    public SqlBytes(SqlBinary value);
    public SqlBytes(Stream s);
    public byte[] Buffer { get; }
    public bool IsNull { get; }
    public long Length { get; }
    public long MaxLength { get; }
    public static SqlBytes Null { get; }
    public Stream Stream { get; set; }
    public byte this[long offset] { get; set; }
    public byte[] Value { get; }
    public static explicit operator SqlBytes (SqlBinary value);
    public static explicit operator SqlBinary (SqlBytes value);
    public long Read(long offset, byte[] buffer, int offsetInBuffer, int count);
    public void SetLength(long value);
    public void SetNull();
    public SqlBinary ToSqlBinary();
    public void Write(long offset, byte[] buffer, int offsetInBuffer, int count);
  }
  public sealed class SqlChars : INullable {
    public SqlChars();
    public SqlChars(char[] buffer);
    public SqlChars(SqlString value);
    public char[] Buffer { get; }
    public bool IsNull { get; }
    public long Length { get; }
    public long MaxLength { get; }
    public static SqlChars Null { get; }
    public char this[long offset] { get; set; }
    public char[] Value { get; }
    public static explicit operator SqlString (SqlChars value);
    public static explicit operator SqlChars (SqlString value);
    public long Read(long offset, char[] buffer, int offsetInBuffer, int count);
    public void SetLength(long value);
    public void SetNull();
    public SqlString ToSqlString();
    public void Write(long offset, char[] buffer, int offsetInBuffer, int count);
  }
  public enum SqlCompareOptions {
    BinarySort = 32768,
    BinarySort2 = 16384,
    IgnoreCase = 1,
    IgnoreKanaType = 8,
    IgnoreNonSpace = 2,
    IgnoreWidth = 16,
    None = 0,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlDateTime : IComparable, INullable {
    public static readonly SqlDateTime MaxValue;
    public static readonly SqlDateTime MinValue;
    public static readonly SqlDateTime Null;
    public static readonly int SQLTicksPerHour;
    public static readonly int SQLTicksPerMinute;
    public static readonly int SQLTicksPerSecond;
    public SqlDateTime(DateTime value);
    public SqlDateTime(int dayTicks, int timeTicks);
    public SqlDateTime(int year, int month, int day);
    public SqlDateTime(int year, int month, int day, int hour, int minute, int second);
    public SqlDateTime(int year, int month, int day, int hour, int minute, int second, double millisecond);
    public SqlDateTime(int year, int month, int day, int hour, int minute, int second, int bilisecond);
    public int DayTicks { get; }
    public bool IsNull { get; }
    public int TimeTicks { get; }
    public DateTime Value { get; }
    public static SqlDateTime Add(SqlDateTime x, TimeSpan t);
    public int CompareTo(SqlDateTime value);
    public int CompareTo(object value);
    public static SqlBoolean Equals(SqlDateTime x, SqlDateTime y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y);
    public static SqlBoolean GreaterThanOrEqual(SqlDateTime x, SqlDateTime y);
    public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y);
    public static SqlBoolean LessThanOrEqual(SqlDateTime x, SqlDateTime y);
    public static SqlBoolean NotEquals(SqlDateTime x, SqlDateTime y);
    public static SqlDateTime operator +(SqlDateTime x, TimeSpan t);
    public static SqlBoolean operator ==(SqlDateTime x, SqlDateTime y);
    public static explicit operator DateTime (SqlDateTime x);
    public static explicit operator SqlDateTime (SqlString x);
    public static SqlBoolean operator >(SqlDateTime x, SqlDateTime y);
    public static SqlBoolean operator >=(SqlDateTime x, SqlDateTime y);
    public static implicit operator SqlDateTime (DateTime value);
    public static SqlBoolean operator !=(SqlDateTime x, SqlDateTime y);
    public static SqlBoolean operator <(SqlDateTime x, SqlDateTime y);
    public static SqlBoolean operator <=(SqlDateTime x, SqlDateTime y);
    public static SqlDateTime operator -(SqlDateTime x, TimeSpan t);
    public static SqlDateTime Parse(string s);
    public static SqlDateTime Subtract(SqlDateTime x, TimeSpan t);
    public SqlString ToSqlString();
    public override string ToString();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlDecimal : IComparable, INullable {
    public static readonly byte MaxPrecision;
    public static readonly byte MaxScale;
    public static readonly SqlDecimal MaxValue;
    public static readonly SqlDecimal MinValue;
    public static readonly SqlDecimal Null;
    public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int data1, int data2, int data3, int data4);
    public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int[] bits);
    public SqlDecimal(decimal value);
    public SqlDecimal(double dVal);
    public SqlDecimal(int value);
    public SqlDecimal(long value);
    public byte[] BinData { get; }
    public int[] Data { get; }
    public bool IsNull { get; }
    public bool IsPositive { get; }
    public byte Precision { get; }
    public byte Scale { get; }
    public decimal Value { get; }
    public static SqlDecimal Abs(SqlDecimal n);
    public static SqlDecimal Add(SqlDecimal x, SqlDecimal y);
    public static SqlDecimal AdjustScale(SqlDecimal n, int digits, bool fRound);
    public static SqlDecimal Ceiling(SqlDecimal n);
    public int CompareTo(SqlDecimal value);
    public int CompareTo(object value);
    public static SqlDecimal ConvertToPrecScale(SqlDecimal n, int precision, int scale);
    public static SqlDecimal Divide(SqlDecimal x, SqlDecimal y);
    public static SqlBoolean Equals(SqlDecimal x, SqlDecimal y);
    public override bool Equals(object value);
    public static SqlDecimal Floor(SqlDecimal n);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y);
    public static SqlBoolean GreaterThanOrEqual(SqlDecimal x, SqlDecimal y);
    public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y);
    public static SqlBoolean LessThanOrEqual(SqlDecimal x, SqlDecimal y);
    public static SqlDecimal Multiply(SqlDecimal x, SqlDecimal y);
    public static SqlBoolean NotEquals(SqlDecimal x, SqlDecimal y);
    public static SqlDecimal operator +(SqlDecimal x, SqlDecimal y);
    public static SqlDecimal operator /(SqlDecimal x, SqlDecimal y);
    public static SqlBoolean operator ==(SqlDecimal x, SqlDecimal y);
    public static explicit operator SqlDecimal (SqlBoolean x);
    public static explicit operator decimal (SqlDecimal x);
    public static explicit operator SqlDecimal (SqlDouble x);
    public static explicit operator SqlDecimal (SqlSingle x);
    public static explicit operator SqlDecimal (SqlString x);
    public static explicit operator SqlDecimal (double x);
    public static SqlBoolean operator >(SqlDecimal x, SqlDecimal y);
    public static SqlBoolean operator >=(SqlDecimal x, SqlDecimal y);
    public static implicit operator SqlDecimal (SqlByte x);
    public static implicit operator SqlDecimal (SqlInt16 x);
    public static implicit operator SqlDecimal (SqlInt32 x);
    public static implicit operator SqlDecimal (SqlInt64 x);
    public static implicit operator SqlDecimal (SqlMoney x);
    public static implicit operator SqlDecimal (decimal x);
    public static implicit operator SqlDecimal (long x);
    public static SqlBoolean operator !=(SqlDecimal x, SqlDecimal y);
    public static SqlBoolean operator <(SqlDecimal x, SqlDecimal y);
    public static SqlBoolean operator <=(SqlDecimal x, SqlDecimal y);
    public static SqlDecimal operator *(SqlDecimal x, SqlDecimal y);
    public static SqlDecimal operator -(SqlDecimal x, SqlDecimal y);
    public static SqlDecimal operator -(SqlDecimal x);
    public static SqlDecimal Parse(string s);
    public static SqlDecimal Power(SqlDecimal n, double exp);
    public static SqlDecimal Round(SqlDecimal n, int position);
    public static SqlInt32 Sign(SqlDecimal n);
    public static SqlDecimal Subtract(SqlDecimal x, SqlDecimal y);
    public double ToDouble();
    public SqlBoolean ToSqlBoolean();
    public SqlByte ToSqlByte();
    public SqlDouble ToSqlDouble();
    public SqlInt16 ToSqlInt16();
    public SqlInt32 ToSqlInt32();
    public SqlInt64 ToSqlInt64();
    public SqlMoney ToSqlMoney();
    public SqlSingle ToSqlSingle();
    public SqlString ToSqlString();
    public override string ToString();
    public static SqlDecimal Truncate(SqlDecimal n, int position);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlDouble : IComparable, INullable {
    public static readonly SqlDouble MaxValue;
    public static readonly SqlDouble MinValue;
    public static readonly SqlDouble Null;
    public static readonly SqlDouble Zero;
    public SqlDouble(double value);
    public bool IsNull { get; }
    public double Value { get; }
    public static SqlDouble Add(SqlDouble x, SqlDouble y);
    public int CompareTo(SqlDouble value);
    public int CompareTo(object value);
    public static SqlDouble Divide(SqlDouble x, SqlDouble y);
    public static SqlBoolean Equals(SqlDouble x, SqlDouble y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y);
    public static SqlBoolean GreaterThanOrEqual(SqlDouble x, SqlDouble y);
    public static SqlBoolean LessThan(SqlDouble x, SqlDouble y);
    public static SqlBoolean LessThanOrEqual(SqlDouble x, SqlDouble y);
    public static SqlDouble Multiply(SqlDouble x, SqlDouble y);
    public static SqlBoolean NotEquals(SqlDouble x, SqlDouble y);
    public static SqlDouble operator +(SqlDouble x, SqlDouble y);
    public static SqlDouble operator /(SqlDouble x, SqlDouble y);
    public static SqlBoolean operator ==(SqlDouble x, SqlDouble y);
    public static explicit operator SqlDouble (SqlBoolean x);
    public static explicit operator double (SqlDouble x);
    public static explicit operator SqlDouble (SqlString x);
    public static SqlBoolean operator >(SqlDouble x, SqlDouble y);
    public static SqlBoolean operator >=(SqlDouble x, SqlDouble y);
    public static implicit operator SqlDouble (SqlByte x);
    public static implicit operator SqlDouble (SqlDecimal x);
    public static implicit operator SqlDouble (SqlInt16 x);
    public static implicit operator SqlDouble (SqlInt32 x);
    public static implicit operator SqlDouble (SqlInt64 x);
    public static implicit operator SqlDouble (SqlMoney x);
    public static implicit operator SqlDouble (SqlSingle x);
    public static implicit operator SqlDouble (double x);
    public static SqlBoolean operator !=(SqlDouble x, SqlDouble y);
    public static SqlBoolean operator <(SqlDouble x, SqlDouble y);
    public static SqlBoolean operator <=(SqlDouble x, SqlDouble y);
    public static SqlDouble operator *(SqlDouble x, SqlDouble y);
    public static SqlDouble operator -(SqlDouble x, SqlDouble y);
    public static SqlDouble operator -(SqlDouble x);
    public static SqlDouble Parse(string s);
    public static SqlDouble Subtract(SqlDouble x, SqlDouble y);
    public SqlBoolean ToSqlBoolean();
    public SqlByte ToSqlByte();
    public SqlDecimal ToSqlDecimal();
    public SqlInt16 ToSqlInt16();
    public SqlInt32 ToSqlInt32();
    public SqlInt64 ToSqlInt64();
    public SqlMoney ToSqlMoney();
    public SqlSingle ToSqlSingle();
    public SqlString ToSqlString();
    public override string ToString();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlGuid : IComparable, INullable {
    public static readonly SqlGuid Null;
    public SqlGuid(byte[] value);
    public SqlGuid(Guid g);
    public SqlGuid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k);
    public SqlGuid(string s);
    public bool IsNull { get; }
    public Guid Value { get; }
    public int CompareTo(SqlGuid value);
    public int CompareTo(object value);
    public static SqlBoolean Equals(SqlGuid x, SqlGuid y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlGuid x, SqlGuid y);
    public static SqlBoolean GreaterThanOrEqual(SqlGuid x, SqlGuid y);
    public static SqlBoolean LessThan(SqlGuid x, SqlGuid y);
    public static SqlBoolean LessThanOrEqual(SqlGuid x, SqlGuid y);
    public static SqlBoolean NotEquals(SqlGuid x, SqlGuid y);
    public static SqlBoolean operator ==(SqlGuid x, SqlGuid y);
    public static explicit operator SqlGuid (SqlBinary x);
    public static explicit operator Guid (SqlGuid x);
    public static explicit operator SqlGuid (SqlString x);
    public static SqlBoolean operator >(SqlGuid x, SqlGuid y);
    public static SqlBoolean operator >=(SqlGuid x, SqlGuid y);
    public static implicit operator SqlGuid (Guid x);
    public static SqlBoolean operator !=(SqlGuid x, SqlGuid y);
    public static SqlBoolean operator <(SqlGuid x, SqlGuid y);
    public static SqlBoolean operator <=(SqlGuid x, SqlGuid y);
    public static SqlGuid Parse(string s);
    public byte[] ToByteArray();
    public SqlBinary ToSqlBinary();
    public SqlString ToSqlString();
    public override string ToString();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlInt16 : IComparable, INullable {
    public static readonly SqlInt16 MaxValue;
    public static readonly SqlInt16 MinValue;
    public static readonly SqlInt16 Null;
    public static readonly SqlInt16 Zero;
    public SqlInt16(short value);
    public bool IsNull { get; }
    public short Value { get; }
    public static SqlInt16 Add(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 BitwiseAnd(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 BitwiseOr(SqlInt16 x, SqlInt16 y);
    public int CompareTo(SqlInt16 value);
    public int CompareTo(object value);
    public static SqlInt16 Divide(SqlInt16 x, SqlInt16 y);
    public static SqlBoolean Equals(SqlInt16 x, SqlInt16 y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y);
    public static SqlBoolean GreaterThanOrEqual(SqlInt16 x, SqlInt16 y);
    public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y);
    public static SqlBoolean LessThanOrEqual(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 Mod(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 Modulus(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 Multiply(SqlInt16 x, SqlInt16 y);
    public static SqlBoolean NotEquals(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 OnesComplement(SqlInt16 x);
    public static SqlInt16 operator +(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 operator &(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 operator |(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 operator /(SqlInt16 x, SqlInt16 y);
    public static SqlBoolean operator ==(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 operator ^(SqlInt16 x, SqlInt16 y);
    public static explicit operator SqlInt16 (SqlBoolean x);
    public static explicit operator SqlInt16 (SqlDecimal x);
    public static explicit operator SqlInt16 (SqlDouble x);
    public static explicit operator short (SqlInt16 x);
    public static explicit operator SqlInt16 (SqlInt32 x);
    public static explicit operator SqlInt16 (SqlInt64 x);
    public static explicit operator SqlInt16 (SqlMoney x);
    public static explicit operator SqlInt16 (SqlSingle x);
    public static explicit operator SqlInt16 (SqlString x);
    public static SqlBoolean operator >(SqlInt16 x, SqlInt16 y);
    public static SqlBoolean operator >=(SqlInt16 x, SqlInt16 y);
    public static implicit operator SqlInt16 (SqlByte x);
    public static implicit operator SqlInt16 (short x);
    public static SqlBoolean operator !=(SqlInt16 x, SqlInt16 y);
    public static SqlBoolean operator <(SqlInt16 x, SqlInt16 y);
    public static SqlBoolean operator <=(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 operator %(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 operator *(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 operator ~(SqlInt16 x);
    public static SqlInt16 operator -(SqlInt16 x, SqlInt16 y);
    public static SqlInt16 operator -(SqlInt16 x);
    public static SqlInt16 Parse(string s);
    public static SqlInt16 Subtract(SqlInt16 x, SqlInt16 y);
    public SqlBoolean ToSqlBoolean();
    public SqlByte ToSqlByte();
    public SqlDecimal ToSqlDecimal();
    public SqlDouble ToSqlDouble();
    public SqlInt32 ToSqlInt32();
    public SqlInt64 ToSqlInt64();
    public SqlMoney ToSqlMoney();
    public SqlSingle ToSqlSingle();
    public SqlString ToSqlString();
    public override string ToString();
    public static SqlInt16 Xor(SqlInt16 x, SqlInt16 y);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlInt32 : IComparable, INullable {
    public static readonly SqlInt32 MaxValue;
    public static readonly SqlInt32 MinValue;
    public static readonly SqlInt32 Null;
    public static readonly SqlInt32 Zero;
    public SqlInt32(int value);
    public bool IsNull { get; }
    public int Value { get; }
    public static SqlInt32 Add(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 BitwiseAnd(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 BitwiseOr(SqlInt32 x, SqlInt32 y);
    public int CompareTo(SqlInt32 value);
    public int CompareTo(object value);
    public static SqlInt32 Divide(SqlInt32 x, SqlInt32 y);
    public static SqlBoolean Equals(SqlInt32 x, SqlInt32 y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y);
    public static SqlBoolean GreaterThanOrEqual(SqlInt32 x, SqlInt32 y);
    public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y);
    public static SqlBoolean LessThanOrEqual(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 Mod(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 Modulus(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 Multiply(SqlInt32 x, SqlInt32 y);
    public static SqlBoolean NotEquals(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 OnesComplement(SqlInt32 x);
    public static SqlInt32 operator +(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 operator &(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 operator |(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 operator /(SqlInt32 x, SqlInt32 y);
    public static SqlBoolean operator ==(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 operator ^(SqlInt32 x, SqlInt32 y);
    public static explicit operator SqlInt32 (SqlBoolean x);
    public static explicit operator SqlInt32 (SqlDecimal x);
    public static explicit operator SqlInt32 (SqlDouble x);
    public static explicit operator int (SqlInt32 x);
    public static explicit operator SqlInt32 (SqlInt64 x);
    public static explicit operator SqlInt32 (SqlMoney x);
    public static explicit operator SqlInt32 (SqlSingle x);
    public static explicit operator SqlInt32 (SqlString x);
    public static SqlBoolean operator >(SqlInt32 x, SqlInt32 y);
    public static SqlBoolean operator >=(SqlInt32 x, SqlInt32 y);
    public static implicit operator SqlInt32 (SqlByte x);
    public static implicit operator SqlInt32 (SqlInt16 x);
    public static implicit operator SqlInt32 (int x);
    public static SqlBoolean operator !=(SqlInt32 x, SqlInt32 y);
    public static SqlBoolean operator <(SqlInt32 x, SqlInt32 y);
    public static SqlBoolean operator <=(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 operator %(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 operator *(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 operator ~(SqlInt32 x);
    public static SqlInt32 operator -(SqlInt32 x, SqlInt32 y);
    public static SqlInt32 operator -(SqlInt32 x);
    public static SqlInt32 Parse(string s);
    public static SqlInt32 Subtract(SqlInt32 x, SqlInt32 y);
    public SqlBoolean ToSqlBoolean();
    public SqlByte ToSqlByte();
    public SqlDecimal ToSqlDecimal();
    public SqlDouble ToSqlDouble();
    public SqlInt16 ToSqlInt16();
    public SqlInt64 ToSqlInt64();
    public SqlMoney ToSqlMoney();
    public SqlSingle ToSqlSingle();
    public SqlString ToSqlString();
    public override string ToString();
    public static SqlInt32 Xor(SqlInt32 x, SqlInt32 y);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlInt64 : IComparable, INullable {
    public static readonly SqlInt64 MaxValue;
    public static readonly SqlInt64 MinValue;
    public static readonly SqlInt64 Null;
    public static readonly SqlInt64 Zero;
    public SqlInt64(long value);
    public bool IsNull { get; }
    public long Value { get; }
    public static SqlInt64 Add(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 BitwiseAnd(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 BitwiseOr(SqlInt64 x, SqlInt64 y);
    public int CompareTo(SqlInt64 value);
    public int CompareTo(object value);
    public static SqlInt64 Divide(SqlInt64 x, SqlInt64 y);
    public static SqlBoolean Equals(SqlInt64 x, SqlInt64 y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y);
    public static SqlBoolean GreaterThanOrEqual(SqlInt64 x, SqlInt64 y);
    public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y);
    public static SqlBoolean LessThanOrEqual(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 Mod(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 Modulus(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 Multiply(SqlInt64 x, SqlInt64 y);
    public static SqlBoolean NotEquals(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 OnesComplement(SqlInt64 x);
    public static SqlInt64 operator +(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 operator &(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 operator |(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 operator /(SqlInt64 x, SqlInt64 y);
    public static SqlBoolean operator ==(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 operator ^(SqlInt64 x, SqlInt64 y);
    public static explicit operator SqlInt64 (SqlBoolean x);
    public static explicit operator SqlInt64 (SqlDecimal x);
    public static explicit operator SqlInt64 (SqlDouble x);
    public static explicit operator long (SqlInt64 x);
    public static explicit operator SqlInt64 (SqlMoney x);
    public static explicit operator SqlInt64 (SqlSingle x);
    public static explicit operator SqlInt64 (SqlString x);
    public static SqlBoolean operator >(SqlInt64 x, SqlInt64 y);
    public static SqlBoolean operator >=(SqlInt64 x, SqlInt64 y);
    public static implicit operator SqlInt64 (SqlByte x);
    public static implicit operator SqlInt64 (SqlInt16 x);
    public static implicit operator SqlInt64 (SqlInt32 x);
    public static implicit operator SqlInt64 (long x);
    public static SqlBoolean operator !=(SqlInt64 x, SqlInt64 y);
    public static SqlBoolean operator <(SqlInt64 x, SqlInt64 y);
    public static SqlBoolean operator <=(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 operator %(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 operator *(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 operator ~(SqlInt64 x);
    public static SqlInt64 operator -(SqlInt64 x, SqlInt64 y);
    public static SqlInt64 operator -(SqlInt64 x);
    public static SqlInt64 Parse(string s);
    public static SqlInt64 Subtract(SqlInt64 x, SqlInt64 y);
    public SqlBoolean ToSqlBoolean();
    public SqlByte ToSqlByte();
    public SqlDecimal ToSqlDecimal();
    public SqlDouble ToSqlDouble();
    public SqlInt16 ToSqlInt16();
    public SqlInt32 ToSqlInt32();
    public SqlMoney ToSqlMoney();
    public SqlSingle ToSqlSingle();
    public SqlString ToSqlString();
    public override string ToString();
    public static SqlInt64 Xor(SqlInt64 x, SqlInt64 y);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlMoney : IComparable, INullable {
    public static readonly SqlMoney MaxValue;
    public static readonly SqlMoney MinValue;
    public static readonly SqlMoney Null;
    public static readonly SqlMoney Zero;
    public SqlMoney(decimal value);
    public SqlMoney(double value);
    public SqlMoney(int value);
    public SqlMoney(long value);
    public bool IsNull { get; }
    public decimal Value { get; }
    public static SqlMoney Add(SqlMoney x, SqlMoney y);
    public int CompareTo(SqlMoney value);
    public int CompareTo(object value);
    public static SqlMoney Divide(SqlMoney x, SqlMoney y);
    public static SqlBoolean Equals(SqlMoney x, SqlMoney y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y);
    public static SqlBoolean GreaterThanOrEqual(SqlMoney x, SqlMoney y);
    public static SqlBoolean LessThan(SqlMoney x, SqlMoney y);
    public static SqlBoolean LessThanOrEqual(SqlMoney x, SqlMoney y);
    public static SqlMoney Multiply(SqlMoney x, SqlMoney y);
    public static SqlBoolean NotEquals(SqlMoney x, SqlMoney y);
    public static SqlMoney operator +(SqlMoney x, SqlMoney y);
    public static SqlMoney operator /(SqlMoney x, SqlMoney y);
    public static SqlBoolean operator ==(SqlMoney x, SqlMoney y);
    public static explicit operator SqlMoney (SqlBoolean x);
    public static explicit operator SqlMoney (SqlDecimal x);
    public static explicit operator SqlMoney (SqlDouble x);
    public static explicit operator decimal (SqlMoney x);
    public static explicit operator SqlMoney (SqlSingle x);
    public static explicit operator SqlMoney (SqlString x);
    public static explicit operator SqlMoney (double x);
    public static SqlBoolean operator >(SqlMoney x, SqlMoney y);
    public static SqlBoolean operator >=(SqlMoney x, SqlMoney y);
    public static implicit operator SqlMoney (SqlByte x);
    public static implicit operator SqlMoney (SqlInt16 x);
    public static implicit operator SqlMoney (SqlInt32 x);
    public static implicit operator SqlMoney (SqlInt64 x);
    public static implicit operator SqlMoney (decimal x);
    public static implicit operator SqlMoney (long x);
    public static SqlBoolean operator !=(SqlMoney x, SqlMoney y);
    public static SqlBoolean operator <(SqlMoney x, SqlMoney y);
    public static SqlBoolean operator <=(SqlMoney x, SqlMoney y);
    public static SqlMoney operator *(SqlMoney x, SqlMoney y);
    public static SqlMoney operator -(SqlMoney x, SqlMoney y);
    public static SqlMoney operator -(SqlMoney x);
    public static SqlMoney Parse(string s);
    public static SqlMoney Subtract(SqlMoney x, SqlMoney y);
    public decimal ToDecimal();
    public double ToDouble();
    public int ToInt32();
    public long ToInt64();
    public SqlBoolean ToSqlBoolean();
    public SqlByte ToSqlByte();
    public SqlDecimal ToSqlDecimal();
    public SqlDouble ToSqlDouble();
    public SqlInt16 ToSqlInt16();
    public SqlInt32 ToSqlInt32();
    public SqlInt64 ToSqlInt64();
    public SqlSingle ToSqlSingle();
    public SqlString ToSqlString();
    public override string ToString();
  }
  public sealed class SqlNullValueException : SqlTypeException {
    public SqlNullValueException();
    public SqlNullValueException(string message);
    public SqlNullValueException(string message, Exception e);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlSingle : IComparable, INullable {
    public static readonly SqlSingle MaxValue;
    public static readonly SqlSingle MinValue;
    public static readonly SqlSingle Null;
    public static readonly SqlSingle Zero;
    public SqlSingle(double value);
    public SqlSingle(float value);
    public bool IsNull { get; }
    public float Value { get; }
    public static SqlSingle Add(SqlSingle x, SqlSingle y);
    public int CompareTo(SqlSingle value);
    public int CompareTo(object value);
    public static SqlSingle Divide(SqlSingle x, SqlSingle y);
    public static SqlBoolean Equals(SqlSingle x, SqlSingle y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y);
    public static SqlBoolean GreaterThanOrEqual(SqlSingle x, SqlSingle y);
    public static SqlBoolean LessThan(SqlSingle x, SqlSingle y);
    public static SqlBoolean LessThanOrEqual(SqlSingle x, SqlSingle y);
    public static SqlSingle Multiply(SqlSingle x, SqlSingle y);
    public static SqlBoolean NotEquals(SqlSingle x, SqlSingle y);
    public static SqlSingle operator +(SqlSingle x, SqlSingle y);
    public static SqlSingle operator /(SqlSingle x, SqlSingle y);
    public static SqlBoolean operator ==(SqlSingle x, SqlSingle y);
    public static explicit operator SqlSingle (SqlBoolean x);
    public static explicit operator SqlSingle (SqlDouble x);
    public static explicit operator float (SqlSingle x);
    public static explicit operator SqlSingle (SqlString x);
    public static SqlBoolean operator >(SqlSingle x, SqlSingle y);
    public static SqlBoolean operator >=(SqlSingle x, SqlSingle y);
    public static implicit operator SqlSingle (SqlByte x);
    public static implicit operator SqlSingle (SqlDecimal x);
    public static implicit operator SqlSingle (SqlInt16 x);
    public static implicit operator SqlSingle (SqlInt32 x);
    public static implicit operator SqlSingle (SqlInt64 x);
    public static implicit operator SqlSingle (SqlMoney x);
    public static implicit operator SqlSingle (float x);
    public static SqlBoolean operator !=(SqlSingle x, SqlSingle y);
    public static SqlBoolean operator <(SqlSingle x, SqlSingle y);
    public static SqlBoolean operator <=(SqlSingle x, SqlSingle y);
    public static SqlSingle operator *(SqlSingle x, SqlSingle y);
    public static SqlSingle operator -(SqlSingle x, SqlSingle y);
    public static SqlSingle operator -(SqlSingle x);
    public static SqlSingle Parse(string s);
    public static SqlSingle Subtract(SqlSingle x, SqlSingle y);
    public SqlBoolean ToSqlBoolean();
    public SqlByte ToSqlByte();
    public SqlDecimal ToSqlDecimal();
    public SqlDouble ToSqlDouble();
    public SqlInt16 ToSqlInt16();
    public SqlInt32 ToSqlInt32();
    public SqlInt64 ToSqlInt64();
    public SqlMoney ToSqlMoney();
    public SqlString ToSqlString();
    public override string ToString();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct SqlString : IComparable, INullable {
    public static readonly SqlString Null;
    public static readonly int BinarySort;
    public static readonly int BinarySort2;
    public static readonly int IgnoreCase;
    public static readonly int IgnoreKanaType;
    public static readonly int IgnoreNonSpace;
    public static readonly int IgnoreWidth;
    public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data);
    public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data, bool fUnicode);
    public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data, int index, int count);
    public SqlString(int lcid, SqlCompareOptions compareOptions, byte[] data, int index, int count, bool fUnicode);
    public SqlString(string data);
    public SqlString(string data, int lcid);
    public SqlString(string data, int lcid, SqlCompareOptions compareOptions);
    public CompareInfo CompareInfo { get; }
    public CultureInfo CultureInfo { get; }
    public bool IsNull { get; }
    public int LCID { get; }
    public SqlCompareOptions SqlCompareOptions { get; }
    public string Value { get; }
    public static SqlString Add(SqlString x, SqlString y);
    public SqlString Clone();
    public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions);
    public int CompareTo(SqlString value);
    public int CompareTo(object value);
    public static SqlString Concat(SqlString x, SqlString y);
    public static SqlBoolean Equals(SqlString x, SqlString y);
    public override bool Equals(object value);
    public override int GetHashCode();
    public byte[] GetNonUnicodeBytes();
    public byte[] GetUnicodeBytes();
    public static SqlBoolean GreaterThan(SqlString x, SqlString y);
    public static SqlBoolean GreaterThanOrEqual(SqlString x, SqlString y);
    public static SqlBoolean LessThan(SqlString x, SqlString y);
    public static SqlBoolean LessThanOrEqual(SqlString x, SqlString y);
    public static SqlBoolean NotEquals(SqlString x, SqlString y);
    public static SqlString operator +(SqlString x, SqlString y);
    public static SqlBoolean operator ==(SqlString x, SqlString y);
    public static explicit operator SqlString (SqlBoolean x);
    public static explicit operator SqlString (SqlByte x);
    public static explicit operator SqlString (SqlDateTime x);
    public static explicit operator SqlString (SqlDecimal x);
    public static explicit operator SqlString (SqlDouble x);
    public static explicit operator SqlString (SqlGuid x);
    public static explicit operator SqlString (SqlInt16 x);
    public static explicit operator SqlString (SqlInt32 x);
    public static explicit operator SqlString (SqlInt64 x);
    public static explicit operator SqlString (SqlMoney x);
    public static explicit operator SqlString (SqlSingle x);
    public static explicit operator string (SqlString x);
    public static SqlBoolean operator >(SqlString x, SqlString y);
    public static SqlBoolean operator >=(SqlString x, SqlString y);
    public static implicit operator SqlString (string x);
    public static SqlBoolean operator !=(SqlString x, SqlString y);
    public static SqlBoolean operator <(SqlString x, SqlString y);
    public static SqlBoolean operator <=(SqlString x, SqlString y);
    public SqlBoolean ToSqlBoolean();
    public SqlByte ToSqlByte();
    public SqlDateTime ToSqlDateTime();
    public SqlDecimal ToSqlDecimal();
    public SqlDouble ToSqlDouble();
    public SqlGuid ToSqlGuid();
    public SqlInt16 ToSqlInt16();
    public SqlInt32 ToSqlInt32();
    public SqlInt64 ToSqlInt64();
    public SqlMoney ToSqlMoney();
    public SqlSingle ToSqlSingle();
    public override string ToString();
  }
  public sealed class SqlTruncateException : SqlTypeException {
    public SqlTruncateException();
    public SqlTruncateException(string message);
    public SqlTruncateException(string message, Exception e);
  }
  public class SqlTypeException : Exception {
    public SqlTypeException();
    public SqlTypeException(string message);
    public SqlTypeException(string message, Exception e);
  }
  public sealed class SqlXml : INullable {
    public SqlXml();
    public SqlXml(Stream value);
    public SqlXml(XmlReader value);
    public bool IsNull { get; }
    public static SqlXml Null { get; }
    public string Value { get; }
    public XmlReader CreateReader();
  }
}
