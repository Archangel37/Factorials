using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Factorials
{
    public partial class FormFact : Form
    {
        public FormFact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";

            if (!String.IsNullOrWhiteSpace(richTextBoxNum.Text))
            {
                DateTime StartTime =  DateTime.Now;
                try
                {
                    BigInteger number = BigInteger.Parse(richTextBoxNum.Text);

                    BigInteger Factorial = new System.Numerics.BigInteger();
                    Factorial = 1;

                    BigInteger i = new System.Numerics.BigInteger();//аккуратнее, в цикле используется ++, если будут ошибки заменить на BigInteger.Add(BigInt,BigInt)

                    for (i = 1; i <= number; i++)
                    {
                        Factorial = BigInteger.Multiply(Factorial, i);

                    }

                    DateTime EndTime = DateTime.Now;
                    richTextBoxResult.Text += "Calculation time without Threading: " + (EndTime - StartTime).ToString("g") + Environment.NewLine;
                        //Convert.ToString(EndTime - StartTime, "HH:mm:ss.fffff");
                    richTextBoxResult.Text += Convert.ToString(Factorial);
                }
                catch (ArgumentException)
                {
                    richTextBoxResult.Text = "Incorrect data entry";
                
                }

                catch (FormatException)
                {
                    richTextBoxResult.Text = "Incorrect data entry, FormatException";
                }
               
                catch (System.OverflowException)
                {
                    richTextBoxResult.Text = "Incorrect data entry, OverflowException";
                }


            }
        }
    }
}
