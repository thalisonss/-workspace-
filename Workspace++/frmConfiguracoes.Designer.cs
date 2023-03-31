namespace Workspace__
{
    partial class frmConfiguracoes
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
            this.cboVozes = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboVozes
            // 
            this.cboVozes.FormattingEnabled = true;
            this.cboVozes.Location = new System.Drawing.Point(248, 82);
            this.cboVozes.Name = "cboVozes";
            this.cboVozes.Size = new System.Drawing.Size(121, 21);
            this.cboVozes.TabIndex = 0;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(266, 198);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 1;
            this.btnAplicar.Text = "button1";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cboVozes);
            this.Name = "frmConfiguracoes";
            this.Text = "frmConfiguracoes";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVozes;
        private System.Windows.Forms.Button btnAplicar;
    }
}