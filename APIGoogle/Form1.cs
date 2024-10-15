using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIGoogle
{
    public partial class Form1 : Form
    {

        GoogleMethods methods;
        public Form1(string jsonKey)
        {
            InitializeComponent();
            methods = new GoogleMethods(jsonKey);
            textBoxStartEvent.Text = DateTime.Now.ToString();
            textBoxEndEvent.Text = DateTime.Now.AddMinutes(10).ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxStartEvent.Text = monthCalendar1.SelectionStart.ToString();
        }
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxEndEvent.Text = monthCalendar2.SelectionStart.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileDriveId = textFileId.Text;

            string filePath = textPath.Text.Trim();
            string newFileName = string.IsNullOrEmpty(textFileName.Text) ? Path.GetFileNameWithoutExtension(filePath) : textFileName.Text;
            methods.useGoogleDriveMethods(true, fileDriveId, newFileName, filePath);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime startDate,endDate;

            startDate = string.IsNullOrEmpty(textBoxStartEvent.Text)? DateTime.Now : DateTime.Parse(textBoxStartEvent.Text);
            endDate = string.IsNullOrEmpty(textBoxEndEvent.Text) || textBoxStartEvent.Text  == textBoxEndEvent.Text 
            ? startDate.AddMinutes(10) : DateTime.Parse(textBoxEndEvent.Text);

            string calendarID = textCalendarID.Text;
            methods.useGoogleCalendar(calendarID, true, startDate, endDate, textSummary.Text, textDescription.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string calendarID = textCalendarID.Text;
            methods.useGoogleCalendar(calendarID,false, DateTime.Now, DateTime.Now);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string fileDriveId = textFileId.Text;
            string filePath = filePathLocal.Text.Trim();
            string findFileName = string.IsNullOrEmpty(FindFileName.Text) ? string.Empty : FindFileName.Text;

            methods.useGoogleDriveMethods(false, fileDriveId, findFileName, filePath);
        }

        private void textFileId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                enabledBottoms(1);
                enabledBottoms(2);
            }

        }

        private void textCalendarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                enabledBottoms(2);
                enabledBottoms(3);
            }

        }

        public void enabledBottoms(int numBottom)
        {
            switch (numBottom)
            {
                case 1:
                    button1.Enabled = !string.IsNullOrEmpty(textFileId.Text) && !string.IsNullOrEmpty(textPath.Text);
                    break;
                case 2:
                    button2.Enabled = !string.IsNullOrEmpty(textCalendarID.Text) &&
                     !string.IsNullOrEmpty(textSummary.Text) && !string.IsNullOrEmpty(textDescription.Text)
                    && !string.IsNullOrEmpty(textBoxStartEvent.Text) && !string.IsNullOrEmpty(textBoxEndEvent.Text);
                    break;
                case 3:
                    button3.Enabled = !string.IsNullOrEmpty(textCalendarID.Text);
                 break;
                case 4:
                    button4.Enabled = !string.IsNullOrEmpty(textCalendarID.Text);
                    break;
                default:
                    break;
            }
        }
        private void textSummary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                enabledBottoms(2);
            }
        }

        private void textPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                enabledBottoms(1);
            }
        }

        private void filePathLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                enabledBottoms(4);
            }
        }

        private void textDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            enabledBottoms(2);
        }

        private void textBoxStartEvent_TextChanged(object sender, EventArgs e)
        {
            enabledBottoms(2);
        }

        private void textBoxEndEvent_TextChanged(object sender, EventArgs e)
        {
            enabledBottoms(2);
        }
    }
}
