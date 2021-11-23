using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vasilev12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FirstCipher();
            TwoCipher();
            FiguresAndClounes();
        }
        void FiguresAndClounes()
        {
            Circle cirk = new Circle();
            cirk.Color = "Red";
            cirk.radius = 10;
            richTextBox3.Text = $"Круг и его площадь ({cirk.Area()})";

            Rectangle rectangle = new Rectangle();
            rectangle.Color = "WhiteRed";
            rectangle.width = 10;
            rectangle.height = 5;
            richTextBox3.Text += $"\nКвадрат и его площадь({rectangle.Area()})";
        }
        void TwoCipher()
        {
            BCipher aBCCipher = new BCipher();
            richTextBox2.Text = "Вторая\nДо: ";
            aBCCipher.encryption = "АБВа";
            richTextBox2.Text += aBCCipher.encryption + "\nПосле: ";
            aBCCipher.encode();
            richTextBox2.Text += aBCCipher.encryption + "\nОбратно: ";
            aBCCipher.decode();
            richTextBox2.Text += aBCCipher.encryption;
        }

        void FirstCipher()
        {
            richTextBox1.Text = "Первая\nДо: ";
            ACipher aCipher = new ACipher();
            aCipher.encryption = "АбВгДЯ";
            richTextBox1.Text += aCipher.encryption + "\nПосле: ";
            aCipher.encode();
            richTextBox1.Text += aCipher.encryption + "\nОбратно: ";
            aCipher.decode();
            richTextBox1.Text += aCipher.encryption;
        }
    }
}
