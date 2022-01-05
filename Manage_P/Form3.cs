using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_P;
using static Manage_P.Form1;

namespace ChangePass
{
    public partial class Form3 : Form
    {
        //tạo 2 thuộc tính filePath và info
        private string filePath;
        private string info;
        public Form3(string filePath, string info)
        {
            InitializeComponent();
            //gán giá trị truyền vào từ Form1 cho filePath và info
            this.filePath = filePath;
            this.info = info;
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePath);
            File.Delete(filePath);
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] ch = lines[i].Split(new char [] { ':' });
                    if (ch[0] == info)
                    {
                        writer.WriteLine(ch[0]+": "+newPass_textBox.Text);
                    }
                    else
                    {
                        writer.WriteLine(lines[i]);
                    }
                }
                writer.Close();
            }
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
