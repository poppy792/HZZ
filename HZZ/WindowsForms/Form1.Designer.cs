namespace WindowsForms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iZBORNIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iZBORNIKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iZBORNIKToolStripMenuItem
            // 
            this.iZBORNIKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomoćToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.iZBORNIKToolStripMenuItem.Name = "iZBORNIKToolStripMenuItem";
            this.iZBORNIKToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.iZBORNIKToolStripMenuItem.Text = "IZBORNIK";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.oProgramuToolStripMenuItem.Text = "o Programu";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 546);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HZZ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iZBORNIKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

