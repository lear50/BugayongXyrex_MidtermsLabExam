using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BugayongXyrex_MidtermsLabExam
{
    public partial class Student_Page : Form
    {
        string mysqlCon = "server = 127.0.0.1; user = root; database = studentinfodb; password =";

        public Student_Page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        private void LoadStudentRecords()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();

                string query = @"SELECT 
                                    studentId,
                                    CONCAT(firstName, ' ', middleName, ' ', lastName) AS fullName
                                FROM studentrecordtb
                                ORDER BY studentId";

                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                
                int yPos = 180; 

                
                while (reader.Read())
                {
                    
                    Label lblStudentId = new Label();
                    lblStudentId.Text = reader["studentId"].ToString();
                    lblStudentId.Location = new System.Drawing.Point(130, yPos);
                    lblStudentId.AutoSize = true;
                    this.Controls.Add(lblStudentId);

                    
                    Label lblStudentName = new Label();
                    lblStudentName.Text = reader["fullName"].ToString();
                    lblStudentName.Location = new System.Drawing.Point(365, yPos);
                    lblStudentName.AutoSize = true;
                    this.Controls.Add(lblStudentName);

                    
                    Button viewButton = new Button();
                    viewButton.Text = "view";
                    viewButton.Name = "viewButton" + reader["studentId"].ToString();
                    viewButton.Location = new System.Drawing.Point(660, yPos);
                    viewButton.Size = new System.Drawing.Size(65, 23);
                    viewButton.Tag = reader["studentId"].ToString(); 
                    viewButton.Click += new EventHandler(ViewButton_Click);
                    this.Controls.Add(viewButton);

                    
                    yPos += 40;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string studentId = btn.Tag.ToString();

            StudentPage_Individual individualPage = new StudentPage_Individual(studentId);
            individualPage.Show();
        }
    }
}