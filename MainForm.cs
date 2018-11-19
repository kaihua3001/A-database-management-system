using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuDataManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainFormDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadStuInfo();
        }

        private void LoadStuInfo()
        {
            List<StuInfo> StuInformationList = new List<StuInfo>();
            //get connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            string cnnStr = SqlHelper.GetSqlConnectionString();
            string sql =
                "select [stuID], [stuName], [stuGender], [stuBirthDate], [stuPhoneNumber], [DelFlag] from[dbo].[StuInfo] where [Delflag]=0";
            using (SqlDataAdapter adapter= new SqlDataAdapter(sql,cnnStr))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                foreach (DataRow itmeRow in data.Rows)
                {
                    StuInfo stuInfo = new StuInfo();
                    stuInfo.stuID = int.Parse(itmeRow["stuID"].ToString().Trim());
                    stuInfo.stuName = itmeRow["stuName"].ToString().Trim();
                    stuInfo.stuGender = itmeRow["stuGender"].ToString().Trim();
                    stuInfo.stuBirthDate=DateTime.Parse(itmeRow["stuBirthDate"].ToString().Trim());
                    stuInfo.stuPhoneNumber = itmeRow["stuPhoneNumber"].ToString().Trim();
                    stuInfo.DelFlag = int.Parse(itmeRow["DelFlag"].ToString().Trim());

                    StuInformationList.Add(stuInfo);


                }

                this.mainFormDataGridView.DataSource = StuInformationList;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.mainFormDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please make a selection");
                return;
            }

            if (MessageBox.Show("Delete Confrim", "Attention!", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            int deleteID = int.Parse(this.mainFormDataGridView.SelectedRows[0].Cells["stuID"].Value.ToString());

            string connStr = SqlHelper.GetSqlConnectionString();

            using (SqlConnection sqlConnectionDelete = new SqlConnection(connStr))
            {
                using (SqlCommand deleteCommand=sqlConnectionDelete.CreateCommand())
                {
                    sqlConnectionDelete.Open();
                    //deleteCommand.CommandText = "delete from stuInfo where stuID=@stuID";
                    deleteCommand.CommandText = "update stuInfo set DelFlag = 1 where stuID=@stuID";
                    deleteCommand.Parameters.AddWithValue("@stuID", deleteID);


                    if (deleteCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Succeed");
                    }

                    LoadStuInfo();
                }
            }

           // MessageBox.Show("Delete");
        }

        private void mainFormDataGridView_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(this.mainFormDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            int selectRowID = int.Parse(this.mainFormDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            string stuConnectionString = SqlHelper.GetSqlConnectionString();
            using (SqlConnection sqlChangeConnection =new SqlConnection(stuConnectionString))
            {
                using (SqlCommand sqlChangeCommand=sqlChangeConnection.CreateCommand())
                {
                    sqlChangeConnection.Open();
                    sqlChangeCommand.CommandText = "select [stuID], [stuName], [stuGender], [stuBirthDate], [stuPhoneNumber], [DelFlag] from[dbo].[StuInfo] where stuID=@stuID";
                    sqlChangeCommand.Parameters.AddWithValue("@stuID", selectRowID);
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
            string sqlSaveConnection = SqlHelper.GetSqlConnectionString();
            using (SqlConnection sqlSaveConn=new SqlConnection(sqlSaveConnection))
            {
                using (SqlCommand sqlSaveCommand=sqlSaveConn.CreateCommand())
                {
                    sqlSaveConn.Open();
                    int selectRowID = int.Parse(this.mainFormDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    sqlSaveCommand.CommandText =
                        "update stuInfo set stuName=@stuName, stuGender=@stuGender, stuBirthDate=@stuBirthDate, stuPhoneNumber=@stuPhoneNumber where stuID=@stuID";
                    sqlSaveCommand.Parameters.AddWithValue("stuID", selectRowID);
                    sqlSaveCommand.Parameters.AddWithValue("stuName", this.studentNameTextBox.Text);
                    sqlSaveCommand.Parameters.AddWithValue("stuGender", this.studentGenderTextBox.Text);
                    sqlSaveCommand.Parameters.AddWithValue("stuBirthDate",
                        DateTime.Parse(this.studenBirthDateTextBox.Text));
                    sqlSaveCommand.Parameters.AddWithValue("stuPhoneNumber", this.studentPhoneNumberTextBox.Text);
                    sqlSaveCommand.ExecuteNonQuery();
                    MessageBox.Show("Succeed");

                }

                LoadStuInfo();
            }
        }

        private void mainFormDataGridView_DoubleClick(object sender, EventArgs e)
        {

            if (this.mainFormDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }
            int selectedRowID = int.Parse(this.mainFormDataGridView.SelectedRows[0].Cells[0].Value.ToString());



            StuInfoEditorForm stuInfoEditor = new StuInfoEditorForm(new StuInfo(){stuID = selectedRowID});

            stuInfoEditor.FormClosing += stuInfoEditor_FormClosing;


            stuInfoEditor.Show();


        }

        private void stuInfoEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadStuInfo();
        }

        private void mainFormSearchButton_Click(object sender, EventArgs e)
        {

            string connectionString = SqlHelper.GetSqlConnectionString();
            string sqlText = "select [stuID], [stuName], [stuGender], [stuBirthDate], [stuPhoneNumber], [DelFlag] from[dbo].[StuInfo]";

            List<StuInfo> StuInformationList = new List<StuInfo>();
            List<string> searchList =new List<string>();
            List<SqlParameter> parameters=new List<SqlParameter>();

            if (!string.IsNullOrEmpty(this.studentNameTextBox.Text.Trim()))
            {
                searchList.Add("stuName like @stuName");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@stuName";
                parameter.Value = "%" + studentNameTextBox.Text + "%";
                parameters.Add(parameter);
            }



            if (!string.IsNullOrEmpty(this.studentPhoneNumberTextBox.Text.Trim()))
            {
                searchList.Add("stuPhoneNumber like @stuPhoneNumber");
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@stuPhoneNumber";
                parameter.Value = "%" + studentPhoneNumberTextBox.Text + "%";
                parameters.Add(parameter);
            }

            if (searchList.Count > 0)
            {
                sqlText += " where "+string.Join(" and ", searchList);
            }

            using (SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(sqlText,connectionString))
            {
                sqlDataAdapter.SelectCommand.Parameters.AddRange(parameters.ToArray());
                DataTable dataTable = new DataTable();


                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow itmeRow in dataTable.Rows)
                {
                    StuInfo stuInfo = new StuInfo();
                    stuInfo.stuID = int.Parse(itmeRow["stuID"].ToString().Trim());
                    stuInfo.stuName = itmeRow["stuName"].ToString().Trim();
                    stuInfo.stuGender = itmeRow["stuGender"].ToString().Trim();
                    stuInfo.stuBirthDate = DateTime.Parse(itmeRow["stuBirthDate"].ToString().Trim());
                    stuInfo.stuPhoneNumber = itmeRow["stuPhoneNumber"].ToString().Trim();
                    stuInfo.DelFlag = int.Parse(itmeRow["DelFlag"].ToString().Trim());

                    StuInformationList.Add(stuInfo);


                }

                this.mainFormDataGridView.DataSource = StuInformationList;

            }
        }
    }
}
