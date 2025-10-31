using System;
using System.Drawing;
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

     
            for (int j = 0; j < 3; j++)
            {


                for (int i = 0; i < 3; i++)
                {

                    //インスタンスの生成
                    TestButton testButton = new TestButton(new Point(50 * i, 50 * j), new Size(50, 50), "あいうえお");





                    //コントロールのボタンを設置
                    Controls.Add(testButton);

               
                }


            }

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
