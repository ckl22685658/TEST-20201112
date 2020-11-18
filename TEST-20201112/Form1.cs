using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_20201112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputstr;
            inputstr = textBox1.Text;
            switch (inputstr)
            {
                case "1":
                    label8.Text= "紅茶，費用10元";
                    pictureBox1.BackgroundImage = global::TEST_20201112.Properties.Resources.紅茶;
                    break;
                case"2":
                    label8.Text = "綠茶，費用12元";
                    pictureBox1.BackgroundImage = global::TEST_20201112.Properties.Resources.綠茶;
                    break;
                case "3":
                    label8.Text = "烏龍茶，費用15元";
                    pictureBox1.BackgroundImage = global::TEST_20201112.Properties.Resources.烏龍茶;
                    break;
                case "4":
                    label8.Text = "冬瓜茶，費用9元";
                    pictureBox1.BackgroundImage = global::TEST_20201112.Properties.Resources.冬瓜茶;
                    break;
                case "5":
                    label8.Text = "奶茶，費用11元";
                    pictureBox1.BackgroundImage = global::TEST_20201112.Properties.Resources.奶茶;
                    break;
                default:
                    label8.Text = "錯誤，請重新輸入";
                    //pictureBox1.BackgroundImage = global::TEST_20201112.Properties.Resources.紅茶;
                    break;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
