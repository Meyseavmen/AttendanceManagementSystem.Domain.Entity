using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagementSystem.Domain.Entity;
using AttendanceManagementSystem.Application;
namespace AttendanceManagementSystem.Presentation;

public partial class EmployeeForm : Form
{
    private ITimeSheet timeSheet;
    public EmployeeForm(ITimeSheet timeSheet)
    {
        InitializeComponent();
        this.timeSheet = timeSheet;
        LoadToGrid();

        updateButton.Enabled = false;
        saveButton.Enabled = false;
        deleteButton.Enabled = false;

        
    }

    private void addnewButton_Click(object sender, EventArgs e)
    {
        fullNameTextBox.Clear();
        positionTextBox.Clear();
        cardnoTextBox.Clear();
        usernameTextBox.Clear();
        passwordTextBox.Clear();
        fullNameTextBox.Focus();
        saveButton.Enabled = true;
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (timeSheet.IsDuplicateCardNo(cardnoTextBox.Text.Trim()))
            {
                MessageBox.Show("Card number already exists. Please enter a unique card number.");
                return;
            }
             if (!timeSheet.IsNameValid(fullNameTextBox.Text.Trim()))
    {
        MessageBox.Show("Full name should contain only letters.");
        return;
    }

            var emp = new Employee() {
                FullName = fullNameTextBox.Text.Trim(),
                Position = positionTextBox.Text.Trim(),
                CardNo = cardnoTextBox.Text.Trim(),
                UserAccount = new UserAccount()
                {
                    Username = usernameTextBox.Text.Trim(),
                    Password = passwordTextBox.Text.Trim()
                }
                };
            timeSheet.AddEmployee(emp);
            LoadToGrid();
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }
        finally
        {
            addnewButton.Enabled = true;
            saveButton.Enabled = false;
        }
    }
    private void LoadToGrid()
    {
        dataGridView1.DataSource = timeSheet.GetAllEmployee();
        dataGridView1.Refresh(); //show the lastest data
    }
    private void LoadToGrid(bool isSimpleVersion)
    {
        dataGridView1.DataSource = timeSheet.GetAllEmployee(isSimpleVersion);
        dataGridView1.Refresh(); //show the lastest data
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        try
        {
            timeSheet.UpdateEmployee(employeeIDTextBox.Text, fullNameTextBox.Text, positionTextBox.Text);
            LoadToGrid();
        }
        catch (ArgumentException Ae) { MessageBox.Show(Ae.Message); }
        finally
        {
            addnewButton.Enabled = true;
            saveButton.Enabled = true;
            updateButton.Enabled = false;
        }
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
        {
            employeeIDTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
            fullNameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
            positionTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
            cardnoTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
            addnewButton.Enabled = false;
            saveButton.Enabled = false;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
        }
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            var empId = employeeIDTextBox.Text.Trim();
            timeSheet.DeleteEmployee(empId);
            LoadToGrid();
            fullNameTextBox.Clear();
            positionTextBox.Clear();
            cardnoTextBox.Clear();
            employeeIDTextBox.Clear();
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }
        finally
        {
            addnewButton.Enabled = true;
            saveButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
        }
    }

}
