using System;
using System.Windows;
using System.Windows.Controls;


namespace SLCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _atr;
        private int _sign;
        private int _bid;
        private double _slSetting;
        private double _tpSetting;
        public MainWindow()
        {
            InitializeComponent();
            InitializeValues();
        }

        private void InitializeValues()
        {
            SetAtr();
            SetSign();
            SetBid();
            SetSlSetting();
            SetTpSetting();
        }

        private void SetTpSetting()
        {
            try
            {
                _tpSetting = ScrollBarTpSetting.Value;
                if (LabelTp != null)
                {
                    LabelTp.Content = _tpSetting;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _tpSetting = 2;
            }
        }

        private void SetSlSetting()
        {
            try
            {
                _slSetting = ScrollBarSlSetting.Value;
                if (LabelSl != null)
                {
                    LabelSl.Content = _slSetting;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _slSetting = 0.5;
            }

        }

        private void SetBid()
        {
            try
            {
                _bid = Convert.ToInt32(TextBoxBid.Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _bid = 0;
            }
        }

        private void SetAtr()
        {
            try
            {
                _atr = Convert.ToInt32(TextBoxAtr.Text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _atr = 0;
            }
        }
        private void SetSign()
        {
            if (ComboBoxDirection.SelectedIndex == 0)
            {
                _sign = 1;
            }
            else
            {
                _sign = -1;
            }
        }

        protected void textBoxATR_TextChanged(object sender, EventArgs e)
        {
            SetAtr();
            CalculateTpSl();
        }

        protected void comboBoxDirection_SelectionChanged(object sender, EventArgs e)
        {
            SetSign();
            CalculateTpSl();
        }

        protected void textBoxBid_TextChanged(object sender, EventArgs e)
        {
            SetBid();
            CalculateTpSl();
        }

        protected void sl_setting_ValueChanged(Object sender,
            EventArgs e)
        {
            SetSlSetting();
            CalculateTpSl();
        }

        protected void tp_setting_ValueChanged(Object sender,
            EventArgs e)
        {
            SetTpSetting();
            CalculateTpSl();
        }

        private void CalculateTpSl()
        {
            if (TextBoxSlOut == null || TextBoxTpOut == null)
            {
                return;
            }
            TextBoxSlOut.Text = Convert.ToString(_bid - (int)(_sign * _atr * _slSetting));
            TextBoxTpOut.Text = Convert.ToString(_bid + (int)(_sign * _atr * _tpSetting));
        }

    }

}
