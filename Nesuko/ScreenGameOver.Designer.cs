namespace Nesuko
{
    partial class GameOver
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
            this.label1 = new System.Windows.Forms.Label();
            this.Inicio = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(69, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inicio
            // 
            this.Inicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Inicio.Location = new System.Drawing.Point(219, 269);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(75, 23);
            this.Inicio.TabIndex = 1;
            this.Inicio.Text = "Inicio";
            this.Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salir.Location = new System.Drawing.Point(405, 269);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(715, 379);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "GameOver";
            this.Text = "ScreenGameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Salir;
    }
}