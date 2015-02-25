```diff
---lib-full\System.Xml.XPath.XDocument.dll
+++lib-oss\System.Xml.XPath.XDocument.dll
 namespace System.Xml.XPath {
  public static class Extensions {
    public static XPathNavigator CreateNavigator(this XNode node);
    public static XPathNavigator CreateNavigator(this XNode node, XmlNameTable nameTable);
    public static object XPathEvaluate(this XNode node, string expression);
    public static object XPathEvaluate(this XNode node, string expression, IXmlNamespaceResolver resolver);
    public static XElement XPathSelectElement(this XNode node, string expression);
    public static XElement XPathSelectElement(this XNode node, string expression, IXmlNamespaceResolver resolver);
    public static IEnumerable<XElement> XPathSelectElements(this XNode node, string expression);
    public static IEnumerable<XElement> XPathSelectElements(this XNode node, string expression, IXmlNamespaceResolver resolver);
  }
  public static class XDocumentExtensions {
    public static IXPathNavigable ToXPathNavigable(this XNode node);
  }
 }
```
