using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class formVideoInfoSetting : Form
    {
        public formVideoInfoSetting()
        {
            InitializeComponent();
        }
        String SqlString = @"Server=pc1;database=VideoRentalDB;uid=sa;pwd=std001";
        SqlConnection conn;
        
        private void formVideoInfoSetting_Load(object sender, EventArgs e)//로드 될 때 필터링
        {
            comboGenre.Items.Clear();
            comboGenre.Items.Add("전체");

            try
            {
                conn = new SqlConnection(SqlString);
                conn.Open();

                SqlCommand com = new SqlCommand("Video_Genre_Select", conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    comboGenre.Items.Add(dr["Genre"].ToString());
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
        private void btnVideoList_Click(object sender, EventArgs e)//비디오 목록 엑셀로 출력
        {
            saveFileDialog1.Filter = "CSV파일|*.csv";
            saveFileDialog1.FileName = "비디오목록.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    conn = new SqlConnection(SqlString);
                    conn.Open();

                    SqlCommand com = new SqlCommand("Video_Select_ByGenre", conn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = comboGenre.Text;

                    SqlDataReader dr = com.ExecuteReader();

                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);

                    sw.WriteLine("비디오코드,장르,제목,배우,감독,제작사,출시일");

                    while (dr.Read())
                    {
                        sw.WriteLine(
                            dr["VideoCode"].ToString() + "," +
                            dr["Genre"].ToString() + "," +
                            dr["Title"].ToString() + "," +
                            dr["Actor"].ToString() + "," +
                            dr["Director"].ToString() + "," +
                            dr["Production"].ToString() + "," +
                            dr["ReleaseDate"].ToString()
                        );
                    }

                    sw.Close();
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
        }
        private void btnVideoRentalStatus_Click(object sender, EventArgs e)//대여 현황 엑셀로 출력
        {
            saveFileDialog1.Filter = "CSV파일|*.csv";
            saveFileDialog1.FileName = "대여현황.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    conn = new SqlConnection(SqlString);
                    conn.Open();

                    SqlCommand com = new SqlCommand("Video_Rentaling", conn);
                    com.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = com.ExecuteReader();

                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);

                    sw.WriteLine("비디오제목,고객명,대여일,반납예정일");

                    while (dr.Read())
                    {
                        sw.WriteLine(
                            dr["Title"].ToString() + "," +
                            dr["CustomerName"].ToString() + "," +
                            dr["RentalDate"].ToString() + "," +
                            dr["DueDate"].ToString()
                        );
                    }

                    sw.Close();
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
        }
    }
}
