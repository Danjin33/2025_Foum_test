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

        private Form1 _form1;

  
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

        public TestButton(Form1 form1, Point position,Size size, string test)
        {
            _form1 = form1;


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
            _form1.GetTestButton(1, 1).SetEnable(true);
            //　!_enadleのお陰で切り替わる
           // SetEnable(!_enable);

        }
    }
}
