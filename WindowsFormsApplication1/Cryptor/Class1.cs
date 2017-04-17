using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Cryptor
{
    public class CryptorClass
    {
		// 암호화에 사용될 키
		static byte[] CryptoKey = ASCIIEncoding.ASCII.GetBytes("default1");

		/// <summary>
		/// DES 를 이용한 암호화
		/// </summary>
		/// <param name="_data"></param>
		/// <returns></returns>
		public static string EncryptUseDES(string _data)
		{
			byte[] data = Encoding.UTF8.GetBytes(_data);

			DESCryptoServiceProvider des = new DESCryptoServiceProvider();

			des.Key = CryptoKey;
			des.IV = CryptoKey;

			MemoryStream ms = new MemoryStream();
			CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);

			cs.Write(data, 0, data.Length);
			cs.FlushFinalBlock();

			return Convert.ToBase64String(ms.ToArray());
		}

		public static string DecryptUseDES(string _data)
		{
			byte[] data = Convert.FromBase64String(_data);

			DESCryptoServiceProvider des = new DESCryptoServiceProvider();

			des.Key = CryptoKey;
			des.IV = CryptoKey;

			MemoryStream ms = new MemoryStream();
			CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);

			cs.Write(data, 0, data.Length);
			cs.FlushFinalBlock();

			return Encoding.UTF8.GetString(ms.ToArray());
		}
    }
}
