namespace Owo
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.chk_Ded = new System.Windows.Forms.CheckBox();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.chk_EasyMode = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1000, 1000);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(388, 1087);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(77, 53);
            this.Left.TabIndex = 1;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(554, 1087);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(77, 53);
            this.Right.TabIndex = 2;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(471, 1028);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(77, 53);
            this.Up.TabIndex = 3;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(471, 1146);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(77, 53);
            this.Down.TabIndex = 4;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(471, 1087);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(77, 53);
            this.last.TabIndex = 5;
            this.last.Text = "Last";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // chk_Ded
            // 
            this.chk_Ded.AutoSize = true;
            this.chk_Ded.Location = new System.Drawing.Point(237, 1059);
            this.chk_Ded.Name = "chk_Ded";
            this.chk_Ded.Size = new System.Drawing.Size(65, 24);
            this.chk_Ded.TabIndex = 6;
            this.chk_Ded.Text = "Ded";
            this.chk_Ded.UseVisualStyleBackColor = true;
            // 
            // txt_Score
            // 
            this.txt_Score.Location = new System.Drawing.Point(21, 1057);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(210, 26);
            this.txt_Score.TabIndex = 7;
            // 
            // chk_EasyMode
            // 
            this.chk_EasyMode.AutoSize = true;
            this.chk_EasyMode.Location = new System.Drawing.Point(237, 1116);
            this.chk_EasyMode.Name = "chk_EasyMode";
            this.chk_EasyMode.Size = new System.Drawing.Size(114, 24);
            this.chk_EasyMode.TabIndex = 8;
            this.chk_EasyMode.Text = "Easy mode";
            this.chk_EasyMode.UseVisualStyleBackColor = true;
            this.chk_EasyMode.CheckedChanged += new System.EventHandler(this.chk_EasyMode_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1036, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(369, 936);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Scores";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 1268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chk_EasyMode);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.chk_Ded);
            this.Controls.Add(this.last);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Funny snake game by Lily (https://github.com/bido67)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.CheckBox chk_Ded;
        private System.Windows.Forms.TextBox txt_Score;
        private System.Windows.Forms.CheckBox chk_EasyMode;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

