
namespace AverageValues
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
            this.RedBox = new System.Windows.Forms.Label();
            this.AverageNumberSolver = new System.Windows.Forms.Label();
            this.EnterANumber = new System.Windows.Forms.Label();
            this.CalculateChangeText = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RedBox
            // 
            this.RedBox.BackColor = System.Drawing.Color.Red;
            this.RedBox.Location = new System.Drawing.Point(0, 0);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(903, 106);
            this.RedBox.TabIndex = 0;
            // 
            // AverageNumberSolver
            // 
            this.AverageNumberSolver.AutoSize = true;
            this.AverageNumberSolver.BackColor = System.Drawing.Color.Red;
            this.AverageNumberSolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageNumberSolver.ForeColor = System.Drawing.Color.White;
            this.AverageNumberSolver.Location = new System.Drawing.Point(174, 27);
            this.AverageNumberSolver.Name = "AverageNumberSolver";
            this.AverageNumberSolver.Size = new System.Drawing.Size(502, 51);
            this.AverageNumberSolver.TabIndex = 1;
            this.AverageNumberSolver.Text = "Average Number Solver";
            // 
            // EnterANumber
            // 
            this.EnterANumber.AutoSize = true;
            this.EnterANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterANumber.ForeColor = System.Drawing.Color.White;
            this.EnterANumber.Location = new System.Drawing.Point(177, 146);
            this.EnterANumber.Name = "EnterANumber";
            this.EnterANumber.Size = new System.Drawing.Size(391, 31);
            this.EnterANumber.TabIndex = 2;
            this.EnterANumber.Text = "Enter a Number And Press Add";
            // 
            // CalculateChangeText
            // 
            this.CalculateChangeText.AutoSize = true;
            this.CalculateChangeText.ForeColor = System.Drawing.Color.White;
            this.CalculateChangeText.Location = new System.Drawing.Point(154, 215);
            this.CalculateChangeText.Name = "CalculateChangeText";
            this.CalculateChangeText.Size = new System.Drawing.Size(438, 25);
            this.CalculateChangeText.TabIndex = 3;
            this.CalculateChangeText.Text = "(Enter 0 and press add to calculate average)";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(231, 306);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 31);
            this.InputTextBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Black;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(354, 295);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 53);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(159, 442);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(500, 80);
            this.OutputTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(723, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(891, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.CalculateChangeText);
            this.Controls.Add(this.EnterANumber);
            this.Controls.Add(this.AverageNumberSolver);
            this.Controls.Add(this.RedBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RedBox;
        private System.Windows.Forms.Label AverageNumberSolver;
        private System.Windows.Forms.Label EnterANumber;
        private System.Windows.Forms.Label CalculateChangeText;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button button1;
    }
}

