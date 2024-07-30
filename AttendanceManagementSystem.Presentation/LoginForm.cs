using AttendanceManagementSystem.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementSystem.Presentation;

public partial class LoginForm : Form
{
    private IAuthentication _auth;
    public LoginForm(IAuthentication auth)
    {
        InitializeComponent();
        _auth = auth;
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        //get the username and password from TextBox UI
        var un = usernameTextBox.Text.Trim();
        var ps = passwordTextBox.Text.Trim();
        try
        {
            bool result = _auth.ValidateLogin(un, ps);
            if (result) //Login Successfully
            {
                this.Hide(); //Hide Login Form
            } else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        } catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }
    }
}
