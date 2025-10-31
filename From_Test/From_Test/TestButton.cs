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
        public TestButton(Point position,Size size, string test)
        { 
            Location = position;
            Size = size;
            Text = test;


            Click += hogehogeClick;

        }

        private void hogehogeClick(object sender, EventArgs e)
        {
            MessageBox.Show("人体模型");
        }
    }
}
