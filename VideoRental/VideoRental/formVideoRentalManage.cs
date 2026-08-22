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

namespace VideoRental
{
    public partial class formVideoRentalManage : Form
    {
        public formVideoRentalManage()
        {
            InitializeComponent();
        }
        String SqlString = @"Server=pc1;database=VideoRentalDB;uid=sa;pwd=std001";
        SqlConnection conn;
        DataTable dt;
        private void btnSearch_Click(object sender, EventArgs e)//찾기 버튼
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Customer_Find", conn);
                com.CommandType = CommandType.StoredProcedure;


                com.Parameters.Add("@CustomerNum", SqlDbType.VarChar).Value = textInputCustomerCode.Text;
                com.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = textInputCustomerName.Text;
                com.Parameters.Add("@Phone", SqlDbType.VarChar).Value = textInputCustomerPhone.Text;
                com.Parameters.Add("@CellPhone", SqlDbType.VarChar).Value = textInputCustomerCell.Text;

                dt = new DataTable();
                SqlDataReader dr = com.ExecuteReader();

                dt.Clear();
                dt.Load(dr);

                dr.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("조회된 고객이 없습니다.");
                }
                else if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];

                    textCustomerCode.Text = row["CustomerNum"].ToString();
                    textCustomerName.Text = row["CustomerName"].ToString();
                    textCustomerResidentNum.Text = row["ResidentNum"].ToString();
                    textCustomerType.Text = row["CustomerType"].ToString();
                    textCustomerPhone.Text = row["Phone"].ToString();
                    textCustomerCell.Text = row["CellPhone"].ToString();
                    textCustomerMail.Text = row["Mail"].ToString();
                    textCustomerAddr.Text = row["Address"].ToString();

                    Show_Rental();
                }
                else
                {
                    Ls_CustomerChoice.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Ls_CustomerChoice.Items.Add(
                            dt.Rows[i]["CustomerName"].ToString()
                        );
                    }

                    tabControl1.SelectedIndex = 1;
                }

                Show_Rental();
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

        private void btnAttend_Click(object sender, EventArgs e)//등록 버튼
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Rental_Insert", conn);
                com.CommandType = CommandType.StoredProcedure;

                DateTime dueDate = Date_RentalDate.Value.AddDays(7);
                Lb_ReturnDate.Text = dueDate.ToString("yyyy-MM-dd");

                com.Parameters.Add("@CustomerNum", SqlDbType.VarChar).Value = textCustomerCode.Text;
                com.Parameters.Add("@VideoCode", SqlDbType.VarChar).Value = textVideoCode.Text;
                com.Parameters.Add("@RentalDate", SqlDbType.Date).Value = Date_RentalDate.Value;
                com.Parameters.Add("@DueDate", SqlDbType.Date).Value = dueDate;
                com.Parameters.Add("@RentalFee", SqlDbType.Int).Value = Convert.ToInt32(Lb_RentalFee.Text);
                com.Parameters.Add("@LateFee", SqlDbType.Int).Value = Lb_LateFee.Text;

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
            Show_Rental();
        }

        private void btnVideoReturn_Click(object sender, EventArgs e)//비디오 회수 버튼
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Rental_Return", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@RentalNum", SqlDbType.Int).Value =
                    dataGridView1.CurrentRow.Cells[0].Value.ToString();

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

            Show_Rental();
        }


        private void Show_Rental()//그리드에 조회
        {
            dataGridView1.Rows.Clear();

            int totalCount = 0;
            int totalRentalFee = 0;
            int totalLateFee = 0;

            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Rental_FindByCustomer", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@CustomerNum", SqlDbType.VarChar).Value = textCustomerCode.Text;

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    int rentalFee = Convert.ToInt32(dr["RentalFee"]);
                    int dailyLateFee = Convert.ToInt32(dr["LateFee"]);
                    DateTime dueDate = Convert.ToDateTime(dr["DueDate"]);

                    int lateFee = 0;

                    if (DateTime.Today > dueDate)
                    {
                        lateFee = (DateTime.Today - dueDate).Days * dailyLateFee;
                    }

                    dataGridView1.Rows.Add(
                        dr["RentalNum"].ToString(),
                        dr["VideoCode"].ToString(),
                        dr["Title"].ToString(),
                        rentalFee.ToString(),
                        lateFee.ToString()
                    );

                    totalCount++;
                    totalRentalFee += rentalFee;
                    totalLateFee += lateFee;
                }

                dr.Close();

                dataGridView1.Columns[0].Visible = false;

                Lb_TotalRentalCount.Text = totalCount.ToString("0") + "개";
                Lb_TotalRentalFee.Text = totalRentalFee.ToString("000") + "원";
                Lb_TotalLateFee.Text = totalLateFee.ToString("000") + "원";
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

        private void textVideoCode_KeyPress(object sender, KeyPressEventArgs e)//비디오 코드 입력시 엔터로 조회
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                return;
                
            }
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Video_Find", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@VideoCode", SqlDbType.VarChar).Value = textVideoCode.Text;

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {

                    textVideoTitle.Text = dr["Title"].ToString();
                    Lb_RentalFee.Text = dr["RentalFee"].ToString();
                    Lb_LateFee.Text = dr["LateFee"].ToString();
                }
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

        private void Ls_CustomerChoice_SelectedIndexChanged(object sender, EventArgs e)//고객 선택에서 고객을 클릭했을 때 정보 조회
        {
            if (Ls_CustomerChoice.SelectedIndex < 0)
                return;

            DataRow row = dt.Rows[Ls_CustomerChoice.SelectedIndex];

            textCustomerCode.Text = row["CustomerNum"].ToString();
            textCustomerName.Text = row["CustomerName"].ToString();
            textCustomerResidentNum.Text = row["ResidentNum"].ToString();
            textCustomerType.Text = row["CustomerType"].ToString();
            textCustomerPhone.Text = row["Phone"].ToString();
            textCustomerCell.Text = row["CellPhone"].ToString();
            textCustomerMail.Text = row["Mail"].ToString();
            textCustomerAddr.Text = row["Address"].ToString();

            Show_Rental();
        }
    }
}
