using System.Windows.Forms;

namespace Lab_5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Showing = new System.Windows.Forms.Button();
            this.Erase = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckQuadrangular = new System.Windows.Forms.CheckBox();
            this.CheckRound = new System.Windows.Forms.CheckBox();
            this.ChangeCircles = new System.Windows.Forms.Button();
            this.ChangeQuadrangles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1160, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1307, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Массив";
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(1234, 77);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(102, 48);
            this.Create.TabIndex = 2;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Showing
            // 
            this.Showing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Showing.Location = new System.Drawing.Point(1342, 77);
            this.Showing.Name = "Showing";
            this.Showing.Size = new System.Drawing.Size(110, 48);
            this.Showing.TabIndex = 3;
            this.Showing.Text = "Показать";
            this.Showing.UseVisualStyleBackColor = true;
            this.Showing.Click += new System.EventHandler(this.Showing_Click);
            // 
            // Erase
            // 
            this.Erase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Erase.Location = new System.Drawing.Point(1234, 131);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(102, 48);
            this.Erase.TabIndex = 4;
            this.Erase.Text = "Стереть";
            this.Erase.UseVisualStyleBackColor = true;
            this.Erase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Delete.Location = new System.Drawing.Point(1342, 131);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 48);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Уничтожить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1210, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 63);
            this.label2.TabIndex = 6;
            this.label2.Text = "Для перемещенния фигур используйте стрелки на клавиатуре";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckQuadrangular);
            this.panel1.Controls.Add(this.CheckRound);
            this.panel1.Location = new System.Drawing.Point(1234, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 118);
            this.panel1.TabIndex = 7;
            // 
            // CheckQuadrangles
            // 
            this.CheckQuadrangular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckQuadrangular.Location = new System.Drawing.Point(3, 66);
            this.CheckQuadrangular.Name = "CheckQuadrangles";
            this.CheckQuadrangular.Size = new System.Drawing.Size(162, 49);
            this.CheckQuadrangular.TabIndex = 9;
            this.CheckQuadrangular.Text = "Многоугольники";
            this.CheckQuadrangular.UseVisualStyleBackColor = true;
            this.CheckQuadrangular.CheckedChanged += new System.EventHandler(this.CheckQuadrangular_CheckedChanged);
            // 
            // CheckCircles
            // 
            this.CheckRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckRound.Location = new System.Drawing.Point(3, 3);
            this.CheckRound.Name = "CheckCircles";
            this.CheckRound.Size = new System.Drawing.Size(162, 57);
            this.CheckRound.TabIndex = 8;
            this.CheckRound.Text = "Круглые фигуры";
            this.CheckRound.UseVisualStyleBackColor = true;
            this.CheckRound.CheckedChanged += new System.EventHandler(this.CheckCircle_CheckedChanged);
            // 
            // ChangeCircles
            // 
            this.ChangeCircles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeCircles.Location = new System.Drawing.Point(1234, 447);
            this.ChangeCircles.Name = "ChangeCircles";
            this.ChangeCircles.Size = new System.Drawing.Size(102, 48);
            this.ChangeCircles.TabIndex = 8;
            this.ChangeCircles.Text = "Круглые";
            this.ChangeCircles.UseVisualStyleBackColor = true;
            this.ChangeCircles.Click += new System.EventHandler(this.ChangeRound_Click);
            // 
            // ChangeQuadrangles
            // 
            this.ChangeQuadrangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeQuadrangles.Location = new System.Drawing.Point(1342, 447);
            this.ChangeQuadrangles.Name = "ChangeQuadrangles";
            this.ChangeQuadrangles.Size = new System.Drawing.Size(122, 48);
            this.ChangeQuadrangles.TabIndex = 9;
            this.ChangeQuadrangles.Text = "Многоугольники";
            this.ChangeQuadrangles.UseVisualStyleBackColor = true;
            this.ChangeQuadrangles.Click += new System.EventHandler(this.ChangeQuadrangular_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1210, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 39);
            this.label3.TabIndex = 15;
            this.label3.Text = "Изменение размеров фигур:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 751);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeQuadrangles);
            this.Controls.Add(this.ChangeCircles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Erase);
            this.Controls.Add(this.Showing);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Label label1;
        private Button Create;
        private Button Showing;
        private Button Erase;
        private Button Delete;
        private Label label2;
        private Panel panel1;
        private CheckBox CheckRound;
        private CheckBox CheckQuadrangular;
        private Button ChangeCircles;
        private Button ChangeQuadrangles;
        private Label label3;
    }
}

