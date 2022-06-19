using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiTieuHangNgay
{
    public partial class Home : Form
    {
        DataUtil obj = new DataUtil();
        List<string> Directory = new List<string>();
        public Home()
        {
            InitializeComponent();
            Directory.Add("Menu");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelTroGiup.Visible = false;
            PanelCaiDat.Visible = false;
            PanelQRCode.Visible = false;
            PanelOtherApp.Visible = false;

            User.TabStop = false;
            User.FlatStyle = FlatStyle.Flat;
            User.FlatAppearance.BorderSize = 0;

            BtnBack.TabStop = false;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.FlatAppearance.BorderSize = 0;

            BtnNext.TabStop = false;
            BtnNext.FlatStyle = FlatStyle.Flat;
            BtnNext.FlatAppearance.BorderSize = 0;

            TietkiemText.Select();


            ////BtnMenu
            //BtnMenu.TabStop = false;
            //BtnMenu.FlatStyle = FlatStyle.Flat;
            //BtnMenu.FlatAppearance.BorderSize = 0;
            //BtnMenu.ForeColor = Color.Blue;

            ////BtnTroGiup
            //BtnTroGiup.TabStop = false;
            //BtnTroGiup.FlatStyle = FlatStyle.Flat;
            //BtnTroGiup.FlatAppearance.BorderSize = 0;
            //BtnTroGiup.ForeColor = Color.Blue;

            ////BtnCaiDat
            //BtnCaiDat.TabStop = false;
            //BtnCaiDat.FlatStyle = FlatStyle.Flat;
            //BtnCaiDat.FlatAppearance.BorderSize = 0;
            //BtnCaiDat.ForeColor = Color.Blue;

            ////BtnQR
            //BtnQR.TabStop = false;
            //BtnQR.FlatStyle = FlatStyle.Flat;
            //BtnQR.FlatAppearance.BorderSize = 0;
            //BtnQR.ForeColor = Color.Blue;

            ////BtnOtherApp
            //BtnOtherApp.TabStop = false;
            //BtnOtherApp.FlatStyle = FlatStyle.Flat;
            //BtnOtherApp.FlatAppearance.BorderSize = 0;
            //BtnOtherApp.ForeColor = Color.Blue;
        }

        // PanelAllMenu
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            PanelTroGiup.Visible = false;
            PanelCaiDat.Visible = false;
            PanelQRCode.Visible = false;
            PanelOtherApp.Visible = false;

            Path.Text = "Menu";

            if (string.Compare(Directory[Directory.Count - 1], "Menu") != 0)
                Directory.Add("Menu");

            PanelMenu.Visible = true;
            PanelMenu.Show();
        }

        private void BtnTroGiup_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
            PanelCaiDat.Visible = false;
            PanelQRCode.Visible = false;
            PanelOtherApp.Visible = false;

            Path.Text = "Help";
            if (string.Compare(Directory[Directory.Count - 1], "Help") != 0)
                Directory.Add("Help");

            PanelTroGiup.Visible = true;
            PanelTroGiup.Show();
        }

        private void BtnCaiDat_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
            PanelTroGiup.Visible = false;
            PanelQRCode.Visible = false;
            PanelOtherApp.Visible = false;

            Path.Text = "Setting";
            if (string.Compare(Directory[Directory.Count - 1], "Setting") != 0)
                Directory.Add("Setting");

            PanelCaiDat.Visible = true;
            PanelCaiDat.Show();
        }

        private void BtnQR_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
            PanelTroGiup.Visible = false;
            PanelCaiDat.Visible = false;
            PanelOtherApp.Visible = false;

            Path.Text = "QR";
            if (string.Compare(Directory[Directory.Count - 1], "QR") != 0)
                Directory.Add("QR");

            PanelQRCode.Visible = true;
            PanelQRCode.Show();
        }

        private void BtnOtherApp_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
            PanelTroGiup.Visible = false;
            PanelCaiDat.Visible = false;
            PanelQRCode.Visible = false;

            Path.Text = "OtherApp";
            if (string.Compare(Directory[Directory.Count - 1], "OtherApp") != 0)
                Directory.Add("OtherApp");

            PanelOtherApp.Visible = true;
            PanelOtherApp.Show();
        }

        // UserLogin
        private void User_Click(object sender, EventArgs e)
        {

        }

        // Back and Next
        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

        }

        private void CheckDirectory(String para)
        {
            // tách chuỗi cuối thành mảng bằng dấu '/'
            string[] result = Directory[Directory.Count - 1].Split('/');

            // nếu phần tử cuối cùng của chuỗi được tách khác chuỗi truyền vào thì thêm vào directory, ngược lại không thêm
            if (string.Compare(result[result.Length - 1], para) != 0)
                Directory[Directory.Count - 1] += '/' + result[result.Length - 1]; 
        }

        // PanelMenu
        private void BtnNhap_Click(object sender, EventArgs e)
        {
            
            TypeDisplayImage frm2 = new TypeDisplayImage();
            frm2.Show();
        }

        // PanelTroGiup
        private void BtnXemds_Click(object sender, EventArgs e)
        {

        }

        private void BtnHDSD_Click(object sender, EventArgs e)
        {

        }

        private void BtnXemThongTin_Click(object sender, EventArgs e)
        {

        }

        private void BtnThongTinHomNay_Click(object sender, EventArgs e)
        {

        }

        private void BtnFeedBack_Click(object sender, EventArgs e)
        {

        }

        // PanelCaiDat
        private void BtnDoiHinhNen_Click(object sender, EventArgs e)
        {

        }

        private void BtnDoiFont_Click(object sender, EventArgs e)
        {

        }

        private void BtnCaiDatKhac_Click(object sender, EventArgs e)
        {

        }

        private void BtnDoiMauNen_Click(object sender, EventArgs e)
        {

        }

        private void BtnDoiMauChu_Click(object sender, EventArgs e)
        {

        }

        private void BtnMacDinh_Click(object sender, EventArgs e)
        {

        }

        // PanelQRCode
        private void BtnDocQR_Click(object sender, EventArgs e)
        {

        }

        private void BtnTaoQR_Click(object sender, EventArgs e)
        {

        }

        // PanelOtherApp
        private void LabelMoredownload_Click(object sender, EventArgs e)
        {

        }

        private void LabelMorenotdownload_Click(object sender, EventArgs e)
        {

        }

        private void LabelMoredownload_MouseHover(object sender, EventArgs e)
        {
            // mặc định nền trắng, chữ đen --> chữ blue
            // nếu nền đen --> chữ blue
            // nếu nền blue --> chữ red
            // nếu chữ blue --> red
            if (PanelOtherApp.BackColor == Color.White && LabelMorenotdownload.ForeColor == Color.Black)
                LabelMoredownload.ForeColor = Color.Blue;
            else if (PanelOtherApp.BackColor == Color.Black)
                LabelMoredownload.ForeColor = Color.Blue;
            else if (PanelOtherApp.BackColor == Color.Blue)
                LabelMoredownload.ForeColor = Color.Red;
        }

        private void LabelMoredownload_MouseLeave(object sender, EventArgs e)
        {
            if (PanelOtherApp.BackColor == Color.Black)
                LabelMoredownload.ForeColor = Color.White;
            else
                LabelMoredownload.ForeColor = Color.Black;
        }

        private void LabelMorenotdownload_MouseHover(object sender, EventArgs e)
        {
            if (PanelOtherApp.BackColor == Color.White && LabelMorenotdownload.ForeColor == Color.Black)
                LabelMorenotdownload.ForeColor = Color.Blue;
            else if (PanelOtherApp.BackColor == Color.Black)
                LabelMorenotdownload.ForeColor = Color.Blue;
            else if (PanelOtherApp.BackColor == Color.Blue)
                LabelMorenotdownload.ForeColor = Color.Red;
        }

        private void LabelMorenotdownload_MouseLeave(object sender, EventArgs e)
        {
            if (PanelOtherApp.BackColor == Color.Black)
                LabelMorenotdownload.ForeColor = Color.White;
            else
                LabelMorenotdownload.ForeColor = Color.Black;
        }

        private void BtnDownloadTool_Click(object sender, EventArgs e)
        {

        }

        // Menu Pop-up
        private void MenuRefresh_Click(object sender, EventArgs e)
        {

        }

        private void MenuXemThongTin_Click(object sender, EventArgs e)
        {

        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // MenuLogin Pop-up
        private void MenuAccountInfor_Click(object sender, EventArgs e)
        {

        }

        private void MenuHistory_Click(object sender, EventArgs e)
        {

        }

        private void MenuDisplay_Click(object sender, EventArgs e)
        {

        }

        private void TietkiemText_Leave(object sender, EventArgs e)
        {
            TietkiemText.Text = obj.ChiaThapPhan(TietkiemText.Text);
        }

        private void TrocapText_Leave(object sender, EventArgs e)
        {
            TrocapText.Text = obj.ChiaThapPhan(TrocapText.Text);
        }

        private void SanphamText_Leave(object sender, EventArgs e)
        {
            if (int.Parse(SanphamText.Text) < 10)
                MessageBox.Show("Hello", "Thông báo");
        }

        private void GiamuaText_Leave(object sender, EventArgs e)
        {

        }
    }
}
