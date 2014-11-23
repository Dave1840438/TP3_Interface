using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compact_Agenda
{
    public partial class CustomSelectControl : UserControl
    {
        public int MinimumValue { get; set; }
        public int MaximumValue { get; set; }

        private int _leap;

        public int Leap { get {return _leap;} set { if (value == 0) _leap = 1; else _leap = value;  } }
        
        public int StartValue { get; set; }

        int _currentValue;

        public int Value { get { return Int32.Parse(textBox1.Text); } set { textBox1.Text = value.ToString(); } }

        public CustomSelectControl()
        {
            _leap = 1;
            InitializeComponent();
            _currentValue = (StartValue / _leap) * _leap;
            UpdateTextBoxValue();
        }

        public new event EventHandler ValueChanged
        {
            add { textBox1.TextChanged += value; }
            remove { textBox1.TextChanged -= value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _currentValue += Leap;

            if (_currentValue > MaximumValue)
                _currentValue = MinimumValue;

            UpdateTextBoxValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _currentValue -= Leap;

            if (_currentValue < MinimumValue)
                _currentValue = (MaximumValue / _leap) * _leap;

            UpdateTextBoxValue();
        }

        private void UpdateTextBoxValue()
        {
            textBox1.Text = _currentValue.ToString();
        }
    }
}
