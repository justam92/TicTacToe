namespace TicTacToe
{
    partial class GameBoard
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinningsCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.area11 = new System.Windows.Forms.Button();
            this.area12 = new System.Windows.Forms.Button();
            this.area13 = new System.Windows.Forms.Button();
            this.area21 = new System.Windows.Forms.Button();
            this.area22 = new System.Windows.Forms.Button();
            this.area23 = new System.Windows.Forms.Button();
            this.area31 = new System.Windows.Forms.Button();
            this.area32 = new System.Windows.Forms.Button();
            this.area33 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfWinsForX = new System.Windows.Forms.Label();
            this.numberOfDraws = new System.Windows.Forms.Label();
            this.numberOfWinsForY = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.resetWinningsCountToolStripMenuItem,
            this.endGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.gameToolStripMenuItem.Text = "Gra";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.startGameToolStripMenuItem.Text = "Rozpocznij grę";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // resetWinningsCountToolStripMenuItem
            // 
            this.resetWinningsCountToolStripMenuItem.Name = "resetWinningsCountToolStripMenuItem";
            this.resetWinningsCountToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.resetWinningsCountToolStripMenuItem.Text = "Wyzeruj zliczanie zwycięstw";
            this.resetWinningsCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinningsCountToolStripMenuItem_Click);
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.endGameToolStripMenuItem.Text = "Zakończ grę";
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.endGameToolStripMenuItem_Click);
            // 
            // area11
            // 
            this.area11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area11.Location = new System.Drawing.Point(12, 27);
            this.area11.Name = "area11";
            this.area11.Size = new System.Drawing.Size(125, 125);
            this.area11.TabIndex = 1;
            this.area11.UseVisualStyleBackColor = true;
            this.area11.Click += new System.EventHandler(this.button_click);
            this.area11.MouseEnter += new System.EventHandler(this.button_enter);
            this.area11.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // area12
            // 
            this.area12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area12.Location = new System.Drawing.Point(143, 27);
            this.area12.Name = "area12";
            this.area12.Size = new System.Drawing.Size(125, 125);
            this.area12.TabIndex = 2;
            this.area12.UseVisualStyleBackColor = true;
            this.area12.Click += new System.EventHandler(this.button_click);
            this.area12.MouseEnter += new System.EventHandler(this.button_enter);
            this.area12.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // area13
            // 
            this.area13.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area13.Location = new System.Drawing.Point(274, 27);
            this.area13.Name = "area13";
            this.area13.Size = new System.Drawing.Size(125, 125);
            this.area13.TabIndex = 3;
            this.area13.UseVisualStyleBackColor = true;
            this.area13.Click += new System.EventHandler(this.button_click);
            this.area13.MouseEnter += new System.EventHandler(this.button_enter);
            this.area13.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // area21
            // 
            this.area21.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area21.Location = new System.Drawing.Point(12, 158);
            this.area21.Name = "area21";
            this.area21.Size = new System.Drawing.Size(125, 125);
            this.area21.TabIndex = 4;
            this.area21.UseVisualStyleBackColor = true;
            this.area21.Click += new System.EventHandler(this.button_click);
            this.area21.MouseEnter += new System.EventHandler(this.button_enter);
            this.area21.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // area22
            // 
            this.area22.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area22.Location = new System.Drawing.Point(143, 158);
            this.area22.Name = "area22";
            this.area22.Size = new System.Drawing.Size(125, 125);
            this.area22.TabIndex = 5;
            this.area22.UseVisualStyleBackColor = true;
            this.area22.Click += new System.EventHandler(this.button_click);
            this.area22.MouseEnter += new System.EventHandler(this.button_enter);
            this.area22.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // area23
            // 
            this.area23.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area23.Location = new System.Drawing.Point(274, 158);
            this.area23.Name = "area23";
            this.area23.Size = new System.Drawing.Size(125, 125);
            this.area23.TabIndex = 6;
            this.area23.UseVisualStyleBackColor = true;
            this.area23.Click += new System.EventHandler(this.button_click);
            this.area23.MouseEnter += new System.EventHandler(this.button_enter);
            this.area23.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // area31
            // 
            this.area31.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area31.Location = new System.Drawing.Point(12, 289);
            this.area31.Name = "area31";
            this.area31.Size = new System.Drawing.Size(125, 125);
            this.area31.TabIndex = 7;
            this.area31.UseVisualStyleBackColor = true;
            this.area31.Click += new System.EventHandler(this.button_click);
            this.area31.MouseEnter += new System.EventHandler(this.button_enter);
            this.area31.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // area32
            // 
            this.area32.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area32.Location = new System.Drawing.Point(143, 289);
            this.area32.Name = "area32";
            this.area32.Size = new System.Drawing.Size(125, 125);
            this.area32.TabIndex = 8;
            this.area32.UseVisualStyleBackColor = true;
            this.area32.Click += new System.EventHandler(this.button_click);
            this.area32.MouseEnter += new System.EventHandler(this.button_enter);
            this.area32.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // area33
            // 
            this.area33.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area33.Location = new System.Drawing.Point(274, 289);
            this.area33.Name = "area33";
            this.area33.Size = new System.Drawing.Size(125, 125);
            this.area33.TabIndex = 9;
            this.area33.UseVisualStyleBackColor = true;
            this.area33.Click += new System.EventHandler(this.button_click);
            this.area33.MouseEnter += new System.EventHandler(this.button_enter);
            this.area33.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Liczba zwycięstw X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(157, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Liczba remisów";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(281, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Liczba zwycięstw O";
            // 
            // numberOfWinsForX
            // 
            this.numberOfWinsForX.AutoSize = true;
            this.numberOfWinsForX.Location = new System.Drawing.Point(65, 450);
            this.numberOfWinsForX.Name = "numberOfWinsForX";
            this.numberOfWinsForX.Size = new System.Drawing.Size(13, 13);
            this.numberOfWinsForX.TabIndex = 13;
            this.numberOfWinsForX.Text = "0";
            // 
            // numberOfDraws
            // 
            this.numberOfDraws.AutoSize = true;
            this.numberOfDraws.Location = new System.Drawing.Point(200, 450);
            this.numberOfDraws.Name = "numberOfDraws";
            this.numberOfDraws.Size = new System.Drawing.Size(13, 13);
            this.numberOfDraws.TabIndex = 14;
            this.numberOfDraws.Text = "0";
            // 
            // numberOfWinsForY
            // 
            this.numberOfWinsForY.AutoSize = true;
            this.numberOfWinsForY.Location = new System.Drawing.Point(335, 450);
            this.numberOfWinsForY.Name = "numberOfWinsForY";
            this.numberOfWinsForY.Size = new System.Drawing.Size(13, 13);
            this.numberOfWinsForY.TabIndex = 15;
            this.numberOfWinsForY.Text = "0";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 507);
            this.Controls.Add(this.numberOfWinsForY);
            this.Controls.Add(this.numberOfDraws);
            this.Controls.Add(this.numberOfWinsForX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.area33);
            this.Controls.Add(this.area32);
            this.Controls.Add(this.area31);
            this.Controls.Add(this.area23);
            this.Controls.Add(this.area22);
            this.Controls.Add(this.area21);
            this.Controls.Add(this.area13);
            this.Controls.Add(this.area12);
            this.Controls.Add(this.area11);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kółko i Krzyżyk";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.Button area11;
        private System.Windows.Forms.Button area12;
        private System.Windows.Forms.Button area13;
        private System.Windows.Forms.Button area21;
        private System.Windows.Forms.Button area22;
        private System.Windows.Forms.Button area23;
        private System.Windows.Forms.Button area31;
        private System.Windows.Forms.Button area32;
        private System.Windows.Forms.Button area33;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numberOfWinsForX;
        private System.Windows.Forms.Label numberOfDraws;
        private System.Windows.Forms.Label numberOfWinsForY;
        private System.Windows.Forms.ToolStripMenuItem resetWinningsCountToolStripMenuItem;
    }
}

