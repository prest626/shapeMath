
namespace shapeMath
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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.radius = new System.Windows.Forms.NumericUpDown();
            this.base1 = new System.Windows.Forms.NumericUpDown();
            this.base2 = new System.Windows.Forms.NumericUpDown();
            this.radius_lbl = new System.Windows.Forms.Label();
            this.base1_lbl = new System.Windows.Forms.Label();
            this.base2_lbl = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.height_lbl = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "Area of a Circle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cirArea);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(319, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 87);
            this.button4.TabIndex = 0;
            this.button4.Text = "Area of a Cube";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.cubArea);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(458, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 87);
            this.button5.TabIndex = 0;
            this.button5.Text = "Area of a trapesium";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.trapArea);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(601, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 87);
            this.button6.TabIndex = 0;
            this.button6.Text = "Area of a Triangle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.triArea);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(176, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 87);
            this.button8.TabIndex = 0;
            this.button8.Text = "Perimiter of a Circle";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.cirPer);
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(31, 66);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(120, 20);
            this.radius.TabIndex = 1;
            // 
            // base1
            // 
            this.base1.Location = new System.Drawing.Point(165, 66);
            this.base1.Name = "base1";
            this.base1.Size = new System.Drawing.Size(120, 20);
            this.base1.TabIndex = 1;
            // 
            // base2
            // 
            this.base2.Location = new System.Drawing.Point(308, 66);
            this.base2.Name = "base2";
            this.base2.Size = new System.Drawing.Size(120, 20);
            this.base2.TabIndex = 1;
            // 
            // radius_lbl
            // 
            this.radius_lbl.AutoSize = true;
            this.radius_lbl.Location = new System.Drawing.Point(31, 47);
            this.radius_lbl.Name = "radius_lbl";
            this.radius_lbl.Size = new System.Drawing.Size(40, 13);
            this.radius_lbl.TabIndex = 2;
            this.radius_lbl.Text = "Radius";
            // 
            // base1_lbl
            // 
            this.base1_lbl.AutoSize = true;
            this.base1_lbl.Location = new System.Drawing.Point(162, 47);
            this.base1_lbl.Name = "base1_lbl";
            this.base1_lbl.Size = new System.Drawing.Size(40, 13);
            this.base1_lbl.TabIndex = 2;
            this.base1_lbl.Text = "Base 1";
            // 
            // base2_lbl
            // 
            this.base2_lbl.AutoSize = true;
            this.base2_lbl.Location = new System.Drawing.Point(305, 47);
            this.base2_lbl.Name = "base2_lbl";
            this.base2_lbl.Size = new System.Drawing.Size(40, 13);
            this.base2_lbl.TabIndex = 2;
            this.base2_lbl.Text = "Base 2";
            this.base2_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(447, 66);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(120, 20);
            this.height.TabIndex = 1;
            // 
            // height_lbl
            // 
            this.height_lbl.AutoSize = true;
            this.height_lbl.Location = new System.Drawing.Point(444, 47);
            this.height_lbl.Name = "height_lbl";
            this.height_lbl.Size = new System.Drawing.Size(38, 13);
            this.height_lbl.TabIndex = 2;
            this.height_lbl.Text = "Height";
            this.height_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(109, 342);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(679, 36);
            this.answer.TabIndex = 2;
            this.answer.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Answer Is:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base One Is The Base You Use If There Is Only One Base ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.height_lbl);
            this.Controls.Add(this.base2_lbl);
            this.Controls.Add(this.base1_lbl);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.radius_lbl);
            this.Controls.Add(this.height);
            this.Controls.Add(this.base2);
            this.Controls.Add(this.base1);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.NumericUpDown base1;
        private System.Windows.Forms.NumericUpDown base2;
        private System.Windows.Forms.Label radius_lbl;
        private System.Windows.Forms.Label base1_lbl;
        private System.Windows.Forms.Label base2_lbl;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label height_lbl;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

