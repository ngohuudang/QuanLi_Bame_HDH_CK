
namespace Manage_P
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.time_listView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeFrom = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTo = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDuration = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInterrupt = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSum = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTime = new System.Windows.Forms.ToolStripMenuItem();
            this.filePath_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadTime_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.time_textBox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // time_listView
            // 
            this.time_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.time_listView.ContextMenuStrip = this.contextMenuStrip1;
            this.time_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.time_listView.FullRowSelect = true;
            this.time_listView.GridLines = true;
            this.time_listView.HideSelection = false;
            this.time_listView.Location = new System.Drawing.Point(10, 159);
            this.time_listView.Name = "time_listView";
            this.time_listView.ShowItemToolTips = true;
            this.time_listView.Size = new System.Drawing.Size(381, 237);
            this.time_listView.TabIndex = 0;
            this.time_listView.UseCompatibleStateImageBehavior = false;
            this.time_listView.View = System.Windows.Forms.View.Details;
            this.time_listView.SelectedIndexChanged += new System.EventHandler(this.time_listView_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STT";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "From";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "To";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duration";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Interrupt";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sum";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFrom,
            this.changeTo,
            this.changeDuration,
            this.changeInterrupt,
            this.changeSum,
            this.deleteTime});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 136);
            // 
            // changeFrom
            // 
            this.changeFrom.Name = "changeFrom";
            this.changeFrom.Size = new System.Drawing.Size(166, 22);
            this.changeFrom.Text = "thay đổi From";
            this.changeFrom.Click += new System.EventHandler(this.changeFrom_Click);
            // 
            // changeTo
            // 
            this.changeTo.Name = "changeTo";
            this.changeTo.Size = new System.Drawing.Size(166, 22);
            this.changeTo.Text = "thay đổi To";
            this.changeTo.Click += new System.EventHandler(this.changeTo_Click);
            // 
            // changeDuration
            // 
            this.changeDuration.Name = "changeDuration";
            this.changeDuration.Size = new System.Drawing.Size(166, 22);
            this.changeDuration.Text = "thay đổi duration";
            this.changeDuration.Click += new System.EventHandler(this.changeDuration_Click);
            // 
            // changeInterrupt
            // 
            this.changeInterrupt.Name = "changeInterrupt";
            this.changeInterrupt.Size = new System.Drawing.Size(166, 22);
            this.changeInterrupt.Text = "thay đổi interrupt";
            this.changeInterrupt.Click += new System.EventHandler(this.changeInterrupt_Click);
            // 
            // changeSum
            // 
            this.changeSum.Name = "changeSum";
            this.changeSum.Size = new System.Drawing.Size(166, 22);
            this.changeSum.Text = "thay đổi sum";
            this.changeSum.Click += new System.EventHandler(this.changeSum_Click);
            // 
            // deleteTime
            // 
            this.deleteTime.Name = "deleteTime";
            this.deleteTime.Size = new System.Drawing.Size(166, 22);
            this.deleteTime.Text = "xóa";
            this.deleteTime.Click += new System.EventHandler(this.deleteTime_Click);
            // 
            // filePath_textBox
            // 
            this.filePath_textBox.Location = new System.Drawing.Point(65, 19);
            this.filePath_textBox.Name = "filePath_textBox";
            this.filePath_textBox.Size = new System.Drawing.Size(266, 20);
            this.filePath_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "file_path";
            // 
            // loadTime_btn
            // 
            this.loadTime_btn.Location = new System.Drawing.Point(347, 16);
            this.loadTime_btn.Name = "loadTime_btn";
            this.loadTime_btn.Size = new System.Drawing.Size(44, 23);
            this.loadTime_btn.TabIndex = 3;
            this.loadTime_btn.Text = "load";
            this.loadTime_btn.UseVisualStyleBackColor = true;
            this.loadTime_btn.Click += new System.EventHandler(this.loadTime_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "add_Time";
            // 
            // time_textBox
            // 
            this.time_textBox.Location = new System.Drawing.Point(72, 51);
            this.time_textBox.Name = "time_textBox";
            this.time_textBox.Size = new System.Drawing.Size(259, 20);
            this.time_textBox.TabIndex = 5;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(347, 51);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(44, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 83);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "hướng dẫn thêm  thời gian (add_Time)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 105);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(122, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "đổi mật khẩu cho ba mẹ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(12, 130);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(111, 13);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "đổi mật khẩu cho con";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(404, 408);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.time_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadTime_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePath_textBox);
            this.Controls.Add(this.time_listView);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management software for parents";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView time_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox filePath_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadTime_btn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeFrom;
        private System.Windows.Forms.ToolStripMenuItem changeTo;
        private System.Windows.Forms.ToolStripMenuItem changeDuration;
        private System.Windows.Forms.ToolStripMenuItem changeInterrupt;
        private System.Windows.Forms.ToolStripMenuItem changeSum;
        private System.Windows.Forms.ToolStripMenuItem deleteTime;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox time_textBox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

