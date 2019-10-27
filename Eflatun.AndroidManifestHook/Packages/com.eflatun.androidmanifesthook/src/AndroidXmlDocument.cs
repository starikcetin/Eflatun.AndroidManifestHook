using System.Text;
using System.Xml;

namespace Eflatun.AndroidManifestHook
{
    public class AndroidXmlDocument : XmlDocument
    {
        private const string AndroidXmlNamespace = "http://schemas.android.com/apk/res/android";
        private readonly string _path;
        protected readonly XmlNamespaceManager NamespaceManager;

        protected AndroidXmlDocument(string path)
        {
            _path = path;
            NamespaceManager = new XmlNamespaceManager(NameTable);
            NamespaceManager.AddNamespace("android", AndroidXmlNamespace);

            using (var reader = new XmlTextReader(_path))
            {
                reader.Read();
                Load(reader);
            }
        }

        public void Save()
        {
            using (var writer = new XmlTextWriter(_path, new UTF8Encoding(false)) {Formatting = Formatting.Indented})
            {
                Save(writer);
            }
        }
    }
}
