
namespace BojanCarina_ArtStore_Atestat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.MyCartButton = new System.Windows.Forms.Button();
            this.PaintingsButton = new System.Windows.Forms.Button();
            this.SculpturesButton = new System.Windows.Forms.Button();
            this.EventsButton = new System.Windows.Forms.Button();
            this.DigitalArtButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.myCart1 = new BojanCarina_ArtStore_Atestat.MyCart();
            this.homeUserControl1 = new BojanCarina_ArtStore_Atestat.HomeUserControl();
            this.paintingsUserControl1 = new BojanCarina_ArtStore_Atestat.PaintingsUserControl(this.myCart1);
            this.sculpturesUserControl1 = new BojanCarina_ArtStore_Atestat.SculpturesUserControl(this.myCart1);
            this.digitalUserControl1 = new BojanCarina_ArtStore_Atestat.DigitalUserControl(this.myCart1);
            this.eventsUserControl1 = new BojanCarina_ArtStore_Atestat.EventsUserControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.MyCartButton);
            this.panel1.Controls.Add(this.PaintingsButton);
            this.panel1.Controls.Add(this.SculpturesButton);
            this.panel1.Controls.Add(this.EventsButton);
            this.panel1.Controls.Add(this.DigitalArtButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 760);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LightBlue;
            this.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidePanel.Location = new System.Drawing.Point(-1, 171);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(15, 47);
            this.SidePanel.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-1, 708);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 47);
            this.button7.TabIndex = 9;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MyCartButton
            // 
            this.MyCartButton.FlatAppearance.BorderSize = 0;
            this.MyCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyCartButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyCartButton.Image = ((System.Drawing.Image)(resources.GetObject("MyCartButton.Image")));
            this.MyCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyCartButton.Location = new System.Drawing.Point(11, 410);
            this.MyCartButton.Name = "MyCartButton";
            this.MyCartButton.Size = new System.Drawing.Size(191, 47);
            this.MyCartButton.TabIndex = 8;
            this.MyCartButton.Text = "My Cart";
            this.MyCartButton.UseVisualStyleBackColor = true;
            this.MyCartButton.Click += new System.EventHandler(this.MyCartButton_Click);
            // 
            // PaintingsButton
            // 
            this.PaintingsButton.FlatAppearance.BorderSize = 0;
            this.PaintingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaintingsButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaintingsButton.Image = ((System.Drawing.Image)(resources.GetObject("PaintingsButton.Image")));
            this.PaintingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaintingsButton.Location = new System.Drawing.Point(11, 224);
            this.PaintingsButton.Name = "PaintingsButton";
            this.PaintingsButton.Size = new System.Drawing.Size(191, 47);
            this.PaintingsButton.TabIndex = 7;
            this.PaintingsButton.Text = "Paintings";
            this.PaintingsButton.UseVisualStyleBackColor = true;
            this.PaintingsButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // SculpturesButton
            // 
            this.SculpturesButton.FlatAppearance.BorderSize = 0;
            this.SculpturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SculpturesButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SculpturesButton.Image = ((System.Drawing.Image)(resources.GetObject("SculpturesButton.Image")));
            this.SculpturesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SculpturesButton.Location = new System.Drawing.Point(11, 277);
            this.SculpturesButton.Name = "SculpturesButton";
            this.SculpturesButton.Size = new System.Drawing.Size(191, 47);
            this.SculpturesButton.TabIndex = 6;
            this.SculpturesButton.Text = "Sculptures";
            this.SculpturesButton.UseVisualStyleBackColor = true;
            this.SculpturesButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // EventsButton
            // 
            this.EventsButton.FlatAppearance.BorderSize = 0;
            this.EventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventsButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventsButton.Image = ((System.Drawing.Image)(resources.GetObject("EventsButton.Image")));
            this.EventsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EventsButton.Location = new System.Drawing.Point(11, 369);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(191, 47);
            this.EventsButton.TabIndex = 5;
            this.EventsButton.Text = "Events";
            this.EventsButton.UseVisualStyleBackColor = true;
            this.EventsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DigitalArtButton
            // 
            this.DigitalArtButton.FlatAppearance.BorderSize = 0;
            this.DigitalArtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DigitalArtButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DigitalArtButton.Image = ((System.Drawing.Image)(resources.GetObject("DigitalArtButton.Image")));
            this.DigitalArtButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DigitalArtButton.Location = new System.Drawing.Point(11, 325);
            this.DigitalArtButton.Name = "DigitalArtButton";
            this.DigitalArtButton.Size = new System.Drawing.Size(191, 47);
            this.DigitalArtButton.TabIndex = 4;
            this.DigitalArtButton.Text = "Digital Art";
            this.DigitalArtButton.UseVisualStyleBackColor = true;
            this.DigitalArtButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(11, 171);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(191, 47);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(23, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 126);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArtPoint";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(203, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1210, 22);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1182, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(793, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find us @artpoint_ on:";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(987, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 35);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1073, 30);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(37, 35);
            this.button9.TabIndex = 10;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(1030, 30);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(37, 35);
            this.button10.TabIndex = 11;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(1248, 30);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(37, 35);
            this.button11.TabIndex = 12;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(1291, 30);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(37, 35);
            this.button12.TabIndex = 13;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(203, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Carina Bojan-Online Art Shop";
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.BackColor = System.Drawing.Color.AliceBlue;
            this.homeUserControl1.Location = new System.Drawing.Point(232, 69);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(1161, 659);
            this.homeUserControl1.TabIndex = 16;
            // 
            // paintingsUserControl1
            // 
            this.paintingsUserControl1.BackColor = System.Drawing.Color.AliceBlue;
            this.paintingsUserControl1.Location = new System.Drawing.Point(222, 67);
            this.paintingsUserControl1.Name = "paintingsUserControl1";
            this.paintingsUserControl1.Size = new System.Drawing.Size(1170, 677);
            this.paintingsUserControl1.TabIndex = 17;
            // 
            // sculpturesUserControl1
            // 
            this.sculpturesUserControl1.BackColor = System.Drawing.Color.AliceBlue;
            this.sculpturesUserControl1.Location = new System.Drawing.Point(218, 64);
            this.sculpturesUserControl1.Name = "sculpturesUserControl1";
            this.sculpturesUserControl1.Size = new System.Drawing.Size(1175, 667);
            this.sculpturesUserControl1.TabIndex = 18;
            // 
            // digitalUserControl1
            // 
            this.digitalUserControl1.BackColor = System.Drawing.Color.AliceBlue;
            this.digitalUserControl1.Location = new System.Drawing.Point(215, 68);
            this.digitalUserControl1.Name = "digitalUserControl1";
            this.digitalUserControl1.Size = new System.Drawing.Size(1181, 674);
            this.digitalUserControl1.TabIndex = 19;
            // 
            // eventsUserControl1
            // 
            this.eventsUserControl1.BackColor = System.Drawing.Color.AliceBlue;
            this.eventsUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventsUserControl1.Location = new System.Drawing.Point(232, 71);
            this.eventsUserControl1.Name = "eventsUserControl1";
            this.eventsUserControl1.Size = new System.Drawing.Size(1149, 643);
            this.eventsUserControl1.TabIndex = 20;
            // 
            // myCart1
            // 
            this.myCart1.BackColor = System.Drawing.Color.AliceBlue;
            this.myCart1.Location = new System.Drawing.Point(232, 68);
            this.myCart1.Name = "myCart1";
            this.myCart1.Size = new System.Drawing.Size(1149, 667);
            this.myCart1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1413, 760);
            this.Controls.Add(this.myCart1);
            this.Controls.Add(this.eventsUserControl1);
            this.Controls.Add(this.digitalUserControl1);
            this.Controls.Add(this.sculpturesUserControl1);
            this.Controls.Add(this.paintingsUserControl1);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button MyCartButton;
        private System.Windows.Forms.Button PaintingsButton;
        private System.Windows.Forms.Button SculpturesButton;
        private System.Windows.Forms.Button EventsButton;
        private System.Windows.Forms.Button DigitalArtButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label3;
        private HomeUserControl homeUserControl1;
        private PaintingsUserControl paintingsUserControl1;
        private SculpturesUserControl sculpturesUserControl1;
        private DigitalUserControl digitalUserControl1;
        private EventsUserControl eventsUserControl1;
        private MyCart myCart1;
        private System.Windows.Forms.Button button1;
    }
}

