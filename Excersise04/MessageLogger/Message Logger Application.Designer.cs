namespace MessageLogger
{
    partial class MessageLoggerApplication
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
            this.button_send = new System.Windows.Forms.Button();
            this.checkBox_leftPanel = new System.Windows.Forms.CheckBox();
            this.checkBox_rightPanel = new System.Windows.Forms.CheckBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_leftPanel = new System.Windows.Forms.TextBox();
            this.textBox_rightPanel = new System.Windows.Forms.TextBox();
            this.groupBox_leftOutput = new System.Windows.Forms.GroupBox();
            this.groupBox_rightOutput = new System.Windows.Forms.GroupBox();
            this.groupBox_leftOutput.SuspendLayout();
            this.groupBox_rightOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(276, 136);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button_send_click);
            // 
            // checkBox_leftPanel
            // 
            this.checkBox_leftPanel.AutoSize = true;
            this.checkBox_leftPanel.Location = new System.Drawing.Point(104, 12);
            this.checkBox_leftPanel.Name = "checkBox_leftPanel";
            this.checkBox_leftPanel.Size = new System.Drawing.Size(74, 17);
            this.checkBox_leftPanel.TabIndex = 1;
            this.checkBox_leftPanel.Text = "Left Panel";
            this.checkBox_leftPanel.UseVisualStyleBackColor = true;
            this.checkBox_leftPanel.CheckedChanged += new System.EventHandler(this.OutputEnabledCheckBox_CheckedChanged);
            // 
            // checkBox_rightPanel
            // 
            this.checkBox_rightPanel.AutoSize = true;
            this.checkBox_rightPanel.Location = new System.Drawing.Point(422, 12);
            this.checkBox_rightPanel.Name = "checkBox_rightPanel";
            this.checkBox_rightPanel.Size = new System.Drawing.Size(81, 17);
            this.checkBox_rightPanel.TabIndex = 0;
            this.checkBox_rightPanel.Text = "Right Panel";
            this.checkBox_rightPanel.UseVisualStyleBackColor = true;
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(159, 35);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(299, 95);
            this.textBox_input.TabIndex = 2;
            // 
            // textBox_leftPanel
            // 
            this.textBox_leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_leftPanel.Enabled = false;
            this.textBox_leftPanel.Location = new System.Drawing.Point(3, 16);
            this.textBox_leftPanel.Multiline = true;
            this.textBox_leftPanel.Name = "textBox_leftPanel";
            this.textBox_leftPanel.Size = new System.Drawing.Size(293, 220);
            this.textBox_leftPanel.TabIndex = 0;
            // 
            // textBox_rightPanel
            // 
            this.textBox_rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_rightPanel.Enabled = false;
            this.textBox_rightPanel.Location = new System.Drawing.Point(3, 16);
            this.textBox_rightPanel.Multiline = true;
            this.textBox_rightPanel.Name = "textBox_rightPanel";
            this.textBox_rightPanel.Size = new System.Drawing.Size(288, 220);
            this.textBox_rightPanel.TabIndex = 0;
            // 
            // groupBox_leftOutput
            // 
            this.groupBox_leftOutput.Controls.Add(this.textBox_leftPanel);
            this.groupBox_leftOutput.Location = new System.Drawing.Point(12, 199);
            this.groupBox_leftOutput.Name = "groupBox_leftOutput";
            this.groupBox_leftOutput.Size = new System.Drawing.Size(299, 239);
            this.groupBox_leftOutput.TabIndex = 3;
            this.groupBox_leftOutput.TabStop = false;
            this.groupBox_leftOutput.Text = "Left Output";
            // 
            // groupBox_rightOutput
            // 
            this.groupBox_rightOutput.Controls.Add(this.textBox_rightPanel);
            this.groupBox_rightOutput.Location = new System.Drawing.Point(317, 199);
            this.groupBox_rightOutput.Name = "groupBox_rightOutput";
            this.groupBox_rightOutput.Size = new System.Drawing.Size(294, 239);
            this.groupBox_rightOutput.TabIndex = 4;
            this.groupBox_rightOutput.TabStop = false;
            this.groupBox_rightOutput.Text = "Right Output";
            // 
            // MessageLoggerApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.checkBox_leftPanel);
            this.Controls.Add(this.groupBox_rightOutput);
            this.Controls.Add(this.checkBox_rightPanel);
            this.Controls.Add(this.groupBox_leftOutput);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_input);
            this.Name = "MessageLoggerApplication";
            this.Text = "Message Logger Application";
            this.groupBox_leftOutput.ResumeLayout(false);
            this.groupBox_leftOutput.PerformLayout();
            this.groupBox_rightOutput.ResumeLayout(false);
            this.groupBox_rightOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.CheckBox checkBox_leftPanel;
        private System.Windows.Forms.CheckBox checkBox_rightPanel;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_leftPanel;
        private System.Windows.Forms.TextBox textBox_rightPanel;
        private System.Windows.Forms.GroupBox groupBox_leftOutput;
        private System.Windows.Forms.GroupBox groupBox_rightOutput;
    }
}

