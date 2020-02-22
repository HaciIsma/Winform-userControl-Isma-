namespace usercontrol
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
            this.table4 = new usercontrol.Table();
            this.table3 = new usercontrol.Table();
            this.table2 = new usercontrol.Table();
            this.table = new usercontrol.Table();
            this.SuspendLayout();
            // 
            // table4
            // 
            this.table4.BackColor = System.Drawing.Color.Transparent;
            this.table4.Location = new System.Drawing.Point(580, 415);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(455, 248);
            this.table4.TabIndex = 1;
            this.table4.TableTitle = "Masa";
            // 
            // table3
            // 
            this.table3.BackColor = System.Drawing.Color.Transparent;
            this.table3.Location = new System.Drawing.Point(22, 415);
            this.table3.Name = "table3";
            this.table3.Size = new System.Drawing.Size(455, 248);
            this.table3.TabIndex = 1;
            this.table3.TableTitle = "Masa";
            // 
            // table2
            // 
            this.table2.BackColor = System.Drawing.Color.Transparent;
            this.table2.Location = new System.Drawing.Point(563, 72);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(455, 248);
            this.table2.TabIndex = 1;
            this.table2.TableTitle = "Masa";
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.Location = new System.Drawing.Point(52, 31);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(473, 267);
            this.table.TabIndex = 0;
            this.table.TableTitle = "Masa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 716);
            this.Controls.Add(this.table4);
            this.Controls.Add(this.table3);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Table table;
        private Table table2;
        private Table table3;
        private Table table4;
    }
}

