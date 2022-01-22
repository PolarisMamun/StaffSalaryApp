using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffSalaryApp
{
    //Practice: Bonus Calculator
    public partial class Form1 : Form
    {
        public static double salary;
        public static double bonus;
        public static double totalSalary;
        public Form1()
        {
            InitializeComponent();
        }

        private void showTotalSalaryButton_Click(object sender, EventArgs e)
        {
            salary = Convert.ToDouble(basicSalaryTextBox.Text);

            if (salary > 10000)
            {
                bonus = (salary * 0.05);
                bonusTextBox.Text = bonus.ToString();
                totalSalary = salary + bonus;
                totalSalaryTextBox.Text = totalSalary.ToString();

            }
            else if (salary <= 10000 && salary >= 8000)
            {
                bonus = (salary * 0.06);
                bonusTextBox.Text = bonus.ToString();
                totalSalary = salary + bonus;

                totalSalaryTextBox.Text = totalSalary.ToString();

            }
            else
            {
                bonus = (salary * 0.07);
                bonusTextBox.Text = bonus.ToString();

                totalSalary = salary + bonus;
                totalSalaryTextBox.Text = totalSalary.ToString();

            }
        }
    }
}
