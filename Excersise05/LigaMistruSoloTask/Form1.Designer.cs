namespace LigaMistruSoloTask
{
    partial class LigaMistruForm
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
            this.listHracuDataGridView = new System.Windows.Forms.DataGridView();
            this.PridejButton = new System.Windows.Forms.Button();
            this.VymazButton = new System.Windows.Forms.Button();
            this.UpravitButton = new System.Windows.Forms.Button();
            this.NejlepsiButton = new System.Windows.Forms.Button();
            this.RegistrovatButton = new System.Windows.Forms.Button();
            this.ZrusitButton = new System.Windows.Forms.Button();
            this.KonecButton = new System.Windows.Forms.Button();
            this.LogyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listHracuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listHracuDataGridView
            // 
            this.listHracuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listHracuDataGridView.Location = new System.Drawing.Point(12, 12);
            this.listHracuDataGridView.Name = "listHracuDataGridView";
            this.listHracuDataGridView.Size = new System.Drawing.Size(531, 200);
            this.listHracuDataGridView.TabIndex = 0;
            // 
            // PridejButton
            // 
            this.PridejButton.Location = new System.Drawing.Point(559, 12);
            this.PridejButton.Name = "PridejButton";
            this.PridejButton.Size = new System.Drawing.Size(75, 23);
            this.PridejButton.TabIndex = 1;
            this.PridejButton.Text = "Přidej";
            this.PridejButton.UseVisualStyleBackColor = true;
            this.PridejButton.Click += new System.EventHandler(this.PridejButton_Click);
            // 
            // VymazButton
            // 
            this.VymazButton.Location = new System.Drawing.Point(559, 42);
            this.VymazButton.Name = "VymazButton";
            this.VymazButton.Size = new System.Drawing.Size(75, 23);
            this.VymazButton.TabIndex = 2;
            this.VymazButton.Text = "Vymaž";
            this.VymazButton.UseVisualStyleBackColor = true;
            this.VymazButton.Click += new System.EventHandler(this.VymazButton_Click);
            // 
            // UpravitButton
            // 
            this.UpravitButton.Location = new System.Drawing.Point(559, 72);
            this.UpravitButton.Name = "UpravitButton";
            this.UpravitButton.Size = new System.Drawing.Size(75, 23);
            this.UpravitButton.TabIndex = 3;
            this.UpravitButton.Text = "Upravit...";
            this.UpravitButton.UseVisualStyleBackColor = true;
            this.UpravitButton.Click += new System.EventHandler(this.UpravitButton_Click);
            // 
            // NejlepsiButton
            // 
            this.NejlepsiButton.Location = new System.Drawing.Point(559, 102);
            this.NejlepsiButton.Name = "NejlepsiButton";
            this.NejlepsiButton.Size = new System.Drawing.Size(75, 23);
            this.NejlepsiButton.TabIndex = 4;
            this.NejlepsiButton.Text = "Nejlepší";
            this.NejlepsiButton.UseVisualStyleBackColor = true;
            this.NejlepsiButton.Click += new System.EventHandler(this.NejlepsiButton_Click);
            // 
            // RegistrovatButton
            // 
            this.RegistrovatButton.Location = new System.Drawing.Point(559, 131);
            this.RegistrovatButton.Name = "RegistrovatButton";
            this.RegistrovatButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrovatButton.TabIndex = 5;
            this.RegistrovatButton.Text = "Registrovat";
            this.RegistrovatButton.UseVisualStyleBackColor = true;
            this.RegistrovatButton.Click += new System.EventHandler(this.RegistrovatButton_Click);
            // 
            // ZrusitButton
            // 
            this.ZrusitButton.Location = new System.Drawing.Point(559, 160);
            this.ZrusitButton.Name = "ZrusitButton";
            this.ZrusitButton.Size = new System.Drawing.Size(75, 23);
            this.ZrusitButton.TabIndex = 6;
            this.ZrusitButton.Text = "Zrušit";
            this.ZrusitButton.UseVisualStyleBackColor = true;
            this.ZrusitButton.Click += new System.EventHandler(this.ZrusitButton_Click);
            // 
            // KonecButton
            // 
            this.KonecButton.Location = new System.Drawing.Point(559, 189);
            this.KonecButton.Name = "KonecButton";
            this.KonecButton.Size = new System.Drawing.Size(75, 23);
            this.KonecButton.TabIndex = 7;
            this.KonecButton.Text = "Konec";
            this.KonecButton.UseVisualStyleBackColor = true;
            this.KonecButton.Click += new System.EventHandler(this.KonecButton_Click);
            // 
            // LogyTextBox
            // 
            this.LogyTextBox.Location = new System.Drawing.Point(12, 218);
            this.LogyTextBox.Multiline = true;
            this.LogyTextBox.Name = "LogyTextBox";
            this.LogyTextBox.Size = new System.Drawing.Size(622, 81);
            this.LogyTextBox.TabIndex = 8;
            // 
            // LigaMistruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 310);
            this.Controls.Add(this.LogyTextBox);
            this.Controls.Add(this.KonecButton);
            this.Controls.Add(this.ZrusitButton);
            this.Controls.Add(this.RegistrovatButton);
            this.Controls.Add(this.NejlepsiButton);
            this.Controls.Add(this.UpravitButton);
            this.Controls.Add(this.VymazButton);
            this.Controls.Add(this.PridejButton);
            this.Controls.Add(this.listHracuDataGridView);
            this.Name = "LigaMistruForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listHracuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listHracuDataGridView;
        private System.Windows.Forms.Button PridejButton;
        private System.Windows.Forms.Button VymazButton;
        private System.Windows.Forms.Button UpravitButton;
        private System.Windows.Forms.Button NejlepsiButton;
        private System.Windows.Forms.Button RegistrovatButton;
        private System.Windows.Forms.Button ZrusitButton;
        private System.Windows.Forms.Button KonecButton;
        private System.Windows.Forms.TextBox LogyTextBox;
    }
}

