namespace MeinErstes
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdHallo = new System.Windows.Forms.Button();
            this.cmdEnde = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdHallo
            // 
            this.cmdHallo.Location = new System.Drawing.Point(36, 60);
            this.cmdHallo.Name = "cmdHallo";
            this.cmdHallo.Size = new System.Drawing.Size(75, 23);
            this.cmdHallo.TabIndex = 0;
            this.cmdHallo.Text = "Hallo";
            this.cmdHallo.UseVisualStyleBackColor = true;
            this.cmdHallo.Click += new System.EventHandler(this.cmdHallo_Click);
            // 
            // cmdEnde
            // 
            this.cmdEnde.Location = new System.Drawing.Point(36, 99);
            this.cmdEnde.Name = "cmdEnde";
            this.cmdEnde.Size = new System.Drawing.Size(75, 23);
            this.cmdEnde.TabIndex = 1;
            this.cmdEnde.Text = "Ende";
            this.cmdEnde.UseVisualStyleBackColor = true;
            this.cmdEnde.Click += new System.EventHandler(this.cmdEnde_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnzeige.Location = new System.Drawing.Point(33, 19);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(2, 19);
            this.lblAnzeige.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 154);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdEnde);
            this.Controls.Add(this.cmdHallo);
            this.Name = "Form1";
            this.Text = "Testformular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdHallo;
        private System.Windows.Forms.Button cmdEnde;
        private System.Windows.Forms.Label lblAnzeige;
    }
}

