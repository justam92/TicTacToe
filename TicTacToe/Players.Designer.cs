namespace TicTacToe
{
    partial class Players
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namePlayer1 = new System.Windows.Forms.TextBox();
            this.namePlayer2 = new System.Windows.Forms.TextBox();
            this.surnamePlayer1 = new System.Windows.Forms.TextBox();
            this.surnamePlayer2 = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa Gracza Pierwszego:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa Gracza Drugiego:";
            // 
            // namePlayer1
            // 
            this.namePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.namePlayer1.Location = new System.Drawing.Point(221, 13);
            this.namePlayer1.Name = "namePlayer1";
            this.namePlayer1.Size = new System.Drawing.Size(170, 22);
            this.namePlayer1.TabIndex = 2;
            this.namePlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.namePlayer1_MouseClick);
            this.namePlayer1.TextChanged += new System.EventHandler(this.namePlayer1_TextChanged);
            // 
            // namePlayer2
            // 
            this.namePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.namePlayer2.Location = new System.Drawing.Point(221, 62);
            this.namePlayer2.Name = "namePlayer2";
            this.namePlayer2.Size = new System.Drawing.Size(170, 22);
            this.namePlayer2.TabIndex = 3;
            this.namePlayer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.namePlayer2_MouseClick);
            // 
            // surnamePlayer1
            // 
            this.surnamePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnamePlayer1.Location = new System.Drawing.Point(397, 13);
            this.surnamePlayer1.Name = "surnamePlayer1";
            this.surnamePlayer1.Size = new System.Drawing.Size(199, 22);
            this.surnamePlayer1.TabIndex = 4;
            this.surnamePlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.surnamePlayer1_MouseClick);
            // 
            // surnamePlayer2
            // 
            this.surnamePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnamePlayer2.Location = new System.Drawing.Point(397, 62);
            this.surnamePlayer2.Name = "surnamePlayer2";
            this.surnamePlayer2.Size = new System.Drawing.Size(199, 22);
            this.surnamePlayer2.TabIndex = 5;
            this.surnamePlayer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.surnamePlayer2_MouseClick);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(471, 108);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(125, 32);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "Graj";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 152);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.surnamePlayer2);
            this.Controls.Add(this.surnamePlayer1);
            this.Controls.Add(this.namePlayer2);
            this.Controls.Add(this.namePlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(622, 191);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(622, 191);
            this.Name = "Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gracze";
            this.Load += new System.EventHandler(this.Players_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namePlayer1;
        private System.Windows.Forms.TextBox namePlayer2;
        private System.Windows.Forms.TextBox surnamePlayer1;
        private System.Windows.Forms.TextBox surnamePlayer2;
        private System.Windows.Forms.Button buttonPlay;
    }
}