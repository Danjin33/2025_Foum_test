using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //模範解答では、iとjを位置設定の値に掛けてた
            // TestButton.Location = new Point(50 * i,50 * j);

            int tate = 20;
            for (int j = 0; j < 6; j++)
            {
                int iti = 50;

                for (int i = 0; i < 4; i++)
                {

                    //インスタンスの生成
                    TestButton testButton = new TestButton();

                    //ボタンのサイズを設定
                    testButton.Size = new Size(50, 50);

                    //ボタンの位置を設定
                    testButton.Location = new Point(iti, tate);

                    //ボタン内のテキストを設定
                    testButton.Text = "あいうえお";

                    //マウスホバーなるものもあるらしい
                    testButton.Click += hogehogeClick;


                    //コントロールのボタンを設置
                    Controls.Add(testButton);

                    iti += 50;
                }

             tate += 50;

            }
            
        }
        //自分で作成することも可能
        private void hogehogeClick(object sender, EventArgs e)
        {
            MessageBox.Show("人体模型");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(´･ω･`)ｱﾜﾜ");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
