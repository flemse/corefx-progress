﻿```diff
---lib-full\System.Text.Encoding.CodePages.dll
+++lib-oss\System.Text.Encoding.CodePages.dll
 namespace System.Text {
  public sealed class CodePagesEncodingProvider : EncodingProvider {
    public static EncodingProvider Instance { get; }
+   public override Encoding GetEncoding(int codepage);
+   public override Encoding GetEncoding(string name);
  }
 }
```
