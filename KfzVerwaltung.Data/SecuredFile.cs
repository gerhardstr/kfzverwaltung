using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KfzVerwaltung.Data
{
	[Serializable()]
	public class SecuredFile
	{

		public static SecuredFile Read(string fileName, string password)
		{
			StreamReader reader = new StreamReader(fileName, Encoding.UTF8);
			XmlSerializer serializer = new XmlSerializer(typeof(SecuredFile));
			SecuredFile securedFile = (SecuredFile)serializer.Deserialize(reader);
			reader.Close();
			return securedFile;
		}

		public string Owner { get; set; }
		public string MasterKey { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime LastUpdate { get; set; }
		public List<LoginInfo> LoginInfos { get; set; } = new List<LoginInfo>();
		public List<Car> Cars { get; set; } = new List<Car>();
		public List<String> Categories  { get; set; }

		public void Save(string fileName, string password)
		{
			StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
			XmlSerializer serializer = new XmlSerializer(typeof(SecuredFile));
			serializer.Serialize(writer, this);
			writer.Close();
		}
	}
}

