namespace AdminProcesos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstprocesos = new System.Windows.Forms.ListBox();
            this.lstid = new System.Windows.Forms.ListBox();
            this.lstram = new System.Windows.Forms.ListBox();
            this.lstvirtual = new System.Windows.Forms.ListBox();
            this.lstcpu = new System.Windows.Forms.ListBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotalprocesos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstprocesos
            // 
            this.lstprocesos.FormattingEnabled = true;
            this.lstprocesos.Location = new System.Drawing.Point(26, 75);
            this.lstprocesos.Name = "lstprocesos";
            this.lstprocesos.Size = new System.Drawing.Size(151, 277);
            this.lstprocesos.TabIndex = 0;
            // 
            // lstid
            // 
            this.lstid.FormattingEnabled = true;
            this.lstid.Location = new System.Drawing.Point(225, 75);
            this.lstid.Name = "lstid";
            this.lstid.Size = new System.Drawing.Size(151, 277);
            this.lstid.TabIndex = 1;
            // 
            // lstram
            // 
            this.lstram.FormattingEnabled = true;
            this.lstram.Location = new System.Drawing.Point(425, 75);
            this.lstram.Name = "lstram";
            this.lstram.Size = new System.Drawing.Size(151, 277);
            this.lstram.TabIndex = 2;
            // 
            // lstvirtual
            // 
            this.lstvirtual.FormattingEnabled = true;
            this.lstvirtual.Location = new System.Drawing.Point(621, 75);
            this.lstvirtual.Name = "lstvirtual";
            this.lstvirtual.Size = new System.Drawing.Size(151, 277);
            this.lstvirtual.TabIndex = 3;
            // 
            // lstcpu
            // 
            this.lstcpu.FormattingEnabled = true;
            this.lstcpu.Location = new System.Drawing.Point(836, 75);
            this.lstcpu.Name = "lstcpu";
            this.lstcpu.Size = new System.Drawing.Size(151, 277);
            this.lstcpu.TabIndex = 4;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(43, 389);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(101, 38);
            this.btnactualizar.TabIndex = 5;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(451, 390);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(101, 37);
            this.btncerrar.TabIndex = 6;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(856, 391);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(101, 34);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Procesos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Identificador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Memoria RAM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Memoria virtual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(869, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Procesador/CPU";
            // 
            // lbltotalprocesos
            // 
            this.lbltotalprocesos.AutoSize = true;
            this.lbltotalprocesos.Location = new System.Drawing.Point(37, 534);
            this.lbltotalprocesos.Name = "lbltotalprocesos";
            this.lbltotalprocesos.Size = new System.Drawing.Size(35, 13);
            this.lbltotalprocesos.TabIndex = 13;
            this.lbltotalprocesos.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 596);
            this.Controls.Add(this.lbltotalprocesos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.lstcpu);
            this.Controls.Add(this.lstvirtual);
            this.Controls.Add(this.lstram);
            this.Controls.Add(this.lstid);
            this.Controls.Add(this.lstprocesos);
            this.Name = "Form1";
            this.Text = "Gestor de procesos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstprocesos;
        private System.Windows.Forms.ListBox lstid;
        private System.Windows.Forms.ListBox lstram;
        private System.Windows.Forms.ListBox lstvirtual;
        private System.Windows.Forms.ListBox lstcpu;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotalprocesos;
    }
}

