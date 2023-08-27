namespace Keypad_Code_Translator
{
    partial class Form1
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
            this.CodeBox = new System.Windows.Forms.RichTextBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.toText = new System.Windows.Forms.Button();
            this.toCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(43, 114);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(302, 150);
            this.CodeBox.TabIndex = 0;
            this.CodeBox.Text = "";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(433, 114);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(316, 150);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "";
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(93, 293);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(194, 59);
            this.toText.TabIndex = 2;
            this.toText.Text = "Convert To Text";
            this.toText.UseVisualStyleBackColor = true;
            this.toText.Click += new System.EventHandler(this.ConvertToText);
            // 
            // toCode
            // 
            this.toCode.Location = new System.Drawing.Point(487, 293);
            this.toCode.Name = "toCode";
            this.toCode.Size = new System.Drawing.Size(194, 59);
            this.toCode.TabIndex = 3;
            this.toCode.Text = "Convert To Code";
            this.toCode.UseVisualStyleBackColor = true;
            this.toCode.Click += new System.EventHandler(this.ConvertToCode);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Code Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Text Here";
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(39, 26);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 20);
            this.msgLabel.TabIndex = 6;
            this.msgLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toCode);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.CodeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CodeBox;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button toText;
        private System.Windows.Forms.Button toCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label msgLabel;
    }
}

