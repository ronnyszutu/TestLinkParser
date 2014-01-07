namespace TestLinkParser
{
    partial class frmTestLinkParser
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
            this.btnOpenXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenXML
            // 
            this.btnOpenXML.Location = new System.Drawing.Point(188, 143);
            this.btnOpenXML.Name = "btnOpenXML";
            this.btnOpenXML.Size = new System.Drawing.Size(75, 23);
            this.btnOpenXML.TabIndex = 0;
            this.btnOpenXML.Text = "Open XML";
            this.btnOpenXML.UseVisualStyleBackColor = true;
            this.btnOpenXML.Click += new System.EventHandler(this.btnOpenXML_Click);
            // 
            // frmTestLinkParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 329);
            this.Controls.Add(this.btnOpenXML);
            this.Name = "frmTestLinkParser";
            this.Text = "TestLink Parser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenXML;
    }
}

