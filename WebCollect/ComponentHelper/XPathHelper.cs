using System.Xml;

namespace WebCollect.ComponentHelper
{
    public class XPathHelper
    {
        private static string xpath;
        public static string GetXpath(string xmlpath, string xmlnodename)
        {
            XmlTextReader xtr = new XmlTextReader(xmlpath);

            while (xtr.Read())
            {

                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == xmlnodename)
                {
                    xpath = xtr.ReadString();
                    break;
                }
            }
            return xpath;
            
        }
    }
}
