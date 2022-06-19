using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace ChiTieuHangNgay
{
    class DataUtil
    {
        XmlElement root;
        XmlDocument doc;
        string filename;

        public DataUtil()
        {
            filename = "Data.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement rt = doc.CreateElement("chitieuhangngay");
                doc.AppendChild(rt);
                doc.Save(filename);
            }

            // tạo file nhật ký
            string path = "NhatKy.txt";
            FileStream filelog;
            if (!File.Exists(path))
            {
                filelog = new FileStream(path, FileMode.CreateNew);
                filelog.Close();
            }

            // tạo file cài đặt

            // tạo file tài khoản


            doc.Load(filename);
            root = doc.DocumentElement;
        }

        // hàm chia thập phân cho chuỗi số
        public string ChiaThapPhan(string chuoi)
        {
            string result = "";
            int i = 0;

            if (chuoi.Length <= 3)
            {
                result = chuoi;
            }

            while (chuoi.Length > 3)
            {
                i = chuoi.Length - 3;
                result = "." + chuoi.Substring(i, 3) + result;
                chuoi = chuoi.Substring(0, i);

                if (chuoi.Length <= 3)
                {
                    result = chuoi + result;
                }
            }

            return result;
        }

        // hàm chuyển đổi số thành văn bản
        public string ConvertNumberToText(string chuoi)
        {
            string result = "";

            // vd: 152.685
            // chia thập phân chuỗi đưa vào
            chuoi = ChiaThapPhan(chuoi);
            // tách chuỗi bằng dấu .
            string[] soluong = chuoi.Split('.');
            
            for(int i=0; i<soluong.Length; i++)
            {
                int sl = 3;
                foreach(char item in soluong[i])
                {
                    if (sl == 1)
                        result += NumberToText(item.ToString(),1) + " trăm ";
                    else if (sl == 2)
                        result += NumberToText(item.ToString().ToLower(),1) + " mươi ";
                    else
                        result += NumberToText(item.ToString().ToLower(),1);

                    sl--;
                }

                int dem = soluong.Length - i;
                if (dem == 2)
                    result += "nghìn";
                else if (dem == 3)
                    result += "triệu";
                else if (dem == 5)
                    result += "tỉ";

            }    

            return result;
        }

        // mẫu chuyển đổi số thành văn bản
        public string NumberToText(string chuoi, int soluong)
        {
            string result = "";

            if(soluong == 1)
            {
                if (int.Parse(chuoi) == 1)
                    result = "Một";
                if (int.Parse(chuoi) == 2)
                    result = "Hai";
                if (int.Parse(chuoi) == 3)
                    result = "Ba";
                if (int.Parse(chuoi) == 4)
                    result = "Bốn";
                if (int.Parse(chuoi) == 5)
                    result = "Năm";
                if (int.Parse(chuoi) == 6)
                    result = "Sáu";
                if (int.Parse(chuoi) == 7)
                    result = "Bảy";
                if (int.Parse(chuoi) == 8)
                    result = "Tám";
                if (int.Parse(chuoi) == 9)
                    result = "Chín";
            }    
            
            return result;
        }


    }
}
