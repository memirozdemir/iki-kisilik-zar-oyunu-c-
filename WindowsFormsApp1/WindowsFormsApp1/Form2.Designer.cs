namespace WindowsFormsApp1
{
    partial class Form2
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
            this.start1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dice1 = new System.Windows.Forms.Label();
            this.dice2 = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.start2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // start1
            // 
            this.start1.BackColor = System.Drawing.Color.Black;
            this.start1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.start1.ForeColor = System.Drawing.Color.White;
            this.start1.Location = new System.Drawing.Point(178, 332);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(119, 63);
            this.start1.TabIndex = 0;
            this.start1.Text = "Roll Dices";
            this.start1.UseVisualStyleBackColor = false;
            this.start1.Click += new System.EventHandler(this.start1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(251, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(307, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2";
            // 
            // dice1
            // 
            this.dice1.AutoSize = true;
            this.dice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dice1.Location = new System.Drawing.Point(104, 291);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(24, 25);
            this.dice1.TabIndex = 5;
            this.dice1.Text = "0";
            // 
            // dice2
            // 
            this.dice2.AutoSize = true;
            this.dice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dice2.Location = new System.Drawing.Point(339, 291);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(24, 25);
            this.dice2.TabIndex = 6;
            this.dice2.Text = "0";
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Black;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.restart.ForeColor = System.Drawing.Color.White;
            this.restart.Location = new System.Drawing.Point(395, 11);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(91, 34);
            this.restart.TabIndex = 7;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // start2
            // 
            this.start2.BackColor = System.Drawing.Color.Black;
            this.start2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.start2.ForeColor = System.Drawing.Color.White;
            this.start2.Location = new System.Drawing.Point(178, 332);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(119, 63);
            this.start2.TabIndex = 8;
            this.start2.Text = "Start";
            this.start2.UseVisualStyleBackColor = false;
            this.start2.Click += new System.EventHandler(this.start2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Player 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Player 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Score:";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.score1.Location = new System.Drawing.Point(103, 483);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(19, 20);
            this.score1.TabIndex = 12;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.score2.Location = new System.Drawing.Point(103, 522);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(19, 20);
            this.score2.TabIndex = 13;
            this.score2.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(489, 556);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dice1;
        private System.Windows.Forms.Label dice2;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button start2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
    }
}