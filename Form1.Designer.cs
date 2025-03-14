namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxNb = new System.Windows.Forms.PictureBox();
            this.picBoxRy = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.tmrMove1 = new System.Windows.Forms.Timer(this.components);
            this.btnMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRy)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxNb
            // 
            this.picBoxNb.Image = ((System.Drawing.Image)(resources.GetObject("picBoxNb.Image")));
            this.picBoxNb.Location = new System.Drawing.Point(257, 12);
            this.picBoxNb.Name = "picBoxNb";
            this.picBoxNb.Size = new System.Drawing.Size(246, 168);
            this.picBoxNb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxNb.TabIndex = 0;
            this.picBoxNb.TabStop = false;
            this.picBoxNb.Click += new System.EventHandler(this.picBoxNb_Click);
            // 
            // picBoxRy
            // 
            this.picBoxRy.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRy.Image")));
            this.picBoxRy.Location = new System.Drawing.Point(306, 186);
            this.picBoxRy.Name = "picBoxRy";
            this.picBoxRy.Size = new System.Drawing.Size(143, 201);
            this.picBoxRy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRy.TabIndex = 1;
            this.picBoxRy.TabStop = false;
            this.picBoxRy.Click += new System.EventHandler(this.picBoxRy_Click);
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // tmrMove1
            // 
            this.tmrMove1.Tick += new System.EventHandler(this.tmrMove1_Tick);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(565, 308);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(111, 30);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.picBoxRy);
            this.Controls.Add(this.picBoxNb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxNb;
        private System.Windows.Forms.PictureBox picBoxRy;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Timer tmrMove1;
        private System.Windows.Forms.Button btnMove;
    }
}

