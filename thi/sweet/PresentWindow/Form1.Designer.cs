namespace PresentWindow
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.totalWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addButton.Location = new System.Drawing.Point(58, 116);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 56);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.AliceBlue;
            this.editButton.Location = new System.Drawing.Point(58, 206);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 57);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Ivory;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(311, 97);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(410, 308);
            this.listBox.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Lavender;
            this.deleteButton.Location = new System.Drawing.Point(58, 287);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 56);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // totalWeight
            // 
            this.totalWeight.AutoSize = true;
            this.totalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalWeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalWeight.Location = new System.Drawing.Point(464, 438);
            this.totalWeight.Name = "totalWeight";
            this.totalWeight.Size = new System.Drawing.Size(23, 25);
            this.totalWeight.TabIndex = 4;
            this.totalWeight.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(322, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Weight =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(312, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calories =";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.caloriesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.caloriesLabel.Location = new System.Drawing.Point(464, 474);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(23, 25);
            this.caloriesLabel.TabIndex = 6;
            this.caloriesLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(778, 575);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalWeight);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label totalWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label caloriesLabel;
    }
}

