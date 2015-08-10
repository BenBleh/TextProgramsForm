namespace TextProgramsForm
{
    partial class TextProgramis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextProgramis));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FizzBuzz = new System.Windows.Forms.TabPage();
            this.FizzBuzzRun = new System.Windows.Forms.Button();
            this.FizzBuzzOutput = new System.Windows.Forms.RichTextBox();
            this.FizzBuzzDesc = new System.Windows.Forms.RichTextBox();
            this.Reverse = new System.Windows.Forms.TabPage();
            this.RSButRun = new System.Windows.Forms.Button();
            this.RStxtOut = new System.Windows.Forms.TextBox();
            this.RStxtInput = new System.Windows.Forms.TextBox();
            this.ReverseStringOutput = new System.Windows.Forms.RichTextBox();
            this.reverseStringInput = new System.Windows.Forms.RichTextBox();
            this.ReversSDesc = new System.Windows.Forms.RichTextBox();
            this.PigLatin = new System.Windows.Forms.TabPage();
            this.PigLatRun = new System.Windows.Forms.Button();
            this.PglattxtOut = new System.Windows.Forms.TextBox();
            this.PglattxtIn = new System.Windows.Forms.TextBox();
            this.PgltOutput = new System.Windows.Forms.RichTextBox();
            this.PgLtInput = new System.Windows.Forms.RichTextBox();
            this.PigLatDesc = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.FizzBuzz.SuspendLayout();
            this.Reverse.SuspendLayout();
            this.PigLatin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FizzBuzz);
            this.tabControl1.Controls.Add(this.Reverse);
            this.tabControl1.Controls.Add(this.PigLatin);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // FizzBuzz
            // 
            this.FizzBuzz.Controls.Add(this.FizzBuzzRun);
            this.FizzBuzz.Controls.Add(this.FizzBuzzOutput);
            this.FizzBuzz.Controls.Add(this.FizzBuzzDesc);
            this.FizzBuzz.Location = new System.Drawing.Point(4, 22);
            this.FizzBuzz.Name = "FizzBuzz";
            this.FizzBuzz.Padding = new System.Windows.Forms.Padding(3);
            this.FizzBuzz.Size = new System.Drawing.Size(787, 493);
            this.FizzBuzz.TabIndex = 0;
            this.FizzBuzz.Text = "FizzBuzz";
            this.FizzBuzz.UseVisualStyleBackColor = true;
            // 
            // FizzBuzzRun
            // 
            this.FizzBuzzRun.Location = new System.Drawing.Point(335, 101);
            this.FizzBuzzRun.Name = "FizzBuzzRun";
            this.FizzBuzzRun.Size = new System.Drawing.Size(75, 23);
            this.FizzBuzzRun.TabIndex = 2;
            this.FizzBuzzRun.Text = "Run code";
            this.FizzBuzzRun.UseVisualStyleBackColor = true;
            this.FizzBuzzRun.Click += new System.EventHandler(this.FizzBuzzRun_Click_1);
            // 
            // FizzBuzzOutput
            // 
            this.FizzBuzzOutput.Location = new System.Drawing.Point(50, 130);
            this.FizzBuzzOutput.Name = "FizzBuzzOutput";
            this.FizzBuzzOutput.ReadOnly = true;
            this.FizzBuzzOutput.Size = new System.Drawing.Size(667, 227);
            this.FizzBuzzOutput.TabIndex = 1;
            this.FizzBuzzOutput.Text = "";
            // 
            // FizzBuzzDesc
            // 
            this.FizzBuzzDesc.Location = new System.Drawing.Point(17, 7);
            this.FizzBuzzDesc.Name = "FizzBuzzDesc";
            this.FizzBuzzDesc.ReadOnly = true;
            this.FizzBuzzDesc.Size = new System.Drawing.Size(740, 88);
            this.FizzBuzzDesc.TabIndex = 0;
            this.FizzBuzzDesc.Text = resources.GetString("FizzBuzzDesc.Text");
            // 
            // Reverse
            // 
            this.Reverse.Controls.Add(this.RSButRun);
            this.Reverse.Controls.Add(this.RStxtOut);
            this.Reverse.Controls.Add(this.RStxtInput);
            this.Reverse.Controls.Add(this.ReverseStringOutput);
            this.Reverse.Controls.Add(this.reverseStringInput);
            this.Reverse.Controls.Add(this.ReversSDesc);
            this.Reverse.Location = new System.Drawing.Point(4, 22);
            this.Reverse.Name = "Reverse";
            this.Reverse.Padding = new System.Windows.Forms.Padding(3);
            this.Reverse.Size = new System.Drawing.Size(787, 493);
            this.Reverse.TabIndex = 1;
            this.Reverse.Text = "Reverse String";
            this.Reverse.UseVisualStyleBackColor = true;
            // 
            // RSButRun
            // 
            this.RSButRun.Location = new System.Drawing.Point(362, 261);
            this.RSButRun.Name = "RSButRun";
            this.RSButRun.Size = new System.Drawing.Size(75, 23);
            this.RSButRun.TabIndex = 5;
            this.RSButRun.Text = "Run";
            this.RSButRun.UseVisualStyleBackColor = true;
            this.RSButRun.Click += new System.EventHandler(this.RSButRun_Click);
            // 
            // RStxtOut
            // 
            this.RStxtOut.Location = new System.Drawing.Point(587, 122);
            this.RStxtOut.Name = "RStxtOut";
            this.RStxtOut.ReadOnly = true;
            this.RStxtOut.Size = new System.Drawing.Size(100, 20);
            this.RStxtOut.TabIndex = 4;
            this.RStxtOut.Text = "Output";
            // 
            // RStxtInput
            // 
            this.RStxtInput.Location = new System.Drawing.Point(100, 122);
            this.RStxtInput.Name = "RStxtInput";
            this.RStxtInput.ReadOnly = true;
            this.RStxtInput.Size = new System.Drawing.Size(100, 20);
            this.RStxtInput.TabIndex = 3;
            this.RStxtInput.Text = "Input";
            // 
            // ReverseStringOutput
            // 
            this.ReverseStringOutput.Location = new System.Drawing.Point(483, 166);
            this.ReverseStringOutput.Name = "ReverseStringOutput";
            this.ReverseStringOutput.ReadOnly = true;
            this.ReverseStringOutput.Size = new System.Drawing.Size(300, 308);
            this.ReverseStringOutput.TabIndex = 2;
            this.ReverseStringOutput.Text = "";
            // 
            // reverseStringInput
            // 
            this.reverseStringInput.Location = new System.Drawing.Point(6, 166);
            this.reverseStringInput.Name = "reverseStringInput";
            this.reverseStringInput.Size = new System.Drawing.Size(300, 300);
            this.reverseStringInput.TabIndex = 1;
            this.reverseStringInput.Text = "";
            // 
            // ReversSDesc
            // 
            this.ReversSDesc.Location = new System.Drawing.Point(6, 6);
            this.ReversSDesc.Name = "ReversSDesc";
            this.ReversSDesc.ReadOnly = true;
            this.ReversSDesc.Size = new System.Drawing.Size(773, 96);
            this.ReversSDesc.TabIndex = 0;
            this.ReversSDesc.Text = "Reverse a String - Enter a string and the program will reverse it and print it ou" +
    "t.";
            // 
            // PigLatin
            // 
            this.PigLatin.Controls.Add(this.PigLatRun);
            this.PigLatin.Controls.Add(this.PglattxtOut);
            this.PigLatin.Controls.Add(this.PglattxtIn);
            this.PigLatin.Controls.Add(this.PgltOutput);
            this.PigLatin.Controls.Add(this.PgLtInput);
            this.PigLatin.Controls.Add(this.PigLatDesc);
            this.PigLatin.Location = new System.Drawing.Point(4, 22);
            this.PigLatin.Name = "PigLatin";
            this.PigLatin.Padding = new System.Windows.Forms.Padding(3);
            this.PigLatin.Size = new System.Drawing.Size(787, 493);
            this.PigLatin.TabIndex = 2;
            this.PigLatin.Text = "PigLatin";
            this.PigLatin.UseVisualStyleBackColor = true;
            // 
            // PigLatRun
            // 
            this.PigLatRun.Location = new System.Drawing.Point(361, 267);
            this.PigLatRun.Name = "PigLatRun";
            this.PigLatRun.Size = new System.Drawing.Size(75, 23);
            this.PigLatRun.TabIndex = 11;
            this.PigLatRun.Text = "Run";
            this.PigLatRun.UseVisualStyleBackColor = true;
            this.PigLatRun.Click += new System.EventHandler(this.PigLatRun_Click);
            // 
            // PglattxtOut
            // 
            this.PglattxtOut.Location = new System.Drawing.Point(586, 128);
            this.PglattxtOut.Name = "PglattxtOut";
            this.PglattxtOut.ReadOnly = true;
            this.PglattxtOut.Size = new System.Drawing.Size(100, 20);
            this.PglattxtOut.TabIndex = 10;
            this.PglattxtOut.Text = "Output";
            // 
            // PglattxtIn
            // 
            this.PglattxtIn.Location = new System.Drawing.Point(99, 128);
            this.PglattxtIn.Name = "PglattxtIn";
            this.PglattxtIn.ReadOnly = true;
            this.PglattxtIn.Size = new System.Drawing.Size(100, 20);
            this.PglattxtIn.TabIndex = 9;
            this.PglattxtIn.Text = "Input";
            // 
            // PgltOutput
            // 
            this.PgltOutput.Location = new System.Drawing.Point(482, 172);
            this.PgltOutput.Name = "PgltOutput";
            this.PgltOutput.ReadOnly = true;
            this.PgltOutput.Size = new System.Drawing.Size(300, 308);
            this.PgltOutput.TabIndex = 8;
            this.PgltOutput.Text = "";
            // 
            // PgLtInput
            // 
            this.PgLtInput.Location = new System.Drawing.Point(5, 172);
            this.PgLtInput.Name = "PgLtInput";
            this.PgLtInput.Size = new System.Drawing.Size(300, 300);
            this.PgLtInput.TabIndex = 7;
            this.PgLtInput.Text = "";
            // 
            // PigLatDesc
            // 
            this.PigLatDesc.Location = new System.Drawing.Point(5, 12);
            this.PigLatDesc.Name = "PigLatDesc";
            this.PigLatDesc.ReadOnly = true;
            this.PigLatDesc.Size = new System.Drawing.Size(773, 96);
            this.PigLatDesc.TabIndex = 6;
            this.PigLatDesc.Text = resources.GetString("PigLatDesc.Text");
            // 
            // TextProgramis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "TextProgramis";
            this.Text = "Text Programs";
            this.tabControl1.ResumeLayout(false);
            this.FizzBuzz.ResumeLayout(false);
            this.Reverse.ResumeLayout(false);
            this.Reverse.PerformLayout();
            this.PigLatin.ResumeLayout(false);
            this.PigLatin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FizzBuzz;
        private System.Windows.Forms.TabPage Reverse;
        private System.Windows.Forms.Button FizzBuzzRun;
        private System.Windows.Forms.RichTextBox FizzBuzzOutput;
        private System.Windows.Forms.RichTextBox FizzBuzzDesc;
        private System.Windows.Forms.RichTextBox ReverseStringOutput;
        private System.Windows.Forms.RichTextBox reverseStringInput;
        private System.Windows.Forms.RichTextBox ReversSDesc;
        private System.Windows.Forms.Button RSButRun;
        private System.Windows.Forms.TextBox RStxtOut;
        private System.Windows.Forms.TextBox RStxtInput;
        private System.Windows.Forms.TabPage PigLatin;
        private System.Windows.Forms.Button PigLatRun;
        private System.Windows.Forms.TextBox PglattxtOut;
        private System.Windows.Forms.TextBox PglattxtIn;
        private System.Windows.Forms.RichTextBox PgltOutput;
        private System.Windows.Forms.RichTextBox PgLtInput;
        private System.Windows.Forms.RichTextBox PigLatDesc;
    }
}

