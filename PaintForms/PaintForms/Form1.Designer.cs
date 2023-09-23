namespace PaintForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Circle = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ColorsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Yellow = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Villet = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Width = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Square = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).BeginInit();
            this.ColorsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Circle
            // 
            this.Circle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Circle.Location = new System.Drawing.Point(2, 134);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(1010, 449);
            this.Circle.TabIndex = 0;
            this.Circle.TabStop = false;
            this.Circle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Holst_MouseDown);
            this.Circle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Holst_MouseMove);
            this.Circle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Holst_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(876, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear Holst";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(724, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save Holst Bro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Save_Click);
            // 
            // ColorsPanel
            // 
            this.ColorsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorsPanel.Controls.Add(this.ChangeColor);
            this.ColorsPanel.Controls.Add(this.button);
            this.ColorsPanel.Controls.Add(this.label1);
            this.ColorsPanel.Controls.Add(this.Yellow);
            this.ColorsPanel.Controls.Add(this.Pink);
            this.ColorsPanel.Controls.Add(this.Green);
            this.ColorsPanel.Controls.Add(this.Red);
            this.ColorsPanel.Controls.Add(this.Villet);
            this.ColorsPanel.Controls.Add(this.Blue);
            this.ColorsPanel.Controls.Add(this.White);
            this.ColorsPanel.Controls.Add(this.Black);
            this.ColorsPanel.Location = new System.Drawing.Point(181, 16);
            this.ColorsPanel.Name = "ColorsPanel";
            this.ColorsPanel.Size = new System.Drawing.Size(189, 78);
            this.ColorsPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Цветошки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow.Location = new System.Drawing.Point(41, 32);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(30, 23);
            this.Yellow.TabIndex = 7;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Color_Click);
            // 
            // Pink
            // 
            this.Pink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Pink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pink.Location = new System.Drawing.Point(114, 3);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(31, 23);
            this.Pink.TabIndex = 6;
            this.Pink.UseVisualStyleBackColor = false;
            this.Pink.Click += new System.EventHandler(this.Color_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.LimeGreen;
            this.Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green.Location = new System.Drawing.Point(77, 3);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(31, 23);
            this.Green.TabIndex = 5;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Color_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red.Location = new System.Drawing.Point(40, 3);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(31, 23);
            this.Red.TabIndex = 4;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Color_Click);
            // 
            // Villet
            // 
            this.Villet.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Villet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Villet.Location = new System.Drawing.Point(114, 32);
            this.Villet.Name = "Villet";
            this.Villet.Size = new System.Drawing.Size(30, 23);
            this.Villet.TabIndex = 3;
            this.Villet.UseVisualStyleBackColor = false;
            this.Villet.Click += new System.EventHandler(this.Color_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blue.Location = new System.Drawing.Point(78, 32);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(30, 23);
            this.Blue.TabIndex = 2;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Color_Click);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.White.Location = new System.Drawing.Point(4, 32);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(30, 23);
            this.White.TabIndex = 1;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.Color_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Black.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Black.Location = new System.Drawing.Point(4, 3);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(30, 23);
            this.Black.TabIndex = 0;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Color_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Width);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 78);
            this.panel1.TabIndex = 4;
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(18, 3);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(118, 45);
            this.Width.TabIndex = 1;
            this.Width.ValueChanged += new System.EventHandler(this.Width_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Толщина";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Triangle);
            this.panel2.Controls.Add(this.Square);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(385, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 78);
            this.panel2.TabIndex = 5;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Blue;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(151, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(30, 23);
            this.button.TabIndex = 9;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.Color_Click);
            // 
            // ChangeColor
            // 
            this.ChangeColor.BackColor = System.Drawing.Color.Transparent;
            this.ChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColor.Image = ((System.Drawing.Image)(resources.GetObject("ChangeColor.Image")));
            this.ChangeColor.Location = new System.Drawing.Point(151, 32);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(30, 23);
            this.ChangeColor.TabIndex = 10;
            this.ChangeColor.Text = "?";
            this.ChangeColor.UseVisualStyleBackColor = false;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 52);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фигуры";
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(98, 4);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(64, 52);
            this.Square.TabIndex = 7;
            this.Square.UseVisualStyleBackColor = true;
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(191, 4);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(64, 52);
            this.Triangle.TabIndex = 7;
            this.Triangle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColorsPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Circle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).EndInit();
            this.ColorsPanel.ResumeLayout(false);
            this.ColorsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Circle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel ColorsPanel;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Pink;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Villet;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Width;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ChangeColor;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

