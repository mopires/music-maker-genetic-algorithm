namespace MusicMakerGeneticAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSizePopulation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMutation = new System.Windows.Forms.TextBox();
            this.labelBestChord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSizePopulation
            // 
            this.txtSizePopulation.Location = new System.Drawing.Point(76, 9);
            this.txtSizePopulation.Name = "txtSizePopulation";
            this.txtSizePopulation.Size = new System.Drawing.Size(77, 20);
            this.txtSizePopulation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "População";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(76, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 29);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mutação";
            // 
            // txtMutation
            // 
            this.txtMutation.Location = new System.Drawing.Point(76, 35);
            this.txtMutation.Name = "txtMutation";
            this.txtMutation.Size = new System.Drawing.Size(77, 20);
            this.txtMutation.TabIndex = 4;
            // 
            // labelBestChord
            // 
            this.labelBestChord.AutoSize = true;
            this.labelBestChord.Location = new System.Drawing.Point(194, 12);
            this.labelBestChord.Name = "labelBestChord";
            this.labelBestChord.Size = new System.Drawing.Size(0, 13);
            this.labelBestChord.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 103);
            this.Controls.Add(this.labelBestChord);
            this.Controls.Add(this.txtMutation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSizePopulation);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSizePopulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMutation;
        private System.Windows.Forms.Label labelBestChord;
    }
}

