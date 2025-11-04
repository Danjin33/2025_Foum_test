using System;
using System.Drawing;
using System.Windows.Forms;

namespace From_Test
{

    public partial class Form1 : Form
    {
        //constをつけると初期化時にのみ値の変更が可能になる

        //ボタンの横幅
        const int BUTTON_SIZE_X = 100;

        //ボタンの縦幅
        const int BUTTON_SIZE_Y = 100;


        //ボタンが縦に何個並ぶか
        const int BOARD_SIZE_X = 3;

        //ボタンが横に何個並ぶか
        const int BOARD_SIZE_Y = 3;

        //TestButtonの二次元配列
        private TestButton[,] _buttonArray;



        public Form1()
        {
            InitializeComponent();

            //_buttonArrayの初期化
            _buttonArray = new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];

            //模範解答では、iとjを位置設定の値に掛けてた
            // TestButton.Location = new Point(50 * i,50 * j);

     
            for (int j = 0; j < BOARD_SIZE_X; j++)
            {


                for (int i = 0; i < BOARD_SIZE_Y; i++)
                {

                    //インスタンスの生成
                    TestButton testButton = new TestButton
                        (this, i, j,  
                        
                        new Size(BUTTON_SIZE_X,BUTTON_SIZE_Y), "(´･ω･`)ﾔｷｲﾓ...");

                    //配列にボタンの参照を追加
                    _buttonArray[j,i] = testButton;

                    //コントロールのボタンを設置
                    Controls.Add(testButton);

               
                }

            }

        }

        public TestButton GetTestButton(int x, int y)
        {
            //－1と3以上を入れたときにバグらないようにする

            if (x < 0 || x >= BOARD_SIZE_X) return null;
            if (y < 0 || y >= BOARD_SIZE_Y) return null;

            return _buttonArray[y, x];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(´･ω･`)ｱﾜﾜ");
        }

    }
}
