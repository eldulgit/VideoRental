using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VideoRental
{
    public partial class formCustomer : Form
    {
        public formCustomer()
        {
            InitializeComponent();
        }

        String SqlString = @"Server=pc1;database=VideoRentalDB;uid=sa;pwd=std001";
        SqlConnection conn;

        private void formCustomer_Load(object sender, EventArgs e)
        {
            Show_Customer();
        }
        
        private void Show_Customer() // 고객 정보 갱신
        {
            dataGridView1.Rows.Clear();
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Customer_Select", conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString(),
                        dr[5].ToString(),
                        dr[6].ToString(),
                        dr[7].ToString(),
                        dr[8].ToString()
                        );
                }

                dr.Close();

                Lb_CustomerCount.Text = (dataGridView1.Rows.Count -1 ).ToString() + "개";
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) // 고객 추가
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Customer_Insert", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@CustomerNum", SqlDbType.VarChar).Value = textCustomerNum.Text;
                com.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = textCustomerName.Text;
                com.Parameters.Add("@ResidentNum", SqlDbType.Char).Value = textCustomerResidentNum.Text;
                com.Parameters.Add("@CustomerType", SqlDbType.NChar).Value = textCustomerType.Text;
                com.Parameters.Add("@Gender", SqlDbType.Char).Value = textCustomerGender.Text;
                com.Parameters.Add("@Phone", SqlDbType.Char).Value = textCustomerPhone.Text;
                com.Parameters.Add("@CellPhone", SqlDbType.Char).Value = textCustomerCell.Text;
                com.Parameters.Add("@Mail", SqlDbType.VarChar).Value = textCustomerMail.Text;
                com.Parameters.Add("@Address", SqlDbType.NVarChar).Value = textCustomerAddr.Text;

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            Show_Customer();
        }

        private void btnSave_Click(object sender, EventArgs e) //고객 수정
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Customer_Update", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@CustomerNum", SqlDbType.VarChar).Value = textCustomerNum.Text;
                com.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = textCustomerName.Text;
                com.Parameters.Add("@ResidentNum", SqlDbType.Char).Value = textCustomerResidentNum.Text;
                com.Parameters.Add("@CustomerType", SqlDbType.NChar).Value = textCustomerType.Text;
                com.Parameters.Add("@Gender", SqlDbType.Char).Value = textCustomerGender.Text;
                com.Parameters.Add("@Phone", SqlDbType.Char).Value = textCustomerPhone.Text;
                com.Parameters.Add("@CellPhone", SqlDbType.Char).Value = textCustomerCell.Text;
                com.Parameters.Add("@Mail", SqlDbType.VarChar).Value = textCustomerMail.Text;
                com.Parameters.Add("@Address", SqlDbType.NVarChar).Value = textCustomerAddr.Text;

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            Show_Customer();
        }

        private void btnDelete_Click(object sender, EventArgs e) //고객 삭제
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Customer_Delete", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@CustomerNum", SqlDbType.VarChar).Value = textCustomerNum.Text;

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            Show_Customer();
        }

        private void btnCancel_Click(object sender, EventArgs e) //입력 정보 초기화
        {
            textCustomerNum.Text = "";
            textCustomerName.Text = "";
            textCustomerResidentNum.Text = "";
            textCustomerType.Text = "";
            textCustomerGender.Text = "";
            textCustomerPhone.Text = "";
            textCustomerCell.Text = ""; 
            textCustomerMail.Text = "";
            textCustomerAddr.Text = "";

        }
        private void btnCardManagement_Click(object sender, EventArgs e) //카드 관리(미구현)
        {

        }
        private void btnExit_Click(object sender, EventArgs e) //나가기
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //그리드 클릭시 텍스트박스에 띄움
        {
            textCustomerNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textCustomerName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textCustomerResidentNum.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textCustomerType.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textCustomerGender.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textCustomerPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textCustomerCell.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textCustomerMail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textCustomerAddr.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
