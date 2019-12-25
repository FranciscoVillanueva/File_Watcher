using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Observador
{
    // clase XmlDocumento ----------------------------------
    public class XmlDocumento
    {
        public string Directorio;
        public XmlDocumento()
        {
        }

        public XmlDocumento(string Dir)
        { 
            Directorio = Dir;
        }

        public void AgregaObjetoAListaXml<T>(List<T> L, T objeto)
        {
            L = LeeYRetornaListaDeObjetos<T>();
            L.Add(objeto);
            SerializeToXml(L);
        }

        public List<T> LeeYRetornaListaDeObjetos<T>()
        {
            if (File.Exists(Directorio))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.Load(Directorio);
                return DeserializeFromXml<List<T>>(Doc.OuterXml);
            }
            else
            {
                return new List<T>();
            }
        }

        public T DeserializeFromXml<T>(string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
                tr.Close();
            }
            return result;
        }

        public void SerializeToXml<T>(T obj)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            FileStream fileStream = new FileStream(Directorio, FileMode.Create);
            ser.Serialize(fileStream, obj);
            fileStream.Close();
        }
    }
}
