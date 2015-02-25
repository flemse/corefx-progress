namespace System {
  public static class AppContext {
    public static string BaseDirectory { get; }
    public static void SetSwitch(string switchName, bool isEnabled);
    public static bool TryGetSwitch(string switchName, out bool isEnabled);
  }
}
