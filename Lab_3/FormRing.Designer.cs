namespace Lab_3
{
    partial class FormRing
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
            this.ChangeRad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Newradius = new System.Windows.Forms.TextBox();
            this.MoveTo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewcoordY = new System.Windows.Forms.TextBox();
            this.NewcoordX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Radius = new System.Windows.Forms.TextBox();
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
            this.Generation.Location = new System.Drawing.Point(735, 160);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(118, 43);
            this.Generation.TabIndex = 5;
            this.Generation.Text = "Сгенерировать";
            this.Generation.UseVisualStyleBackColor = true;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(763, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "№";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(848, 228);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(103, 20);
            this.Number.TabIndex = 6;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(848, 560);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(118, 50);
            this.Del.TabIndex = 12;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // ChangeRad
            // 
            this.ChangeRad.Location = new System.Drawing.Point(848, 476);
            this.ChangeRad.Name = "ChangeRad";
            this.ChangeRad.Size = new System.Drawing.Size(118, 50);
            this.ChangeRad.TabIndex = 11;
            this.ChangeRad.Text = "Изменить";
            this.ChangeRad.UseVisualStyleBackColor = true;
            this.ChangeRad.Click += new System.EventHandler(this.ChangeRad_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(757, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "новый радиус:";
            // 
            // Newradius
            // 
            this.Newradius.Location = new System.Drawing.Point(848, 424);
            this.Newradius.Name = "Newradius";
            this.Newradius.Size = new System.Drawing.Size(103, 20);
            this.Newradius.TabIndex = 10;
            // 
            // MoveTo
            // 
            this.MoveTo.Location = new System.Drawing.Point(848, 347);
            this.MoveTo.Name = "MoveTo";
            this.MoveTo.Size = new System.Drawing.Size(118, 51);
            this.MoveTo.TabIndex = 9;
            this.MoveTo.Text = "Передвинуть";
            this.MoveTo.UseVisualStyleBackColor = true;
            this.MoveTo.Click += new System.EventHandler(this.MoveTo_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(763, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "новый y:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(763, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "новый x:";
            // 
            // NewcoordY
            // 
            this.NewcoordY.Location = new System.Drawing.Point(848, 303);
            this.NewcoordY.Name = "NewcoordY";
            this.NewcoordY.Size = new System.Drawing.Size(103, 20);
            this.NewcoordY.TabIndex = 8;
            // 
            // NewcoordX
            // 
            this.NewcoordX.Location = new System.Drawing.Point(848, 264);
            this.NewcoordX.Name = "NewcoordX";
            this.NewcoordX.Size = new System.Drawing.Size(103, 20);
            this.NewcoordX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(763, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "радиус:";
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(848, 119);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(103, 20);
            this.Radius.TabIndex = 3;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(848, 160);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(118, 43);
            this.Create.TabIndex = 4;
            this.Create.Text = "Показать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(763, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "центр y:";
            // 
            // CoordY
            // 
            this.CoordY.Location = new System.Drawing.Point(848, 82);
            this.CoordY.Name = "CoordY";
            this.CoordY.Size = new System.Drawing.Size(103, 20);
            this.CoordY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(763, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "центр x:";
            // 
            // CoordX
            // 
            this.CoordX.Location = new System.Drawing.Point(848, 47);
            this.CoordX.Name = "CoordX";
            this.CoordX.Size = new System.Drawing.Size(103, 20);
            this.CoordX.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 639);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FormRing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 640);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.ChangeRad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Newradius);
            this.Controls.Add(this.MoveTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewcoordY);
            this.Controls.Add(this.NewcoordX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoordY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoordX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRing";
            this.Text = "FormRing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button ChangeRad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Newradius;
        private System.Windows.Forms.Button MoveTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewcoordY;
        private System.Windows.Forms.TextBox NewcoordX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoordY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CoordX;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}