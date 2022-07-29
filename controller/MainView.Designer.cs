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
            ((System.ComponentModel.ISupportInitialize)(this.com_numericUpDown)).BeginInit();
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
            this.output_richTextBox.Location = new System.Drawing.Point(12, 277);
            this.output_richTextBox.Name = "output_richTextBox";
            this.output_richTextBox.Size = new System.Drawing.Size(776, 161);
            this.output_richTextBox.TabIndex = 4;
            this.output_richTextBox.Text = "";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output_richTextBox);
            this.Controls.Add(this.com_numericUpDown);
            this.Controls.Add(this.tare_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.connect_button);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.com_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button connect_button;
        private Button send_button;
        private Button tare_button;
        private NumericUpDown com_numericUpDown;
        private RichTextBox output_richTextBox;
    }
}