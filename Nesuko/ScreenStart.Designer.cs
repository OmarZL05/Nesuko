namespace Nesuko
{
    partial class ScreenStart
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenStart));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SSL_Credits = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.btn_OpenRanking = new System.Windows.Forms.Button();
            this.btn_InsertCoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nesuko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "A New Sudoku";
            // 
            // SSL_Credits
            // 
            this.SSL_Credits.AutoSize = true;
            this.SSL_Credits.Location = new System.Drawing.Point(64, 9);
            this.SSL_Credits.Name = "SSL_Credits";
            this.SSL_Credits.Size = new System.Drawing.Size(13, 13);
            this.SSL_Credits.TabIndex = 3;
            this.SSL_Credits.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Creditos: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 6;
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(159, 246);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(81, 23);
            this.btn_StartGame.TabIndex = 7;
            this.btn_StartGame.Text = "Iniciar Partida";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            this.btn_StartGame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_StartGame_KeyDown);
            // 
            // btn_OpenRanking
            // 
            this.btn_OpenRanking.Location = new System.Drawing.Point(159, 275);
            this.btn_OpenRanking.Name = "btn_OpenRanking";
            this.btn_OpenRanking.Size = new System.Drawing.Size(81, 23);
            this.btn_OpenRanking.TabIndex = 8;
            this.btn_OpenRanking.Text = "Abrir Ranking";
            this.btn_OpenRanking.UseVisualStyleBackColor = true;
            this.btn_OpenRanking.Click += new System.EventHandler(this.btn_OpenRanking_Click);
            this.btn_OpenRanking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_OpenRanking_KeyDown);
            // 
            // btn_InsertCoin
            // 
            this.btn_InsertCoin.Location = new System.Drawing.Point(12, 34);
            this.btn_InsertCoin.Name = "btn_InsertCoin";
            this.btn_InsertCoin.Size = new System.Drawing.Size(81, 23);
            this.btn_InsertCoin.TabIndex = 9;
            this.btn_InsertCoin.Text = "Insert Coin";
            this.btn_InsertCoin.UseMnemonic = false;
            this.btn_InsertCoin.UseVisualStyleBackColor = true;
            this.btn_InsertCoin.Click += new System.EventHandler(this.btn_InsertCoin_Click);
            // 
            // ScreenStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(404, 382);
            this.Controls.Add(this.btn_InsertCoin);
            this.Controls.Add(this.btn_OpenRanking);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SSL_Credits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScreenStart";
            this.Text = "Nesuko";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SSL_Credits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_OpenRanking;
        private System.Windows.Forms.Button btn_InsertCoin;
    }
}

