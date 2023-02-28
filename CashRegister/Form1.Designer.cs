namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.carrotLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.beanLabel = new System.Windows.Forms.Label();
            this.potatoLabel = new System.Windows.Forms.Label();
            this.carrotInput = new System.Windows.Forms.TextBox();
            this.beanInput = new System.Windows.Forms.TextBox();
            this.potatoInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Green;
            this.titleLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-2, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(416, 66);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "The Good Vegetable Store";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carrotLabel
            // 
            this.carrotLabel.AutoSize = true;
            this.carrotLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrotLabel.Location = new System.Drawing.Point(22, 100);
            this.carrotLabel.Name = "carrotLabel";
            this.carrotLabel.Size = new System.Drawing.Size(204, 26);
            this.carrotLabel.TabIndex = 1;
            this.carrotLabel.Text = "Number of Carrots:";
            this.carrotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.receiptLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(443, 87);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(307, 486);
            this.receiptLabel.TabIndex = 2;
            // 
            // beanLabel
            // 
            this.beanLabel.AutoSize = true;
            this.beanLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beanLabel.Location = new System.Drawing.Point(22, 184);
            this.beanLabel.Name = "beanLabel";
            this.beanLabel.Size = new System.Drawing.Size(193, 26);
            this.beanLabel.TabIndex = 3;
            this.beanLabel.Text = "Number of Beans:";
            this.beanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // potatoLabel
            // 
            this.potatoLabel.AutoSize = true;
            this.potatoLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potatoLabel.Location = new System.Drawing.Point(22, 143);
            this.potatoLabel.Name = "potatoLabel";
            this.potatoLabel.Size = new System.Drawing.Size(216, 26);
            this.potatoLabel.TabIndex = 4;
            this.potatoLabel.Text = "Number of Potatoes:";
            this.potatoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // carrotInput
            // 
            this.carrotInput.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrotInput.Location = new System.Drawing.Point(279, 97);
            this.carrotInput.Name = "carrotInput";
            this.carrotInput.Size = new System.Drawing.Size(104, 33);
            this.carrotInput.TabIndex = 5;
            // 
            // beanInput
            // 
            this.beanInput.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beanInput.Location = new System.Drawing.Point(279, 181);
            this.beanInput.Name = "beanInput";
            this.beanInput.Size = new System.Drawing.Size(104, 33);
            this.beanInput.TabIndex = 6;
            // 
            // potatoInput
            // 
            this.potatoInput.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potatoInput.Location = new System.Drawing.Point(279, 140);
            this.potatoInput.Name = "potatoInput";
            this.potatoInput.Size = new System.Drawing.Size(104, 33);
            this.potatoInput.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.BorderSize = 3;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(27, 233);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(356, 41);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(22, 296);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(114, 26);
            this.subTotalLabel.TabIndex = 9;
            this.subTotalLabel.Text = "Sub Total:";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(22, 368);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(70, 26);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(22, 332);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(56, 26);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "Tax:";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BackColor = System.Drawing.Color.White;
            this.subTotalOutput.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(178, 296);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(205, 26);
            this.subTotalOutput.TabIndex = 12;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(178, 332);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(205, 26);
            this.taxOutput.TabIndex = 13;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(178, 368);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(205, 26);
            this.totalOutput.TabIndex = 14;
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.Color.Black;
            this.dividerLabel.Location = new System.Drawing.Point(27, 413);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(356, 14);
            this.dividerLabel.TabIndex = 15;
            this.dividerLabel.Text = "label1";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(279, 445);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(104, 33);
            this.tenderedInput.TabIndex = 17;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(22, 448);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(113, 26);
            this.tenderedLabel.TabIndex = 16;
            this.tenderedLabel.Text = "Tendered:";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.Enabled = false;
            this.changeButton.FlatAppearance.BorderSize = 3;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(30, 494);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(353, 41);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.White;
            this.changeOutput.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(173, 547);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(210, 26);
            this.changeOutput.TabIndex = 20;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(22, 547);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(94, 26);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change:";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.White;
            this.printButton.Enabled = false;
            this.printButton.FlatAppearance.BorderSize = 3;
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(27, 587);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(356, 41);
            this.printButton.TabIndex = 21;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(22, 97);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(361, 531);
            this.errorLabel.TabIndex = 22;
            this.errorLabel.Text = "ERROR! Please only write numbers in the text boxes!";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.White;
            this.newOrderButton.FlatAppearance.BorderSize = 3;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(441, 587);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(309, 41);
            this.newOrderButton.TabIndex = 23;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(411, 652);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.potatoInput);
            this.Controls.Add(this.beanInput);
            this.Controls.Add(this.carrotInput);
            this.Controls.Add(this.potatoLabel);
            this.Controls.Add(this.beanLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.carrotLabel);
            this.Controls.Add(this.titleLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label carrotLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label beanLabel;
        private System.Windows.Forms.Label potatoLabel;
        private System.Windows.Forms.TextBox carrotInput;
        private System.Windows.Forms.TextBox beanInput;
        private System.Windows.Forms.TextBox potatoInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

