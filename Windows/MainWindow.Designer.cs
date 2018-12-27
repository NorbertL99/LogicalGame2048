namespace _2048
{
    partial class MainWindow
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGame = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeScores = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScores = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeInstruction = new System.Windows.Forms.ToolStripMenuItem();
            this.seeAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.number1 = new System.Windows.Forms.Label();
            this.field1 = new System.Windows.Forms.PictureBox();
            this.field2 = new System.Windows.Forms.PictureBox();
            this.field3 = new System.Windows.Forms.PictureBox();
            this.field4 = new System.Windows.Forms.PictureBox();
            this.field5 = new System.Windows.Forms.PictureBox();
            this.field9 = new System.Windows.Forms.PictureBox();
            this.field6 = new System.Windows.Forms.PictureBox();
            this.field7 = new System.Windows.Forms.PictureBox();
            this.field8 = new System.Windows.Forms.PictureBox();
            this.field14 = new System.Windows.Forms.PictureBox();
            this.field13 = new System.Windows.Forms.PictureBox();
            this.field12 = new System.Windows.Forms.PictureBox();
            this.field11 = new System.Windows.Forms.PictureBox();
            this.field10 = new System.Windows.Forms.PictureBox();
            this.field15 = new System.Windows.Forms.PictureBox();
            this.field16 = new System.Windows.Forms.PictureBox();
            this.number3 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.number4 = new System.Windows.Forms.Label();
            this.number5 = new System.Windows.Forms.Label();
            this.number9 = new System.Windows.Forms.Label();
            this.number13 = new System.Windows.Forms.Label();
            this.number6 = new System.Windows.Forms.Label();
            this.number7 = new System.Windows.Forms.Label();
            this.number16 = new System.Windows.Forms.Label();
            this.number12 = new System.Windows.Forms.Label();
            this.number8 = new System.Windows.Forms.Label();
            this.number14 = new System.Windows.Forms.Label();
            this.number10 = new System.Windows.Forms.Label();
            this.number15 = new System.Windows.Forms.Label();
            this.number11 = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field16)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.informationsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(441, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame,
            this.saveGame,
            this.loadGame});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(133, 22);
            this.newGame.Text = "New game";
            // 
            // saveGame
            // 
            this.saveGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.saveGame.Name = "saveGame";
            this.saveGame.Size = new System.Drawing.Size(133, 22);
            this.saveGame.Text = "Save game";
            // 
            // loadGame
            // 
            this.loadGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(133, 22);
            this.loadGame.Text = "Load game";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeScores,
            this.resetScores});
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // seeScores
            // 
            this.seeScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.seeScores.Name = "seeScores";
            this.seeScores.Size = new System.Drawing.Size(179, 22);
            this.seeScores.Text = "See TOP 10 scores";
            // 
            // resetScores
            // 
            this.resetScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.resetScores.Name = "resetScores";
            this.resetScores.Size = new System.Drawing.Size(179, 22);
            this.resetScores.Text = "Reset TOP 10 scores";
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeInstruction,
            this.seeAuthor});
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.informationsToolStripMenuItem.Text = "Informations";
            // 
            // seeInstruction
            // 
            this.seeInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.seeInstruction.Name = "seeInstruction";
            this.seeInstruction.Size = new System.Drawing.Size(131, 22);
            this.seeInstruction.Text = "Instruction";
            // 
            // seeAuthor
            // 
            this.seeAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.seeAuthor.Name = "seeAuthor";
            this.seeAuthor.Size = new System.Drawing.Size(131, 22);
            this.seeAuthor.Text = "Author";
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.BackColor = System.Drawing.Color.Transparent;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number1.ForeColor = System.Drawing.Color.White;
            this.number1.Location = new System.Drawing.Point(20, 156);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(84, 25);
            this.number1.TabIndex = 1;
            this.number1.Text = "999999";
            // 
            // field1
            // 
            this.field1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field1.Location = new System.Drawing.Point(12, 117);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(100, 100);
            this.field1.TabIndex = 2;
            this.field1.TabStop = false;
            // 
            // field2
            // 
            this.field2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field2.Location = new System.Drawing.Point(118, 117);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(100, 100);
            this.field2.TabIndex = 3;
            this.field2.TabStop = false;
            // 
            // field3
            // 
            this.field3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field3.Location = new System.Drawing.Point(224, 117);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(100, 100);
            this.field3.TabIndex = 4;
            this.field3.TabStop = false;
            // 
            // field4
            // 
            this.field4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field4.Location = new System.Drawing.Point(330, 117);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(100, 100);
            this.field4.TabIndex = 5;
            this.field4.TabStop = false;
            // 
            // field5
            // 
            this.field5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field5.Location = new System.Drawing.Point(12, 223);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(100, 100);
            this.field5.TabIndex = 6;
            this.field5.TabStop = false;
            // 
            // field9
            // 
            this.field9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field9.Location = new System.Drawing.Point(12, 329);
            this.field9.Name = "field9";
            this.field9.Size = new System.Drawing.Size(100, 100);
            this.field9.TabIndex = 7;
            this.field9.TabStop = false;
            // 
            // field6
            // 
            this.field6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field6.Location = new System.Drawing.Point(118, 223);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(100, 100);
            this.field6.TabIndex = 8;
            this.field6.TabStop = false;
            // 
            // field7
            // 
            this.field7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field7.Location = new System.Drawing.Point(224, 223);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(100, 100);
            this.field7.TabIndex = 9;
            this.field7.TabStop = false;
            // 
            // field8
            // 
            this.field8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field8.Location = new System.Drawing.Point(330, 223);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(100, 100);
            this.field8.TabIndex = 10;
            this.field8.TabStop = false;
            // 
            // field14
            // 
            this.field14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field14.Location = new System.Drawing.Point(118, 435);
            this.field14.Name = "field14";
            this.field14.Size = new System.Drawing.Size(100, 100);
            this.field14.TabIndex = 11;
            this.field14.TabStop = false;
            // 
            // field13
            // 
            this.field13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field13.Location = new System.Drawing.Point(12, 435);
            this.field13.Name = "field13";
            this.field13.Size = new System.Drawing.Size(100, 100);
            this.field13.TabIndex = 12;
            this.field13.TabStop = false;
            // 
            // field12
            // 
            this.field12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field12.Location = new System.Drawing.Point(330, 329);
            this.field12.Name = "field12";
            this.field12.Size = new System.Drawing.Size(100, 100);
            this.field12.TabIndex = 13;
            this.field12.TabStop = false;
            // 
            // field11
            // 
            this.field11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field11.Location = new System.Drawing.Point(224, 329);
            this.field11.Name = "field11";
            this.field11.Size = new System.Drawing.Size(100, 100);
            this.field11.TabIndex = 14;
            this.field11.TabStop = false;
            // 
            // field10
            // 
            this.field10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field10.Location = new System.Drawing.Point(118, 329);
            this.field10.Name = "field10";
            this.field10.Size = new System.Drawing.Size(100, 100);
            this.field10.TabIndex = 15;
            this.field10.TabStop = false;
            // 
            // field15
            // 
            this.field15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field15.Location = new System.Drawing.Point(224, 435);
            this.field15.Name = "field15";
            this.field15.Size = new System.Drawing.Size(100, 100);
            this.field15.TabIndex = 16;
            this.field15.TabStop = false;
            // 
            // field16
            // 
            this.field16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.field16.Location = new System.Drawing.Point(330, 435);
            this.field16.Name = "field16";
            this.field16.Size = new System.Drawing.Size(100, 100);
            this.field16.TabIndex = 17;
            this.field16.TabStop = false;
            // 
            // number3
            // 
            this.number3.AutoSize = true;
            this.number3.BackColor = System.Drawing.Color.Transparent;
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number3.ForeColor = System.Drawing.Color.White;
            this.number3.Location = new System.Drawing.Point(232, 156);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(84, 25);
            this.number3.TabIndex = 18;
            this.number3.Text = "999999";
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.BackColor = System.Drawing.Color.Transparent;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number2.ForeColor = System.Drawing.Color.White;
            this.number2.Location = new System.Drawing.Point(125, 156);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(84, 25);
            this.number2.TabIndex = 19;
            this.number2.Text = "999999";
            // 
            // number4
            // 
            this.number4.AutoSize = true;
            this.number4.BackColor = System.Drawing.Color.Transparent;
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number4.ForeColor = System.Drawing.Color.White;
            this.number4.Location = new System.Drawing.Point(339, 156);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(84, 25);
            this.number4.TabIndex = 20;
            this.number4.Text = "999999";
            // 
            // number5
            // 
            this.number5.AutoSize = true;
            this.number5.BackColor = System.Drawing.Color.Transparent;
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number5.ForeColor = System.Drawing.Color.White;
            this.number5.Location = new System.Drawing.Point(20, 261);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(84, 25);
            this.number5.TabIndex = 21;
            this.number5.Text = "999999";
            // 
            // number9
            // 
            this.number9.AutoSize = true;
            this.number9.BackColor = System.Drawing.Color.Transparent;
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number9.ForeColor = System.Drawing.Color.White;
            this.number9.Location = new System.Drawing.Point(20, 369);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(84, 25);
            this.number9.TabIndex = 22;
            this.number9.Text = "999999";
            // 
            // number13
            // 
            this.number13.AutoSize = true;
            this.number13.BackColor = System.Drawing.Color.Transparent;
            this.number13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number13.ForeColor = System.Drawing.Color.White;
            this.number13.Location = new System.Drawing.Point(20, 474);
            this.number13.Name = "number13";
            this.number13.Size = new System.Drawing.Size(84, 25);
            this.number13.TabIndex = 23;
            this.number13.Text = "999999";
            // 
            // number6
            // 
            this.number6.AutoSize = true;
            this.number6.BackColor = System.Drawing.Color.Transparent;
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number6.ForeColor = System.Drawing.Color.White;
            this.number6.Location = new System.Drawing.Point(125, 261);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(84, 25);
            this.number6.TabIndex = 24;
            this.number6.Text = "999999";
            // 
            // number7
            // 
            this.number7.AutoSize = true;
            this.number7.BackColor = System.Drawing.Color.Transparent;
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number7.ForeColor = System.Drawing.Color.White;
            this.number7.Location = new System.Drawing.Point(232, 261);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(84, 25);
            this.number7.TabIndex = 25;
            this.number7.Text = "999999";
            // 
            // number16
            // 
            this.number16.AutoSize = true;
            this.number16.BackColor = System.Drawing.Color.Transparent;
            this.number16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number16.ForeColor = System.Drawing.Color.White;
            this.number16.Location = new System.Drawing.Point(339, 474);
            this.number16.Name = "number16";
            this.number16.Size = new System.Drawing.Size(84, 25);
            this.number16.TabIndex = 26;
            this.number16.Text = "999999";
            // 
            // number12
            // 
            this.number12.AutoSize = true;
            this.number12.BackColor = System.Drawing.Color.Transparent;
            this.number12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number12.ForeColor = System.Drawing.Color.White;
            this.number12.Location = new System.Drawing.Point(339, 369);
            this.number12.Name = "number12";
            this.number12.Size = new System.Drawing.Size(84, 25);
            this.number12.TabIndex = 27;
            this.number12.Text = "999999";
            // 
            // number8
            // 
            this.number8.AutoSize = true;
            this.number8.BackColor = System.Drawing.Color.Transparent;
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number8.ForeColor = System.Drawing.Color.White;
            this.number8.Location = new System.Drawing.Point(339, 260);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(84, 25);
            this.number8.TabIndex = 28;
            this.number8.Text = "999999";
            // 
            // number14
            // 
            this.number14.AutoSize = true;
            this.number14.BackColor = System.Drawing.Color.Transparent;
            this.number14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number14.ForeColor = System.Drawing.Color.White;
            this.number14.Location = new System.Drawing.Point(125, 474);
            this.number14.Name = "number14";
            this.number14.Size = new System.Drawing.Size(84, 25);
            this.number14.TabIndex = 29;
            this.number14.Text = "999999";
            // 
            // number10
            // 
            this.number10.AutoSize = true;
            this.number10.BackColor = System.Drawing.Color.Transparent;
            this.number10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number10.ForeColor = System.Drawing.Color.White;
            this.number10.Location = new System.Drawing.Point(125, 369);
            this.number10.Name = "number10";
            this.number10.Size = new System.Drawing.Size(84, 25);
            this.number10.TabIndex = 30;
            this.number10.Text = "999999";
            // 
            // number15
            // 
            this.number15.AutoSize = true;
            this.number15.BackColor = System.Drawing.Color.Transparent;
            this.number15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number15.ForeColor = System.Drawing.Color.White;
            this.number15.Location = new System.Drawing.Point(232, 474);
            this.number15.Name = "number15";
            this.number15.Size = new System.Drawing.Size(84, 25);
            this.number15.TabIndex = 31;
            this.number15.Text = "999999";
            // 
            // number11
            // 
            this.number11.AutoSize = true;
            this.number11.BackColor = System.Drawing.Color.Transparent;
            this.number11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number11.ForeColor = System.Drawing.Color.White;
            this.number11.Location = new System.Drawing.Point(232, 369);
            this.number11.Name = "number11";
            this.number11.Size = new System.Drawing.Size(84, 25);
            this.number11.TabIndex = 32;
            this.number11.Text = "999999";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.Location = new System.Drawing.Point(2, 43);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(51, 55);
            this.pointsLabel.TabIndex = 33;
            this.pointsLabel.Text = "0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(441, 544);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.number11);
            this.Controls.Add(this.number15);
            this.Controls.Add(this.number10);
            this.Controls.Add(this.number14);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number12);
            this.Controls.Add(this.number16);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number13);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.field16);
            this.Controls.Add(this.field15);
            this.Controls.Add(this.field10);
            this.Controls.Add(this.field11);
            this.Controls.Add(this.field12);
            this.Controls.Add(this.field13);
            this.Controls.Add(this.field14);
            this.Controls.Add(this.field8);
            this.Controls.Add(this.field7);
            this.Controls.Add(this.field6);
            this.Controls.Add(this.field9);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.field1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Name = "MainWindow";
            this.Text = "2048";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGame;
        private System.Windows.Forms.ToolStripMenuItem saveGame;
        private System.Windows.Forms.ToolStripMenuItem loadGame;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeScores;
        private System.Windows.Forms.ToolStripMenuItem resetScores;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeInstruction;
        private System.Windows.Forms.ToolStripMenuItem seeAuthor;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.PictureBox field1;
        private System.Windows.Forms.PictureBox field2;
        private System.Windows.Forms.PictureBox field3;
        private System.Windows.Forms.PictureBox field4;
        private System.Windows.Forms.PictureBox field5;
        private System.Windows.Forms.PictureBox field9;
        private System.Windows.Forms.PictureBox field6;
        private System.Windows.Forms.PictureBox field7;
        private System.Windows.Forms.PictureBox field8;
        private System.Windows.Forms.PictureBox field14;
        private System.Windows.Forms.PictureBox field13;
        private System.Windows.Forms.PictureBox field12;
        private System.Windows.Forms.PictureBox field11;
        private System.Windows.Forms.PictureBox field10;
        private System.Windows.Forms.PictureBox field15;
        private System.Windows.Forms.PictureBox field16;
        private System.Windows.Forms.Label number3;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.Label number4;
        private System.Windows.Forms.Label number5;
        private System.Windows.Forms.Label number9;
        private System.Windows.Forms.Label number13;
        private System.Windows.Forms.Label number6;
        private System.Windows.Forms.Label number7;
        private System.Windows.Forms.Label number16;
        private System.Windows.Forms.Label number12;
        private System.Windows.Forms.Label number8;
        private System.Windows.Forms.Label number14;
        private System.Windows.Forms.Label number10;
        private System.Windows.Forms.Label number15;
        private System.Windows.Forms.Label number11;
        private System.Windows.Forms.Label pointsLabel;
    }
}

