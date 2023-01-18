namespace MMGame
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
            this.components = new System.ComponentModel.Container();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.guessTextBox = new System.Windows.Forms.RichTextBox();
            this.guessesRemainingLabel = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pastGuessesListBox = new System.Windows.Forms.RichTextBox();
            this.MasterMindLabel = new System.Windows.Forms.Label();
            this.OneMoreBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.resultsLabel.Location = new System.Drawing.Point(252, 325);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(0, 13);
            this.resultsLabel.TabIndex = 0;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.guessButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.guessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guessButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.guessButton.Location = new System.Drawing.Point(161, 453);
            this.guessButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(88, 27);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click_1);
            // 
            // guessTextBox
            // 
            this.guessTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(187)))), ((int)(((byte)(141)))));
            this.guessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guessTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.guessTextBox.Location = new System.Drawing.Point(255, 411);
            this.guessTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(361, 69);
            this.guessTextBox.TabIndex = 3;
            this.guessTextBox.Text = "";
            // 
            // guessesRemainingLabel
            // 
            this.guessesRemainingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(187)))), ((int)(((byte)(141)))));
            this.guessesRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guessesRemainingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.guessesRemainingLabel.Location = new System.Drawing.Point(138, 55);
            this.guessesRemainingLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guessesRemainingLabel.Name = "guessesRemainingLabel";
            this.guessesRemainingLabel.Size = new System.Drawing.Size(134, 110);
            this.guessesRemainingLabel.TabIndex = 4;
            this.guessesRemainingLabel.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.label1.Location = new System.Drawing.Point(134, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Remaining Guesses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.label2.Location = new System.Drawing.Point(252, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input your guess here";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.startButton.Location = new System.Drawing.Point(819, 411);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 27);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.resetButton.Location = new System.Drawing.Point(819, 453);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(88, 27);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.label3.Location = new System.Drawing.Point(14, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Past Guesses";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pastGuessesListBox
            // 
            this.pastGuessesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(187)))), ((int)(((byte)(141)))));
            this.pastGuessesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pastGuessesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.pastGuessesListBox.Location = new System.Drawing.Point(14, 55);
            this.pastGuessesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pastGuessesListBox.Name = "pastGuessesListBox";
            this.pastGuessesListBox.Size = new System.Drawing.Size(116, 284);
            this.pastGuessesListBox.TabIndex = 11;
            this.pastGuessesListBox.Text = "";
            // 
            // MasterMindLabel
            // 
            this.MasterMindLabel.AutoSize = true;
            this.MasterMindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MasterMindLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.MasterMindLabel.Location = new System.Drawing.Point(302, 10);
            this.MasterMindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MasterMindLabel.Name = "MasterMindLabel";
            this.MasterMindLabel.Size = new System.Drawing.Size(328, 39);
            this.MasterMindLabel.TabIndex = 12;
            this.MasterMindLabel.Text = "Master Mind Game";
            // 
            // OneMoreBTN
            // 
            this.OneMoreBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.OneMoreBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneMoreBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OneMoreBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(177)))));
            this.OneMoreBTN.Location = new System.Drawing.Point(138, 173);
            this.OneMoreBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OneMoreBTN.Name = "OneMoreBTN";
            this.OneMoreBTN.Size = new System.Drawing.Size(134, 27);
            this.OneMoreBTN.TabIndex = 14;
            this.OneMoreBTN.Text = "One More Turn";
            this.OneMoreBTN.UseVisualStyleBackColor = false;
            this.OneMoreBTN.Click += new System.EventHandler(this.OneMoreBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.OneMoreBTN);
            this.Controls.Add(this.MasterMindLabel);
            this.Controls.Add(this.pastGuessesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessesRemainingLabel);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.resultsLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.RichTextBox guessTextBox;
        private System.Windows.Forms.RichTextBox guessesRemainingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox pastGuessesListBox;
        private System.Windows.Forms.Label MasterMindLabel;
        private System.Windows.Forms.Button OneMoreBTN;
    }
}

