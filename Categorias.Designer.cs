
namespace semana13_sistemadeventas
{
    partial class Categorias
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
            this.bprimero = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.ComboBox();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.banterior = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrpcion de productos";
            // 
            // bprimero
            // 
            this.bprimero.Location = new System.Drawing.Point(12, 233);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(98, 48);
            this.bprimero.TabIndex = 1;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = true;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.FormattingEnabled = true;
            this.txtproducto.Location = new System.Drawing.Point(75, 46);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(121, 23);
            this.txtproducto.TabIndex = 3;
            // 
            // lstnivel
            // 
            this.lstnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lstnivel.Location = new System.Drawing.Point(75, 120);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(52, 23);
            this.lstnivel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "nivel";
            // 
            // txtclave
            // 
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.FormattingEnabled = true;
            this.txtclave.Location = new System.Drawing.Point(75, 83);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(121, 23);
            this.txtclave.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clave";
            // 
            // banterior
            // 
            this.banterior.Location = new System.Drawing.Point(127, 233);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(98, 48);
            this.banterior.TabIndex = 8;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = true;
            this.banterior.Click += new System.EventHandler(this.banterior_Click);
            // 
            // bsiguiente
            // 
            this.bsiguiente.Location = new System.Drawing.Point(243, 233);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(98, 48);
            this.bsiguiente.TabIndex = 9;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = true;
            this.bsiguiente.Click += new System.EventHandler(this.bsiguiente_Click);
            // 
            // bultimo
            // 
            this.bultimo.Location = new System.Drawing.Point(356, 233);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(98, 48);
            this.bultimo.TabIndex = 10;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = true;
            this.bultimo.Click += new System.EventHandler(this.button4_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.Location = new System.Drawing.Point(12, 296);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(98, 48);
            this.bnuevo.TabIndex = 11;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(12, 296);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(98, 48);
            this.bguardar.TabIndex = 12;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Location = new System.Drawing.Point(127, 296);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(98, 48);
            this.beliminar.TabIndex = 13;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.Location = new System.Drawing.Point(243, 296);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(98, 48);
            this.bmodificar.TabIndex = 14;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // bactualizar
            // 
            this.bactualizar.Location = new System.Drawing.Point(243, 296);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(98, 48);
            this.bactualizar.TabIndex = 15;
            this.bactualizar.Text = "Actualizar";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(356, 296);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(98, 48);
            this.bsalir.TabIndex = 16;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bprimero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bactualizar);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Descripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtproducto;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtclave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}