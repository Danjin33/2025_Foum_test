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
    internal class TestButton : Button
    {
        private Color _onColor = Color.Blue;
        private Color _offColor = Color.Red;

        private bool _enable;


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

        public TestButton(Point position,Size size, string test)
        { 
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


            //　!_enadleのお陰で切り替わる
            SetEnable(!_enable);

        }
    }
}
