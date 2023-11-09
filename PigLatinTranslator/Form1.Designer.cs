namespace PigLatinTranslator
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
            label2 = new Label();
            txtPigLatin = new TextBox();
            txtEnglish = new TextBox();
            btnTranslate = new Button();
            btnExit = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter English text here:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 177);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Pig Latin translation:";
            // 
            // txtPigLatin
            // 
            txtPigLatin.Location = new Point(27, 195);
            txtPigLatin.Multiline = true;
            txtPigLatin.Name = "txtPigLatin";
            txtPigLatin.ReadOnly = true;
            txtPigLatin.ScrollBars = ScrollBars.Vertical;
            txtPigLatin.Size = new Size(456, 102);
            txtPigLatin.TabIndex = 3;
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(27, 43);
            txtEnglish.Multiline = true;
            txtEnglish.Name = "txtEnglish";
            txtEnglish.ScrollBars = ScrollBars.Vertical;
            txtEnglish.Size = new Size(456, 102);
            txtEnglish.TabIndex = 4;
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(27, 329);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(75, 23);
            btnTranslate.TabIndex = 5;
            btnTranslate.Text = "&Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(408, 329);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(145, 329);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 379);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnTranslate);
            Controls.Add(txtEnglish);
            Controls.Add(txtPigLatin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Pig Latin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPigLatin;
        private TextBox txtEnglish;
        private Button btnTranslate;
        private Button btnExit;
        private Button btnClear;
    }
}