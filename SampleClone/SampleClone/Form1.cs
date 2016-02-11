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

namespace SampleClone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> aList = new List<string>();
       
        Random rand = new Random();
        public void AdviseMe()
        {
            aList.Add("Hello world never taught me programming");
            aList.Add("Breakpoints don't break a program");
            aList.Add("Nothing programmed nothing displayed");
            aList.Add("I don't know how the Internet code got into my program, honest");
            aList.Add("A comment on how comments are helpful is a helpful comment");
            aList.Add("Agile programming doesn't mean your program can dance");
            aList.Add("SQL is not short for sequel even though you say that way");
            aList.Add("Clean code is dry clean only");
            aList.Add("Programming events are not the same as a life events");
            aList.Add("The programmer lifecycle: Test, Program, Get paid, Repeat");
            aList.Add("Programming is hard, I just make it look easy");
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            AdviseMe();
            MessageBox.Show(aList[rand.Next(0, aList.Count() - 1)].ToString());
        }
    }
}
