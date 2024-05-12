namespace PresentWindow
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chooseButton = new System.Windows.Forms.Button();
            this.waffleRadio = new System.Windows.Forms.RadioButton();
            this.chocolateRadio = new System.Windows.Forms.RadioButton();
            this.candyRadio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.Cal = new System.Windows.Forms.Label();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.choose3Button = new System.Windows.Forms.Button();
            this.chocolateCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chooseButton);
            this.panel1.Controls.Add(this.waffleRadio);
            this.panel1.Controls.Add(this.chocolateRadio);
            this.panel1.Controls.Add(this.candyRadio);
            this.panel1.Location = new System.Drawing.Point(101, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 269);
            this.panel1.TabIndex = 0;
            // 
            // chooseButton
            // 
            this.chooseButton.BackColor = System.Drawing.Color.GhostWhite;
            this.chooseButton.Location = new System.Drawing.Point(13, 185);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(105, 39);
            this.chooseButton.TabIndex = 1;
            this.chooseButton.Text = "choose";
            this.chooseButton.UseVisualStyleBackColor = false;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // waffleRadio
            // 
            this.waffleRadio.AutoSize = true;
            this.waffleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.waffleRadio.Location = new System.Drawing.Point(13, 119);
            this.waffleRadio.Name = "waffleRadio";
            this.waffleRadio.Size = new System.Drawing.Size(78, 24);
            this.waffleRadio.TabIndex = 2;
            this.waffleRadio.Text = "Waffle";
            this.waffleRadio.UseVisualStyleBackColor = true;
            // 
            // chocolateRadio
            // 
            this.chocolateRadio.AutoSize = true;
            this.chocolateRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chocolateRadio.Location = new System.Drawing.Point(13, 71);
            this.chocolateRadio.Name = "chocolateRadio";
            this.chocolateRadio.Size = new System.Drawing.Size(105, 24);
            this.chocolateRadio.TabIndex = 1;
            this.chocolateRadio.Text = "Chocolate";
            this.chocolateRadio.UseVisualStyleBackColor = true;
            // 
            // candyRadio
            // 
            this.candyRadio.AutoSize = true;
            this.candyRadio.Checked = true;
            this.candyRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.candyRadio.Location = new System.Drawing.Point(13, 24);
            this.candyRadio.Name = "candyRadio";
            this.candyRadio.Size = new System.Drawing.Size(77, 24);
            this.candyRadio.TabIndex = 0;
            this.candyRadio.TabStop = true;
            this.candyRadio.Text = "Candy";
            this.candyRadio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chocolateCheckBox);
            this.panel2.Controls.Add(this.choose3Button);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.caloriesTextBox);
            this.panel2.Controls.Add(this.Cal);
            this.panel2.Controls.Add(this.weightTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(447, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 269);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(97, 69);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(138, 22);
            this.weightTextBox.TabIndex = 1;
            // 
            // Cal
            // 
            this.Cal.AutoSize = true;
            this.Cal.Location = new System.Drawing.Point(22, 110);
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(57, 16);
            this.Cal.TabIndex = 2;
            this.Cal.Text = "Calories";
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Location = new System.Drawing.Point(97, 110);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(138, 22);
            this.caloriesTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filling";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chocolate",
            "Milk",
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(97, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // choose3Button
            // 
            this.choose3Button.BackColor = System.Drawing.Color.GhostWhite;
            this.choose3Button.Location = new System.Drawing.Point(25, 198);
            this.choose3Button.Name = "choose3Button";
            this.choose3Button.Size = new System.Drawing.Size(105, 39);
            this.choose3Button.TabIndex = 6;
            this.choose3Button.Text = "choose";
            this.choose3Button.UseVisualStyleBackColor = false;
            this.choose3Button.Click += new System.EventHandler(this.choose3Button_Click);
            // 
            // chocolateCheckBox
            // 
            this.chocolateCheckBox.AutoSize = true;
            this.chocolateCheckBox.Location = new System.Drawing.Point(25, 29);
            this.chocolateCheckBox.Name = "chocolateCheckBox";
            this.chocolateCheckBox.Size = new System.Drawing.Size(97, 20);
            this.chocolateCheckBox.TabIndex = 7;
            this.chocolateCheckBox.Text = "Chocolate?";
            this.chocolateCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton waffleRadio;
        private System.Windows.Forms.RadioButton chocolateRadio;
        private System.Windows.Forms.RadioButton candyRadio;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.Label Cal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button choose3Button;
        private System.Windows.Forms.CheckBox chocolateCheckBox;
    }
}