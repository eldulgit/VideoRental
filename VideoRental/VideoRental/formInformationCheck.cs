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
    public partial class formInformationCheck : Form
    {
        public formInformationCheck()
        {
            InitializeComponent();
        }

        String SqlString = @"Server=pc1;database=VideoRentalDB;uid=sa;pwd=std001";
        SqlConnection conn;

        private void btnSearch_Click(object sender, EventArgs e)//찾기 버튼
        {
            string proc = "";

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            if (rbVideoRentalRanking.Checked)//비디오 대여 순위
            {
                proc = "Video_Rank";

                dataGridView1.Columns.Add("count", "대여횟수");
                dataGridView1.Columns.Add("VideoCode","비디오 코드");
                dataGridView1.Columns.Add("title", "비디오제목");
                dataGridView1.Columns.Add("Genre", "장르");
                dataGridView1.Columns.Add("Actor", "주연배우");
                dataGridView1.Columns.Add("Director", "감독");
                dataGridView1.Columns.Add("Production", "제작사");
                dataGridView1.Columns.Add("ReleaseDate", "출시일");

            }
            else if (rbRentalVideo.Checked)//대여중인 비디오
            {
                proc = "Video_Rentaling";

                dataGridView1.Columns.Add("Title", "비디오제목");
                dataGridView1.Columns.Add("CustomerName", "고객명");
                dataGridView1.Columns.Add("RentalDate", "대여일");
                dataGridView1.Columns.Add("DueDate", "반납예정일");
            }
            else if (rbCustomerRentalRanking.Checked)//고객 대여 순위
            {
                proc = "Customer_Rank";

                dataGridView1.Columns.Add("count", "대여횟수");
                dataGridView1.Columns.Add("CustomerName", "고객명");
                dataGridView1.Columns.Add("CustomerType", "등급");
                dataGridView1.Columns.Add("Gender", "성별");
                dataGridView1.Columns.Add("Phone", "연락처");
                dataGridView1.Columns.Add("CellPhone", "휴대폰");
                dataGridView1.Columns.Add("Address", "주소");
            }

            
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();
                SqlCommand com = new SqlCommand(proc, conn);
                com.CommandType = CommandType.StoredProcedure;

                if (rbVideoRentalRanking.Checked)//비디오 대여 순위 선택시 장르로 필터링
                {
                    com.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = textGenre.Text;
                }
                else if (rbCustomerRentalRanking.Checked)//고객 대여 순위 선택시 고객 타입으로 필터링
                {
                    com.Parameters.Add("@CustomerType", SqlDbType.NChar).Value = textCustomerType.Text;
                }

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    if (rbVideoRentalRanking.Checked)
                    {
                        dataGridView1.Rows.Add(
                            dr[0].ToString(),
                            dr[1].ToString(),
                            dr[2].ToString(),
                            dr[3].ToString(),
                            dr[4].ToString(),
                            dr[5].ToString(),
                            dr[6].ToString(),
                            dr[7].ToString()
                        );
                    }
                    else if (rbRentalVideo.Checked)
                    {
                        dataGridView1.Rows.Add(
                            dr[0].ToString(),
                            dr[1].ToString(),
                            dr[2].ToString(),
                            dr[3].ToString()
                        );
                    }
                    else if (rbCustomerRentalRanking.Checked)
                    {
                        dataGridView1.Rows.Add(
                            dr[0].ToString(),
                            dr[1].ToString(),
                            dr[2].ToString(),
                            dr[3].ToString(),
                            dr[4].ToString(),
                            dr[5].ToString(),
                            dr[6].ToString()
                        );
                    }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
