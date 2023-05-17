namespace Metaverse_Assignment_2___Server
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
            label1 = new Label();
            txtIP = new TextBox();
            start = new Button();
            chatBox = new TextBox();
            txtMessage = new TextBox();
            label2 = new Label();
            sendMessage = new Button();
            lbclientIPs = new ListBox();
            clientIP = new Label();
            GameStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Server: ";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(63, 33);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(517, 23);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1:9000";
            // 
            // start
            // 
            start.Location = new Point(77, 459);
            start.Name = "start";
            start.Size = new Size(94, 34);
            start.TabIndex = 2;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // chatBox
            // 
            chatBox.Location = new Point(63, 62);
            chatBox.Multiline = true;
            chatBox.Name = "chatBox";
            chatBox.ScrollBars = ScrollBars.Both;
            chatBox.Size = new Size(517, 326);
            chatBox.TabIndex = 3;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(77, 405);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(503, 23);
            txtMessage.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 408);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Message: ";
            // 
            // sendMessage
            // 
            sendMessage.Location = new Point(486, 459);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new Size(94, 34);
            sendMessage.TabIndex = 6;
            sendMessage.Text = "Send";
            sendMessage.UseVisualStyleBackColor = true;
            sendMessage.Click += sendMessage_Click;
            // 
            // lbclientIPs
            // 
            lbclientIPs.FormattingEnabled = true;
            lbclientIPs.ItemHeight = 15;
            lbclientIPs.Location = new Point(603, 75);
            lbclientIPs.Name = "lbclientIPs";
            lbclientIPs.SelectionMode = SelectionMode.MultiSimple;
            lbclientIPs.Size = new Size(265, 439);
            lbclientIPs.TabIndex = 7;
            // 
            // clientIP
            // 
            clientIP.AutoSize = true;
            clientIP.Location = new Point(603, 51);
            clientIP.Name = "clientIP";
            clientIP.Size = new Size(54, 15);
            clientIP.TabIndex = 8;
            clientIP.Text = "Client IP:";
            // 
            // GameStart
            // 
            GameStart.Location = new Point(260, 449);
            GameStart.Name = "GameStart";
            GameStart.Size = new Size(122, 54);
            GameStart.TabIndex = 9;
            GameStart.Text = "Start Game (Client)";
            GameStart.UseVisualStyleBackColor = true;
            GameStart.Click += Game_Start_Clicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(904, 524);
            Controls.Add(GameStart);
            Controls.Add(clientIP);
            Controls.Add(lbclientIPs);
            Controls.Add(sendMessage);
            Controls.Add(txtMessage);
            Controls.Add(label2);
            Controls.Add(chatBox);
            Controls.Add(start);
            Controls.Add(txtIP);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TCP/IP Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private Button start;
        private TextBox chatBox;
        private TextBox txtMessage;
        private Label label2;
        private Button sendMessage;
        private ListBox lbclientIPs;
        private Label clientIP;
        private Button GameStart;
    }
}