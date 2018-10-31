using System;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {

        private int _numberOne;
        private int _numberTow;
        private int _mathOperation;
        private int _check;
        private int _total;

        public Form1()
        {
            InitializeComponent();
            PlayGame();
        }

        private void KeyisDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.P || e.KeyChar == 112)
            {
                _check = 1;
                CheckResult();
            }
            else if (e.KeyChar == (char)Keys.M || e.KeyChar == 109)
            {
                _check = 2;
                CheckResult();
            }
            else if (e.KeyChar == (char)Keys.X || e.KeyChar == 120)
            {
                _check = 3;
                CheckResult();
            }
            else if (e.KeyChar == (char)Keys.D || e.KeyChar == 100)
            {
                _check = 4;
                CheckResult();
            }
        }

        public void PlayGame()
        {
            var ranNumber = new Random();
            _numberOne = ranNumber.Next(1, 40);
            _numberTow = ranNumber.Next(1, 50);
            _mathOperation = ranNumber.Next(1, 5);
            pictureBox1.Image = Properties.Resources.qq1;

            switch (_mathOperation)
            {
                case 1:
                    AddNumbers();
                    break;
                case 2:
                    SubstractNumbers();
                    break;
                case 3:
                    MultiplyNumbers();
                    break;
                case 4:
                    DivideNumbers();
                    break;
            }


            label1.Text = Convert.ToString(_numberOne);
            label2.Text = Convert.ToString(_numberTow);
            label4.Text = Convert.ToString(_total);
        }

        public void AddNumbers()
        {
            _total = _numberOne + _numberTow;
        }
        public void SubstractNumbers()
        {
            _total = _numberOne - _numberTow;
        }
        public void MultiplyNumbers()
        {
            _total = _numberOne * _numberTow;
        }
        public void DivideNumbers()
        {
            _total = _numberOne / _numberTow;
        }

        public void CheckResult()
        {
            if (_check == _mathOperation)
            {
                switch (_mathOperation)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.plus;
                        MessageBox.Show(@"Correct");
                        PlayGame();
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.minus;
                        MessageBox.Show(@"Correct");
                        PlayGame();
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.multi;
                        MessageBox.Show(@"Correct");
                        PlayGame();
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.divide;
                        MessageBox.Show(@"Correct");
                        PlayGame();
                        break;
                }
            }
            else
            {
                MessageBox.Show(@"Wrong Answer");
            }
        }
    }
}