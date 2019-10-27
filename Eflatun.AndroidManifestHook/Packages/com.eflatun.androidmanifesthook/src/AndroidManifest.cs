using System.Xml;

namespace Eflatun.AndroidManifestHook
{
    public class AndroidManifest : AndroidXmlDocument {
        public XmlElement ManifestElement { get; }
        public XmlElement ApplicationElement { get; }
        public string AndroidNamespace => NamespaceManager.LookupNamespace("android");

        public AndroidManifest(string path) : base(path) {
            ManifestElement = SelectSingleNode("/manifest") as XmlElement;
            ApplicationElement = SelectSingleNode("/manifest/application") as XmlElement;
        }

        /// <summary>
        /// returns <paramref name="value"/>
        /// </summary>
        public string SetAttributeWithAndroidNamespace(XmlElement element, string name, string value)
        {
            return element.SetAttribute(name, AndroidNamespace, value);
        }
    }
}
