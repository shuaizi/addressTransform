using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace addressTransform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            string realUrl = "";
            string thunderUrl = "";
            string tencentUrl = "";
            string flashgetUrl = "";
            string baseURL = this.txtBAddr.Text;
            if (baseURL.Trim().Equals(""))
            {
                MessageBox.Show("地址栏不能为空");
                this.txtBAddr.Text = "";
                this.txtBAddr.Focus();
            }
            else 
            {
                char[] sep = { '/', '/' };
                string[] urlDeal = this.txtBAddr.Text.Trim().Split(new[] { "//" }, StringSplitOptions.None);
                string head = urlDeal[0].Trim().ToLower();
                String body = urlDeal[1].Trim();
                MessageBox.Show(head + "\n" + body);
                if (head.Equals("") || body.Equals("")) {
                    MessageBox.Show("url格式错误");
                    this.txtBAddr.Text = "";
                    this.txtBAddr.Focus();
                    return;
                }       
                //得到真实地址
                if (head.Equals("thunder:")) {
                    string tmp = this.base64Decode(body);
                    realUrl = tmp.Substring(2, tmp.Length - 4);
                }
                else if (head.Equals("flashget:")) {
                    string[] dealUrl1 = body.Split('&');
                    string tmp = this.base64Decode(dealUrl1[0]);
                    realUrl = tmp.Substring(10, tmp.Length - 20);
                }
                else if(head.Equals("qqdl:")){
                    realUrl = this.base64Decode(body);
                }
                else if (head.Equals("http:") || head.Equals("https:") || head.Equals("ftp:")
                        || head.Equals("mms:") || head.Equals("rtsp:"))
                {
                    realUrl = this.txtBAddr.Text.Trim();
                }
                else {
                    MessageBox.Show("暂不支持此协议\n请联系作者");
                    this.txtBAddr.Focus();
                    return;
                }
                //转换各下载软件地址
                thunderUrl = "thunder://" + this.base64Encode("AA" + realUrl + "ZZ");
                tencentUrl = "qqdl://" + this.base64Encode(realUrl);
                flashgetUrl = "Flashget://" + this.base64Encode("[FLASHGET]" + realUrl + "[FLASHGET]") + "&aiyh";
                //输出结果
                this.rtbAnswer.Text = "";
                string lblText = "努力转换中";
                for (int i = 0; i < 6; i++) {
                    lblText = lblText + ".";
                    this.label2.Text = lblText;
                    this.label2.Update();
                    Thread.Sleep(300);
                }
                this.label2.Text = "转换结果";
                this.rtbAnswer.Text = "";
                this.rtbAnswer.AppendText("\n原始下载地址：" + realUrl);
                this.rtbAnswer.AppendText("\n迅雷下载地址：" + thunderUrl);
                this.rtbAnswer.AppendText("\n快车下载地址：" + flashgetUrl);
                this.rtbAnswer.AppendText("\n旋风下载地址：" + tencentUrl);
            }

        }
        //base64编码
        private string base64Encode(string baseUrl)
        {
            byte[] output = Encoding.Default.GetBytes(baseUrl);
            string str = Convert.ToBase64String(output);
            return str;
        }
        //base64解码
        private string base64Decode(string baseUrl) {
            MessageBox.Show(baseUrl);
            byte[] output = Convert.FromBase64String(baseUrl);
            string str = Encoding.Default.GetString(output);
            return str;
        }
    }
}
