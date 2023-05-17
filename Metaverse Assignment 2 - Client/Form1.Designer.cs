namespace Metaverse_Assignment_2___Client
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtIP = new TextBox();
            connect = new Button();
            chatBox = new TextBox();
            txtMessage = new TextBox();
            label2 = new Label();
            sendMessage = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
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
            label1.Click += label1_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(63, 33);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(695, 23);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1:9000";
            // 
            // connect
            // 
            connect.Location = new Point(683, 470);
            connect.Name = "connect";
            connect.Size = new Size(94, 34);
            connect.TabIndex = 2;
            connect.Text = "Connect";
            connect.UseVisualStyleBackColor = true;
            connect.Click += connect_Click;
            // 
            // chatBox
            // 
            chatBox.Location = new Point(63, 62);
            chatBox.Multiline = true;
            chatBox.Name = "chatBox";
            chatBox.ScrollBars = ScrollBars.Both;
            chatBox.Size = new Size(695, 326);
            chatBox.TabIndex = 3;
            chatBox.TextChanged += textBox2_TextChanged;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(77, 405);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(681, 23);
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
            sendMessage.Location = new Point(583, 470);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new Size(94, 34);
            sendMessage.TabIndex = 6;
            sendMessage.Text = "Send";
            sendMessage.UseVisualStyleBackColor = true;
            sendMessage.Click += sendMessage_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label18, 3, 3);
            tableLayoutPanel1.Controls.Add(label17, 2, 3);
            tableLayoutPanel1.Controls.Add(label16, 1, 3);
            tableLayoutPanel1.Controls.Add(label15, 0, 3);
            tableLayoutPanel1.Controls.Add(label14, 3, 2);
            tableLayoutPanel1.Controls.Add(label13, 2, 2);
            tableLayoutPanel1.Controls.Add(label12, 1, 2);
            tableLayoutPanel1.Controls.Add(label11, 0, 2);
            tableLayoutPanel1.Controls.Add(label10, 3, 1);
            tableLayoutPanel1.Controls.Add(label9, 2, 1);
            tableLayoutPanel1.Controls.Add(label8, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(789, 102);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(513, 402);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ActiveCaption;
            label18.Location = new Point(387, 300);
            label18.Name = "label18";
            label18.Size = new Size(120, 99);
            label18.TabIndex = 15;
            label18.Text = "1";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            label18.Click += Label_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ActiveCaption;
            label17.Location = new Point(260, 300);
            label17.Name = "label17";
            label17.Size = new Size(118, 99);
            label17.TabIndex = 14;
            label17.Text = "1";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            label17.Click += Label_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ActiveCaption;
            label16.Location = new Point(133, 300);
            label16.Name = "label16";
            label16.Size = new Size(118, 99);
            label16.TabIndex = 13;
            label16.Text = "1";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            label16.Click += Label_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ActiveCaption;
            label15.Location = new Point(6, 300);
            label15.Name = "label15";
            label15.Size = new Size(118, 99);
            label15.TabIndex = 12;
            label15.Text = "1";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            label15.Click += Label_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ActiveCaption;
            label14.Location = new Point(387, 201);
            label14.Name = "label14";
            label14.Size = new Size(120, 96);
            label14.TabIndex = 11;
            label14.Text = "1";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            label14.Click += Label_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaption;
            label13.Location = new Point(260, 201);
            label13.Name = "label13";
            label13.Size = new Size(118, 96);
            label13.TabIndex = 10;
            label13.Text = "1";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Click += Label_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaption;
            label12.Location = new Point(133, 201);
            label12.Name = "label12";
            label12.Size = new Size(118, 96);
            label12.TabIndex = 9;
            label12.Text = "1";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += Label_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaption;
            label11.Location = new Point(6, 201);
            label11.Name = "label11";
            label11.Size = new Size(118, 96);
            label11.TabIndex = 8;
            label11.Text = "1";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += Label_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(387, 102);
            label10.Name = "label10";
            label10.Size = new Size(120, 96);
            label10.TabIndex = 7;
            label10.Text = "1";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += Label_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(260, 102);
            label9.Name = "label9";
            label9.Size = new Size(118, 96);
            label9.TabIndex = 6;
            label9.Text = "1";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += Label_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(133, 102);
            label8.Name = "label8";
            label8.Size = new Size(118, 96);
            label8.TabIndex = 5;
            label8.Text = "1";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += Label_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(6, 102);
            label7.Name = "label7";
            label7.Size = new Size(118, 96);
            label7.TabIndex = 4;
            label7.Text = "1";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += Label_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(387, 3);
            label6.Name = "label6";
            label6.Size = new Size(120, 96);
            label6.TabIndex = 3;
            label6.Text = "1";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += Label_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(260, 3);
            label5.Name = "label5";
            label5.Size = new Size(118, 96);
            label5.TabIndex = 2;
            label5.Text = "1";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += Label_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(133, 3);
            label4.Name = "label4";
            label4.Size = new Size(118, 96);
            label4.TabIndex = 1;
            label4.Text = "1";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += Label_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(118, 96);
            label3.TabIndex = 0;
            label3.Text = "1";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += Label_Click;
            // 
            // timer1
            // 
            timer1.Interval = 750;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1314, 516);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(sendMessage);
            Controls.Add(txtMessage);
            Controls.Add(label2);
            Controls.Add(chatBox);
            Controls.Add(connect);
            Controls.Add(txtIP);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TCP/IP Client";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private Button connect;
        private TextBox chatBox;
        private TextBox txtMessage;
        private Label label2;
        private Button sendMessage;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}