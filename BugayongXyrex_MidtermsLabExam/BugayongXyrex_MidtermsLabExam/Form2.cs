using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BugayongXyrex_MidtermsLabExam
{
    public partial class StudentPage_Individual : Form
    {
        string mysqlCon = "server = 127.0.0.1; user = root; database = studentinfodb; password =";
        private string studentId;

        // Default constructor (you might need this for the designer)
        public StudentPage_Individual()
        {
            InitializeComponent();
        }

        // Constructor that accepts student ID
        public StudentPage_Individual(string id)
        {
            InitializeComponent();
            studentId = id;
        }

        private void StudentPage_Individual_Load(object sender, EventArgs e)
        {
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();

         
                string query = @"SELECT 
                                    s.*,
                                    c.courseName,
                                    y.yearLvl,
                                    CONCAT(s.firstName, ' ', s.middleName, ' ', s.lastName) AS fullName,
                                    CONCAT(s.houseNo, ' ', s.brgyName, ', ', s.municipality, ', ', s.province, ', ', s.region, ', ', s.country) AS fullAddress,
                                    CONCAT(s.guardianFirstName, ' ', s.guardianLastName) AS guardianFullName
                                FROM studentrecordtb s
                                JOIN coursetb c ON s.courseId = c.courseId
                                JOIN yeartb y ON s.yearId = y.yearId
                                WHERE s.studentId = @studentId";

                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.AddWithValue("@studentId", studentId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
 
                    CreateDataLabel("lblStudentId", 285, 134, reader["studentId"].ToString());
                    CreateDataLabel("lblFullName", 285, 172, reader["fullName"].ToString());
                    CreateDataLabel("lblAddress", 285, 207, reader["fullAddress"].ToString());
                    CreateDataLabel("lblBirthdate", 285, 243, reader["birthdate"].ToString());
                    CreateDataLabel("lblAge", 285, 279, reader["age"].ToString());
                    CreateDataLabel("lblContactNo", 285, 315, reader["studContactNo"].ToString());
                    CreateDataLabel("lblEmail", 285, 351, reader["emailAddress"].ToString());
                    CreateDataLabel("lblGuardian", 285, 388, reader["guardianFullName"].ToString());
                    CreateDataLabel("lblHobbies", 285, 459, reader["hobbies"].ToString());
                    CreateDataLabel("lblNickname", 285, 498, reader["nickname"].ToString());

                    
                    CreateDataLabel("lblYear", 630, 135, reader["yearLvl"].ToString());
                    CreateDataLabel("lblCourse", 630, 172, reader["courseName"].ToString());
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

        private void CreateDataLabel(string name, int x, int y, string text)
        {
            Label lbl = new Label();
            lbl.Name = name;
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
        }
    }
}