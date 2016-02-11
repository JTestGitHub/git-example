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
        StreamReader sr;
        Random rand = new Random();
        public void AdviseMe()
        {
            sr = File.OpenText("Comments.txt");
            while (!sr.EndOfStream)
            {
                aList.Add(sr.ReadLine());
            }
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            AdviseMe();
            MessageBox.Show(aList[rand.Next(0, aList.Count() - 1)].ToString());
        }
    }
}
