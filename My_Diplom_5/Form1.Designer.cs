namespace My_Diplom_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVariant = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUD_tau = new System.Windows.Forms.NumericUpDown();
            this.numUD_Delta0 = new System.Windows.Forms.NumericUpDown();
            this.numUD_f = new System.Windows.Forms.NumericUpDown();
            this.numUD_vA = new System.Windows.Forms.NumericUpDown();
            this.numUD_betta = new System.Windows.Forms.NumericUpDown();
            this.numUD_R = new System.Windows.Forms.NumericUpDown();
            this.numUD_alfa = new System.Windows.Forms.NumericUpDown();
            this.numUD_c = new System.Windows.Forms.NumericUpDown();
            this.numUD_a = new System.Windows.Forms.NumericUpDown();
            this.numUD_m = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_tau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Delta0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_vA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_betta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_alfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Завдання \"Д-3\" з предмету \"Теоретична механіка\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Варіант №";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(114, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 126);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(199, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Закон сили :";
            // 
            // comboBoxVariant
            // 
            this.comboBoxVariant.FormattingEnabled = true;
            this.comboBoxVariant.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxVariant.Location = new System.Drawing.Point(147, 40);
            this.comboBoxVariant.Name = "comboBoxVariant";
            this.comboBoxVariant.Size = new System.Drawing.Size(73, 24);
            this.comboBoxVariant.TabIndex = 4;
            this.comboBoxVariant.SelectedIndexChanged += new System.EventHandler(this.comboBoxVariant_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUD_tau);
            this.groupBox1.Controls.Add(this.numUD_Delta0);
            this.groupBox1.Controls.Add(this.numUD_f);
            this.groupBox1.Controls.Add(this.numUD_vA);
            this.groupBox1.Controls.Add(this.numUD_betta);
            this.groupBox1.Controls.Add(this.numUD_R);
            this.groupBox1.Controls.Add(this.numUD_alfa);
            this.groupBox1.Controls.Add(this.numUD_c);
            this.groupBox1.Controls.Add(this.numUD_a);
            this.groupBox1.Controls.Add(this.numUD_m);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(23, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вхідні параметри";
            // 
            // numUD_tau
            // 
            this.numUD_tau.DecimalPlaces = 2;
            this.numUD_tau.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_tau.Location = new System.Drawing.Point(578, 70);
            this.numUD_tau.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_tau.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_tau.Name = "numUD_tau";
            this.numUD_tau.Size = new System.Drawing.Size(79, 27);
            this.numUD_tau.TabIndex = 7;
            this.numUD_tau.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // numUD_Delta0
            // 
            this.numUD_Delta0.DecimalPlaces = 2;
            this.numUD_Delta0.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_Delta0.Location = new System.Drawing.Point(578, 20);
            this.numUD_Delta0.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_Delta0.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_Delta0.Name = "numUD_Delta0";
            this.numUD_Delta0.Size = new System.Drawing.Size(79, 27);
            this.numUD_Delta0.TabIndex = 7;
            this.numUD_Delta0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // numUD_f
            // 
            this.numUD_f.DecimalPlaces = 2;
            this.numUD_f.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_f.Location = new System.Drawing.Point(429, 70);
            this.numUD_f.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_f.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_f.Name = "numUD_f";
            this.numUD_f.Size = new System.Drawing.Size(79, 27);
            this.numUD_f.TabIndex = 7;
            this.numUD_f.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // numUD_vA
            // 
            this.numUD_vA.DecimalPlaces = 2;
            this.numUD_vA.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_vA.Location = new System.Drawing.Point(429, 20);
            this.numUD_vA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_vA.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_vA.Name = "numUD_vA";
            this.numUD_vA.Size = new System.Drawing.Size(79, 27);
            this.numUD_vA.TabIndex = 7;
            this.numUD_vA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // numUD_betta
            // 
            this.numUD_betta.DecimalPlaces = 2;
            this.numUD_betta.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_betta.Location = new System.Drawing.Point(300, 70);
            this.numUD_betta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_betta.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_betta.Name = "numUD_betta";
            this.numUD_betta.Size = new System.Drawing.Size(79, 27);
            this.numUD_betta.TabIndex = 7;
            this.numUD_betta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // numUD_R
            // 
            this.numUD_R.DecimalPlaces = 2;
            this.numUD_R.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_R.Location = new System.Drawing.Point(298, 21);
            this.numUD_R.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_R.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_R.Name = "numUD_R";
            this.numUD_R.Size = new System.Drawing.Size(79, 27);
            this.numUD_R.TabIndex = 7;
            this.numUD_R.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // numUD_alfa
            // 
            this.numUD_alfa.DecimalPlaces = 2;
            this.numUD_alfa.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_alfa.Location = new System.Drawing.Point(163, 70);
            this.numUD_alfa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_alfa.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_alfa.Name = "numUD_alfa";
            this.numUD_alfa.Size = new System.Drawing.Size(79, 27);
            this.numUD_alfa.TabIndex = 7;
            this.numUD_alfa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // numUD_c
            // 
            this.numUD_c.DecimalPlaces = 2;
            this.numUD_c.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_c.Location = new System.Drawing.Point(163, 21);
            this.numUD_c.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_c.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_c.Name = "numUD_c";
            this.numUD_c.Size = new System.Drawing.Size(79, 27);
            this.numUD_c.TabIndex = 7;
            this.numUD_c.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // numUD_a
            // 
            this.numUD_a.DecimalPlaces = 2;
            this.numUD_a.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_a.Location = new System.Drawing.Point(35, 70);
            this.numUD_a.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_a.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_a.Name = "numUD_a";
            this.numUD_a.Size = new System.Drawing.Size(79, 27);
            this.numUD_a.TabIndex = 7;
            this.numUD_a.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // numUD_m
            // 
            this.numUD_m.DecimalPlaces = 2;
            this.numUD_m.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numUD_m.Location = new System.Drawing.Point(35, 26);
            this.numUD_m.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUD_m.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numUD_m.Name = "numUD_m";
            this.numUD_m.Size = new System.Drawing.Size(79, 27);
            this.numUD_m.TabIndex = 7;
            this.numUD_m.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numUD_m_MouseUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(526, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "tau:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(398, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "f:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "betta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "alfa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "a:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Delta0:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "vA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "R:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "m:";
            // 
            // textBox_output
            // 
            this.textBox_output.AllowDrop = true;
            this.textBox_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_output.Location = new System.Drawing.Point(106, 440);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(348, 181);
            this.textBox_output.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(703, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(674, 509);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1399, 698);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxVariant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Завдання \"Д-3\" з предмету \"Теоретична механіка\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_tau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Delta0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_vA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_betta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_alfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVariant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.NumericUpDown numUD_tau;
        private System.Windows.Forms.NumericUpDown numUD_Delta0;
        private System.Windows.Forms.NumericUpDown numUD_f;
        private System.Windows.Forms.NumericUpDown numUD_vA;
        private System.Windows.Forms.NumericUpDown numUD_betta;
        private System.Windows.Forms.NumericUpDown numUD_R;
        private System.Windows.Forms.NumericUpDown numUD_alfa;
        private System.Windows.Forms.NumericUpDown numUD_c;
        private System.Windows.Forms.NumericUpDown numUD_a;
        private System.Windows.Forms.NumericUpDown numUD_m;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

