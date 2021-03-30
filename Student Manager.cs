using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace StudentMgrNamespace
{
    public partial class StudentManager : Form

    {
        ArrayList studentData = new ArrayList();
        //ArrayList serialData = new System.IO.DirectoryInfo(@".\data\").GetFiles();
        public StudentManager()
        {
            this.Text = "Student Manager";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentData.Add(new Student(1, "Alice", "Alison", "Apple Street", Month.January, Grade.Junior));
            studentData.Add(new Student(2, "Bob", "Bale", "Bushing Street", Month.Feburary, Grade.Sophmore));
            studentData.Add(new Student(3, "Charles", "Corn", "Cable Street", Month.March, Grade.Senior));
            StudentDisplay.DataSource = studentData;
            MonthBoxAddStudent.DataSource = Enum.GetNames(typeof(Month));
            GradeBoxAddStudent.DataSource = Enum.GetNames(typeof(Grade));

            populateSerialGrid();

        }
        private void populateSerialGrid()
        {
            DataTable serialNames = new DataTable();
            serialNames.Columns.Add("File");
            string[] fileList = Directory.GetFiles(@".\data\");
            foreach (string fileName in fileList)
            {
                serialNames.Rows.Add(fileName);
            }
            serialDataGrid.DataSource = serialNames;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            clearAddStudent();
        }
        private void clearAddStudent()
        {
            IDAddStudent.Clear();
            FnameAddStudent.Clear();
            LnameAddStudent.Clear();
            AddressAddStudent.Clear();
        }


        private void addStudent_click(object sender, EventArgs e)
        {
            if (FnameAddStudent.Text != "" || LnameAddStudent.Text != "" ||
                IDAddStudent.Text != "" || AddressAddStudent.Text != "") 
            {
                // val = box.Text.
                Student addStudent = new Student();
                addStudent.Id = Int32.Parse(IDAddStudent.Text);
                addStudent.Fname = FnameAddStudent.Text;
                addStudent.Lname = LnameAddStudent.Text;
                addStudent.Address = AddressAddStudent.Text;
                addStudent.MonthOfAdmission = (Month)MonthBoxAddStudent.SelectedIndex;

                addStudent.Grade = (Grade) GradeBoxAddStudent.SelectedIndex;
                studentData.Add(addStudent);
            } else
            {
                MessageBox.Show("Error: Bad input for student data.");
            }
            refreshData();
        }
        private void refreshData()
        {
            StudentDisplay.DataSource = null;
            StudentDisplay.DataSource = studentData;
            populateSerialGrid();
        }

        private void hideStudentDisplay(object sender, EventArgs e)
        {
            StudentDisplay.Visible = (StudentDisplay.Visible) ? false : true;
        }

        private void removeStudent(object sender, EventArgs e)
        {
            //MessageBox.Show("Remove student not implemented");
            //two methods, remove from grid, or remove based on id.
            studentData.RemoveAt(StudentDisplay.CurrentRow.Index);
            refreshData();
        }

        private void jsonButton_Click(object sender, EventArgs e)
        {
            Student curr = serialSetup();

            string jsonStudent = JsonConvert.SerializeObject(curr);
            string writePath = @".\data\" + curr.Fname + curr.Lname + ".json";
            File.WriteAllText(writePath, jsonStudent);
            refreshData();
        }

        private void xmlButton_Click(object sender, EventArgs e)
        {
            Student curr = serialSetup();

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(curr.GetType());
            string writePath = @".\data\" + curr.Fname + curr.Lname + ".xml";
            var xmlWriter = new StringWriter();
            System.IO.FileStream file = System.IO.File.Create(writePath);
            x.Serialize(file, curr);
            file.Close();
            refreshData();
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            Student curr = serialSetup();
            string writePath = @".\data\" + curr.Fname + curr.Lname + ".bin";
            FileStream fs = new FileStream(writePath, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, curr);
            }
            catch (SerializationException err)
            {
                Console.WriteLine("Failed to serialize. Reason: " + err.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            refreshData();
        }
        private Student serialSetup()
        {
            int index = StudentDisplay.CurrentRow.Index;
            Student curr = (Student)studentData[index];
            System.IO.Directory.CreateDirectory(@"data");
            return curr;
        }

        private void loadStdButton_Click(object sender, EventArgs e)
        {
            int index = serialDataGrid.CurrentRow.Index;
            DataGridViewRow selectedRow = serialDataGrid.Rows[index];
            string filePath = Convert.ToString(selectedRow.Cells["File"].Value);
            string fileType = filePath.Substring(filePath.Length - 3);

            switch (fileType)
            {
                case "son":
                    MessageBox.Show("json");
                    deserialJson(filePath);
                    break;
                case "bin":
                    deserialBinary(filePath);
                    break;
                case "xml":
                    MessageBox.Show("xml");
                    deserialXml(filePath);
                    break;
                default:
                    MessageBox.Show("Bad file");
                    break;
            }
        }
        private void deserialJson(string filePath)
        {
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                Student curr = (Student)serializer.Deserialize(file, typeof(Student));
                studentData.Add(curr);
                refreshData();
                file.Close();
            }
        }
        private void deserialXml(string filePath)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(Student));
            using (StreamReader file = File.OpenText(filePath))
            {
                Student curr = (Student)x.Deserialize(file);
                studentData.Add(curr);
                refreshData();
                file.Close();
            }
        }
        private void deserialBinary(string filePath)
        {
            Student curr = null;
            FileStream fs = new FileStream(filePath, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                curr = (Student)formatter.Deserialize(fs);
                studentData.Add(curr);
                refreshData();
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
