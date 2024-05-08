namespace Restaurant_Table_Reservation_System
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
            titleBox = new TextBox();
            Navigation = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            zarezerwujStolikToolStripMenuItem = new ToolStripMenuItem();
            oNasToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pizzeToolStripMenuItem = new ToolStripMenuItem();
            makaronyToolStripMenuItem = new ToolStripMenuItem();
            przystawkiToolStripMenuItem = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            Navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Anchor = AnchorStyles.None;
            titleBox.BackColor = Color.Coral;
            titleBox.BorderStyle = BorderStyle.None;
            titleBox.Font = new Font("Segoe UI Historic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            titleBox.ForeColor = SystemColors.Window;
            titleBox.Location = new Point(0, 12);
            titleBox.Name = "titleBox";
            titleBox.ScrollBars = ScrollBars.Horizontal;
            titleBox.Size = new Size(1219, 50);
            titleBox.TabIndex = 0;
            titleBox.Text = "Pizzeria Parmegiana";
            titleBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Navigation
            // 
            Navigation.BackColor = Color.OrangeRed;
            Navigation.Dock = DockStyle.Left;
            Navigation.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Navigation.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, zarezerwujStolikToolStripMenuItem, oNasToolStripMenuItem });
            Navigation.Location = new Point(0, 0);
            Navigation.Name = "Navigation";
            Navigation.Size = new Size(195, 789);
            Navigation.TabIndex = 1;
            Navigation.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(182, 34);
            menuToolStripMenuItem.Text = "O nas";
            // 
            // zarezerwujStolikToolStripMenuItem
            // 
            zarezerwujStolikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pizzeToolStripMenuItem, makaronyToolStripMenuItem, przystawkiToolStripMenuItem });
            zarezerwujStolikToolStripMenuItem.Name = "zarezerwujStolikToolStripMenuItem";
            zarezerwujStolikToolStripMenuItem.Size = new Size(182, 34);
            zarezerwujStolikToolStripMenuItem.Text = "Menu";
            // 
            // oNasToolStripMenuItem
            // 
            oNasToolStripMenuItem.Name = "oNasToolStripMenuItem";
            oNasToolStripMenuItem.Size = new Size(182, 34);
            oNasToolStripMenuItem.Text = "Zarezerwuj Stolik";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(611, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(608, 419);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pizzeToolStripMenuItem
            // 
            pizzeToolStripMenuItem.Name = "pizzeToolStripMenuItem";
            pizzeToolStripMenuItem.Size = new Size(189, 34);
            pizzeToolStripMenuItem.Text = "Pizze";
            // 
            // makaronyToolStripMenuItem
            // 
            makaronyToolStripMenuItem.Name = "makaronyToolStripMenuItem";
            makaronyToolStripMenuItem.Size = new Size(189, 34);
            makaronyToolStripMenuItem.Text = "Makarony";
            // 
            // przystawkiToolStripMenuItem
            // 
            przystawkiToolStripMenuItem.Name = "przystawkiToolStripMenuItem";
            przystawkiToolStripMenuItem.Size = new Size(189, 34);
            przystawkiToolStripMenuItem.Text = "Przystawki";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(198, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Coral;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1231, 789);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(Navigation);
            Controls.Add(titleBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = Navigation;
            Name = "Form1";
            Text = "Form1";
            Navigation.ResumeLayout(false);
            Navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private MenuStrip Navigation;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem zarezerwujStolikToolStripMenuItem;
        private ToolStripMenuItem oNasToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem pizzeToolStripMenuItem;
        private ToolStripMenuItem makaronyToolStripMenuItem;
        private ToolStripMenuItem przystawkiToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
    }
}