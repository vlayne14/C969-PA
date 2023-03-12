using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Victoria_Brown_C969_PA
{
    public partial class View_Appointments : Form
    {
        private bool monthPicked = true;
        private DateTime selectedDate;

        public View_Appointments()
        {
            InitializeComponent();
            selectedDate = DateTime.Now;
        }

        //updating DGV for week selected
        private void changeWeekSelected()
        {
            DateTime startOfWeek = beginningOfWeek(selectedDate);
            DateTime endOfWeek = findEndOfWeek(selectedDate);
            viewApptDGV.DataSource = apptInTime(startOfWeek, endOfWeek);
        }

        //updating DGV for month selected
        private void changeMonthSelected()
        {
            DateTime startOfMonth = beginningOfMonth(selectedDate);
            DateTime endOfMonth = findEndOfMonth(selectedDate);
            viewApptDGV.DataSource = apptInTime(startOfMonth, endOfMonth);
        }
        //finding the beginning of the week
        private DateTime beginningOfWeek(DateTime date)
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            var difference = date.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (difference < 0)
            {
                difference = difference + 7;
            }
            return date.AddDays(-difference).Date;
        }

        //end of week
        private DateTime findEndOfWeek(DateTime date)
        {
            return beginningOfWeek(date).AddDays(7).AddMilliseconds(-1);
        }

        //beginning of month
        private DateTime beginningOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        //end of month
        private DateTime findEndOfMonth(DateTime date)
        {
            return beginningOfMonth(date).AddMonths(1).AddMilliseconds(-1);
        }

        //appointments in time period
        private BindingList<Appointment> apptInTime(DateTime startTime, DateTime endTime)
        {
            //lambda to show appointments within specified bounds
            return new BindingList<Appointment>(Main.apptList.Where(appt => appt.startDate >= startTime && appt.endDate <= endTime).ToList());
        }


        //weeek radio button checked
        private void weeklyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (weeklyRadioButton.Checked == true)
            {
                monthPicked = false;
                changeWeekSelected();
            }
        }

        //all appointment view 
		private void allRadioButton_CheckedChanged(object sender, EventArgs e)
		{
            viewApptDGV.DataSource = Main.apptList;
            viewApptDGV.Refresh();
		}

        //month view
        private void monthlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monthlyRadioButton.Checked == true)
            {
                monthPicked = true;
                changeMonthSelected();
            }

        }

		private void viewApptCloseButton_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
