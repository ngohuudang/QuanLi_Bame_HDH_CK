
namespace ChangePass
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.newPass_textBox = new System.Windows.Forms.TextBox();
            this.change_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập mật khẩu mới";
            // 
            // newPass_textBox
            // 
            this.newPass_textBox.Location = new System.Drawing.Point(17, 73);
            this.newPass_textBox.Name = "newPass_textBox";
            this.newPass_textBox.Size = new System.Drawing.Size(147, 20);
            this.newPass_textBox.TabIndex = 3;
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(17, 119);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(64, 35);
            this.change_btn.TabIndex = 4;
            this.change_btn.Text = "Thay đổi";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(100, 119);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(64, 35);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "trở về";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 166);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.newPass_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPass_textBox;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}