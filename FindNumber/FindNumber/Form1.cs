using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNumber
{
    public partial class Form1 : Form
    {
        private int findnumber = 0;
        private int chance = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findnumber = rand.Next(1, 30);
            chance = 5;
            display.Text = "맞출 숫자를 입력하세요";
        }

        private void buttoninput_Click(object sender, EventArgs e)
        {
            int inputnumber = Int32.Parse(textBox.Text);

            if(inputnumber == findnumber)
            {
                display.Text = "승리했습니다!";
            }
            else
            {
                chance--;
                display.Text = "기회는" + chance + "번 남았습니다,";
            }
            if(chance <= 0)
            {
                display.Text = "실패했습니다.";
            }
        }
    }
}
