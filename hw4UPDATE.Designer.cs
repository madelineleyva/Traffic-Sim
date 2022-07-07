
namespace hw1
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
            this.north = new System.Windows.Forms.PictureBox();
            this.south = new System.Windows.Forms.PictureBox();
            this.east = new System.Windows.Forms.PictureBox();
            this.west = new System.Windows.Forms.PictureBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.light1a = new System.Windows.Forms.Button();
            this.light1b = new System.Windows.Forms.Button();
            this.light2b = new System.Windows.Forms.Button();
            this.light2a = new System.Windows.Forms.Button();
            this.light3b = new System.Windows.Forms.Button();
            this.light3a = new System.Windows.Forms.Button();
            this.light4b = new System.Windows.Forms.Button();
            this.light4a = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.light1c = new System.Windows.Forms.Button();
            this.light2c = new System.Windows.Forms.Button();
            this.light3c = new System.Windows.Forms.Button();
            this.light4c = new System.Windows.Forms.Button();
            this.timeOutput = new System.Windows.Forms.Label();
            this.playByPlay = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.north)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.south)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.east)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.west)).BeginInit();
            this.SuspendLayout();
            // 
            // north
            // 
            this.north.BackColor = System.Drawing.SystemColors.ControlDark;
            this.north.Location = new System.Drawing.Point(19, 69);
            this.north.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(227, 467);
            this.north.TabIndex = 0;
            this.north.TabStop = false;
            // 
            // south
            // 
            this.south.BackColor = System.Drawing.SystemColors.ControlDark;
            this.south.Location = new System.Drawing.Point(264, 69);
            this.south.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(227, 467);
            this.south.TabIndex = 1;
            this.south.TabStop = false;
            // 
            // east
            // 
            this.east.BackColor = System.Drawing.SystemColors.ControlDark;
            this.east.Location = new System.Drawing.Point(509, 69);
            this.east.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.east.Name = "east";
            this.east.Size = new System.Drawing.Size(227, 467);
            this.east.TabIndex = 2;
            this.east.TabStop = false;
            // 
            // west
            // 
            this.west.BackColor = System.Drawing.SystemColors.ControlDark;
            this.west.Location = new System.Drawing.Point(754, 69);
            this.west.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.west.Name = "west";
            this.west.Size = new System.Drawing.Size(227, 467);
            this.west.TabIndex = 3;
            this.west.TabStop = false;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(62, 573);
            this.runBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(176, 74);
            this.runBtn.TabIndex = 4;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(256, 573);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(176, 74);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // light1a
            // 
            this.light1a.Location = new System.Drawing.Point(75, 115);
            this.light1a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light1a.Name = "light1a";
            this.light1a.Size = new System.Drawing.Size(107, 93);
            this.light1a.TabIndex = 6;
            this.light1a.UseVisualStyleBackColor = true;
            this.light1a.UseWaitCursor = true;
            this.light1a.Click += new System.EventHandler(this.light1a_Click);
            // 
            // light1b
            // 
            this.light1b.Location = new System.Drawing.Point(75, 393);
            this.light1b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light1b.Name = "light1b";
            this.light1b.Size = new System.Drawing.Size(107, 93);
            this.light1b.TabIndex = 7;
            this.light1b.UseVisualStyleBackColor = true;
            this.light1b.UseWaitCursor = true;
            // 
            // light2b
            // 
            this.light2b.Location = new System.Drawing.Point(325, 393);
            this.light2b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light2b.Name = "light2b";
            this.light2b.Size = new System.Drawing.Size(107, 93);
            this.light2b.TabIndex = 9;
            this.light2b.UseVisualStyleBackColor = true;
            this.light2b.UseWaitCursor = true;
            // 
            // light2a
            // 
            this.light2a.Location = new System.Drawing.Point(325, 115);
            this.light2a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light2a.Name = "light2a";
            this.light2a.Size = new System.Drawing.Size(107, 93);
            this.light2a.TabIndex = 8;
            this.light2a.UseVisualStyleBackColor = true;
            this.light2a.UseWaitCursor = true;
            // 
            // light3b
            // 
            this.light3b.Location = new System.Drawing.Point(567, 393);
            this.light3b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light3b.Name = "light3b";
            this.light3b.Size = new System.Drawing.Size(107, 93);
            this.light3b.TabIndex = 11;
            this.light3b.UseVisualStyleBackColor = true;
            this.light3b.UseWaitCursor = true;
            // 
            // light3a
            // 
            this.light3a.Location = new System.Drawing.Point(567, 115);
            this.light3a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light3a.Name = "light3a";
            this.light3a.Size = new System.Drawing.Size(107, 93);
            this.light3a.TabIndex = 10;
            this.light3a.UseVisualStyleBackColor = true;
            this.light3a.UseWaitCursor = true;
            // 
            // light4b
            // 
            this.light4b.Location = new System.Drawing.Point(816, 393);
            this.light4b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light4b.Name = "light4b";
            this.light4b.Size = new System.Drawing.Size(107, 93);
            this.light4b.TabIndex = 13;
            this.light4b.UseVisualStyleBackColor = true;
            this.light4b.UseWaitCursor = true;
            // 
            // light4a
            // 
            this.light4a.Location = new System.Drawing.Point(816, 115);
            this.light4a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light4a.Name = "light4a";
            this.light4a.Size = new System.Drawing.Size(107, 93);
            this.light4a.TabIndex = 12;
            this.light4a.UseVisualStyleBackColor = true;
            this.light4a.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "North";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "South";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "East";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(828, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "West";
            // 
            // light1c
            // 
            this.light1c.Location = new System.Drawing.Point(75, 254);
            this.light1c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light1c.Name = "light1c";
            this.light1c.Size = new System.Drawing.Size(107, 93);
            this.light1c.TabIndex = 22;
            this.light1c.UseVisualStyleBackColor = true;
            this.light1c.UseWaitCursor = true;
            // 
            // light2c
            // 
            this.light2c.Location = new System.Drawing.Point(325, 254);
            this.light2c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light2c.Name = "light2c";
            this.light2c.Size = new System.Drawing.Size(107, 93);
            this.light2c.TabIndex = 23;
            this.light2c.UseVisualStyleBackColor = true;
            this.light2c.UseWaitCursor = true;
            // 
            // light3c
            // 
            this.light3c.Location = new System.Drawing.Point(567, 254);
            this.light3c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light3c.Name = "light3c";
            this.light3c.Size = new System.Drawing.Size(107, 93);
            this.light3c.TabIndex = 24;
            this.light3c.UseVisualStyleBackColor = true;
            this.light3c.UseWaitCursor = true;
            // 
            // light4c
            // 
            this.light4c.Location = new System.Drawing.Point(816, 254);
            this.light4c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.light4c.Name = "light4c";
            this.light4c.Size = new System.Drawing.Size(107, 93);
            this.light4c.TabIndex = 25;
            this.light4c.UseVisualStyleBackColor = true;
            this.light4c.UseWaitCursor = true;
            // 
            // timeOutput
            // 
            this.timeOutput.AutoSize = true;
            this.timeOutput.Location = new System.Drawing.Point(503, 595);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(197, 32);
            this.timeOutput.TabIndex = 26;
            this.timeOutput.Text = "Time Elapsed:";
            // 
            // playByPlay
            // 
            this.playByPlay.FormattingEnabled = true;
            this.playByPlay.ItemHeight = 31;
            this.playByPlay.Location = new System.Drawing.Point(1000, 69);
            this.playByPlay.Name = "playByPlay";
            this.playByPlay.Size = new System.Drawing.Size(1025, 469);
            this.playByPlay.TabIndex = 27;
            this.playByPlay.SelectedIndexChanged += new System.EventHandler(this.playByPlay_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3687, 675);
            this.Controls.Add(this.playByPlay);
            this.Controls.Add(this.timeOutput);
            this.Controls.Add(this.light4c);
            this.Controls.Add(this.light3c);
            this.Controls.Add(this.light2c);
            this.Controls.Add(this.light1c);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.light4b);
            this.Controls.Add(this.light4a);
            this.Controls.Add(this.light3b);
            this.Controls.Add(this.light3a);
            this.Controls.Add(this.light2b);
            this.Controls.Add(this.light2a);
            this.Controls.Add(this.light1b);
            this.Controls.Add(this.light1a);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.west);
            this.Controls.Add(this.east);
            this.Controls.Add(this.south);
            this.Controls.Add(this.north);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Stoplight";
            ((System.ComponentModel.ISupportInitialize)(this.north)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.south)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.east)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.west)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox north;
        private System.Windows.Forms.PictureBox south;
        private System.Windows.Forms.PictureBox east;
        private System.Windows.Forms.PictureBox west;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button light1a;
        private System.Windows.Forms.Button light1b;
        private System.Windows.Forms.Button light2b;
        private System.Windows.Forms.Button light2a;
        private System.Windows.Forms.Button light3b;
        private System.Windows.Forms.Button light3a;
        private System.Windows.Forms.Button light4b;
        private System.Windows.Forms.Button light4a;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button light1c;
        private System.Windows.Forms.Button light2c;
        private System.Windows.Forms.Button light3c;
        private System.Windows.Forms.Button light4c;
        private System.Windows.Forms.Label timeOutput;
        private System.Windows.Forms.ListBox playByPlay;
    }
}

