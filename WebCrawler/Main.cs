using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WebCrawler
{
    public partial class Main : Form
    {
        private int RunningThreadCount;
        private int RunTimes;
        private int TimeStart;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            TimeStart = System.Environment.TickCount;
            InitProcess();
            if (chkRun.Checked)
                RunProcessThreaded();
            else RunProcess();
        }

        public void InitProcess()
        {
            btnExit.Enabled = false;
            btnRun.Enabled = false;
            chkRun.Enabled = false;
            RunTimes = int.Parse(textBox1.Text);
            FillListView();

            RunningThreadCount = 0;
        }

        public void FillListView()
        {
            lv1.Items.Clear();
            for (int i = 0; i < RunTimes; i++)
            {
                ListViewItem itm = new ListViewItem();
                itm.Text = (i + 1).ToString();
                itm.SubItems.Add("Pending");
                itm.SubItems.Add("-");
                itm.SubItems.Add("-");
                lv1.Items.Add(itm);
            }
        }


        public async void RunProcess()
        {
            for (int i = 0; i < RunTimes; i++)
            {
                updateStatusLabel("Processing: " + (i + 1).ToString() + "/" + RunTimes.ToString());
                lv1.Items[i].Selected = true;
                lv1.Items[i].EnsureVisible();
                lv1.Items[i].SubItems[1].Text = "Processing...";
                ReqObj result = await Web.SendWebRequest(new ReqObj() { ItemID = i.ToString(), WebURL = textBox2.Text });
                lv1.Items[i].SubItems[1].Text = result.ResultCode;
                if (result.ResultCode == "ERR")
                    lv1.Items[i].SubItems[2].Text = result.Message;
            }
            CleanUp();
        }

        private void CleanUp()
        {
            btnExit.Enabled = true;
            btnRun.Enabled = true;
            chkRun.Enabled = true;
            lbThreadCount.Visible = false;
            updateStatusLabel("Status: complete  (Time taken: " + UpdateTime().ToString() + ")");
        }


        public int UpdateTime()
        {
            var TimeEnd = System.Environment.TickCount;
            var TimeTaken = ((TimeEnd - TimeStart) / 1000);
            return (TimeTaken);
        }

        private void updateStatusLabel(string Status)
        {
            lbStatus.Text = Status;
            Application.DoEvents();
        }

        public void RunProcessThreaded()
        {
            updateStatusLabel("Status: threaded mode - watch thread count and list status");
            lbThreadCount.Visible = true;

            for (int i = 0; i < RunTimes; i++)
            {
                updateStatusLabel("Processing: " + (i + 1).ToString() + "/" + RunTimes.ToString());
                lv1.Items[i].Selected = true;
                lv1.Items[i].SubItems[1].Text = "Processing...";
                ReqObj rec = new ReqObj() { ItemID = i.ToString(), WebURL = textBox2.Text };
                CreateWorkThread(rec);
                RunningThreadCount++;
                UpdateThreadCount();
            }
        }


        public void CreateWorkThread(ReqObj rec)
        {
            ThreadOperations item = new ThreadOperations(rec);
            item.Completed += WorkThread_Completed;
            item.DoWork();
        }


        private void WorkThread_Completed(object sender, WorkItemCompletedEventArgs e)
        {
            lv1.Items[int.Parse(e.Result.ItemID)].SubItems[1].Text = e.Result.ResultCode;
            if (e.Result.ResultCode == "ERR")
                lv1.Items[int.Parse(e.Result.ItemID)].SubItems[2].Text = e.Result.Message;

            RunningThreadCount--;
            UpdateThreadCount();

            if (RunningThreadCount == 0)
            {
                CleanUp();
            }

        }

        private void UpdateThreadCount()
        {
            lbThreadCount.Text = "Running threads: " + RunningThreadCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
