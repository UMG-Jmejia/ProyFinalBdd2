﻿
namespace proyectoBDD2
{
    partial class Articulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_Descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_Nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtb_pCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtb_pVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtb_cantComprada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btnListadoArt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-8, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 105);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(564, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 79);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "1590-19-3867";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Josue Francisco Mejia Morales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proyecto BDD2 ";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(-1, 103);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 28);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "Volver";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripcion:";
            // 
            // txtb_Descripcion
            // 
            this.txtb_Descripcion.Location = new System.Drawing.Point(236, 261);
            this.txtb_Descripcion.Name = "txtb_Descripcion";
            this.txtb_Descripcion.Size = new System.Drawing.Size(495, 22);
            this.txtb_Descripcion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre:";
            // 
            // txtb_Nombre
            // 
            this.txtb_Nombre.Location = new System.Drawing.Point(236, 224);
            this.txtb_Nombre.Name = "txtb_Nombre";
            this.txtb_Nombre.Size = new System.Drawing.Size(495, 22);
            this.txtb_Nombre.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio Compra:";
            // 
            // txtb_pCompra
            // 
            this.txtb_pCompra.Location = new System.Drawing.Point(236, 299);
            this.txtb_pCompra.Name = "txtb_pCompra";
            this.txtb_pCompra.Size = new System.Drawing.Size(495, 22);
            this.txtb_pCompra.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Precio venta:";
            // 
            // txtb_pVenta
            // 
            this.txtb_pVenta.Location = new System.Drawing.Point(236, 336);
            this.txtb_pVenta.Name = "txtb_pVenta";
            this.txtb_pVenta.Size = new System.Drawing.Size(495, 22);
            this.txtb_pVenta.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cantidad comprada:";
            // 
            // txtb_cantComprada
            // 
            this.txtb_cantComprada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtb_cantComprada.Location = new System.Drawing.Point(236, 375);
            this.txtb_cantComprada.Name = "txtb_cantComprada";
            this.txtb_cantComprada.Size = new System.Drawing.Size(495, 22);
            this.txtb_cantComprada.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(342, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 39);
            this.label11.TabIndex = 19;
            this.label11.Text = "Articulo";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Actualizar.Location = new System.Drawing.Point(207, 457);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(426, 52);
            this.btn_Actualizar.TabIndex = 20;
            this.btn_Actualizar.Text = "Actualizar BDD";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btnListadoArt
            // 
            this.btnListadoArt.Location = new System.Drawing.Point(567, 109);
            this.btnListadoArt.Name = "btnListadoArt";
            this.btnListadoArt.Size = new System.Drawing.Size(231, 29);
            this.btnListadoArt.TabIndex = 21;
            this.btnListadoArt.Text = "Mostrar Listado de articulos";
            this.btnListadoArt.UseVisualStyleBackColor = true;
            this.btnListadoArt.Click += new System.EventHandler(this.btnListadoArt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoBDD2.Properties.Resources.umg;
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.btnListadoArt);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtb_cantComprada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtb_pVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtb_pCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_Descripcion);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.Articulo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_Descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_Nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtb_pCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtb_pVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtb_cantComprada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btnListadoArt;
    }
}