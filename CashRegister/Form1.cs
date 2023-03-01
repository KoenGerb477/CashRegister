/*
 * Koen Gerber
 * ICS3U
 * March 1st, 2023
 * Cash Register Project
 */

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
        //initialize all variables as globel
        double carrotNumber, potatoNumber, beanNumber, subTotalCost, totalCost, taxAmount, tenderedAmount, changeAmount;
        int orderNumber;
        
        //these variables will not change
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

        //calculate prices button
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //try and catch any errors
            try
            {
                //ding sound whenever button pressed
                dingPlayer.Play();

                //take vegetable number inputs
                carrotNumber = Convert.ToDouble(carrotInput.Text);
                potatoNumber = Convert.ToDouble(potatoInput.Text);
                beanNumber = Convert.ToDouble(beanInput.Text);

                //set buy limit so that the alignment of the receipt doesn't get screwed up
                if (carrotNumber >100 || potatoNumber >100 || beanNumber > 1000)
                {
                    errorLabel.Text = "Not enough stock! Buy less!";
                    errorLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(1000);
                    errorLabel.Visible = false;
                }
                else
                {
                    //calculate all outputs
                    subTotalCost = (carrotNumber * carrotPrice) + (potatoNumber * potatoPrice) +(beanNumber * beanPrice);
                    taxAmount = subTotalCost * taxRate;
                    totalCost = subTotalCost + taxAmount;

                    //Display all outputs
                    subTotalOutput.Text = subTotalCost.ToString("C");
                    taxOutput.Text = taxAmount.ToString("C");
                    totalOutput.Text = totalCost.ToString("C");

                    //enable next button
                    changeButton.Enabled = true;
                    printButton.Enabled = false;
                }
            }
            catch
            {
                //display error message
                errorLabel.Text = "ERROR! Please write numbers in the text boxes!";
                errorLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(1000);
                errorLabel.Visible = false;
            }
        }

        //when calculate change button is pressed
        private void changeButton_Click(object sender, EventArgs e)
        {
            //try and catch any errors
            try {
            //ding when button pressed
            dingPlayer.Play();

            //input tendered and calculate change
            tenderedAmount = Convert.ToDouble(tenderedInput.Text);
            changeAmount = tenderedAmount - totalCost;

            //see if they paid enough money
            if (changeAmount < 0)
            {
                    //if not enough money give them an error message
                    errorLabel.Text = "ERROR! Give me more money brokie!";
                    errorLabel.Visible = true;
                    this.Refresh();
                    Thread.Sleep(1000);
                    errorLabel.Visible = false;
              
            }
            else
            {
                // if enough money display change amount and enable next button
                changeOutput.Text = changeAmount.ToString("C");
                printButton.Enabled = true;
            }
        }
            catch
            {
                //if letters are used display an error
                errorLabel.Text = "ERROR! Please write numbers in the text boxes!";
                errorLabel.Visible = true;
                this.Refresh();
                Thread.Sleep(1000);
                errorLabel.Visible = false;
            }
        }

        //when print button is pressed...
        private void printButton_Click(object sender, EventArgs e)
        {
            //print sound while receipt is printing
            printPlayer.Play();

            //adjust screen and title size to show receipt
            this.Width = 600;
            titleLabel.Width = this.Width;

            //delay time for the speed the receipt prints
            int delayTime = 200;
            //every time a receipt is printed the order number increases
            orderNumber++;
            
            //PRINTING OF RECEIPT
            receiptLabel.Text  =    "\n    Good Vegetables";

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nApril 1st, 2053";

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nOrder Number {orderNumber}";

            this.Refresh();
            Thread.Sleep(delayTime);


            receiptLabel.Text += $"\n\nCarrots  x{carrotNumber}  ";
            double carrots = carrotNumber * carrotPrice;
            receipt2Label.Text += carrots.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nPotatoes x{potatoNumber}  ";
            double potatoes = potatoNumber * potatoPrice;
            receipt2Label.Text += "\n";
            receipt2Label.Text += potatoes.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nBeans    x{beanNumber}  ";
            double beans = beanNumber * beanPrice;
            receipt2Label.Text += "\n";
            receipt2Label.Text += beans.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\n\nSubtotal      ";
            receipt2Label.Text += "\n\n";
            receipt2Label.Text += subTotalCost.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nTax           ";
            receipt2Label.Text += "\n";
            receipt2Label.Text += taxAmount.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nTotal         ";
            receipt2Label.Text += "\n";
            receipt2Label.Text += totalCost.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\n\nTendered      ";
            receipt2Label.Text += "\n\n";
            receipt2Label.Text += tenderedAmount.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);

            receiptLabel.Text += $"\nChange        ";
            receipt2Label.Text += "\n";
            receipt2Label.Text += changeAmount.ToString("C");

            this.Refresh();
            Thread.Sleep(delayTime);
            receiptLabel.Text += "\n\nBye, have a great day!";

            //disable all buttons so that the new order button must be pressed
            printButton.Enabled = false;
            changeButton.Enabled = false;
            calculateButton.Enabled = false;
        }

        //reset everything to default when new order button is pressed
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            dingPlayer.Play();

            ////Reset the program to how it was at the beginning

            //reset the form and title size
            this.Width = 325;
            titleLabel.Width = this.Width;
            
            //empty all input/output labels/text boxes
            subTotalOutput.Text = "";
            totalOutput.Text = "";
            taxOutput.Text = "";
            changeOutput.Text = "";
            carrotInput.Text = "";
            potatoInput.Text = "";
            beanInput.Text = "";
            tenderedInput.Text = "";
            receiptLabel.Text = "";
            receipt2Label.Text = "";

            //set all variables to 0
            carrotNumber = 0;
            potatoNumber = 0;
            beanNumber = 0;
            subTotalCost = 0;
            totalCost = 0;
            taxAmount = 0;
            tenderedAmount = 0;
            changeAmount = 0;

            //enable/disable buttons
            changeButton.Enabled = false;
            printButton.Enabled = false;
            calculateButton.Enabled = true;
        }
    }
}
