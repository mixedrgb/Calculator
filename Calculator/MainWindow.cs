using System.Data;
using System.Drawing.Text;

namespace Calculator
{
    public partial class MainWindow : Form
    {

        private string _calc = "";

        public MainWindow()
        {
            InitializeComponent();
            resultBox.Text = "0";
        }

        private void button_Click(object sender, EventArgs e)
        {
            _calc += (sender as Button).Text;
            resultBox.Text = _calc;
        }

        private void clearClick(object sender, EventArgs e)
        {
            _calc = "";
            resultBox.Text = "0";
        }

        private void buttonEqualsClick(object sender, EventArgs e)
        {
            string formattedCalc = _calc.ToString();

            try
            {
                resultBox.Text = new DataTable().Compute(formattedCalc, null).ToString();
            }
            catch (Exception ex)
            {
                resultBox.Text = "0";
                _calc = "";
            }
        }
    }
}