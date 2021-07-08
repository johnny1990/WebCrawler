
namespace WebCrawler
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lv1 = new System.Windows.Forms.ListView();
            this.URL = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.Results = new System.Windows.Forms.ColumnHeader();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkRun = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbThreadCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRAWLER";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(787, 81);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(95, 49);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Run attempts";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Test Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(471, 23);
            this.textBox2.TabIndex = 5;
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.URL,
            this.Status,
            this.Results});
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(40, 162);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(842, 269);
            this.lv1.TabIndex = 6;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 300;
            // 
            // Results
            // 
            this.Results.Text = "Results";
            this.Results.Width = 200;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(807, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 54);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // chkRun
            // 
            this.chkRun.AutoSize = true;
            this.chkRun.Location = new System.Drawing.Point(40, 458);
            this.chkRun.Name = "chkRun";
            this.chkRun.Size = new System.Drawing.Size(106, 19);
            this.chkRun.TabIndex = 8;
            this.chkRun.Text = "Run threaded...";
            this.chkRun.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "CRAWLER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(222, 461);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(39, 15);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "Status";
            // 
            // lbThreadCount
            // 
            this.lbThreadCount.AutoSize = true;
            this.lbThreadCount.Location = new System.Drawing.Point(222, 489);
            this.lbThreadCount.Name = "lbThreadCount";
            this.lbThreadCount.Size = new System.Drawing.Size(86, 15);
            this.lbThreadCount.TabIndex = 11;
            this.lbThreadCount.Text = "lbThreadCount";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 538);
            this.Controls.Add(this.lbThreadCount);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkRun);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkRun;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Results;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbThreadCount;
    }
}

