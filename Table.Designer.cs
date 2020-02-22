namespace usercontrol
{
    partial class Table
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableBtn
            // 
            this.tableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tableBtn.ForeColor = System.Drawing.Color.Black;
            this.tableBtn.Location = new System.Drawing.Point(126, 60);
            this.tableBtn.Name = "tableBtn";
            this.tableBtn.Size = new System.Drawing.Size(216, 122);
            this.tableBtn.TabIndex = 0;
            this.tableBtn.Text = "Masa";
            this.tableBtn.UseVisualStyleBackColor = false;
            this.tableBtn.Click += new System.EventHandler(this.tableBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(126, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 33);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(126, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 33);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(348, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 51);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(50, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 51);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableBtn);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(455, 248);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tableBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
