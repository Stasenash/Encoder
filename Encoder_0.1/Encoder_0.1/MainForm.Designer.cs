namespace Encoder_0._1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.encodeBtn = new System.Windows.Forms.PictureBox();
            this.decodeBtn = new System.Windows.Forms.PictureBox();
            this.messageTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.encodeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decodeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // encodeBtn
            // 
            this.encodeBtn.BackColor = System.Drawing.Color.Transparent;
            this.encodeBtn.BackgroundImage = global::Encoder_0._1.Properties.Resources.encode;
            this.encodeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.encodeBtn.InitialImage = global::Encoder_0._1.Properties.Resources.encode;
            this.encodeBtn.Location = new System.Drawing.Point(150, 250);
            this.encodeBtn.Name = "encodeBtn";
            this.encodeBtn.Size = new System.Drawing.Size(60, 60);
            this.encodeBtn.TabIndex = 0;
            this.encodeBtn.TabStop = false;
            this.encodeBtn.Click += new System.EventHandler(this.encodeBtn_Click);
            this.encodeBtn.MouseLeave += new System.EventHandler(this.encodeBtn_MouseLeave);
            this.encodeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.encodeBtn_MouseMove);
            // 
            // decodeBtn
            // 
            this.decodeBtn.BackColor = System.Drawing.Color.Transparent;
            this.decodeBtn.BackgroundImage = global::Encoder_0._1.Properties.Resources.decode;
            this.decodeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.decodeBtn.InitialImage = global::Encoder_0._1.Properties.Resources.decode;
            this.decodeBtn.Location = new System.Drawing.Point(350, 250);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(60, 60);
            this.decodeBtn.TabIndex = 1;
            this.decodeBtn.TabStop = false;
            this.decodeBtn.Click += new System.EventHandler(this.decodeBtn_Click);
            this.decodeBtn.MouseLeave += new System.EventHandler(this.decodeBtn_MouseLeave);
            this.decodeBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.decodeBtn_MouseMove);
            // 
            // messageTB
            // 
            this.messageTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.messageTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageTB.Location = new System.Drawing.Point(80, 150);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTB.Size = new System.Drawing.Size(400, 50);
            this.messageTB.TabIndex = 2;
            // 
            // Encoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Encoder_0._1.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.encodeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.Name = "Encoder";
            this.Text = "Encoder";
            ((System.ComponentModel.ISupportInitialize)(this.encodeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decodeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox encodeBtn;
        private System.Windows.Forms.PictureBox decodeBtn;
        private System.Windows.Forms.TextBox messageTB;
    }
}

