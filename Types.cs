using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victoria_Brown_C969_PA
{
	public class Types
	{
		public string Type { get; set; }
		public int Count { get; set; }

		public Types(string type, int count)
		{
			Type = type;
			Count = count;
		}
	}
}
