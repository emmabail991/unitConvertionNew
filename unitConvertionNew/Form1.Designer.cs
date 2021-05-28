
namespace unitConvertionNew
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
            this.titelLabel = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.convertedNumber = new System.Windows.Forms.Label();
            this.convertionChoiceLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.conversionChoice = new System.Windows.Forms.TextBox();
            this.convertionNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titelLabel
            // 
            this.titelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelLabel.Location = new System.Drawing.Point(30, 9);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(315, 52);
            this.titelLabel.TabIndex = 0;
            this.titelLabel.Text = "Linear Conversion";
            this.titelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel1
            // 
            this.infoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel1.Location = new System.Drawing.Point(76, 61);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(211, 21);
            this.infoLabel1.TabIndex = 1;
            this.infoLabel1.Text = "1. Inches to Centimetres";
            // 
            // convertedNumber
            // 
            this.convertedNumber.AutoSize = true;
            this.convertedNumber.Location = new System.Drawing.Point(78, 204);
            this.convertedNumber.Name = "convertedNumber";
            this.convertedNumber.Size = new System.Drawing.Size(142, 13);
            this.convertedNumber.TabIndex = 3;
            this.convertedNumber.Text = "Enter value to be converted:";
            // 
            // convertionChoiceLabel
            // 
            this.convertionChoiceLabel.AutoSize = true;
            this.convertionChoiceLabel.Location = new System.Drawing.Point(77, 175);
            this.convertionChoiceLabel.Name = "convertionChoiceLabel";
            this.convertionChoiceLabel.Size = new System.Drawing.Size(149, 13);
            this.convertionChoiceLabel.TabIndex = 4;
            this.convertionChoiceLabel.Text = "Enter conversion choice (1-4):";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(80, 234);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(246, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click_1);
            // 
            // conversionChoice
            // 
            this.conversionChoice.Location = new System.Drawing.Point(226, 175);
            this.conversionChoice.Name = "conversionChoice";
            this.conversionChoice.Size = new System.Drawing.Size(100, 20);
            this.conversionChoice.TabIndex = 6;
            // 
            // convertionNumber
            // 
            this.convertionNumber.Location = new System.Drawing.Point(226, 204);
            this.convertionNumber.Name = "convertionNumber";
            this.convertionNumber.Size = new System.Drawing.Size(100, 20);
            this.convertionNumber.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "2. Feet to Centimetres";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "3. Yards to Metres";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "4. Miles to Kilometers";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(80, 260);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(246, 65);
            this.outputLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 334);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertionNumber);
            this.Controls.Add(this.conversionChoice);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertionChoiceLabel);
            this.Controls.Add(this.convertedNumber);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.titelLabel);
            this.Name = "Form1";
            this.Text = "unit convertion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label convertedNumber;
        private System.Windows.Forms.Label convertionChoiceLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox conversionChoice;
        private System.Windows.Forms.TextBox convertionNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outputLabel;
    }
}

