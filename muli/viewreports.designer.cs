namespace MultiFaceRec
{
    partial class viewreports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewreports));
            this.Sick = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sick
            // 
            this.Sick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sick.BackgroundImage")));
            this.Sick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sick.ForeColor = System.Drawing.Color.OrangeRed;
            this.Sick.Location = new System.Drawing.Point(39, 59);
            this.Sick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sick.Name = "Sick";
            this.Sick.Size = new System.Drawing.Size(205, 211);
            this.Sick.TabIndex = 0;
            this.Sick.Text = "חולים";
            this.Sick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sick.UseVisualStyleBackColor = true;
            this.Sick.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(373, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 211);
            this.button2.TabIndex = 1;
            this.button2.Text = "מנהל מערכת";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "חזרה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // viewreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sick);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "viewreports";
            this.Text = "viewreports";
            this.Load += new System.EventHandler(this.viewreports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sick;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}