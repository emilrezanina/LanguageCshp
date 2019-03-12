﻿using System;
using System.Windows.Forms;

namespace MessageLogger
{
    public partial class MessageLoggerApplicationForm : Form
    {
        private EventHandler sendTextToLeftOutputEventHandler;
        private EventHandler sendTextToRightOutputEventHandler;

        public MessageLoggerApplicationForm()
        {
            InitializeComponent();
            sendTextToLeftOutputEventHandler = new EventHandler(SendTextToLeftOutput);
            sendTextToRightOutputEventHandler = new EventHandler(SendTextToRightOutput);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (RightPanelCheckBox.Checked)
                RightOutputTextBox.Text += InputMessageEditControl.Text + "\r\n";
        }

        private void SendTextToLeftOutput(object sender, EventArgs e)
        {
            LeftOutputTextBox.Text += InputMessageEditControl.Text + "\r\n";
        }

        private void SendTextToRightOutput(object sender, EventArgs e)
        {
            RightOutputTextBox.Text += InputMessageEditControl.Text + "\r\n";
        }

        private void OutputEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EventHandler checkedChangedEventHandler = null;
            if (sender == LeftPanelCheckBox)
                checkedChangedEventHandler = sendTextToLeftOutputEventHandler;
            else if (sender == RightPanelCheckBox)
                checkedChangedEventHandler = sendTextToRightOutputEventHandler;

            if ((sender as CheckBox).Checked)
                SendButton.Click += sendTextToLeftOutputEventHandler;
            else
                SendButton.Click -= sendTextToLeftOutputEventHandler;
        }
    }
}
