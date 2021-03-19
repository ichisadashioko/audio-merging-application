namespace ConcatAudio
{
    partial class MergingApplication
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
            this.button1 = new System.Windows.Forms.Button();
            this.audioFileEntriesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mp3FormatRadioButton = new System.Windows.Forms.RadioButton();
            this.wavFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.startCancelButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browser source file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // audioFileEntriesListBox
            // 
            this.audioFileEntriesListBox.FormattingEnabled = true;
            this.audioFileEntriesListBox.Location = new System.Drawing.Point(13, 68);
            this.audioFileEntriesListBox.Name = "audioFileEntriesListBox";
            this.audioFileEntriesListBox.Size = new System.Drawing.Size(345, 368);
            this.audioFileEntriesListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target File Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(488, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target Format";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(368, 366);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(420, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // mp3FormatRadioButton
            // 
            this.mp3FormatRadioButton.AutoSize = true;
            this.mp3FormatRadioButton.Location = new System.Drawing.Point(488, 107);
            this.mp3FormatRadioButton.Name = "mp3FormatRadioButton";
            this.mp3FormatRadioButton.Size = new System.Drawing.Size(47, 17);
            this.mp3FormatRadioButton.TabIndex = 9;
            this.mp3FormatRadioButton.TabStop = true;
            this.mp3FormatRadioButton.Text = "MP3";
            this.mp3FormatRadioButton.UseVisualStyleBackColor = true;
            // 
            // wavFormatRadioButton
            // 
            this.wavFormatRadioButton.AutoSize = true;
            this.wavFormatRadioButton.Location = new System.Drawing.Point(737, 107);
            this.wavFormatRadioButton.Name = "wavFormatRadioButton";
            this.wavFormatRadioButton.Size = new System.Drawing.Size(50, 17);
            this.wavFormatRadioButton.TabIndex = 10;
            this.wavFormatRadioButton.TabStop = true;
            this.wavFormatRadioButton.Text = "WAV";
            this.wavFormatRadioButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Play Test";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // startCancelButton
            // 
            this.startCancelButton.Location = new System.Drawing.Point(538, 413);
            this.startCancelButton.Name = "startCancelButton";
            this.startCancelButton.Size = new System.Drawing.Size(75, 23);
            this.startCancelButton.TabIndex = 12;
            this.startCancelButton.Text = "Start";
            this.startCancelButton.UseVisualStyleBackColor = true;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(713, 413);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 13;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // MergingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.startCancelButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wavFormatRadioButton);
            this.Controls.Add(this.mp3FormatRadioButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.audioFileEntriesListBox);
            this.Controls.Add(this.button1);
            this.Name = "MergingApplication";
            this.Text = "Merging Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox audioFileEntriesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton mp3FormatRadioButton;
        private System.Windows.Forms.RadioButton wavFormatRadioButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button startCancelButton;
        private System.Windows.Forms.Button finishButton;
    }
}
