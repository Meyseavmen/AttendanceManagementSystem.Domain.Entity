using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagementSystem.Application;
using AttendanceManagementSystem.Domain.Entity;

namespace AttendanceManagementSystem.Presentation
{
    public partial class ClockManagement : Form
    {
        private ITimeSheet _timeSheet;
        public ClockManagement(ITimeSheet timeSheet)
        {
            _timeSheet = timeSheet;
            InitializeComponent();
        }

        private void ClockManagement_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString();
        }

        private void clockinButton_Click(object sender, EventArgs e)
        {
            try
            {
                _timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 0));
                ShowMessage("Time-in Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }

        private void clockoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                _timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 1));
                ShowMessage("Time-out Successfully!", true);
            }catch(ArgumentException Ec)
            {
                ShowMessage(Ec.Message,false);
            }
        }
        private void ShowMessage(string message, bool Issucceed)
        {
            if( Issucceed )
            {
                MessageBox.Show(message, "Application Info",MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show(message,"Application Info",MessageBoxButtons.OK,MessageBoxIcon.Warning );
            }
            cardnoTextBox.Clear();
            cardnoTextBox.Focus();
        }
    }
}
