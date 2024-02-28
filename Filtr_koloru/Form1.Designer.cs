namespace Filtr_koloru
{
    partial class Window
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Przycisk = new System.Windows.Forms.Button();
            this.asemblerDLL = new System.Windows.Forms.CheckBox();
            this.FirstPhoto = new System.Windows.Forms.PictureBox();
            this.photo = new System.Windows.Forms.Button();
            this.SecondPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ColorChoice = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirstPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // Przycisk
            // 
            this.Przycisk.BackColor = System.Drawing.SystemColors.Window;
            this.Przycisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Przycisk.Location = new System.Drawing.Point(474, 551);
            this.Przycisk.Name = "Przycisk";
            this.Przycisk.Size = new System.Drawing.Size(181, 68);
            this.Przycisk.TabIndex = 0;
            this.Przycisk.Text = "Start";
            this.Przycisk.UseVisualStyleBackColor = false;
            this.Przycisk.Click += new System.EventHandler(this.Przycisk_Click);
            // 
            // asemblerDLL
            // 
            this.asemblerDLL.AutoSize = true;
            this.asemblerDLL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.asemblerDLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asemblerDLL.Location = new System.Drawing.Point(12, 74);
            this.asemblerDLL.Name = "asemblerDLL";
            this.asemblerDLL.Size = new System.Drawing.Size(107, 28);
            this.asemblerDLL.TabIndex = 1;
            this.asemblerDLL.Text = "asembler";
            this.asemblerDLL.UseVisualStyleBackColor = false;
            // 
            // FirstPhoto
            // 
            this.FirstPhoto.Location = new System.Drawing.Point(13, 142);
            this.FirstPhoto.Name = "FirstPhoto";
            this.FirstPhoto.Size = new System.Drawing.Size(525, 386);
            this.FirstPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirstPhoto.TabIndex = 3;
            this.FirstPhoto.TabStop = false;
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.Color.Snow;
            this.photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.photo.Location = new System.Drawing.Point(12, 12);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(166, 56);
            this.photo.TabIndex = 4;
            this.photo.Text = "choosePhoto";
            this.photo.UseVisualStyleBackColor = false;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // SecondPhoto
            // 
            this.SecondPhoto.Location = new System.Drawing.Point(590, 142);
            this.SecondPhoto.Name = "SecondPhoto";
            this.SecondPhoto.Size = new System.Drawing.Size(525, 386);
            this.SecondPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecondPhoto.TabIndex = 5;
            this.SecondPhoto.TabStop = false;
            this.SecondPhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(125, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "if not checked, c++ library is selected";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(585, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected color:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(619, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "RED";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(774, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "BLUE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(944, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "GREEN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ColorChoice
            // 
            this.ColorChoice.AutoSize = true;
            this.ColorChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ColorChoice.Location = new System.Drawing.Point(746, 28);
            this.ColorChoice.Name = "ColorChoice";
            this.ColorChoice.Size = new System.Drawing.Size(63, 25);
            this.ColorChoice.TabIndex = 11;
            this.ColorChoice.Text = "None";
            this.ColorChoice.Click += new System.EventHandler(this.label3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 551);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 43);
            this.button4.TabIndex = 14;
            this.button4.Text = "Histogram przed";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(12, 600);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 43);
            this.button5.TabIndex = 15;
            this.button5.Text = "Histogram po";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(195, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 55);
            this.button6.TabIndex = 16;
            this.button6.Text = "Save Photo";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1137, 675);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ColorChoice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondPhoto);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.FirstPhoto);
            this.Controls.Add(this.asemblerDLL);
            this.Controls.Add(this.Przycisk);
            this.Name = "Window";
            this.Text = "Color Filter";
            this.TransparencyKey = System.Drawing.Color.SteelBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Przycisk;
        private System.Windows.Forms.CheckBox asemblerDLL;
        private System.Windows.Forms.PictureBox FirstPhoto;
        private System.Windows.Forms.Button photo;
        private System.Windows.Forms.PictureBox SecondPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ColorChoice;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

