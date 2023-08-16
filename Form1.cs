using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//雙層迴圈的應用
            string userStringInput=textBox1.Text;
            int inputLevel;//由使用者決定聖誕樹層數
            bool intParse = int.TryParse(userStringInput,out inputLevel);
            int blankNum;
            int leavesNum = 1;
            string result = "";
            string repeat = "";
            int n;//打工人
            if (intParse) 
            {
                blankNum = inputLevel - 1;
                for (int i = 1; i <= inputLevel; i++) 
                {
                    repeat = "0";
                    for (n = 1; n <= blankNum; n++) 
                    {
                        result = result + repeat;
                    }
                    repeat = "*";
                    for (n = 1; n <= leavesNum; n++) 
                    {
                        result = result + repeat;
                    }

                    result += "\n";
                    blankNum--;
                    leavesNum += 2;
                }
                MessageBox.Show(result);
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
