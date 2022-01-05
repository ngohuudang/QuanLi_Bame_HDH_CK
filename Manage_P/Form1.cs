using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using changeInfo;
using ChangePass;
using static changeInfo.Form2;
using static ChangePass.Form3;
using System.Diagnostics;

namespace Manage_P
{
    public partial class Form1 : Form
    {
        public class ControllerSV
        {
            public int index { set; get; }
            public string filePath { set; get; }

            public string time { set; get; }

            public string info { set; get; }

        }

        public Form1()
        {
            InitializeComponent();  //khởi tạo form
            string[] lines = File.ReadAllLines("setting.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] ch = lines[i].Split(new char[] { '=' });
                if (ch[0] == "filePath")
                {
                    this.filePath_textBox.Text = ch[1];
                    break;
                }
            }
            if (filePath_textBox.Text != "") //Nếu đường dẫn filePath còn trống thì không load thời gian về máy
                load(filePath_textBox.Text);

        }

        public void load(string filePath)       //hàm load thời gian về máy
        {
            string from = "";
            string to = "";
            string duration = "";
            string interrupt = "";
            string sum = "";
            time_listView.Items.Clear();            // xóa hết dòng trên listview
            string[] lines = File.ReadAllLines(filePath);   //đọc file setting về máy
            int index_frame = 0;  
            for (int i=0; i < lines.Length; i++)
            {
                if (lines[i] == "frameTime")    //chuoi bat dau cac khoang thoi gian
                {
                    index_frame = i + 1;
                    break;
                }   
            }
            for (int i = index_frame; i < lines.Length; i++)
            {
                string[] ch = lines[i].Split(new char[] { ' ' });
                //lấy các thông tin :from, to, duration, interrupt, sum
                from = ch[0].Substring(1);
                to = ch[1].Substring(1);
                if (ch.Length > 2)
                    duration = ch[2].Substring(1);
                else
                    duration = "";
                if (ch.Length > 3)
                    interrupt = ch[3].Substring(1);
                else
                    interrupt = "";
                if (ch.Length > 4)
                    sum = ch[4].Substring(1);
                else
                    sum = "";
                //thêm các thông tin vừa lấy được vào listview
                ListViewItem item = new ListViewItem((i - index_frame + 1).ToString());
                item.SubItems.Add(from);
                item.SubItems.Add(to);
                item.SubItems.Add(duration);
                item.SubItems.Add(interrupt);
                item.SubItems.Add(sum);
                time_listView.Items.Add(item);
            }
        }

        private void change(string info, string filePath)
        {
            ControllerSV objSV = new ControllerSV();
            objSV.index = 0;            //lưu vị trí dòng cần thay đổi
            objSV.info = info;          //lưu thông tin thuộc tính cần thay đổi
            objSV.time = "";            //lưu thòi gian mới
            objSV.filePath = filePath;  //lưu đường dẫn file
            string[] lines;
            time_listView.Invoke(new MethodInvoker(() =>
            {
                int index_frame = 0;
                objSV.index = Int32.Parse(time_listView.SelectedItems[0].Text); //lấy vị trí dòng cần thay đổi
                lines = File.ReadAllLines(filePath);                        //đọc file setting vào mảng lines
                for (int i=0;i<lines.Length;i++)
                {
                    if(lines[i] == "frameTime")
                    {
                        index_frame = i + 1;
                        break;
                    }
                }
                objSV.time = lines[objSV.index + index_frame - 1];           //lấy dòng đã được chọn để thay đổi
            }));
            Form2 form2 = new Form2(objSV); //khởi tạo 1 form để diền thông tin
            form2.Show();                   //hiện form mới để nhập giá trị
            form2.BringToFront();           //đưa form mới lên đầu
        }

        private void time_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //nút load thông tin thời gian
        private void loadTime_btn_Click(object sender, EventArgs e)
        {
            load(filePath_textBox.Text);
            string[] lines = File.ReadAllLines("setting.txt");
            File.Delete("setting.txt");
            StreamWriter writer;
            using (writer = new StreamWriter("setting.txt", true))
            {

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] ch =lines[i].Split(new char[] { '=' });
                    if (ch[0] == "filePath")
                    {
                        lines[i] = ch[0] + "=" + filePath_textBox.Text;
                    }
                    writer.WriteLine(lines[i]);
                }
            }
            writer.Close();
        }

        //thay đổi thông tin From
        private void changeFrom_Click(object sender, EventArgs e)
        {
            change("From", filePath_textBox.Text);
        }

        //thay đổi thông tin To
        private void changeTo_Click(object sender, EventArgs e)
        {
            change("To", filePath_textBox.Text);
        }

        //thay đổi thông tin Duration
        private void changeDuration_Click(object sender, EventArgs e)
        {
            change("Duration", filePath_textBox.Text);
        }

        //thay đổi thông tin Interrupt
        private void changeInterrupt_Click(object sender, EventArgs e)
        {
            change("Interrupt", filePath_textBox.Text);
        }

        //thay đổi thông tin Sum
        private void changeSum_Click(object sender, EventArgs e)
        {
            change("Sum", filePath_textBox.Text);
        }
        //xóa 1 dòng thời gian ở listview
        private void deleteTime_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePath_textBox.Text);
            //delete line selected
            if (time_listView.SelectedItems.Count > 0)
            {
                time_listView.Items.Remove(time_listView.SelectedItems[0]);
            }
            File.Delete(filePath_textBox.Text);
            StreamWriter writer;
            using (writer = new StreamWriter(filePath_textBox.Text, true))
            {
                int index_frame = 0;
                for (int i=0;i< lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                    if (lines[i] == "frameTime")
                    {
                        index_frame = i + 1;
                        break;
                    }
                }
                for (int i = index_frame; i < time_listView.Items.Count+ index_frame; i++)
                {
                    int index = Int32.Parse(time_listView.Items[i- index_frame].Text);
                    writer.WriteLine(lines[index + index_frame - 1]);
                }
                writer.Close();
            }
            load(filePath_textBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //nút thêm khoảng thời gian vào listview
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (time_textBox.Text == "")
                return;
            using (StreamWriter writer = new StreamWriter(filePath_textBox.Text, true))
            {
                writer.WriteLine(time_textBox.Text);
                writer.Close();
            }
            load(filePath_textBox.Text);
        }

        //link hướng dẫn thêm khoảng thời gian vào listview
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("addTime.txt");
        }

        //link thay đổi mật khẩu cho ba mẹ
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3(filePath_textBox.Text, "pass_P");   //khởi tạo 1 form để diền thông tin
            form3.Show();                                               //hiện form mới để nhập giá trị
            form3.BringToFront();                                       //đưa form mới lên đầu
        }

        //link thay đổi mật khẩu cho con
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3(filePath_textBox.Text, "pass_C");   //khởi tạo 1 form để diền thông tin
            form3.Show();                                               //hiện form mới để nhập giá trị
            form3.BringToFront();                                       //đưa form mới lên đầu
        }
    }
}
