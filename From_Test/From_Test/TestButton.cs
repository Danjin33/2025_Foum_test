using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_Test
{
    //Buttonクラスを継承した
    //TestButtonクラスを作成してください。
    /*internal*/ public class TestButton : Button
    {
        private Color _onColor = Color.Blue;

        private Color _offColor = Color.Red;

        private bool _enable;

        //Form1の参照
        private Form1 _form1;

        //横位置
        private int _x;

        //縦位置
        private int _y;

  
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

        public TestButton(Form1 form1, int x, int y, Point position,Size size, string test)
        {
            //Form1の参照の保存
            _form1 = form1;

            //横位置の保存
            _x = x;

            //縦位置の保存
            _y = y;


            //ボタンの位置を決めるやつ
            Location = position;

            //ボタンのサイズを決めるやつ
            Size = size;

            //ボタンのテキストを決めるやつ
            Text = test;

            SetEnable(false);

            Click += hogehogeClick;

        }

        private void hogehogeClick(object sender, EventArgs e)
        {
            // MessageBox.Show("人体模型");

            //クリックしたらここの処理を実行する

            //クリックしたとこ以外が反応するやつ
            _form1.GetTestButton(_x, _y).SetEnable(true);
            //　!_enadleのお陰で切り替わる
           // SetEnable(!_enable);

        }
    }
}
