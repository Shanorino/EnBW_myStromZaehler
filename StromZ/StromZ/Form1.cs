﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StromZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread tDeamon = new Thread(new ThreadStart(this.refreshWatt));
            tDeamon.Start();
        }
        private void refreshWatt()
        {
            while (true)
            {
                System.Net.WebClient client = new WebClient();
                byte[] page = client.DownloadData("http://192.168.0.100/");
                string content = System.Text.Encoding.UTF8.GetString(page);
                Regex re = new Regex(@"<div class=""whats"">(.*)</div>");
                Match m = re.Match(content);
                if (m.Success)
                {
                    //safe thread update label
                    if (this.lb_watts.InvokeRequired)
                    {
                        Action<string> actionDelegate = delegate (string txt) { this.lb_watts.Text = txt; };
                        this.lb_watts.Invoke(actionDelegate, m.Groups[1].ToString());
                    }
                    else
                    {
                        this.lb_watts.Text = m.Groups[1].ToString();
                    }
                    //record into a file
                    Console.Write(m.Groups[1] + "\r\n");
                    recordWatt(m.Groups[1].ToString());
                }
                Thread.Sleep(1000);
            }
        }
        private void recordWatt(string wattValue)
        {
            wattValue += ","+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"\r\n";
            FileStream fs = new FileStream("C:\\Strom.txt", FileMode.Append);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(wattValue);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
    }
}
