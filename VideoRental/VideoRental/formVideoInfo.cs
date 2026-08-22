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
    public partial class formVideoInfo : Form
    {
        public formVideoInfo()
        {
            InitializeComponent();
        }

        String SqlString = @"Server=pc1;database=VideoRentalDB;uid=sa;pwd=std001";
        SqlConnection conn;

        private void formVideoInfo_Load(object sender, EventArgs e)
        {
            Show_Video();
        }
        private void Show_Video()//비디오 그리드 다시 조회
        {
            videoList.Rows.Clear();
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Video_Select", conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    videoList.Rows.Add(
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString(),
                        dr[5].ToString(),
                        dr[6].ToString()
                        );
                }

                dr.Close();

                textTotalVideo.Text = (videoList.Rows.Count - 1).ToString() + "개";
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
        private void btnAdd_Click(object sender, EventArgs e) //비디오 추가 버튼
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Video_Insert", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@VideoCode", SqlDbType.VarChar).Value = textVideoCode.Text;
                com.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = textGenre.Text;
                com.Parameters.Add("@Title", SqlDbType.NVarChar).Value = textVideoTitle.Text;
                com.Parameters.Add("@Actor", SqlDbType.NVarChar).Value = textActor.Text;
                com.Parameters.Add("@Director", SqlDbType.NVarChar).Value = textDirector.Text;
                com.Parameters.Add("@Production", SqlDbType.NVarChar).Value = textProduction.Text;
                com.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = Dtp_ReleaseDate.Value;

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
            Show_Video();
        }
        

        private void btnSave_Click(object sender, EventArgs e)//저장 버튼
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Video_Update", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@VideoCode", SqlDbType.VarChar).Value = textVideoCode.Text;
                com.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = textGenre.Text;
                com.Parameters.Add("@Title", SqlDbType.NVarChar).Value = textVideoTitle.Text;
                com.Parameters.Add("@Actor", SqlDbType.NVarChar).Value = textActor.Text;
                com.Parameters.Add("@Director", SqlDbType.NVarChar).Value = textDirector.Text;
                com.Parameters.Add("@Production", SqlDbType.NVarChar).Value = textProduction.Text;
                com.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = Dtp_ReleaseDate.Value;

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
            Show_Video();
        }

        private void btnDelete_Click(object sender, EventArgs e)//삭제버튼
        {
            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Video_Delete", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@VideoCode", SqlDbType.VarChar).Value = textVideoCode.Text;

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
            Show_Video();
        }

        private void btnCancel_Click(object sender, EventArgs e)//취소 버튼
        {
            textVideoCode.Text = "";
            textGenre.Text = "";
            textVideoTitle.Text = "";
            textActor.Text = "";
            textDirector.Text = "";
            textProduction.Text = "";
            Dtp_ReleaseDate.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e) //나가기 버튼
        {
            this.Close();
        }

        private void videoList_CellClick(object sender, DataGridViewCellEventArgs e)//그리드 선택
        {
            textVideoCode.Text = videoList.CurrentRow.Cells[0].Value.ToString();
            textGenre.Text = videoList.CurrentRow.Cells[1].Value.ToString();
            textVideoTitle.Text = videoList.CurrentRow.Cells[2].Value.ToString();
            textActor.Text = videoList.CurrentRow.Cells[3].Value.ToString();
            textDirector.Text = videoList.CurrentRow.Cells[4].Value.ToString();
            textProduction.Text = videoList.CurrentRow.Cells[5].Value.ToString();
            Dtp_ReleaseDate.Text = videoList.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
