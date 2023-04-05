using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_Lb4_var4
{
    public partial class FormControlDepartment : Form
    {
        private List<Department> departmentsList = new List<Department>();
        internal FormControlDepartment(List<Department> departments, string title)
        {
            this.Text = title;
            departmentsList = departments;
            InitializeComponent();
            comboBoxDepartments.DataSource = departmentsList;
            comboBoxDepartments.DisplayMember = "DepartmentName";

            if (title == "Розформувати відділ")
                buttonEdit.Text = "Видалити";
            else
                buttonEdit.Text = "Редагувати";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.Text == "Розформувати відділ")
            {
                departmentsList.RemoveAt(comboBoxDepartments.SelectedIndex);
                this.Close();
            }
            else
            {
                FormCreateDepartment formCreateDepartment = new FormCreateDepartment(departmentsList, "Edit", comboBoxDepartments.SelectedIndex);
                this.Hide();
                formCreateDepartment.ShowDialog();
                this.Close();
            }
        }
    }
}
