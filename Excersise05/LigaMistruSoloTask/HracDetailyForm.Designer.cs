namespace LigaMistruSoloTask
{
    partial class HracDetailyForm
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
            this.JmenoLabel = new System.Windows.Forms.Label();
            this.KlubLabel = new System.Windows.Forms.Label();
            this.GolyLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.JmenoTextBox = new System.Windows.Forms.TextBox();
            this.KlubComboBox = new System.Windows.Forms.ComboBox();
            this.GolyTextBox = new System.Windows.Forms.TextBox();
            this.ZrusitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JmenoLabel
            // 
            this.JmenoLabel.AutoSize = true;
            this.JmenoLabel.Location = new System.Drawing.Point(12, 9);
            this.JmenoLabel.Name = "JmenoLabel";
            this.JmenoLabel.Size = new System.Drawing.Size(38, 13);
            this.JmenoLabel.TabIndex = 0;
            this.JmenoLabel.Text = "Jméno";
            // 
            // KlubLabel
            // 
            this.KlubLabel.AutoSize = true;
            this.KlubLabel.Location = new System.Drawing.Point(12, 43);
            this.KlubLabel.Name = "KlubLabel";
            this.KlubLabel.Size = new System.Drawing.Size(28, 13);
            this.KlubLabel.TabIndex = 1;
            this.KlubLabel.Text = "Klub";
            // 
            // GolyLabel
            // 
            this.GolyLabel.AutoSize = true;
            this.GolyLabel.Location = new System.Drawing.Point(12, 81);
            this.GolyLabel.Name = "GolyLabel";
            this.GolyLabel.Size = new System.Drawing.Size(28, 13);
            this.GolyLabel.TabIndex = 2;
            this.GolyLabel.Text = "Góly";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(15, 114);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // JmenoTextBox
            // 
            this.JmenoTextBox.Location = new System.Drawing.Point(116, 6);
            this.JmenoTextBox.Name = "JmenoTextBox";
            this.JmenoTextBox.Size = new System.Drawing.Size(121, 20);
            this.JmenoTextBox.TabIndex = 4;
            // 
            // KlubComboBox
            // 
            this.KlubComboBox.FormattingEnabled = true;
            this.KlubComboBox.Location = new System.Drawing.Point(116, 40);
            this.KlubComboBox.Name = "KlubComboBox";
            this.KlubComboBox.Size = new System.Drawing.Size(121, 21);
            this.KlubComboBox.TabIndex = 5;
            // 
            // GolyTextBox
            // 
            this.GolyTextBox.Location = new System.Drawing.Point(116, 78);
            this.GolyTextBox.Name = "GolyTextBox";
            this.GolyTextBox.Size = new System.Drawing.Size(121, 20);
            this.GolyTextBox.TabIndex = 6;
            // 
            // ZrusitButton
            // 
            this.ZrusitButton.Location = new System.Drawing.Point(116, 114);
            this.ZrusitButton.Name = "ZrusitButton";
            this.ZrusitButton.Size = new System.Drawing.Size(75, 23);
            this.ZrusitButton.TabIndex = 7;
            this.ZrusitButton.Text = "Zrušit";
            this.ZrusitButton.UseVisualStyleBackColor = true;
            this.ZrusitButton.Click += new System.EventHandler(this.ZrusitButton_Click);
            // 
            // NovyHracForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 156);
            this.Controls.Add(this.ZrusitButton);
            this.Controls.Add(this.GolyTextBox);
            this.Controls.Add(this.KlubComboBox);
            this.Controls.Add(this.JmenoTextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.GolyLabel);
            this.Controls.Add(this.KlubLabel);
            this.Controls.Add(this.JmenoLabel);
            this.Name = "NovyHracForm";
            this.Text = "Nový Hráč";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JmenoLabel;
        private System.Windows.Forms.Label KlubLabel;
        private System.Windows.Forms.Label GolyLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox JmenoTextBox;
        private System.Windows.Forms.ComboBox KlubComboBox;
        private System.Windows.Forms.TextBox GolyTextBox;
        private System.Windows.Forms.Button ZrusitButton;
    }
}