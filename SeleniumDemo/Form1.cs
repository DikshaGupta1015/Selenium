using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IWebDriver driver;
        private void button2_Click(object sender, EventArgs e)
        {
            //driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            System.Threading.Thread.Sleep(5000);
            driver.Url = "http://www.w3schools.com";
        }

        private void btnStartChrome_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            driver.Close();
            driver.Quit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            driver.Navigate().Forward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            driver.Navigate().Refresh();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            driver.Url = "file:///D:/Users/Learning/Downloads/default.html";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.Clear();
            element.SendKeys(txtUrl.Text);
            element.Submit();
        }
    }
}
