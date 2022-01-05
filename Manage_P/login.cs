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
using Manage_P;
using static Manage_P.Form1;
using System.Threading;

namespace login
{
    public partial class login : Form
    {
        string filePath = "";
        public login()
        {
            InitializeComponent();
        }
        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeForm()
        {
            login settings = new login();
            this.Close();
            settings.Close();
        }

        private void openNewForm(object obj)
        {
            Application.Run(new Form1());
            string[] lines = File.ReadAllLines(filePath);
            string[] ch = lines[0].Split(new char[] { ':' });
            while (true)
            {
                try
                {
                    File.Delete(filePath);
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(ch[0] + ": 0");
                        for (int i = 1; i < lines.Length; i++)
                        {
                            writer.WriteLine(lines[i]);
                        }
                        writer.Close();
                    }
                    break;
                }
                catch (Exception) { }
            }
            
        }
        
        private bool check_pass(string text_pass)
        {
            string[] lines = File.ReadAllLines("setting.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] ch = lines[i].Split(new char[] { '=' });
                if (ch[0] == "filePath")
                {
                    filePath = ch[1];
                    break;
                }
            }
            lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] ch = lines[i].Split(new char[] { ':' });
                if (ch[0] == "pass_P")
                {
                    if (ch[1] == "")
                        return text_pass == "";
                    return text_pass == ch[1].Substring(1);
                }                   
            }
            return false;
        }

        //private void enter_region()
        //{

        //}

        private void login_btn_Click(object sender, EventArgs e)
        {
            Thread th;
            if(check_pass(password_textBox.Text))
            {
                while(true)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        string[] ch = lines[0].Split(new char[] { ':' });
                        if (ch[1].Substring(1) == "0")
                        {
                            File.Delete(filePath);
                            using (StreamWriter writer = new StreamWriter(filePath, true))
                            {
                                writer.WriteLine(ch[0] + ": 1");
                                for (int i = 1; i < lines.Length; i++)
                                {
                                    writer.WriteLine(lines[i]);
                                }
                                writer.Close();
                            }
                            break;
                        }
                        Thread.Sleep(10000);        //sleep 10s 
                    }
                    catch (Exception){}
                }
                this.Close();
                th = new Thread(openNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

            }
            else
            {
                MessageBox.Show("sai mật khẩu!!!", "Lỗi");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            closeForm();
        }
    }
}
