namespace Lab_3
{
    partial class FormSquare
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
            this.Generation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.Del = new System.Windows.Forms.Button();
            this.ChangeSize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NewSize = new System.Windows.Forms.TextBox();
            this.MoveTo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewcoordY = new System.Windows.Forms.TextBox();
            this.NewcoordX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SquareSize = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CoordY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CoordX = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(715, 160);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(118, 43);
            this.Generation.TabIndex = 5;
            this.Generation.Text = "Сгенерировать";
            this.Generation.UseVisualStyleBackColor = true;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(743, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "№";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(828, 228);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(103, 20);
            this.Number.TabIndex = 6;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(828, 560);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(118, 50);
            this.Del.TabIndex = 12;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // ChangeSize
            // 
            this.ChangeSize.Location = new System.Drawing.Point(828, 476);
            this.ChangeSize.Name = "ChangeSize";
            this.ChangeSize.Size = new System.Drawing.Size(118, 50);
            this.ChangeSize.TabIndex = 11;
            this.ChangeSize.Text = "Изменить";
            this.ChangeSize.UseVisualStyleBackColor = true;
            this.ChangeSize.Click += new System.EventHandler(this.ChangeSize_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(737, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "новый размер:";
            // 
            // NewSize
            // 
            this.NewSize.Location = new System.Drawing.Point(828, 424);
            this.NewSize.Name = "NewSize";
            this.NewSize.Size = new System.Drawing.Size(103, 20);
            this.NewSize.TabIndex = 10;
            // 
            // MoveTo
            // 
            this.MoveTo.Location = new System.Drawing.Point(828, 347);
            this.MoveTo.Name = "MoveTo";
            this.MoveTo.Size = new System.Drawing.Size(118, 51);
            this.MoveTo.TabIndex = 9;
            this.MoveTo.Text = "Передвинуть";
            this.MoveTo.UseVisualStyleBackColor = true;
            this.MoveTo.Click += new System.EventHandler(this.MoveTo_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(743, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "новый y:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(743, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "новый x:";
            // 
            // NewcoordY
            // 
            this.NewcoordY.Location = new System.Drawing.Point(828, 303);
            this.NewcoordY.Name = "NewcoordY";
            this.NewcoordY.Size = new System.Drawing.Size(103, 20);
            this.NewcoordY.TabIndex = 8;
            // 
            // NewcoordX
            // 
            this.NewcoordX.Location = new System.Drawing.Point(828, 264);
            this.NewcoordX.Name = "NewcoordX";
            this.NewcoordX.Size = new System.Drawing.Size(103, 20);
            this.NewcoordX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(743, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "размер:";
            // 
            // SquareSize
            // 
            this.SquareSize.Location = new System.Drawing.Point(828, 119);
            this.SquareSize.Name = "SquareSize";
            this.SquareSize.Size = new System.Drawing.Size(103, 20);
            this.SquareSize.TabIndex = 3;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(828, 160);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(118, 43);
            this.Create.TabIndex = 4;
            this.Create.Text = "Показать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(743, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "начало y:";
            // 
            // CoordY
            // 
            this.CoordY.Location = new System.Drawing.Point(828, 82);
            this.CoordY.Name = "CoordY";
            this.CoordY.Size = new System.Drawing.Size(103, 20);
            this.CoordY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(743, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "начало x:";
            // 
            // CoordX
            // 
            this.CoordX.Location = new System.Drawing.Point(828, 47);
            this.CoordX.Name = "CoordX";
            this.CoordX.Size = new System.Drawing.Size(103, 20);
            this.CoordX.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-19, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 639);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 640);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.ChangeSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewSize);
            this.Controls.Add(this.MoveTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewcoordY);
            this.Controls.Add(this.NewcoordX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SquareSize);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoordY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoordX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSquare";
            this.Text = "FormSquare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button ChangeSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewSize;
        private System.Windows.Forms.Button MoveTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewcoordY;
        private System.Windows.Forms.TextBox NewcoordX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SquareSize;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoordY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CoordX;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}