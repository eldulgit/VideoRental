using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class formVideoRentalSetting : Form
    {
        public formVideoRentalSetting()
        {
            InitializeComponent();
        }

        String SqlString = @"Server=pc1;database=VideoRentalDB;uid=sa;pwd=std001";
        SqlConnection conn;
        
        private void formVideoRentalSetting_Load(object sender, EventArgs e)
        {
            Show_Video_RentalSetting();
        }

        private void Show_Video_RentalSetting()//세팅 정보 조회
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Setting_Select", conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = com.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count++;
                    
                    textTransPeriod.Text = dr[0].ToString();

                    textNewRentalPeriod.Text = dr[1].ToString();
                    textNewRentalFee.Text = dr[2].ToString();
                    textNewLateFee.Text = dr[3].ToString();

                    textOldRentalPeriod.Text = dr[4].ToString();
                    textOldRentalFee.Text = dr[5].ToString();
                    textOldLateFee.Text = dr[6].ToString();
                }

                if(count > 0)//등록 버튼 비활성화용
                {
                    btnAttend.Enabled = false;
                }
                else
                {
                    btnAttend.Enabled = true;
                }

                dr.Close();
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

                SqlCommand com = new SqlCommand("Setting_Insert", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@TransPeriod", SqlDbType.Int).Value = textTransPeriod.Text;
                com.Parameters.Add("@NewRentalPeriod", SqlDbType.Int).Value = textNewRentalPeriod.Text;
                com.Parameters.Add("@NewRentalFee", SqlDbType.Int).Value = textNewRentalFee.Text;
                com.Parameters.Add("@NewLateFee", SqlDbType.Int).Value = textNewLateFee.Text;
                com.Parameters.Add("@OldRentalPeriod", SqlDbType.Int).Value = textOldRentalPeriod.Text;
                com.Parameters.Add("@OldRentalFee", SqlDbType.Int).Value = textOldRentalFee.Text;
                com.Parameters.Add("@OldLateFee", SqlDbType.Int).Value = textOldLateFee.Text;

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
            Show_Video_RentalSetting();
        }

        private void btnEdit_Click(object sender, EventArgs e)//수정버튼
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Setting_Update", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@TransPeriod", SqlDbType.Int).Value = textTransPeriod.Text;
                com.Parameters.Add("@NewRentalPeriod", SqlDbType.Int).Value = textNewRentalPeriod.Text;
                com.Parameters.Add("@NewRentalFee", SqlDbType.Int).Value = textNewRentalFee.Text;
                com.Parameters.Add("@NewLateFee", SqlDbType.Int).Value = textNewLateFee.Text;
                com.Parameters.Add("@OldRentalPeriod", SqlDbType.Int).Value = textOldRentalPeriod.Text;
                com.Parameters.Add("@OldRentalFee", SqlDbType.Int).Value = textOldRentalFee.Text;
                com.Parameters.Add("@OldLateFee", SqlDbType.Int).Value = textOldLateFee.Text;

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
            Show_Video_RentalSetting();
        }

        private void btnExit_Click(object sender, EventArgs e)//나가기 버튼
        {
            this.Close();
        }
    }
}
