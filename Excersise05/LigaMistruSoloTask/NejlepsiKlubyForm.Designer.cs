namespace LigaMistruSoloTask
{
    partial class NejlepsiKlubyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GolyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.KlubyListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Počet max gólů:";
            // 
            // GolyTextBox
            // 
            this.GolyTextBox.Enabled = false;
            this.GolyTextBox.Location = new System.Drawing.Point(102, 10);
            this.GolyTextBox.Name = "GolyTextBox";
            this.GolyTextBox.Size = new System.Drawing.Size(100, 20);
            this.GolyTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KlubyListBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kluby";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(127, 212);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // KlubyListBox
            // 
            this.KlubyListBox.FormattingEnabled = true;
            this.KlubyListBox.Location = new System.Drawing.Point(7, 20);
            this.KlubyListBox.Name = "KlubyListBox";
            this.KlubyListBox.Size = new System.Drawing.Size(195, 147);
            this.KlubyListBox.TabIndex = 0;
            // 
            // NejlepsiKlubyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 247);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GolyTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NejlepsiKlubyForm";
            this.Text = "Nejlepší Kluby";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GolyTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ListBox KlubyListBox;
    }
}