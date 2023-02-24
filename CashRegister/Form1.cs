using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double carrotNumber, potatoNumber, beanNumber, subTotalCost, totalCost, taxAmount, tenderedAmount, changeAmount;
        int orderNumber;
        const double carrotPrice = 0.99;
        const double potatoPrice = 1.49;
        const double beanPrice = 0.1;
        const double taxRate = 0.13;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            carrotNumber = Convert.ToDouble(carrotInput.Text);
            potatoNumber = Convert.ToDouble(potatoInput.Text);
            beanNumber = Convert.ToDouble(beanInput.Text);

            subTotalCost = (carrotNumber * carrotPrice) + (potatoNumber * potatoPrice) +(beanNumber * beanPrice);
            taxAmount = subTotalCost * taxRate;
            totalCost = subTotalCost + taxAmount;

            subTotalOutput.Text = subTotalCost.ToString("C");
            taxOutput.Text = taxAmount.ToString("C");
            totalOutput.Text = totalCost.ToString("C");
        }
        
        private void changeButton_Click(object sender, EventArgs e)
        {
            tenderedAmount = Convert.ToDouble(tenderedInput.Text);
            changeAmount = tenderedAmount - totalCost;

            if (changeAmount < 0)
            {
                changeOutput.Text = $"Not enough!";
            }
            else
            {
                changeOutput.Text = changeAmount.ToString("C");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            orderNumber++;

            recieptLabel.Text  =    "\nThe Good Vegetable Store Company";
            recieptLabel.Text += $"\n\nOrder Number {orderNumber}";
            //recieptLabel.Text +=   $"\n{date}";

            recieptLabel.Text += $"\n\nCarrots x{carrotNumber} ";
            double carrots = carrotNumber * carrotPrice;
            recieptLabel.Text += carrots.ToString("C");

            recieptLabel.Text += $"\n\nPotatoes x{potatoNumber} ";
            double potatoes = potatoNumber * potatoPrice;
            recieptLabel.Text += potatoes.ToString("C");

            recieptLabel.Text += $"\n\nBeans x{beanNumber} ";
            double beans = beanNumber * beanPrice;
            recieptLabel.Text += beans.ToString("C");

        }

    }
}
