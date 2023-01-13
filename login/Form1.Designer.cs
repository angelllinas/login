namespace login
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Panel_title = new System.Windows.Forms.Panel();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_contraseña = new System.Windows.Forms.Label();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.Panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_title
            // 
            this.Panel_title.BackColor = System.Drawing.Color.RoyalBlue;
            this.Panel_title.Controls.Add(this.pb_exit);
            this.Panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_title.Location = new System.Drawing.Point(0, 0);
            this.Panel_title.Name = "Panel_title";
            this.Panel_title.Size = new System.Drawing.Size(308, 30);
            this.Panel_title.TabIndex = 0;
            this.Panel_title.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_title_Paint);
            this.Panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_title_MouseMove);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(53, 238);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(200, 20);
            this.tb_nombre.TabIndex = 1;
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(53, 281);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '*';
            this.tb_contraseña.Size = new System.Drawing.Size(200, 20);
            this.tb_contraseña.TabIndex = 2;
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(83)))), ((int)(((byte)(208)))));
            this.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresar.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_ingresar.Location = new System.Drawing.Point(53, 324);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(200, 31);
            this.bt_ingresar.TabIndex = 3;
            this.bt_ingresar.Text = "INGRESAR";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(50, 222);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 6;
            this.label_nombre.Text = "Nombre";
            // 
            // label_contraseña
            // 
            this.label_contraseña.AutoSize = true;
            this.label_contraseña.Location = new System.Drawing.Point(50, 265);
            this.label_contraseña.Name = "label_contraseña";
            this.label_contraseña.Size = new System.Drawing.Size(61, 13);
            this.label_contraseña.TabIndex = 7;
            this.label_contraseña.Text = "Contraseña";
            // 
            // pb_icon
            // 
            this.pb_icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_icon.Image")));
            this.pb_icon.Location = new System.Drawing.Point(53, 72);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(200, 129);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_icon.TabIndex = 5;
            this.pb_icon.TabStop = false;
            // 
            // pb_exit
            // 
            this.pb_exit.Image = global::login.Properties.Resources.close;
            this.pb_exit.Location = new System.Drawing.Point(263, 0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(45, 30);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_exit.TabIndex = 1;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            this.pb_exit.MouseEnter += new System.EventHandler(this.pb_exit_MouseEnter);
            this.pb_exit.MouseLeave += new System.EventHandler(this.pb_exit_MouseLeave);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 407);
            this.Controls.Add(this.label_contraseña);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.pb_icon);
            this.Controls.Add(this.bt_ingresar);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.Panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Panel_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_title;
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_contraseña;
    }
}

