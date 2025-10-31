using System;
using System.Drawing;
using System.Windows.Forms;

namespace From_Test
{

    public partial class Form1 : Form
    {
        //constをつけると初期化時にのみ値の変更が可能になる

        //
        const int BUTTON_SIZE_X = 100;

        //
        const int BUTTON_SIZE_Y = 100;


        //ボタンが縦に何個並ぶか
        const int BOAORD_SIZE_X = 3;

        //ボタンが横に何個並ぶか
        const int BOAORD_SIZE_Y = 3;



        public Form1()
        {
            InitializeComponent();


            //模範解答では、iとjを位置設定の値に掛けてた
            // TestButton.Location = new Point(50 * i,50 * j);

     
            for (int j = 0; j < BOAORD_SIZE_X; j++)
            {


                for (int i = 0; i < BOAORD_SIZE_Y; i++)
                {

                    //インスタンスの生成
                    TestButton testButton = new TestButton
                        (new Point( BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j),
                        new Size(BUTTON_SIZE_X,BUTTON_SIZE_Y), "あいうえお");

                    //コントロールのボタンを設置
                    Controls.Add(testButton);

               
                }

            }

        }




        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(´･ω･`)ｱﾜﾜ");
        }

    }
}
