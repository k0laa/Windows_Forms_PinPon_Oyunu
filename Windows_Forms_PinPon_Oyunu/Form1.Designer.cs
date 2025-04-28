namespace Windows_Forms_PinPon_Oyunu
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
            components = new System.ComponentModel.Container();
            game_panel = new Panel();
            pictureBox1 = new PictureBox();
            gameOver_panel = new GroupBox();
            exit_btn = new Button();
            label1 = new Label();
            restart_btn = new Button();
            table = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gameOver_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // game_panel
            // 
            game_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            game_panel.Controls.Add(pictureBox1);
            game_panel.Controls.Add(gameOver_panel);
            game_panel.Controls.Add(table);
            game_panel.Dock = DockStyle.Fill;
            game_panel.Location = new Point(0, 0);
            game_panel.Name = "game_panel";
            game_panel.Size = new Size(800, 450);
            game_panel.TabIndex = 0;
            game_panel.Paint += game_panel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.OrangeRed;
            pictureBox1.Location = new Point(50, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // gameOver_panel
            // 
            gameOver_panel.Controls.Add(exit_btn);
            gameOver_panel.Controls.Add(label1);
            gameOver_panel.Controls.Add(restart_btn);
            gameOver_panel.Location = new Point(135, 101);
            gameOver_panel.Name = "gameOver_panel";
            gameOver_panel.Size = new Size(500, 250);
            gameOver_panel.TabIndex = 2;
            gameOver_panel.TabStop = false;
            gameOver_panel.Text = "groupBox1";
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.RosyBrown;
            exit_btn.Font = new Font("Segoe UI", 11F);
            exit_btn.Location = new Point(255, 180);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(245, 70);
            exit_btn.TabIndex = 4;
            exit_btn.Text = "Çıkış";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(98, 23);
            label1.Name = "label1";
            label1.Size = new Size(317, 89);
            label1.TabIndex = 3;
            label1.Text = "Kaybettin";
            // 
            // restart_btn
            // 
            restart_btn.BackColor = Color.DarkSeaGreen;
            restart_btn.Font = new Font("Segoe UI", 11F);
            restart_btn.Location = new Point(0, 180);
            restart_btn.Name = "restart_btn";
            restart_btn.Size = new Size(245, 70);
            restart_btn.TabIndex = 2;
            restart_btn.Text = "Tekrar Oyna";
            restart_btn.UseVisualStyleBackColor = false;
            // 
            // table
            // 
            table.BackColor = Color.Black;
            table.Location = new Point(292, 381);
            table.Name = "table";
            table.Size = new Size(200, 20);
            table.TabIndex = 0;
            table.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(game_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            game_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gameOver_panel.ResumeLayout(false);
            gameOver_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel game_panel;
        private PictureBox table;
        private GroupBox gameOver_panel;
        private Button exit_btn;
        private Label label1;
        private Button restart_btn;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
