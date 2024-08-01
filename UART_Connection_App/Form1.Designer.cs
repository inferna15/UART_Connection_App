using System.IO.Ports;

namespace UART_Connection_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            portsBox = new ComboBox();
            connectBtn = new Button();
            disconnectBtn = new Button();
            messageListBox = new ListBox();
            messageBox = new TextBox();
            sendBtn = new Button();
            SuspendLayout();
            // 
            // portsBox
            // 
            portsBox.FormattingEnabled = true;
            portsBox.Location = new Point(12, 12);
            portsBox.Name = "portsBox";
            portsBox.Size = new Size(281, 28);
            portsBox.TabIndex = 0;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(12, 46);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(281, 29);
            connectBtn.TabIndex = 1;
            connectBtn.Text = "Bağlan";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(12, 81);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(281, 29);
            disconnectBtn.TabIndex = 2;
            disconnectBtn.Text = "Bağlantıyı Kes";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // messageListBox
            // 
            messageListBox.FormattingEnabled = true;
            messageListBox.Location = new Point(13, 116);
            messageListBox.Name = "messageListBox";
            messageListBox.Size = new Size(280, 244);
            messageListBox.TabIndex = 3;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(12, 366);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(281, 27);
            messageBox.TabIndex = 4;
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(12, 399);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(281, 29);
            sendBtn.TabIndex = 5;
            sendBtn.Text = "Gönder";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 450);
            Controls.Add(sendBtn);
            Controls.Add(messageBox);
            Controls.Add(messageListBox);
            Controls.Add(disconnectBtn);
            Controls.Add(connectBtn);
            Controls.Add(portsBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox portsBox;
        private Button connectBtn;
        private Button disconnectBtn;
        private ListBox messageListBox;
        private TextBox messageBox;
        private Button sendBtn;
    }
}
