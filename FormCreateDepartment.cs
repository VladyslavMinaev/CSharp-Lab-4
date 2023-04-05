using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_Lb4_var4
{
    public partial class FormCreateDepartment : Form
    {
        private List<Department> departmentsList;
        private string mode;
        private int index;
        internal FormCreateDepartment(List<Department> departments, string mode, int index)
        {
            departmentsList = departments;
            InitializeComponent();
            this.mode = mode;
            this.index = index;
            if (mode == "Edit")
            {
                buttonAdd.Text = "Редагувати";
                label2.Visible = false;
                numericUpDownCountEmployess.Visible = false;
                textBoxDepartmentName.Text = departmentsList[index].DepartmentName;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (mode == "Add")
            {
                if (textBoxDepartmentName.Text == string.Empty || numericUpDownCountEmployess.Value == 0)
                    MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Department findDepartment = departmentsList.Find(d => d.DepartmentName.Equals(textBoxDepartmentName.Text));
                    if (findDepartment != null)
                        MessageBox.Show("Цей відділ вже записаний!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Department newDepartment = new Department();
                        newDepartment.DepartmentName = textBoxDepartmentName.Text;
                        newDepartment.CountEmployees = Convert.ToInt32(Math.Round(numericUpDownCountEmployess.Value, 0));
                        departmentsList.Add(newDepartment);
                        DialogResult mb = MessageBox.Show("Бажаєте відразу додати співробітників?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mb == DialogResult.Yes)
                        {
                            FormControlEmployees formControlEmployees = new FormControlEmployees("Найм працівників", departmentsList, false, 0, 0);
                            this.Hide();
                            formControlEmployees.ShowDialog();
                        }
                        this.Close();
                    }
                }
            }
            else
            {
                if (textBoxDepartmentName.Text == string.Empty)
                {
                    DialogResult mb = MessageBox.Show("Ви точно бажаєте видалити цей відділ?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (mb == DialogResult.Yes)
                    {
                        departmentsList.RemoveAt(index);
                        this.Close();
                    }
                }
                else
                {
                    departmentsList[index].DepartmentName = textBoxDepartmentName.Text;
                    this.Close();
                }
            }
        }
    }
}
