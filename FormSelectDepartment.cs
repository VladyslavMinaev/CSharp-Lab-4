using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_Lb4_var4
{
    public partial class FormSelectDepartment : Form
    {
        private List<Department> departmentsList;
        public int selectIndexDepartment = 0;

        internal FormSelectDepartment(List<Department> departmentsList)
        {
            InitializeComponent();
            this.departmentsList = departmentsList;
            comboBoxDepartments.DataSource = departmentsList;
            comboBoxDepartments.DisplayMember = "DepartmentName";
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            selectIndexDepartment = comboBoxDepartments.SelectedIndex;
            this.Close();
        }
    }
}
