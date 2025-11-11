using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace From_Test
{
    //Buttonクラスを継承した
    //TestButtonクラスを作成してください。
    /*internal*/
    public class TestButton : Button
    {
        
        private Color _onColor = Color.Yellow;

        private Color _offColor = Color.Purple;

        private bool _enable;

        //Form1の参照
        private Form1 _form1;

        //横位置
        private int _x;

        //縦位置
        private int _y;

        private int _count;


        public TestButton(Form1 form1, int x, int y, Size size, string test)
        {
            //Form1の参照の保存
            _form1 = form1;

            //横位置の保存
            _x = x;

            //縦位置の保存
            _y = y;


            //ボタンの位置を決めるやつ
            Location = new Point(x * size.Width, y * size.Height);

            //ボタンのサイズを決めるやつ
            Size = size;

            //ボタンのテキストを決めるやつ
            Text = test;

            SetEnable(false);

            Click += hogehogeClick;

            _form1.count = _count;

        }

        public void SetEnable(bool on)
        {
            //オンとオフの設定
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
        }

        //ここでオンかオフかを見てる
        public bool InEnable()
        {
            return _enable;
        }


        //　!_enadleのお陰で切り替わる
        public void Toggle()
        {
            SetEnable(!_enable);
        }

        

        //クリックしたらここの処理を実行する
        private void hogehogeClick(object sender, EventArgs e)
        {
            // MessageBox.Show("人体模型");

            //クリックしたとこ以外が反応するやつ
            //楽な書き方
            
            _form1.GetTestButton(_x, _y)?.Toggle();
            _form1.GetTestButton(_x - 1, _y)?.Toggle();
            _form1.GetTestButton(_x + 1, _y)?.Toggle();
            _form1.GetTestButton(_x, _y - 1)?.Toggle();
            _form1.GetTestButton(_x, _y + 1)?.Toggle();

           /*
            //かっちょいい書き方
            for (int i = 0; i < _toggleData.Length; i++)
            { 
                var data = _toggleData[i];
                var button = _form1.GetTestButton(_x + data[0], _y + data[1]);

                if (button != null)
                { 
                    button. Toggle();
                }
            }
            */

            if (_form1.Isclear())
            {
                MessageBox.Show("クリアだよー");
            }

        }
        /*
        //かっちょいいやつ
        private int[][] _toggleData =
        {
            new int[]{0,0 },
            new int[]{1,0},
            new int[]{-1, 0},
            new int[]{0, 1},
            new int[]{0,-1},
        };
        */
    }


}
