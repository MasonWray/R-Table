namespace controller
{
    partial class MainView
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
            this.connect_button = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.tare_button = new System.Windows.Forms.Button();
            this.com_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.output_richTextBox = new System.Windows.Forms.RichTextBox();
            this.bigleft_button = new System.Windows.Forms.Button();
            this.littleleft_button = new System.Windows.Forms.Button();
            this.bigright_button = new System.Windows.Forms.Button();
            this.littleright_button = new System.Windows.Forms.Button();
            this.position_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.position_trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.com_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.position_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(440, 12);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(112, 34);
            this.connect_button.TabIndex = 0;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(558, 12);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(112, 34);
            this.send_button.TabIndex = 1;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            // 
            // tare_button
            // 
            this.tare_button.Location = new System.Drawing.Point(676, 12);
            this.tare_button.Name = "tare_button";
            this.tare_button.Size = new System.Drawing.Size(112, 34);
            this.tare_button.TabIndex = 2;
            this.tare_button.Text = "Tare";
            this.tare_button.UseVisualStyleBackColor = true;
            // 
            // com_numericUpDown
            // 
            this.com_numericUpDown.Location = new System.Drawing.Point(373, 15);
            this.com_numericUpDown.Name = "com_numericUpDown";
            this.com_numericUpDown.Size = new System.Drawing.Size(61, 31);
            this.com_numericUpDown.TabIndex = 3;
            // 
            // output_richTextBox
            // 
            this.output_richTextBox.Location = new System.Drawing.Point(12, 127);
            this.output_richTextBox.Name = "output_richTextBox";
            this.output_richTextBox.Size = new System.Drawing.Size(776, 161);
            this.output_richTextBox.TabIndex = 4;
            this.output_richTextBox.Text = "";
            // 
            // bigleft_button
            // 
            this.bigleft_button.Location = new System.Drawing.Point(12, 12);
            this.bigleft_button.Name = "bigleft_button";
            this.bigleft_button.Size = new System.Drawing.Size(55, 34);
            this.bigleft_button.TabIndex = 5;
            this.bigleft_button.Text = "<<";
            this.bigleft_button.UseVisualStyleBackColor = true;
            this.bigleft_button.Click += new System.EventHandler(this.bigleft_button_Click);
            // 
            // littleleft_button
            // 
            this.littleleft_button.Location = new System.Drawing.Point(73, 12);
            this.littleleft_button.Name = "littleleft_button";
            this.littleleft_button.Size = new System.Drawing.Size(55, 34);
            this.littleleft_button.TabIndex = 6;
            this.littleleft_button.Text = "<";
            this.littleleft_button.UseVisualStyleBackColor = true;
            this.littleleft_button.Click += new System.EventHandler(this.littleleft_button_Click);
            // 
            // bigright_button
            // 
            this.bigright_button.Location = new System.Drawing.Point(195, 12);
            this.bigright_button.Name = "bigright_button";
            this.bigright_button.Size = new System.Drawing.Size(55, 34);
            this.bigright_button.TabIndex = 8;
            this.bigright_button.Text = ">>";
            this.bigright_button.UseVisualStyleBackColor = true;
            this.bigright_button.Click += new System.EventHandler(this.bigright_button_Click);
            // 
            // littleright_button
            // 
            this.littleright_button.Location = new System.Drawing.Point(134, 12);
            this.littleright_button.Name = "littleright_button";
            this.littleright_button.Size = new System.Drawing.Size(55, 34);
            this.littleright_button.TabIndex = 7;
            this.littleright_button.Text = ">";
            this.littleright_button.UseVisualStyleBackColor = true;
            this.littleright_button.Click += new System.EventHandler(this.littleright_button_Click);
            // 
            // position_numericUpDown
            // 
            this.position_numericUpDown.Location = new System.Drawing.Point(256, 15);
            this.position_numericUpDown.Name = "position_numericUpDown";
            this.position_numericUpDown.Size = new System.Drawing.Size(111, 31);
            this.position_numericUpDown.TabIndex = 9;
            // 
            // position_trackBar
            // 
            this.position_trackBar.LargeChange = 100;
            this.position_trackBar.Location = new System.Drawing.Point(12, 52);
            this.position_trackBar.Maximum = 3600;
            this.position_trackBar.Name = "position_trackBar";
            this.position_trackBar.Size = new System.Drawing.Size(776, 69);
            this.position_trackBar.TabIndex = 10;
            this.position_trackBar.TickFrequency = 100;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.position_trackBar);
            this.Controls.Add(this.position_numericUpDown);
            this.Controls.Add(this.bigright_button);
            this.Controls.Add(this.littleright_button);
            this.Controls.Add(this.littleleft_button);
            this.Controls.Add(this.bigleft_button);
            this.Controls.Add(this.output_richTextBox);
            this.Controls.Add(this.com_numericUpDown);
            this.Controls.Add(this.tare_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.connect_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Turntable Controller";
            ((System.ComponentModel.ISupportInitialize)(this.com_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.position_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button connect_button;
        private Button send_button;
        private Button tare_button;
        private NumericUpDown com_numericUpDown;
        private RichTextBox output_richTextBox;
        private Button bigleft_button;
        private Button littleleft_button;
        private Button bigright_button;
        private Button littleright_button;
        private NumericUpDown position_numericUpDown;
        private TrackBar position_trackBar;
    }
}