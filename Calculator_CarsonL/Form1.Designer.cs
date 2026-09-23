namespace Calculator_CarsonL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            result = new Label();
            Divide = new Button();
            Multiply = new Button();
            Subtract = new Button();
            Add = new Button();
            equal = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button0 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            pictureBox1 = new PictureBox();
            Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.MediumPurple;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(36, 201);
            button1.Name = "button1";
            button1.Size = new Size(133, 54);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 34);
            label1.TabIndex = 1;
            label1.Text = "Calculator";
            // 
            // result
            // 
            result.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            result.AutoSize = true;
            result.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            result.Location = new Point(426, 122);
            result.Name = "result";
            result.Size = new Size(0, 47);
            result.TabIndex = 2;
            // 
            // Divide
            // 
            Divide.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Divide.BackColor = Color.Maroon;
            Divide.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Divide.Location = new Point(524, 198);
            Divide.Name = "Divide";
            Divide.Size = new Size(88, 42);
            Divide.TabIndex = 12;
            Divide.Text = "%";
            Divide.UseVisualStyleBackColor = false;
            Divide.Click += Divide_Click;
            // 
            // Multiply
            // 
            Multiply.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Multiply.BackColor = Color.Maroon;
            Multiply.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Multiply.Location = new Point(524, 246);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(87, 42);
            Multiply.TabIndex = 13;
            Multiply.Text = "X";
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += Multiply_Click;
            // 
            // Subtract
            // 
            Subtract.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Subtract.BackColor = Color.Maroon;
            Subtract.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subtract.Location = new Point(524, 294);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(87, 42);
            Subtract.TabIndex = 14;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = false;
            Subtract.Click += Subtract_Click;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Add.BackColor = Color.Maroon;
            Add.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Add.Location = new Point(524, 342);
            Add.Name = "Add";
            Add.Size = new Size(87, 42);
            Add.TabIndex = 16;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // equal
            // 
            equal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            equal.BackColor = Color.Maroon;
            equal.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            equal.Location = new Point(478, 414);
            equal.Name = "equal";
            equal.Size = new Size(133, 42);
            equal.TabIndex = 17;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.MediumPurple;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(192, 201);
            button2.Name = "button2";
            button2.Size = new Size(142, 54);
            button2.TabIndex = 18;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.MediumPurple;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(357, 201);
            button3.Name = "button3";
            button3.Size = new Size(133, 54);
            button3.TabIndex = 19;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.MediumPurple;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(36, 273);
            button4.Name = "button4";
            button4.Size = new Size(133, 52);
            button4.TabIndex = 20;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.MediumPurple;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(192, 273);
            button5.Name = "button5";
            button5.Size = new Size(142, 52);
            button5.TabIndex = 21;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.MediumPurple;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(357, 273);
            button6.Name = "button6";
            button6.Size = new Size(133, 52);
            button6.TabIndex = 22;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button0.BackColor = Color.MediumPurple;
            button0.BackgroundImageLayout = ImageLayout.Center;
            button0.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button0.ImageAlign = ContentAlignment.TopCenter;
            button0.Location = new Point(192, 409);
            button0.Name = "button0";
            button0.Size = new Size(142, 52);
            button0.TabIndex = 23;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.BackColor = Color.MediumPurple;
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.Location = new Point(36, 342);
            button7.Name = "button7";
            button7.Size = new Size(133, 56);
            button7.TabIndex = 24;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.BackColor = Color.MediumPurple;
            button8.BackgroundImageLayout = ImageLayout.Center;
            button8.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button8.ImageAlign = ContentAlignment.TopCenter;
            button8.Location = new Point(192, 342);
            button8.Name = "button8";
            button8.Size = new Size(142, 56);
            button8.TabIndex = 25;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.BackColor = Color.MediumPurple;
            button9.BackgroundImageLayout = ImageLayout.Center;
            button9.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button9.ImageAlign = ContentAlignment.TopCenter;
            button9.Location = new Point(357, 342);
            button9.Name = "button9";
            button9.Size = new Size(133, 56);
            button9.TabIndex = 26;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.MenuHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 181);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // Clear
            // 
            Clear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Clear.BackColor = Color.RoyalBlue;
            Clear.BackgroundImageLayout = ImageLayout.Center;
            Clear.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Clear.ImageAlign = ContentAlignment.TopCenter;
            Clear.Location = new Point(455, 12);
            Clear.Name = "Clear";
            Clear.Size = new Size(156, 57);
            Clear.TabIndex = 28;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(624, 468);
            Controls.Add(Clear);
            Controls.Add(pictureBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button0);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(equal);
            Controls.Add(Add);
            Controls.Add(Subtract);
            Controls.Add(Multiply);
            Controls.Add(Divide);
            Controls.Add(result);
            Controls.Add(label1);
            Controls.Add(button1);
            Cursor = Cursors.Hand;
            ForeColor = Color.Orange;
            MaximizeBox = false;
            Name = "Form1";
            Text = "My App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label result;
        private Button Divide;
        private Button Multiply;
        private Button Subtract;
        private Button Add;
        private Button equal;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button0;
        private Button button7;
        private Button button8;
        private Button button9;
        private PictureBox pictureBox1;
        private Button Clear;
    }
}
