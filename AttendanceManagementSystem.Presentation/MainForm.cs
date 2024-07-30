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
using AttendanceManagementSystem.Infrastructure;

namespace AttendanceManagementSystem.Presentation;

public partial class MainForm : Form
{
    private ITimeSheet _timeSheet;
    private IAuthentication _auth;
    public MainForm(ITimeSheet timeSheet, IAuthentication auth)
    {
        InitializeComponent();
        _timeSheet = timeSheet;
        _auth = auth;
    }

    private void timeRecordButton_Click(object sender, EventArgs e)
    {
        ClockManagement cfrm = new ClockManagement(_timeSheet);
        cfrm.ShowDialog();
    }

    private void managementEmployeeButton_Click(object sender, EventArgs e)
    {
        if (_auth.IsAuthenticated) //true => show the form
        {
            EmployeeForm form = new EmployeeForm(_timeSheet);
            form.ShowDialog();
        }
        else
        {
            MessageBox.Show("Please login!");
        }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("Exit or no?",
            "Emplopyee TimeSheet Management",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information) == DialogResult.No)
        {
            e.Cancel = true;
        }
        else
        {
            System.Environment.Exit(1);
        }
    }

    private void LoginLinkLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        LoginForm lfrm = new LoginForm(_auth);
        lfrm.ShowDialog();
    }
}
