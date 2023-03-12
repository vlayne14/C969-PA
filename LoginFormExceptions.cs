using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victoria_Brown_C969_PA
{
	class LoginFormExceptions : ApplicationException
	{
		public LoginFormExceptions() : base("Incorrect input")
		{
		}

		public LoginFormExceptions(string exemption) : base(exemption)
		{
		}

		public LoginFormExceptions(string exemption, ApplicationException inner) : base(exemption, inner)
		{
		}
	}
}
