using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 突然のなんとか
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int LengthByte(string stTarget)
        {
            // 文字のバイト数を計算
            return System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(stTarget);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double CharByte = Form1.LengthByte(textBox1.Text);
            string totsuzen_ue;
            string totsuzen_shita;
            int lenth = textBox1.Text.Length;
            string ue = "人";
            string shita = "Y^";
            
            for (double i = 0; i < Math.Ceiling(CharByte / 2 + 1) - 2 ; i++)
            {
                ue = ue + "人";
            }

            for (double i = 0; i < Math.Ceiling(CharByte / 2 + 1) - 2 ; i++)
            {
                shita = shita + "Y^";
            }

            totsuzen_ue = "＿" + ue + "＿";
            totsuzen_shita = "￣" + shita + "￣";

            string s = lenth.ToString();
            textBox2.Text = totsuzen_ue + Environment.NewLine + "＞ " + textBox1.Text + " ＜" + Environment.NewLine + totsuzen_shita;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
