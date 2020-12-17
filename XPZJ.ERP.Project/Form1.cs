using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPZJ.ERP.Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MinimizeBox = false;
            WbInit();
        }

        public bool IsLoaded = false;

        private ChromiumWebBrowser browser;
        private void WbInit()
        {
            string GoogleInterface = "http://192.168.0.117";
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser(GoogleInterface);
            browser.FrameLoadEnd += this.WebBrowser_FrameLoadEnd;    //加载完成
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.KeyboardHandler = new CEFKeyBoardHander();
        }

        private void WebBrowser_FrameLoadEnd(object sender, EventArgs e)
        {
            IsLoaded = true;
            //MessageBox.Show("欢迎进入虾皮之家！！！");
        }
    }
}
