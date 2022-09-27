using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace WFAVotingBot
{
    
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            DGV.Rows.Clear();            
            LabelStatus.Text="Initialized";
        }

        private String sendNewRequest(String link,String proxyAddress)
        {            
            //create the constructor with post type and few data
            Browser b = new Browser(link,"POST","a=value1&b=value2");
            return b.GetResponse();             
        }

        delegate void CallThreadDelegate(String text);

        private void callThread(String line)
        {
            
            String  status;

            Console.WriteLine("Inside Thread");
            if(DGV.InvokeRequired||TextBoxLink.InvokeRequired)
            {
                
                if (DGV.InvokeRequired)
                {
                    DGV.BeginInvoke(new CallThreadDelegate(callThread),line);
                }
                else if(TextBoxLink.InvokeRequired)
                {
                    TextBoxLink.BeginInvoke(new CallThreadDelegate(callThread), line);
                }
            }
            else
            {                
                status = sendNewRequest(TextBoxLink.Text, line);
                String[] s = new String[] { (DGV.Rows.Count).ToString(), line, status };
                DGV.Rows.Add(s);
                LabelStatus.Text = status;                
                DGV.Refresh();
            }
        }

        private  void firstThread()
        {
            String line = "";
            StreamReader reader = new StreamReader("E:\\proxy.txt");
            while ((line = reader.ReadLine()) != null)
            {
                new Thread(() => callThread(line)).Start();
                Console.WriteLine(DateTime.Now);
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Read in every line in the file.
            new Thread(firstThread).Start();                                    
        }
    }
}
