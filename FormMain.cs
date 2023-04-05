using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CSharp_Lb4_var4
{
    public partial class FormMain : Form
    {
        private List <Department> departmentsList = new List<Department>();

        private void updateDataGridView()
        {
            dataGridViewInfo.Rows.Clear();
            for (int i = 0; i < departmentsList.Count; i++)
            {
                for (int j = 0; j < departmentsList[i].Employees.Count; j++)
                {
                    string dtName = departmentsList[i].Employees[j].Surname + " " + departmentsList[i].Employees[j].Name + " " + departmentsList[i].Employees[j].LastName;
                    dataGridViewInfo.Rows.Add(dtName, departmentsList[i].Employees[j].Id, departmentsList[i].DepartmentName, departmentsList[i].Employees[j].Salary);
                }
                dataGridViewInfo.Rows.Add();
            }
        }

        public FormMain()
        {
            if (File.Exists("information.json"))
            {
                string readData = File.ReadAllText("information.json");
                departmentsList = JsonSerializer.Deserialize<List<Department>>(readData);
            }
            InitializeComponent();
            updateDataGridView();
        }

        private void createDepartmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCreateDepartment formCreateDepartment = new FormCreateDepartment(departmentsList, "Add", 0);
            this.Hide();
            formCreateDepartment.ShowDialog();
            this.Show();
            updateDataGridView();
        }

        private void disbandDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (departmentsList.Count == 0)
                MessageBox.Show("Ви ще не записали інформацію про відділи в своїй компанії!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormControlDepartment formControlDepartment = new FormControlDepartment(departmentsList, "Розформувати відділ");
                this.Hide();
                formControlDepartment.ShowDialog();
                this.Show();
                updateDataGridView();
            }
        }

        private void renameDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (departmentsList.Count == 0)
                MessageBox.Show("Ви ще не записали інформацію про відділи в своїй компанії!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormControlDepartment formControlDepartment = new FormControlDepartment(departmentsList, "Редагування відділу");
                this.Hide();
                formControlDepartment.ShowDialog();
                this.Show();
                updateDataGridView();
            }
        }

        private void hireEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (departmentsList.Count == 0)
                MessageBox.Show("Для найму працівника необхідно створити відділ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormControlEmployees formControlEmployees = new FormControlEmployees("Найм працівників", departmentsList, true, 0, 0);
                this.Hide();
                formControlEmployees.ShowDialog();
                this.Show();
                updateDataGridView();
            }
        }

        private void fireEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (departmentsList.Count == 0)
                MessageBox.Show("Інформація про працівників відсутня!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormEditEmployees formEditEmployees = new FormEditEmployees(departmentsList, "Звільнення співробітника");
                this.Hide();
                formEditEmployees.ShowDialog();
                this.Show();
                updateDataGridView();
            }
        }

        private void transferEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (departmentsList.Count == 0)
                MessageBox.Show("Інформація про працівників відсутня!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormTransferEmployee formTransferEmployee = new FormTransferEmployee(departmentsList);
                this.Hide();
                formTransferEmployee.ShowDialog(); 
                this.Show();
                updateDataGridView();
            }
        }

        private void changeInformationEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (departmentsList.Count == 0)
                MessageBox.Show("Інформація про працівників відсутня!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormEditEmployees formEditEmployees = new FormEditEmployees(departmentsList, "Редагування інформації про співробітника");
                this.Hide();
                formEditEmployees.ShowDialog();
                this.Show();
                updateDataGridView();
            }
        }

        private void showAllEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (departmentsList.Count == 0)
                MessageBox.Show("Ви ще не записали інформацію про відділи в своїй компанії!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                updateDataGridView();
            }
        }

        private void showDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (departmentsList.Count == 0)
                MessageBox.Show("Ви ще не записали інформацію про відділи в своїй компанії!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormSelectDepartment formSelectDepartment = new FormSelectDepartment(departmentsList);
                this.Hide();
                formSelectDepartment.ShowDialog();
                this.Show();

                dataGridViewInfo.Rows.Clear();
                for (int i = 0; i < departmentsList[formSelectDepartment.selectIndexDepartment].Employees.Count; i++)
                {
                    string dtName = departmentsList[formSelectDepartment.selectIndexDepartment].Employees[i].Surname + " " + 
                        departmentsList[formSelectDepartment.selectIndexDepartment].Employees[i].Name + " " + 
                        departmentsList[formSelectDepartment.selectIndexDepartment].Employees[i].LastName;
                    dataGridViewInfo.Rows.Add(dtName, 
                        departmentsList[formSelectDepartment.selectIndexDepartment].Employees[i].Id, 
                        departmentsList[formSelectDepartment.selectIndexDepartment].DepartmentName, 
                        departmentsList[formSelectDepartment.selectIndexDepartment].Employees[i].Salary);
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви дійсно бажаєте завершити роботу?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string saveData = JsonSerializer.Serialize(departmentsList);
                File.WriteAllText("information.json", saveData);
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
    }
}
