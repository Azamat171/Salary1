using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//базовые параметры 
            double salaryValue = 0, // окад/оклад за час/оклад
                    workTimeValue = 0, // коэффициент премии/рабочие часы/кол-во сделок
                    additionalFactorValue = 0;//размер премии/сверурочные часы/бонус за сделку
            BL.Counter counter = null;
            try
            {//проверка, дурак ли пользователь или нет
                salaryValue = Convert.ToDouble(textBox1.Text);
                workTimeValue = Convert.ToDouble(textBox2.Text);
                additionalFactorValue = Convert.ToDouble(textBox3.Text);

                counter = new BL.Counter(typeTextBox.Text, salaryValue, workTimeValue, additionalFactorValue);
            }
            catch (FormatException ex)
            {//пользователь не умеет писать числа
                resultLabel.Text = "Data error!"; return;
            }
            catch (ArgumentNullException ex)
            {//пользователь не умеет писать тпы рабочих
                resultLabel.Text = "Employee type error!"; return;
            }
            
            resultLabel.Text = "Result: " + counter.CountSalary()+"$";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
