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
            this.Menu = new System.Windows.Forms.Panel();
            this.FizzBuzzBut = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.FizzBuzzBut);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(795, 517);
            this.Menu.TabIndex = 0;
            // 
            // FizzBuzzBut
            // 
            this.FizzBuzzBut.Location = new System.Drawing.Point(26, 39);
            this.FizzBuzzBut.Name = "FizzBuzzBut";
            this.FizzBuzzBut.Size = new System.Drawing.Size(75, 23);
            this.FizzBuzzBut.TabIndex = 0;
            this.FizzBuzzBut.Text = "FizzBuzz";
            this.FizzBuzzBut.UseVisualStyleBackColor = true;
            this.FizzBuzzBut.Click += new System.EventHandler(this.FizzBuzzBut_Click);
            // 
            // TextProgramis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 517);
            this.Controls.Add(this.Menu);
            this.Name = "TextProgramis";
            this.Text = "Text Programs";
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button FizzBuzzBut;
    }
}

