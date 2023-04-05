using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_Lb4_var4
{
    public partial class FormControlEmployees : Form
    {
        private List<Department> departmentsList = new List<Department>();
        private int countSaved = 0;
        private int indexEmployee;

        internal FormControlEmployees(string title, List<Department> departments, bool isEnabledComboBox, int indexDepartment, int indexEmployee)
        {
            this.Text = title;
            departmentsList = departments;
            this.indexEmployee = indexEmployee;

            InitializeComponent();
            if (title == "Редагування інформації про співробітника")
            {
                buttonDone.Visible = false;
                textBoxSurname.Text = departmentsList[indexDepartment].Employees[indexEmployee].Surname;
                textBoxName.Text = departmentsList[indexDepartment].Employees[indexEmployee].Name;
                textBoxLastName.Text = departmentsList[indexDepartment].Employees[indexEmployee].LastName;
                textBoxID.Text = departmentsList[indexDepartment].Employees[indexEmployee].Id;
                textBoxID.Enabled = false;
                numericUpDownSalary.Value = departmentsList[indexDepartment].Employees[indexEmployee].Salary;
            }
            comboBoxDepartment.DataSource = departmentsList;
            comboBoxDepartment.DisplayMember = "DepartmentName";
            comboBoxDepartment.Enabled = isEnabledComboBox;
            if (!isEnabledComboBox && title != "Редагування інформації про співробітника")
                comboBoxDepartment.SelectedIndex = departmentsList.Count - 1;
            else
                comboBoxDepartment.SelectedIndex = indexDepartment;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string resultID = new String(textBoxID.Text.Where(x => Char.IsDigit(x)).ToArray());

            if (textBoxSurname.Text == string.Empty || textBoxName.Text == string.Empty ||
                textBoxLastName.Text == string.Empty || textBoxID.Text == string.Empty || numericUpDownSalary.Value == 0)
                MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.Text == "Редагування інформації про співробітника")
            {
                departmentsList[comboBoxDepartment.SelectedIndex].Employees[indexEmployee].Surname = textBoxSurname.Text;
                departmentsList[comboBoxDepartment.SelectedIndex].Employees[indexEmployee].Name = textBoxName.Text;
                departmentsList[comboBoxDepartment.SelectedIndex].Employees[indexEmployee].LastName = textBoxLastName.Text;
                departmentsList[comboBoxDepartment.SelectedIndex].Employees[indexEmployee].Salary = Convert.ToInt32(Math.Round(numericUpDownSalary.Value, 0));
                departmentsList[comboBoxDepartment.SelectedIndex].Employees[indexEmployee].SurnameID = 
                    departmentsList[comboBoxDepartment.SelectedIndex].Employees[indexEmployee].Surname + " " + 
                    departmentsList[comboBoxDepartment.SelectedIndex].Employees[indexEmployee].Id;
                this.Close();
            }
            else
            {
                if (resultID.Length != 10 || textBoxID.Text.Length != 10)
                    MessageBox.Show("Неправильний формат ідентифікаційного коду!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool findPerson = false;
                    for (int i = 0; i < departmentsList.Count; i++)
                    {
                        Person findPersonID = departmentsList[i].Employees.Find(p => p.Id.Equals(resultID));
                        if (findPersonID != null)
                        {
                            findPerson = true;
                            break;
                        }
                    }
                    if (findPerson)
                        MessageBox.Show("Людина з таким ідентифікаційним кодом вже записана!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Person person = new Person();
                        person.Surname = textBoxSurname.Text;
                        person.Name = textBoxName.Text;
                        person.LastName = textBoxLastName.Text;
                        person.Id = textBoxID.Text;
                        person.Salary = Convert.ToInt32(Math.Round(numericUpDownSalary.Value, 0));
                        person.SurnameID = person.Surname + " " + person.Id;
                        departmentsList[comboBoxDepartment.SelectedIndex].Employees.Add(person);
                        textBoxSurname.Text = string.Empty;
                        textBoxName.Text = string.Empty;
                        textBoxLastName.Text = string.Empty;
                        textBoxID.Text = string.Empty;
                        numericUpDownSalary.Value = 0;
                        if (!comboBoxDepartment.Enabled)
                        {
                            countSaved++;
                            if (countSaved == departmentsList[comboBoxDepartment.SelectedIndex].CountEmployees)
                                this.Close();
                        }
                        else
                            this.Close();
                    }
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
