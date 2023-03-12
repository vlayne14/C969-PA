using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victoria_Brown_C969_PA
{
	public static class User_Tracking
	{
		//text file for tracking
		private static string file = "user_tracking.text";

		//tracking user login on text file
		public static void trackUser(User user)
		{
			bool fileDNE = false;
			string lastFile = "";

			try
			{
				FileStream input = new FileStream(file, FileMode.Open, FileAccess.Read);
				StreamReader readFile = new StreamReader(input);
				lastFile = readFile.ReadToEnd().Trim();
				input.Close();
			}
			catch (IOException)
			{
				fileDNE = true;
			}
			finally
			{
				FileStream output = new FileStream(file, FileMode.Create);
				StreamWriter writeFile = new StreamWriter(output);
				string newLog = $"\"{user.userName}\" logged in at {DateTime.Now.ToUniversalTime()} (UTC).";

				if (fileDNE)
				{
					writeFile.WriteLine(newLog);
					writeFile.Close();
				}
				else
				{
					writeFile.WriteLine(lastFile);
					writeFile.WriteLine(newLog);
					writeFile.Close();
				}
			}
		}
	}
}
