using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeRepoTutorial;

namespace FormsEmpSystem
{
    public partial class Form1 : Form
    {
        Employee eobj;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eobj = new Employee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = eobj.GetEmployees();
            eobj.AddEmployee(new Employee());
        }
    }
}
