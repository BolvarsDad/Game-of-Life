namespace GoL
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnGlider = new System.Windows.Forms.Button();
            this.btnGliderGun = new System.Windows.Forms.Button();
            this.btnRow = new System.Windows.Forms.Button();
            this.cbGrid = new System.Windows.Forms.CheckBox();
            this.cbDraw = new System.Windows.Forms.CheckBox();
            this.nrDelay = new System.Windows.Forms.NumericUpDown();
            this.lbDelay = new System.Windows.Forms.Label();
            this.nrSize = new System.Windows.Forms.NumericUpDown();
            this.lbSize = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.nrDensity = new System.Windows.Forms.NumericUpDown();
            this.lbDensity = new System.Windows.Forms.Label();
            this.lsThemes = new System.Windows.Forms.CheckedListBox();
            this.lbThemes = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbControls = new System.Windows.Forms.Label();
            this.lsPresets = new System.Windows.Forms.CheckedListBox();
            this.lbPresets = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbGen = new System.Windows.Forms.Label();
            this.lbGenerate = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nrDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.ForeColor = System.Drawing.Color.White;
            this.btnRandom.Location = new System.Drawing.Point(844, 12);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            // 
            // btnGlider
            // 
            this.btnGlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnGlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlider.ForeColor = System.Drawing.Color.White;
            this.btnGlider.Location = new System.Drawing.Point(932, 12);
            this.btnGlider.Name = "btnGlider";
            this.btnGlider.Size = new System.Drawing.Size(75, 23);
            this.btnGlider.TabIndex = 1;
            this.btnGlider.Text = "Glider";
            this.btnGlider.UseVisualStyleBackColor = false;
            this.btnGlider.Click += new System.EventHandler(this.btnGlider_Click);
            // 
            // btnGliderGun
            // 
            this.btnGliderGun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnGliderGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGliderGun.ForeColor = System.Drawing.Color.White;
            this.btnGliderGun.Location = new System.Drawing.Point(1019, 12);
            this.btnGliderGun.Name = "btnGliderGun";
            this.btnGliderGun.Size = new System.Drawing.Size(75, 23);
            this.btnGliderGun.TabIndex = 3;
            this.btnGliderGun.Text = "Glider Gun";
            this.btnGliderGun.UseVisualStyleBackColor = false;
            this.btnGliderGun.Click += new System.EventHandler(this.btnGliderGun_Click);
            // 
            // btnRow
            // 
            this.btnRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRow.ForeColor = System.Drawing.Color.White;
            this.btnRow.Location = new System.Drawing.Point(1105, 12);
            this.btnRow.Name = "btnRow";
            this.btnRow.Size = new System.Drawing.Size(75, 23);
            this.btnRow.TabIndex = 4;
            this.btnRow.Text = "Row";
            this.btnRow.UseVisualStyleBackColor = false;
            this.btnRow.Click += new System.EventHandler(this.btnRow_Click);
            // 
            // cbGrid
            // 
            this.cbGrid.AutoSize = true;
            this.cbGrid.ForeColor = System.Drawing.Color.White;
            this.cbGrid.Location = new System.Drawing.Point(679, 16);
            this.cbGrid.Name = "cbGrid";
            this.cbGrid.Size = new System.Drawing.Size(45, 17);
            this.cbGrid.TabIndex = 6;
            this.cbGrid.Text = "Grid";
            this.cbGrid.UseVisualStyleBackColor = true;
            this.cbGrid.CheckedChanged += new System.EventHandler(this.cbGrid_CheckedChanged);
            // 
            // cbDraw
            // 
            this.cbDraw.AutoSize = true;
            this.cbDraw.ForeColor = System.Drawing.Color.White;
            this.cbDraw.Location = new System.Drawing.Point(605, 16);
            this.cbDraw.Name = "cbDraw";
            this.cbDraw.Size = new System.Drawing.Size(51, 17);
            this.cbDraw.TabIndex = 11;
            this.cbDraw.Text = "Draw";
            this.cbDraw.UseVisualStyleBackColor = true;
            // 
            // nrDelay
            // 
            this.nrDelay.Location = new System.Drawing.Point(503, 14);
            this.nrDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nrDelay.Name = "nrDelay";
            this.nrDelay.Size = new System.Drawing.Size(69, 20);
            this.nrDelay.TabIndex = 12;
            this.nrDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lbDelay
            // 
            this.lbDelay.AutoSize = true;
            this.lbDelay.ForeColor = System.Drawing.Color.White;
            this.lbDelay.Location = new System.Drawing.Point(438, 17);
            this.lbDelay.Name = "lbDelay";
            this.lbDelay.Size = new System.Drawing.Size(59, 13);
            this.lbDelay.TabIndex = 13;
            this.lbDelay.Text = "Delay (ms):";
            // 
            // nrSize
            // 
            this.nrSize.Location = new System.Drawing.Point(345, 15);
            this.nrSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrSize.Name = "nrSize";
            this.nrSize.Size = new System.Drawing.Size(69, 20);
            this.nrSize.TabIndex = 14;
            this.nrSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.ForeColor = System.Drawing.Color.White;
            this.lbSize.Location = new System.Drawing.Point(272, 18);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(67, 13);
            this.lbSize.TabIndex = 15;
            this.lbSize.Text = "Square Size:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 23);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(12, 101);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(12, 72);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(97, 23);
            this.btnPause.TabIndex = 18;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // nrDensity
            // 
            this.nrDensity.Location = new System.Drawing.Point(183, 14);
            this.nrDensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrDensity.Name = "nrDensity";
            this.nrDensity.Size = new System.Drawing.Size(69, 20);
            this.nrDensity.TabIndex = 19;
            this.nrDensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDensity
            // 
            this.lbDensity.AutoSize = true;
            this.lbDensity.ForeColor = System.Drawing.Color.White;
            this.lbDensity.Location = new System.Drawing.Point(115, 17);
            this.lbDensity.Name = "lbDensity";
            this.lbDensity.Size = new System.Drawing.Size(62, 13);
            this.lbDensity.TabIndex = 20;
            this.lbDensity.Text = "Density (%):";
            // 
            // lsThemes
            // 
            this.lsThemes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lsThemes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsThemes.ForeColor = System.Drawing.Color.White;
            this.lsThemes.FormattingEnabled = true;
            this.lsThemes.Items.AddRange(new object[] {
            "Dark / Orange",
            "Dark / Green",
            "Dark / White",
            "Dark / Blue",
            "Dark / Red",
            "Light / Orange",
            "Light / Green",
            "Light / Black",
            "Light / Blue",
            "Light / Red"});
            this.lsThemes.Location = new System.Drawing.Point(12, 170);
            this.lsThemes.Name = "lsThemes";
            this.lsThemes.Size = new System.Drawing.Size(97, 152);
            this.lsThemes.TabIndex = 21;
            this.lsThemes.SelectedIndexChanged += new System.EventHandler(this.lsThemes_SelectedIndexChanged);
            // 
            // lbThemes
            // 
            this.lbThemes.AutoSize = true;
            this.lbThemes.ForeColor = System.Drawing.Color.White;
            this.lbThemes.Location = new System.Drawing.Point(22, 145);
            this.lbThemes.Name = "lbThemes";
            this.lbThemes.Size = new System.Drawing.Size(72, 13);
            this.lbThemes.TabIndex = 22;
            this.lbThemes.Text = "Color Themes";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(12, 599);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(97, 15);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "Sinan Pasic 18B";
            // 
            // lbControls
            // 
            this.lbControls.AutoSize = true;
            this.lbControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControls.ForeColor = System.Drawing.Color.White;
            this.lbControls.Location = new System.Drawing.Point(12, 15);
            this.lbControls.Name = "lbControls";
            this.lbControls.Size = new System.Drawing.Size(97, 16);
            this.lbControls.TabIndex = 24;
            this.lbControls.Text = "Game Controls";
            // 
            // lsPresets
            // 
            this.lsPresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lsPresets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsPresets.ForeColor = System.Drawing.Color.White;
            this.lsPresets.FormattingEnabled = true;
            this.lsPresets.Items.AddRange(new object[] {
            "Preset 1",
            "Preset 2",
            "Preset 3",
            "Preset 4",
            "Preset 5"});
            this.lsPresets.Location = new System.Drawing.Point(12, 382);
            this.lsPresets.Name = "lsPresets";
            this.lsPresets.Size = new System.Drawing.Size(97, 77);
            this.lsPresets.TabIndex = 25;
            // 
            // lbPresets
            // 
            this.lbPresets.AutoSize = true;
            this.lbPresets.ForeColor = System.Drawing.Color.White;
            this.lbPresets.Location = new System.Drawing.Point(27, 357);
            this.lbPresets.Name = "lbPresets";
            this.lbPresets.Size = new System.Drawing.Size(66, 13);
            this.lbPresets.TabIndex = 26;
            this.lbPresets.Text = "Preset Maps";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(118, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 573);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lbGen
            // 
            this.lbGen.AutoSize = true;
            this.lbGen.ForeColor = System.Drawing.Color.White;
            this.lbGen.Location = new System.Drawing.Point(10, 563);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(99, 13);
            this.lbGen.TabIndex = 29;
            this.lbGen.Text = "Current Generation:";
            // 
            // lbGenerate
            // 
            this.lbGenerate.AutoSize = true;
            this.lbGenerate.ForeColor = System.Drawing.Color.White;
            this.lbGenerate.Location = new System.Drawing.Point(760, 17);
            this.lbGenerate.Name = "lbGenerate";
            this.lbGenerate.Size = new System.Drawing.Size(78, 13);
            this.lbGenerate.TabIndex = 30;
            this.lbGenerate.Text = "Generate Map:";
            // 
            // txtGen
            // 
            this.txtGen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtGen.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGen.ForeColor = System.Drawing.Color.White;
            this.txtGen.Location = new System.Drawing.Point(25, 478);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(68, 67);
            this.txtGen.TabIndex = 31;
            this.txtGen.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1213, 647);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.lbGenerate);
            this.Controls.Add(this.lbGen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPresets);
            this.Controls.Add(this.lsPresets);
            this.Controls.Add(this.lbControls);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbThemes);
            this.Controls.Add(this.lsThemes);
            this.Controls.Add(this.lbDensity);
            this.Controls.Add(this.nrDensity);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.nrSize);
            this.Controls.Add(this.lbDelay);
            this.Controls.Add(this.nrDelay);
            this.Controls.Add(this.cbDraw);
            this.Controls.Add(this.cbGrid);
            this.Controls.Add(this.btnRow);
            this.Controls.Add(this.btnGliderGun);
            this.Controls.Add(this.btnGlider);
            this.Controls.Add(this.btnRandom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnGlider;
        private System.Windows.Forms.Button btnGliderGun;
        private System.Windows.Forms.Button btnRow;
        private System.Windows.Forms.CheckBox cbGrid;
        private System.Windows.Forms.CheckBox cbDraw;
        private System.Windows.Forms.NumericUpDown nrDelay;
        private System.Windows.Forms.Label lbDelay;
        private System.Windows.Forms.NumericUpDown nrSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.NumericUpDown nrDensity;
        private System.Windows.Forms.Label lbDensity;
        private System.Windows.Forms.CheckedListBox lsThemes;
        private System.Windows.Forms.Label lbThemes;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbControls;
        private System.Windows.Forms.CheckedListBox lsPresets;
        private System.Windows.Forms.Label lbPresets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbGen;
        private System.Windows.Forms.Label lbGenerate;
        private System.Windows.Forms.RichTextBox txtGen;
        private System.Windows.Forms.Timer timer1;
    }
}

