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
using System.Threading;

namespace Factorials
{
    public partial class FormFact : Form
    {
        public FormFact()
        {
            InitializeComponent();
        }

        public int number;
        //public BigInteger number;
        public string ResultString;

        void FactorialIteration()
        {
            DateTime StartTime = DateTime.Now;
            BigInteger Factorial = new System.Numerics.BigInteger();
            Factorial = 1;
            //BigInteger i = new System.Numerics.BigInteger();//аккуратнее, в цикле используется ++, если будут ошибки заменить на BigInteger.Add(BigInt,BigInt)
            
            for (int i = 1; i <= number; i++)
            {
                Factorial = BigInteger.Multiply(Factorial, i);
            }
            DateTime EndTime = DateTime.Now;
            ResultString += "Calculation time with Threading (iteration): " + (EndTime - StartTime).ToString("g") + Environment.NewLine;
            // richTextBoxResult.Text += Convert.ToString(Factorial); //закомментим вывод числа
        }


        void FactorialRecursion()
        {
            DateTime StartTimeRecursion = DateTime.Now;
            BigInteger FactorialRecursion = new System.Numerics.BigInteger();
           
            //BigInteger i = new System.Numerics.BigInteger();//аккуратнее, в цикле используется ++, если будут ошибки заменить на BigInteger.Add(BigInt,BigInt)
            if (checkBox_Recursion.Checked == true)
            {
                FactorialRecursion = factorial(number);
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i == 1)
                        FactorialRecursion = 1;
                    else
                        FactorialRecursion *= i;
                }
            }
            DateTime EndTimeRecursion = DateTime.Now;
            ResultString += "Calculation time with Threading (recursion): " + (EndTimeRecursion - StartTimeRecursion).ToString("g") + Environment.NewLine;
            //richTextBoxResult.Text += Convert.ToString(FactorialRecursion); //закомментим вывод числа
        }


        private static BigInteger factorial(int k) //static BigInteger factorial(BigInteger k)
        {
            //BigInteger result;
            if (k > 1) return (factorial(k - 1) * k);
            else return k;
            //if (k == 1)
            //    return 1;
            //else return (factorial(k - 1)* k);
            
        }



        public void button1_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";
            ResultString = "";
            DateTime StartTotal = DateTime.Now;
            try
            {
                number = int.Parse(richTextBoxNum.Text);
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
    
            Thread thread1 = new Thread(FactorialIteration);
            thread1.Start();
            
            Thread thread2 = new Thread(FactorialRecursion);
            thread2.Start();

            thread1.Join();
            thread2.Join();

            DateTime EndTotal = DateTime.Now;
            richTextBoxResult.Text += ResultString + Environment.NewLine;
            richTextBoxResult.Text += "Calculation time Total: " + (EndTotal - StartTotal).ToString("g");
        }
    }
}
