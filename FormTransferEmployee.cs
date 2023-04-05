using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_Lb4_var4
{
    public partial class FormTransferEmployee : Form
    {
        private List<Department> departmentsList;
        internal FormTransferEmployee(List<Department> departmentsList)
        {
            InitializeComponent();
            this.departmentsList = departmentsList; 
            comboBoxOldDepartment.DataSource = this.departmentsList;
            comboBoxOldDepartment.DisplayMember = "DepartmentName";
            if (departmentsList[comboBoxOldDepartment.SelectedIndex].Employees.Count > 0)
            {
                comboBoxEmployees.DataSource = departmentsList[comboBoxOldDepartment.SelectedIndex].Employees;
                comboBoxEmployees.DisplayMember = "Surname";
            }

            for (int i = 0; i < departmentsList.Count; i++)
                comboBoxNew.Items.Add(departmentsList[i].DepartmentName);
            comboBoxNew.SelectedIndex = 0;

            /*comboBoxNew.DataSource = departmentsList;
            comboBoxNew.DisplayMember = "DepartmentName";*/
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            if (comboBoxOldDepartment.SelectedIndex == comboBoxNew.SelectedIndex)
                MessageBox.Show("Не можна перевести співробітника в цей ж самий відділ!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (departmentsList[comboBoxOldDepartment.SelectedIndex].Employees.Count == 0)
                MessageBox.Show("В цьому відділі відсутня інформація про співробітників!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                departmentsList[comboBoxNew.SelectedIndex].Employees.Add(departmentsList[comboBoxOldDepartment.SelectedIndex].Employees[comboBoxEmployees.SelectedIndex]);
                departmentsList[comboBoxOldDepartment.SelectedIndex].Employees.RemoveAt(comboBoxEmployees.SelectedIndex);
                this.Close();
            }
        }

        private void comboBoxOldDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEmployees.DataSource = null;
            if (departmentsList[comboBoxOldDepartment.SelectedIndex].Employees.Count > 0)
            {
                comboBoxEmployees.DataSource = departmentsList[comboBoxOldDepartment.SelectedIndex].Employees;
                comboBoxEmployees.DisplayMember = "Surname";
            }
        }
    }
}
