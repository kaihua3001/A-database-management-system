using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuDataManagementSystem
{
    public partial class StuInfoEditorForm : Form
    {

        public StuInfo StuInfo { get; set; }

        public StuInfoEditorForm(StuInfo stuInfo)
        {
            InitializeComponent();
            //StuInfo = new StuInfo();
            //StuInfo.stuID = editorID;
            StuInfo = stuInfo;
        }

        private void StuInfoEditorForm_Load(object sender, EventArgs e)
        {
            string stuConnectionString = SqlHelper.GetSqlConnectionString();
            using (SqlConnection sqlChangeConnection = new SqlConnection(stuConnectionString))
            {
                using (SqlCommand sqlChangeCommand = sqlChangeConnection.CreateCommand())
                {
                    sqlChangeConnection.Open();
                    sqlChangeCommand.CommandText = "select [stuID], [stuName], [stuGender], [stuBirthDate], [stuPhoneNumber], [DelFlag] from[dbo].[StuInfo] where stuID=@stuID";
                    sqlChangeCommand.Parameters.AddWithValue("@stuID",StuInfo.stuID );
                    using (SqlDataReader sqlChangeDataReader = sqlChangeCommand.ExecuteReader())
                    {
                        if (sqlChangeDataReader.Read())
                        {
                            this.studentNameTextBox.Text = sqlChangeDataReader["stuName"].ToString();
                            this.studentGenderTextBox.Text = sqlChangeDataReader["stuGender"].ToString();
                            this.studentPhoneNumberTextBox.Text = sqlChangeDataReader["stuPhoneNumber"].ToString();
                            this.studenBirthDateTextBox.Text = sqlChangeDataReader["stuBirthDate"].ToString();
                        }
                    }
                }
            }
        }

        private void studentChangeButton_Click(object sender, EventArgs e)
        {
            string connectionSting = SqlHelper.GetSqlConnectionString();
            using (SqlConnection sqlConnection=new SqlConnection(connectionSting))
            {
                using (SqlCommand sqlCommand=sqlConnection.CreateCommand())
                {
                    sqlConnection.Open();
                    sqlCommand.CommandText =
                        "Update StuInfo set [stuName]=@stuName, [stuGender]=@stuGender, [stuBirthDate]=@stuBirthDate, [stuPhoneNumber]=@stuPhoneNumber where stuID=@stuID";
                    sqlCommand.Parameters.AddWithValue("@stuName", this.studentNameTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@stuGender", this.studentGenderTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@stuBirthDate",
                        DateTime.Parse(this.studenBirthDateTextBox.Text));
                    sqlCommand.Parameters.AddWithValue("@stuPhoneNumber", this.studentPhoneNumberTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@stuID", StuInfo.stuID);
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Succeed");
                    

                    this.Close();
                }
            }
        }
    }
}
