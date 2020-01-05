using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KfzVerwaltung.Data
{
	[Serializable()]
	public class FileManager
	{
        #region Properties
        [XmlIgnore()]
        public string Owner { get; set; }
        [XmlIgnore()]
        public string MasterKey { get; set; }
        public string OwnerEncrypted { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<LoginInfo> LoginInfos { get; set; } = new List<LoginInfo>();
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<String> Categories { get; set; }
        #endregion
               
        #region Methods
        public static FileManager Read(string fileName, string password)
		{
			StreamReader reader = new StreamReader(fileName, Encoding.UTF8);
			XmlSerializer serializer = new XmlSerializer(typeof(FileManager));
			FileManager securedFile = (FileManager)serializer.Deserialize(reader);
			reader.Close();

			securedFile.Owner = securedFile.Decrypt(securedFile.OwnerEncrypted, password);
			foreach (LoginInfo loginInfo in securedFile.LoginInfos)
			{
				loginInfo.Password = securedFile.Decrypt(loginInfo.PasswordEncrypted, password);
				loginInfo.UserName = securedFile.Decrypt(loginInfo.UserNameEncrypted, password);
			}

			return securedFile;
		}
		public void Save(string fileName, string password)
		{
			this.OwnerEncrypted = Encrypt(this.Owner, password);

			foreach (LoginInfo loginInfo in this.LoginInfos)
			{
				loginInfo.UserNameEncrypted = Encrypt(loginInfo.UserName, password);
				loginInfo.PasswordEncrypted = Encrypt(loginInfo.Password, password);
			}

			StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
			XmlSerializer serializer = new XmlSerializer(typeof(FileManager));
			serializer.Serialize(writer, this);
			writer.Close();
		}

		public string Encrypt(string plainText, string password)
		{
			string result = string.Empty;
			MD5 md5 = MD5CryptoServiceProvider.Create();
			byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
			using (Aes aes = Aes.Create())
			{
				//aes.Mode = CipherMode.ECB;
				//aes.Padding = PaddingMode.Zeros;
				aes.Mode = CipherMode.CBC;
				aes.Padding = PaddingMode.PKCS7;
				aes.Key = key;
				aes.KeySize = 256;
				aes.BlockSize = 128;
				// Create an encryptor to perform the stream transform.
				ICryptoTransform encryptor = aes.CreateEncryptor(key, aes.IV);
				// Create the streams used for encryption.
				using (MemoryStream msEncrypt = new MemoryStream())
				{
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						{
							swEncrypt.Write(plainText);
						}
						result = $"{Convert.ToBase64String(msEncrypt.ToArray())}{Convert.ToBase64String(aes.IV)}";
					}
				}
			}

			return result;
		}
		public string Decrypt(string cipherText, string password)
		{
			string result = string.Empty;
			MD5 md5 = MD5CryptoServiceProvider.Create();
			byte[] key = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

			using (Aes aes = new AesManaged())
			{
				//aes.Mode = CipherMode.ECB;
				//aes.Padding = PaddingMode.Zeros;
				aes.Mode = CipherMode.CBC;
				aes.Padding = PaddingMode.PKCS7;
				aes.Key = key;
				aes.KeySize = 256;
				aes.BlockSize = 128;
				string iv = cipherText.Substring(cipherText.Length - 24);
				string tmp = cipherText.Substring(0, cipherText.Length - 24);

				// Create a decryptor to perform the stream transform.
				ICryptoTransform decryptor = aes.CreateDecryptor(key, Convert.FromBase64String(iv));
				// Create the streams used for decryption.
				using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(tmp)))
				{
					msDecrypt.Position = 0;
					byte[] buf = null;
					using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using (StreamReader srDecrypt = new StreamReader(csDecrypt))
						{
							result = srDecrypt.ReadToEnd();
						}
					}
				}

			}

			return result;
		}
        #endregion
    }
}

