
namespace StudentMgrNamespace
{
    partial class StudentManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentDisplay = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MonthBoxAddStudent = new System.Windows.Forms.ComboBox();
            this.GradeBoxAddStudent = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressAddStudent = new System.Windows.Forms.TextBox();
            this.LnameAddStudent = new System.Windows.Forms.TextBox();
            this.FnameAddStudent = new System.Windows.Forms.TextBox();
            this.IDAddStudent = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialTab = new System.Windows.Forms.TabPage();
            this.loadStdButton = new System.Windows.Forms.Button();
            this.binaryButton = new System.Windows.Forms.Button();
            this.xmlButton = new System.Windows.Forms.Button();
            this.jsonButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.StudentLoadedTab = new System.Windows.Forms.TabPage();
            this.SerializedTab = new System.Windows.Forms.TabPage();
            this.serialDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDisplay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.serialTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.StudentLoadedTab.SuspendLayout();
            this.SerializedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDisplay
            // 
            this.StudentDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDisplay.Location = new System.Drawing.Point(3, 3);
            this.StudentDisplay.Name = "StudentDisplay";
            this.StudentDisplay.Size = new System.Drawing.Size(557, 244);
            this.StudentDisplay.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.serialTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 312);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 263);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MonthBoxAddStudent);
            this.tabPage1.Controls.Add(this.GradeBoxAddStudent);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.AddressAddStudent);
            this.tabPage1.Controls.Add(this.LnameAddStudent);
            this.tabPage1.Controls.Add(this.FnameAddStudent);
            this.tabPage1.Controls.Add(this.IDAddStudent);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MonthBoxAddStudent
            // 
            this.MonthBoxAddStudent.FormattingEnabled = true;
            this.MonthBoxAddStudent.Location = new System.Drawing.Point(112, 112);
            this.MonthBoxAddStudent.Name = "MonthBoxAddStudent";
            this.MonthBoxAddStudent.Size = new System.Drawing.Size(182, 21);
            this.MonthBoxAddStudent.TabIndex = 30;
            // 
            // GradeBoxAddStudent
            // 
            this.GradeBoxAddStudent.FormattingEnabled = true;
            this.GradeBoxAddStudent.Location = new System.Drawing.Point(112, 139);
            this.GradeBoxAddStudent.Name = "GradeBoxAddStudent";
            this.GradeBoxAddStudent.Size = new System.Drawing.Size(182, 21);
            this.GradeBoxAddStudent.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Grade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Month of Admission";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addStudent_click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(482, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Name";
            // 
            // AddressAddStudent
            // 
            this.AddressAddStudent.Location = new System.Drawing.Point(112, 88);
            this.AddressAddStudent.Name = "AddressAddStudent";
            this.AddressAddStudent.Size = new System.Drawing.Size(368, 20);
            this.AddressAddStudent.TabIndex = 9;
            // 
            // LnameAddStudent
            // 
            this.LnameAddStudent.Location = new System.Drawing.Point(112, 62);
            this.LnameAddStudent.Name = "LnameAddStudent";
            this.LnameAddStudent.Size = new System.Drawing.Size(182, 20);
            this.LnameAddStudent.TabIndex = 8;
            // 
            // FnameAddStudent
            // 
            this.FnameAddStudent.Location = new System.Drawing.Point(112, 36);
            this.FnameAddStudent.Name = "FnameAddStudent";
            this.FnameAddStudent.Size = new System.Drawing.Size(182, 20);
            this.FnameAddStudent.TabIndex = 7;
            // 
            // IDAddStudent
            // 
            this.IDAddStudent.Location = new System.Drawing.Point(112, 10);
            this.IDAddStudent.Name = "IDAddStudent";
            this.IDAddStudent.Size = new System.Drawing.Size(182, 20);
            this.IDAddStudent.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remove Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 29;
            this.button3.Text = "Remove Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.removeStudent);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 27;
            // 
            // serialTab
            // 
            this.serialTab.Controls.Add(this.loadStdButton);
            this.serialTab.Controls.Add(this.binaryButton);
            this.serialTab.Controls.Add(this.xmlButton);
            this.serialTab.Controls.Add(this.jsonButton);
            this.serialTab.Location = new System.Drawing.Point(4, 22);
            this.serialTab.Name = "serialTab";
            this.serialTab.Padding = new System.Windows.Forms.Padding(3);
            this.serialTab.Size = new System.Drawing.Size(563, 237);
            this.serialTab.TabIndex = 2;
            this.serialTab.Text = "Serialize";
            this.serialTab.UseVisualStyleBackColor = true;
            // 
            // loadStdButton
            // 
            this.loadStdButton.Location = new System.Drawing.Point(396, 208);
            this.loadStdButton.Name = "loadStdButton";
            this.loadStdButton.Size = new System.Drawing.Size(161, 23);
            this.loadStdButton.TabIndex = 3;
            this.loadStdButton.Text = "Load Selected Serialized Student";
            this.loadStdButton.UseVisualStyleBackColor = true;
            this.loadStdButton.Click += new System.EventHandler(this.loadStdButton_Click);
            // 
            // binaryButton
            // 
            this.binaryButton.Location = new System.Drawing.Point(6, 64);
            this.binaryButton.Name = "binaryButton";
            this.binaryButton.Size = new System.Drawing.Size(100, 23);
            this.binaryButton.TabIndex = 2;
            this.binaryButton.Text = "Binary";
            this.binaryButton.UseVisualStyleBackColor = true;
            this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
            // 
            // xmlButton
            // 
            this.xmlButton.Location = new System.Drawing.Point(6, 35);
            this.xmlButton.Name = "xmlButton";
            this.xmlButton.Size = new System.Drawing.Size(100, 23);
            this.xmlButton.TabIndex = 1;
            this.xmlButton.Text = "XML";
            this.xmlButton.UseVisualStyleBackColor = true;
            this.xmlButton.Click += new System.EventHandler(this.xmlButton_Click);
            // 
            // jsonButton
            // 
            this.jsonButton.Location = new System.Drawing.Point(6, 6);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(100, 23);
            this.jsonButton.TabIndex = 0;
            this.jsonButton.Text = "JSON";
            this.jsonButton.UseVisualStyleBackColor = true;
            this.jsonButton.Click += new System.EventHandler(this.jsonButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 581);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hide DataGrid";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.hideStudentDisplay);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.StudentLoadedTab);
            this.tabControl2.Controls.Add(this.SerializedTab);
            this.tabControl2.Location = new System.Drawing.Point(12, 27);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(571, 279);
            this.tabControl2.TabIndex = 5;
            // 
            // StudentLoadedTab
            // 
            this.StudentLoadedTab.Controls.Add(this.StudentDisplay);
            this.StudentLoadedTab.Location = new System.Drawing.Point(4, 22);
            this.StudentLoadedTab.Name = "StudentLoadedTab";
            this.StudentLoadedTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentLoadedTab.Size = new System.Drawing.Size(563, 253);
            this.StudentLoadedTab.TabIndex = 0;
            this.StudentLoadedTab.Text = "Students";
            this.StudentLoadedTab.UseVisualStyleBackColor = true;
            // 
            // SerializedTab
            // 
            this.SerializedTab.Controls.Add(this.serialDataGrid);
            this.SerializedTab.Location = new System.Drawing.Point(4, 22);
            this.SerializedTab.Name = "SerializedTab";
            this.SerializedTab.Padding = new System.Windows.Forms.Padding(3);
            this.SerializedTab.Size = new System.Drawing.Size(563, 253);
            this.SerializedTab.TabIndex = 1;
            this.SerializedTab.Text = "Serialized";
            this.SerializedTab.UseVisualStyleBackColor = true;
            // 
            // serialDataGrid
            // 
            this.serialDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serialDataGrid.Location = new System.Drawing.Point(3, 4);
            this.serialDataGrid.Name = "serialDataGrid";
            this.serialDataGrid.Size = new System.Drawing.Size(557, 244);
            this.serialDataGrid.TabIndex = 1;
            // 
            // StudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 616);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentManager";
            this.Text = "Student Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDisplay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.serialTab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.StudentLoadedTab.ResumeLayout(false);
            this.SerializedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serialDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDisplay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox AddressAddStudent;
        private System.Windows.Forms.TextBox LnameAddStudent;
        private System.Windows.Forms.TextBox FnameAddStudent;
        private System.Windows.Forms.TextBox IDAddStudent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox MonthBoxAddStudent;
        private System.Windows.Forms.ComboBox GradeBoxAddStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabPage serialTab;
        private System.Windows.Forms.Button binaryButton;
        private System.Windows.Forms.Button xmlButton;
        private System.Windows.Forms.Button jsonButton;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage StudentLoadedTab;
        private System.Windows.Forms.TabPage SerializedTab;
        private System.Windows.Forms.DataGridView serialDataGrid;
        private System.Windows.Forms.Button loadStdButton;
    }
}

