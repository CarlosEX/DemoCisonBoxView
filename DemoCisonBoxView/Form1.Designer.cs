
namespace DemoCisonBoxView {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.buttonLight = new System.Windows.Forms.Button();
            this.buttonDark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLight
            // 
            this.buttonLight.Location = new System.Drawing.Point(26, 35);
            this.buttonLight.Name = "buttonLight";
            this.buttonLight.Size = new System.Drawing.Size(112, 23);
            this.buttonLight.TabIndex = 0;
            this.buttonLight.Text = "Light";
            this.buttonLight.UseVisualStyleBackColor = true;
            // 
            // buttonDark
            // 
            this.buttonDark.Location = new System.Drawing.Point(156, 35);
            this.buttonDark.Name = "buttonDark";
            this.buttonDark.Size = new System.Drawing.Size(112, 23);
            this.buttonDark.TabIndex = 1;
            this.buttonDark.Text = "Dark";
            this.buttonDark.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 90);
            this.Controls.Add(this.buttonDark);
            this.Controls.Add(this.buttonLight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLight;
        private System.Windows.Forms.Button buttonDark;
    }
}

