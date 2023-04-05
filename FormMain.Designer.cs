namespace CSharp_Lb4_var4
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.створитиВідділToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDepartmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disbandDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиВідділToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInformationEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметриВідображенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиВідділToolStripMenuItem,
            this.видалитиВідділToolStripMenuItem,
            this.параметриВідображенняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1057, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // створитиВідділToolStripMenuItem
            // 
            this.створитиВідділToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDepartmentToolStripMenuItem1,
            this.disbandDepartmentToolStripMenuItem,
            this.renameDepartmentToolStripMenuItem});
            this.створитиВідділToolStripMenuItem.Name = "створитиВідділToolStripMenuItem";
            this.створитиВідділToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.створитиВідділToolStripMenuItem.Text = "Керування відділами";
            // 
            // createDepartmentToolStripMenuItem1
            // 
            this.createDepartmentToolStripMenuItem1.Name = "createDepartmentToolStripMenuItem1";
            this.createDepartmentToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.createDepartmentToolStripMenuItem1.Text = "Створити відділ";
            this.createDepartmentToolStripMenuItem1.Click += new System.EventHandler(this.createDepartmentToolStripMenuItem1_Click);
            // 
            // disbandDepartmentToolStripMenuItem
            // 
            this.disbandDepartmentToolStripMenuItem.Name = "disbandDepartmentToolStripMenuItem";
            this.disbandDepartmentToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.disbandDepartmentToolStripMenuItem.Text = "Розформувати відділ";
            this.disbandDepartmentToolStripMenuItem.Click += new System.EventHandler(this.disbandDepartmentToolStripMenuItem_Click);
            // 
            // renameDepartmentToolStripMenuItem
            // 
            this.renameDepartmentToolStripMenuItem.Name = "renameDepartmentToolStripMenuItem";
            this.renameDepartmentToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.renameDepartmentToolStripMenuItem.Text = "Перейменування відділу";
            this.renameDepartmentToolStripMenuItem.Click += new System.EventHandler(this.renameDepartmentToolStripMenuItem_Click);
            // 
            // видалитиВідділToolStripMenuItem
            // 
            this.видалитиВідділToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hireEmployeeToolStripMenuItem,
            this.fireEmployeeToolStripMenuItem,
            this.transferEmployeeToolStripMenuItem,
            this.changeInformationEmployeeToolStripMenuItem});
            this.видалитиВідділToolStripMenuItem.Name = "видалитиВідділToolStripMenuItem";
            this.видалитиВідділToolStripMenuItem.Size = new System.Drawing.Size(158, 19);
            this.видалитиВідділToolStripMenuItem.Text = "Керування працівниками";
            // 
            // hireEmployeeToolStripMenuItem
            // 
            this.hireEmployeeToolStripMenuItem.Name = "hireEmployeeToolStripMenuItem";
            this.hireEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hireEmployeeToolStripMenuItem.Text = "Найм";
            this.hireEmployeeToolStripMenuItem.Click += new System.EventHandler(this.hireEmployeeToolStripMenuItem_Click);
            // 
            // fireEmployeeToolStripMenuItem
            // 
            this.fireEmployeeToolStripMenuItem.Name = "fireEmployeeToolStripMenuItem";
            this.fireEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fireEmployeeToolStripMenuItem.Text = "Звільнення";
            this.fireEmployeeToolStripMenuItem.Click += new System.EventHandler(this.fireEmployeeToolStripMenuItem_Click);
            // 
            // transferEmployeeToolStripMenuItem
            // 
            this.transferEmployeeToolStripMenuItem.Name = "transferEmployeeToolStripMenuItem";
            this.transferEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transferEmployeeToolStripMenuItem.Text = "Переведення";
            this.transferEmployeeToolStripMenuItem.Click += new System.EventHandler(this.transferEmployeeToolStripMenuItem_Click);
            // 
            // changeInformationEmployeeToolStripMenuItem
            // 
            this.changeInformationEmployeeToolStripMenuItem.Name = "changeInformationEmployeeToolStripMenuItem";
            this.changeInformationEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeInformationEmployeeToolStripMenuItem.Text = "Зміна інформації";
            this.changeInformationEmployeeToolStripMenuItem.Click += new System.EventHandler(this.changeInformationEmployeeToolStripMenuItem_Click);
            // 
            // параметриВідображенняToolStripMenuItem
            // 
            this.параметриВідображенняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllEmployeesToolStripMenuItem,
            this.showDepartmentToolStripMenuItem});
            this.параметриВідображенняToolStripMenuItem.Name = "параметриВідображенняToolStripMenuItem";
            this.параметриВідображенняToolStripMenuItem.Size = new System.Drawing.Size(161, 19);
            this.параметриВідображенняToolStripMenuItem.Text = "Параметри відображення";
            // 
            // showAllEmployeesToolStripMenuItem
            // 
            this.showAllEmployeesToolStripMenuItem.Name = "showAllEmployeesToolStripMenuItem";
            this.showAllEmployeesToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.showAllEmployeesToolStripMenuItem.Text = "Показати ввесь список працівників";
            this.showAllEmployeesToolStripMenuItem.Click += new System.EventHandler(this.showAllEmployeesToolStripMenuItem_Click);
            // 
            // showDepartmentToolStripMenuItem
            // 
            this.showDepartmentToolStripMenuItem.Name = "showDepartmentToolStripMenuItem";
            this.showDepartmentToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.showDepartmentToolStripMenuItem.Text = "Показати список окремого відділу";
            this.showDepartmentToolStripMenuItem.Click += new System.EventHandler(this.showDepartmentToolStripMenuItem_Click);
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.Id,
            this.Department,
            this.Salary});
            this.dataGridViewInfo.Location = new System.Drawing.Point(22, 50);
            this.dataGridViewInfo.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(1013, 455);
            this.dataGridViewInfo.TabIndex = 1;
            // 
            // FIO
            // 
            this.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIO.HeaderText = "ПІБ";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.HeaderText = "Відділ";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.HeaderText = "Зп";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 527);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1073, 566);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem створитиВідділToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDepartmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disbandDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиВідділToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeInformationEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameDepartmentToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.ToolStripMenuItem параметриВідображенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDepartmentToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}

