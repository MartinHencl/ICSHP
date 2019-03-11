using System;
using System.Windows.Forms;

namespace MessageLogger
{
    public partial class MessageLoggerApplication : Form
    {
        EventHandler sendTextToLeftTextBoxEventHandler;
        EventHandler sendTextToRightTextBoxEventHandler;

        public MessageLoggerApplication()
        {
            InitializeComponent();
            sendTextToLeftTextBoxEventHandler = new EventHandler(SendTextToLeftTextBox);
            sendTextToRightTextBoxEventHandler = new EventHandler(SendTextToRightTextBox);
        }

        private void Button_send_click(object sender, EventArgs e)
        {
            tututu
        }

        private void SendTextToLeftTextBox(object sender, EventArgs e)
        {
            textBox_leftPanel.Text += textBox_input.Text + "\r\n";
        }
        private void SendTextToRightTextBox(object sender, EventArgs e)
        {
            textBox_rightPanel.Text += textBox_input.Text + "\r\n";
        }

        private void OutputEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EventHandler checkedChangedEventhadler = null;
            if (sender == checkBox_leftPanel)
            {
                checkedChangedEventhadler = sendTextToLeftTextBoxEventHandler;
            }
            else if (sender == checkBox_rightPanel)
            {
                checkedChangedEventhadler = sendTextToRightTextBoxEventHandler;
            }

            if ((sender as CheckBox).Checked)
            {
                button_send.Click += checkedChangedEventhadler;
            } else
            {
                button_send.Click -= checkedChangedEventhadler;
            }
        }
    }
}
