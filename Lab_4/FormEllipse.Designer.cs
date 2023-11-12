namespace Lab_3
{
    partial class FormEllipse
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
            this.label9 = new System.Windows.Forms.Label();
            this.NewHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Height_size = new System.Windows.Forms.TextBox();
            this.Generation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.Del = new System.Windows.Forms.Button();
            this.ChangeSize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NewWidth = new System.Windows.Forms.TextBox();
            this.MoveTo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewcoordY = new System.Windows.Forms.TextBox();
            this.NewcoordX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Width_size = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CoordYCenter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CoordXCenter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PivotEllipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(757, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 87;
            this.label9.Text = "новая высота:";
            // 
            // NewHeight
            // 
            this.NewHeight.Location = new System.Drawing.Point(848, 420);
            this.NewHeight.Name = "NewHeight";
            this.NewHeight.Size = new System.Drawing.Size(103, 20);
            this.NewHeight.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(763, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "высота:";
            // 
            // Height_size
            // 
            this.Height_size.Location = new System.Drawing.Point(848, 114);
            this.Height_size.Name = "Height_size";
            this.Height_size.Size = new System.Drawing.Size(103, 20);
            this.Height_size.TabIndex = 4;
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(735, 140);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(118, 43);
            this.Generation.TabIndex = 6;
            this.Generation.Text = "Сгенерировать";
            this.Generation.UseVisualStyleBackColor = true;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(763, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "№";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(848, 208);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(103, 20);
            this.Number.TabIndex = 7;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(848, 578);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(118, 50);
            this.Del.TabIndex = 15;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // ChangeSize
            // 
            this.ChangeSize.Location = new System.Drawing.Point(848, 456);
            this.ChangeSize.Name = "ChangeSize";
            this.ChangeSize.Size = new System.Drawing.Size(118, 50);
            this.ChangeSize.TabIndex = 13;
            this.ChangeSize.Text = "Изменить";
            this.ChangeSize.UseVisualStyleBackColor = true;
            this.ChangeSize.Click += new System.EventHandler(this.ChangeSize_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(757, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "новая ширина:";
            // 
            // NewWidth
            // 
            this.NewWidth.Location = new System.Drawing.Point(848, 384);
            this.NewWidth.Name = "NewWidth";
            this.NewWidth.Size = new System.Drawing.Size(103, 20);
            this.NewWidth.TabIndex = 11;
            // 
            // MoveTo
            // 
            this.MoveTo.Location = new System.Drawing.Point(848, 327);
            this.MoveTo.Name = "MoveTo";
            this.MoveTo.Size = new System.Drawing.Size(118, 51);
            this.MoveTo.TabIndex = 10;
            this.MoveTo.Text = "Передвинуть";
            this.MoveTo.UseVisualStyleBackColor = true;
            this.MoveTo.Click += new System.EventHandler(this.MoveTo_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(763, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "новый  y:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(763, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "новый x:";
            // 
            // NewcoordY
            // 
            this.NewcoordY.Location = new System.Drawing.Point(848, 283);
            this.NewcoordY.Name = "NewcoordY";
            this.NewcoordY.Size = new System.Drawing.Size(103, 20);
            this.NewcoordY.TabIndex = 9;
            // 
            // NewcoordX
            // 
            this.NewcoordX.Location = new System.Drawing.Point(848, 244);
            this.NewcoordX.Name = "NewcoordX";
            this.NewcoordX.Size = new System.Drawing.Size(103, 20);
            this.NewcoordX.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(763, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "ширина:";
            // 
            // Width_size
            // 
            this.Width_size.Location = new System.Drawing.Point(848, 84);
            this.Width_size.Name = "Width_size";
            this.Width_size.Size = new System.Drawing.Size(103, 20);
            this.Width_size.TabIndex = 3;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(848, 140);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(118, 43);
            this.Create.TabIndex = 5;
            this.Create.Text = "Показать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(763, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "начало y:";
            // 
            // CoordYCenter
            // 
            this.CoordYCenter.Location = new System.Drawing.Point(848, 47);
            this.CoordYCenter.Name = "CoordYCenter";
            this.CoordYCenter.Size = new System.Drawing.Size(103, 20);
            this.CoordYCenter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(763, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "начало x:";
            // 
            // CoordXCenter
            // 
            this.CoordXCenter.Location = new System.Drawing.Point(848, 12);
            this.CoordXCenter.Name = "CoordXCenter";
            this.CoordXCenter.Size = new System.Drawing.Size(103, 20);
            this.CoordXCenter.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 639);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // PivotEllipse
            // 
            this.PivotEllipse.Location = new System.Drawing.Point(848, 512);
            this.PivotEllipse.Name = "PivotEllipse";
            this.PivotEllipse.Size = new System.Drawing.Size(118, 50);
            this.PivotEllipse.TabIndex = 14;
            this.PivotEllipse.Text = "Повернуть";
            this.PivotEllipse.UseVisualStyleBackColor = true;
            this.PivotEllipse.Click += new System.EventHandler(this.PivotEllipse_Click);
            // 
            // FormEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 640);
            this.Controls.Add(this.PivotEllipse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NewHeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Height_size);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.ChangeSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewWidth);
            this.Controls.Add(this.MoveTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewcoordY);
            this.Controls.Add(this.NewcoordX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Width_size);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoordYCenter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoordXCenter);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEllipse";
            this.Text = "FormLine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NewHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Height_size;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button ChangeSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewWidth;
        private System.Windows.Forms.Button MoveTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewcoordY;
        private System.Windows.Forms.TextBox NewcoordX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Width_size;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoordYCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CoordXCenter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PivotEllipse;
    }
}