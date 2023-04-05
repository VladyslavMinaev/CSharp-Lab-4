using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CSharp_Lb4_var4
{
    public partial class FormEditEmployees : Form
    {
        private List<Department> departmentsList = new List<Department>();

        internal FormEditEmployees(List<Department> departments, string title)
        {
            InitializeComponent();
            this.Text = title;
            if (title == "Звільнення співробітника")
                buttonEdit.Text = "Звільнити";
            departmentsList = departments;
            comboBoxDepartments.DataSource = departmentsList;
            comboBoxDepartments.DisplayMember = "DepartmentName";
            if (departmentsList[comboBoxDepartments.SelectedIndex].Employees.Count > 0) 
            {
                comboBoxEmployees.DataSource = departmentsList[comboBoxDepartments.SelectedIndex].Employees;
                DataTable dataTable = new DataTable();
                comboBoxEmployees.DisplayMember = "SurnameID";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployees.Text == string.Empty)
                MessageBox.Show("В цьому відділі відсутня інформація про співробітників!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (this.Text == "Звільнення співробітника")
                {
                    DialogResult mb = MessageBox.Show("Ви точно бажаєте звільнити цього співробітника?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mb == DialogResult.Yes)
                    {
                        departmentsList[comboBoxDepartments.SelectedIndex].Employees.RemoveAt(comboBoxEmployees.SelectedIndex);
                        this.Close();
                    }
                }
                else
                {
                    FormControlEmployees formControlEmployees = new FormControlEmployees("Редагування інформації про співробітника", departmentsList, false, comboBoxDepartments.SelectedIndex, comboBoxEmployees.SelectedIndex);
                    this.Hide();
                    formControlEmployees.ShowDialog();
                    this.Close();
                }
            }
        }

        private void comboBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEmployees.DataSource = null;
            if (departmentsList[comboBoxDepartments.SelectedIndex].Employees.Count > 0)
            {
                comboBoxEmployees.DataSource = departmentsList[comboBoxDepartments.SelectedIndex].Employees;
                DataTable dataTable = new DataTable();
                comboBoxEmployees.DisplayMember = "SurnameID";
            }
        }
    }
}
