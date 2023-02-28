using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Media;
using System.Runtime.CompilerServices;

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
        SoundPlayer printPlayer = new SoundPlayer(Properties.Resources.printingSound);
        SoundPlayer dingPlayer = new SoundPlayer(Properties.Resources.dingSound);


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                dingPlayer.Play();


                carrotNumber = Convert.ToDouble(carrotInput.Text);
                potatoNumber = Convert.ToDouble(potatoInput.Text);
                beanNumber = Convert.ToDouble(beanInput.Text);

                subTotalCost = (carrotNumber * carrotPrice) + (potatoNumber * potatoPrice) +(beanNumber * beanPrice);
                taxAmount = subTotalCost * taxRate;
                totalCost = subTotalCost + taxAmount;

                subTotalOutput.Text = subTotalCost.ToString("C");
                taxOutput.Text = taxAmount.ToString("C");
                totalOutput.Text = totalCost.ToString("C");
                changeButton.Enabled = true;
                printButton.Enabled = false;
            }
            catch
            {
                errorLabel.Text = "ERROR! Please write numbers in the text boxes!";
                errorLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(1000);
                errorLabel.Visible = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try {
            dingPlayer.Play();


            tenderedAmount = Convert.ToDouble(tenderedInput.Text);
            changeAmount = tenderedAmount - totalCost;

            if (changeAmount < 0)
            {
                    errorLabel.Text = "ERROR! Give me more money!";
                    errorLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(1000);
                    errorLabel.Visible = false;
              
            }
            else
            {
                changeOutput.Text = changeAmount.ToString("C");
                printButton.Enabled = true;
            }
        }
            catch
            {
                errorLabel.Text = "ERROR! Please write numbers in the text boxes!";
                errorLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(1000);
                errorLabel.Visible = false;
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            dingPlayer.Play();

            printPlayer.Play();

            this.Width = 600;
            titleLabel.Width = this.Width;

            int delayTime = 200;
            orderNumber++;

            receiptLabel.Text  =    "\n    Good Vegetables";

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\n\n     Order Number {orderNumber}";

            this.Refresh();
            Thread.Sleep(delayTime);


            receiptLabel.Text += $"\n\nCarrots  x{carrotNumber}  ";
            double carrots = carrotNumber * carrotPrice;
            receiptLabel.Text += carrots.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nPotatoes x{potatoNumber}  ";
            double potatoes = potatoNumber * potatoPrice;
            receiptLabel.Text += potatoes.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nBeans    x{beanNumber}  ";
            double beans = beanNumber * beanPrice;
            receiptLabel.Text += beans.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\n\nSubtotal     ";
            receiptLabel.Text += subTotalCost.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nTax          ";
            receiptLabel.Text += taxAmount.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nTotal        ";
            receiptLabel.Text += totalCost.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\n\nTendered     ";
            receiptLabel.Text += tenderedAmount.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nChange       ";
            receiptLabel.Text += changeAmount.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);
            receiptLabel.Text += "\n\nBye, have a great day!";

            printButton.Enabled = false;
            changeButton.Enabled = false;
            calculateButton.Enabled = false;
        }


        private void newOrderButton_Click(object sender, EventArgs e)
        {
            dingPlayer.Play();


            this.Width = 325;
            titleLabel.Width = this.Width;
            subTotalOutput.Text = "";
            totalOutput.Text = "";
            taxOutput.Text = "";
            changeButton.Enabled = false;
            changeOutput.Text = "";
            printButton.Enabled = false;

            carrotNumber = 0;
            potatoNumber = 0;
            beanNumber = 0; 
            subTotalCost = 0;
            totalCost = 0;
            taxAmount = 0; 
            tenderedAmount = 0; 
            changeAmount = 0;
            carrotInput.Text = "";
            potatoInput.Text = "";
            beanInput.Text = "";
            tenderedInput.Text = "";

            changeButton.Enabled = false;
            printButton.Enabled = false;
            calculateButton.Enabled = true;
        }


    }
}
