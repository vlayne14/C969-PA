using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victoria_Brown_C969_PA
{
    public partial class Appointment_Types : Form
    {
        public Appointment_Types()
        {
            InitializeComponent();
        }

		//form load
		private void Appointment_Types_Load(object sender, EventArgs e)
		{
			var text = new StringBuilder();
			//adding starting line text to text box
			text.AppendLine("Reporting Appointment Types by Month: (Last Month, Current Month, Next Month)");
			text.AppendLine();

			//definining this month, last month, and next month
			DateTime thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			DateTime nextMonth = thisMonth.AddMonths(2).AddMilliseconds(-1);
			DateTime lastMonth = thisMonth.AddMonths(-1);

			var apptByMonth = Main.apptList

			//lambda expressions ordering and grouping appointments, as well as ensuring the appointments meet specified conditions
			.OrderBy(appt => appt.startDate)
			.Where(appt => appt.startDate >= lastMonth && appt.startDate <= nextMonth)
			.GroupBy(appt => appt.startDate.ToString("MMMM yyyy"));

			//writing results to textbox 
			foreach (var group in apptByMonth)
			{
				text.AppendLine($"{group.Key}:");
				var typesByMonth = group.GroupBy(appt => appt.type);

				foreach (var list in typesByMonth)
				{
					text.AppendLine($"\t{list.Key}: {list.Count()}");
				}
				text.AppendLine();
			}
			apptTypeText.Text = text.ToString();


		}

		//close button clicked
		private void apptTypeCloseButton_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		
	}
}
