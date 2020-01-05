using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KfzVerwaltung.Data
{
	[Serializable()]
	public class LoginInfo
	{
		#region properties
		[XmlIgnore()]
		public string UserName { get; set; }
		[XmlElement(ElementName = "UserName")]
		public string UserNameEncrypted { get; set; }
		[XmlIgnore()]
		public string Password { get; set; }
		[XmlElement(ElementName = "Password")]
		public string PasswordEncrypted { get; set; }
		#endregion
	}
}
