using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class formVideoRental : Form
    {
        public formVideoRental()
        {
            InitializeComponent();
        }
        private void Tb_Rental_Return_Click(object sender, EventArgs e)//대여반납
        {
            formVideoRentalManage formVideoRentalManage = new formVideoRentalManage();
            formVideoRentalManage.MdiParent = this;
            formVideoRentalManage.Show();
        }

        private void MnuRentalReturn_Click(object sender, EventArgs e)//메뉴 - 비디오 대여반납
        {
            formVideoRentalManage formVideoRentalManage = new formVideoRentalManage();
            formVideoRentalManage.MdiParent = this;
            formVideoRentalManage.Show();
        }

        private void Tb_VideoManage_Click(object sender, EventArgs e)//비디오 관리
        {
            formVideoInfo formVideoInfo = new formVideoInfo();
            formVideoInfo.MdiParent = this;
            formVideoInfo.Show();
        }

        private void MnuVideoManage_Click(object sender, EventArgs e)//메뉴 - 비디오 관리
        {
            formVideoInfo formVideoInfo = new formVideoInfo();
            formVideoInfo.MdiParent = this;
            formVideoInfo.Show();
        }

        private void Tb_CustomerManage_Click(object sender, EventArgs e)//고객관리
        {
            formCustomer formCustomer = new formCustomer();
            formCustomer.MdiParent = this;
            formCustomer.Show();
        }

        private void MnuCustomerManage_Click(object sender, EventArgs e)//메뉴 - 고객관리
        {
            formCustomer formCustomer = new formCustomer();
            formCustomer.MdiParent = this;
            formCustomer.Show();
        }

        private void Tb_InfoCheck_Click(object sender, EventArgs e)//정보조회
        {
            formInformationCheck formInformationCheck = new formInformationCheck();
            formInformationCheck.MdiParent = this;
            formInformationCheck.Show();

            formVideoInfoSetting formVideoInfoSetting = new formVideoInfoSetting();
            formVideoInfoSetting.MdiParent = this;
            formVideoInfoSetting.Show();
        }

        private void MnuInfoCheck_Click(object sender, EventArgs e)//메뉴 - 정보조회
        {
            formInformationCheck formInformationCheck = new formInformationCheck();
            formInformationCheck.MdiParent = this;
            formInformationCheck.Show();

            formVideoInfoSetting formVideoInfoSetting = new formVideoInfoSetting();
            formVideoInfoSetting.MdiParent = this;
            formVideoInfoSetting.Show();
        }

        private void Tb_Setting_Click(object sender, EventArgs e)//환경설정
        {
            formVideoRentalSetting formVideoRentalSetting = new formVideoRentalSetting();
            formVideoRentalSetting.MdiParent= this;
            formVideoRentalSetting.Show();
        }

        private void MnuSetting_Click(object sender, EventArgs e)//메뉴-환경설정
        {
            formVideoRentalSetting formVideoRentalSetting = new formVideoRentalSetting();
            formVideoRentalSetting.MdiParent = this;
            formVideoRentalSetting.Show();
        }

        private void Mnu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
