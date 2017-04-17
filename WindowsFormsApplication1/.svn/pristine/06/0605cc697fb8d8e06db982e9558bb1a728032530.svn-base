using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class AbilityData
    {
        int id;
        string name;
        string comment;
        byte code;
        int composeID1;
        int composeID2;

        public int ID { get { return id; } }
        public string Name { get { return name; } }
        public string Comment { get { return comment; } }
        public byte Code { get { return code; } }
        public int ComposeID1 { get { return composeID1; } }
        public int ComposeID2 { get { return composeID2; } }

		public AbilityData()
		{
			Reset();
		}

        public AbilityData(int _id, string _name, string _comment, byte _code, int _comID1, int _comID2)
        {
            id = _id;
            name = _name;
            comment = _comment;
            code = _code;
            composeID1 = _comID1;
            composeID2 = _comID2;
        }

		public AbilityData(AbilityData ad)
		{
			id = ad.id;
			name = ad.name;
			comment = ad.comment;
			code = ad.code;
			composeID1 = ad.composeID1;
			composeID2 = ad.composeID2;
		}

		public void Reset()
		{
			id = 0;
			name = null;
			comment = null;
			code = 0;
			composeID1 = 0;
			composeID2 = 0;
		}
    }
}
