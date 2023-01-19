namespace AutomacaoDeskTop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btmMapear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdTexto = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ETAPA = new System.Windows.Forms.ColumnHeader();
            this.TIPO = new System.Windows.Forms.ColumnHeader();
            this.VALOR = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btmMapear
            // 
            this.btmMapear.ForeColor = System.Drawing.Color.DarkGreen;
            this.btmMapear.Location = new System.Drawing.Point(106, 92);
            this.btmMapear.Name = "btmMapear";
            this.btmMapear.Size = new System.Drawing.Size(83, 23);
            this.btmMapear.TabIndex = 0;
            this.btmMapear.Text = "MAPEAR";
            this.btmMapear.UseVisualStyleBackColor = true;
            this.btmMapear.Click += new System.EventHandler(this.btmMapear_Click);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(106, 199);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(225, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnAdTexto
            // 
            this.btnAdTexto.ForeColor = System.Drawing.Color.Black;
            this.btnAdTexto.Location = new System.Drawing.Point(106, 142);
            this.btnAdTexto.Name = "btnAdTexto";
            this.btnAdTexto.Size = new System.Drawing.Size(225, 23);
            this.btnAdTexto.TabIndex = 2;
            this.btnAdTexto.Text = "ADICIONAR TEXTO";
            this.btnAdTexto.UseVisualStyleBackColor = true;
            // 
            // btnParar
            // 
            this.btnParar.ForeColor = System.Drawing.Color.Black;
            this.btnParar.Location = new System.Drawing.Point(238, 92);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(93, 23);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "PARAR";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ETAPA,
            this.TIPO,
            this.VALOR});
            this.listView1.Location = new System.Drawing.Point(29, 248);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(366, 161);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ETAPA
            // 
            this.ETAPA.Text = "ETAPA";
            // 
            // TIPO
            // 
            this.TIPO.Text = "TIPO";
            // 
            // VALOR
            // 
            this.VALOR.Text = "VALOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnAdTexto);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btmMapear);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btmMapear;
        private Button btnStart;
        private Button btnAdTexto;
        private Button btnParar;
        private Label label1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader ETAPA;
        private ColumnHeader TIPO;
        private ColumnHeader VALOR;
    }
}