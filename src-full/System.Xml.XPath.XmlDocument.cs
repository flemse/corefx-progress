namespace System.Xml {
  public static class XmlDocumentXPathExtensions {
    public static XPathNavigator CreateNavigator(this XmlDocument document);
    public static XPathNavigator CreateNavigator(this XmlDocument document, XmlNode node);
    public static XPathNavigator CreateNavigator(this XmlNode node);
    public static XmlNodeList SelectNodes(this XmlNode node, string xpath);
    public static XmlNodeList SelectNodes(this XmlNode node, string xpath, XmlNamespaceManager nsmgr);
    public static XmlNode SelectSingleNode(this XmlNode node, string xpath);
    public static XmlNode SelectSingleNode(this XmlNode node, string xpath, XmlNamespaceManager nsmgr);
    public static IXPathNavigable ToXPathNavigable(this XmlNode node);
  }
}
