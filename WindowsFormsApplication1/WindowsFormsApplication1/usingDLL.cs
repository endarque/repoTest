using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDLL
{
	class usingDLLClass
	{
		public static System.Reflection.Assembly ResolveAssembly(object sender, ResolveEventArgs args)
		{
			System.Reflection.Assembly thisAssembly = System.Reflection.Assembly.GetExecutingAssembly();
			string name = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";
			var files = thisAssembly.GetManifestResourceNames().Where(s => s.EndsWith(name));

			if(files.Count() > 0)
			{
				string filename = files.First();
				using (System.IO.Stream stream = thisAssembly.GetManifestResourceStream(filename))
				{
					if(stream != null)
					{
						byte[] data = new byte[stream.Length];
						stream.Read(data, 0, data.Length);
						return System.Reflection.Assembly.Load(data);
					}
				}
			}

			return null;
		}
	}
}
