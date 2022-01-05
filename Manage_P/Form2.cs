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

namespace changeInfo
{
    public partial class Form2 : Form
    {
        private ControllerSV objSV;
        public class infoAccount
        {
            public string time { set; get; }

        }
        public Form2(ControllerSV objSV)
        {
            InitializeComponent();
            this.objSV = objSV;
        }
        private void closeForm()
        {
            Form2 settings = new Form2(objSV);
            this.Close();
            settings.Close();
        }
        private void change_btn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            int n = 0;
            string line = "";
            string[] ch = objSV.time.Split(new char[] { ' ' });
            if (objSV.info == "From")
            {
                line = line + "F" + filePath_textBox.Text;
                n++;
                while (n < ch.Length)
                {
                    line += " " + ch[n];
                    n++;
                }
            }
            else if (objSV.info == "To")
            {
                line = line + ch[0] + " T" + filePath_textBox.Text;
                n = 2;
                while (n < ch.Length)
                {
                    line += " " + ch[n];
                    n++;
                }
            }
            else if (objSV.info == "Duration")
            {
                line = line + ch[0] + " " + ch[1] + " D" + filePath_textBox.Text;
                n = 3;
                while (n < ch.Length)
                {
                    line += " " + ch[n];
                    n++;
                }
            }
            else if (objSV.info == "Interrupt")
            {
                n = 4;
                for (int i=0;i<n-1;i++)
                {
                    line = line + ch[i] + " ";
                }    
                line = line + "I" + filePath_textBox.Text;
                
                while (n < ch.Length)
                {
                    line += " " + ch[n];
                    n++;
                }
            }
            else if (objSV.info == "Sum")
            {
                n = 5;
                for (int i = 0; i < n - 1; i++)
                {
                    line = line + ch[i] + " ";
                }
                line = line + "S" + filePath_textBox.Text;
            }
            infoAccount newAccount = new infoAccount();
            newAccount.time = line;
            string[] lines = File.ReadAllLines(objSV.filePath);
            File.Delete(objSV.filePath);
            StreamWriter writer;
            using (writer = new StreamWriter(objSV.filePath, true))
            {
                int index_frame = 0;
                for (int i=0;i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                    if (lines[i]== "frameTime")
                    {
                        index_frame = i + 1;
                        break;
                    }    
                }    
                for (int i = index_frame; i < lines.Length; i++)
                {
                    if (i == objSV.index + index_frame - 1)
                    {
                        writer.WriteLine(newAccount.time);
                    }

                    else
                    {
                        writer.WriteLine(lines[i]);
                    }
                }
            }
            writer.Close();
            closeForm();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            closeForm();
        }
    }
}
