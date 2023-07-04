namespace SimulacionParcial.Windows
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnCancelar = new Button();
            btnOk = new Button();
            txtAltura = new TextBox();
            label2 = new Label();
            txtRadio = new TextBox();
            label1 = new Label();
            dgbConos = new DataGridView();
            colRadio = new DataGridViewTextBoxColumn();
            colAltura = new DataGridViewTextBoxColumn();
            colGeneratriz = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbConos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancelar);
            splitContainer1.Panel1.Controls.Add(btnOk);
            splitContainer1.Panel1.Controls.Add(txtAltura);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtRadio);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgbConos);
            splitContainer1.Size = new Size(920, 517);
            splitContainer1.SplitterDistance = 222;
            splitContainer1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(179, 133);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 68);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(61, 133);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 68);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(138, 78);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 85);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Altura:";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(138, 33);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 27);
            txtRadio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Radio:";
            // 
            // dgbConos
            // 
            dgbConos.AllowUserToAddRows = false;
            dgbConos.AllowUserToDeleteRows = false;
            dgbConos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbConos.Columns.AddRange(new DataGridViewColumn[] { colRadio, colAltura, colGeneratriz, colArea, colVolumen });
            dgbConos.Dock = DockStyle.Fill;
            dgbConos.Location = new Point(0, 0);
            dgbConos.Name = "dgbConos";
            dgbConos.ReadOnly = true;
            dgbConos.RowHeadersWidth = 51;
            dgbConos.RowTemplate.Height = 29;
            dgbConos.Size = new Size(920, 291);
            dgbConos.TabIndex = 0;
            // 
            // colRadio
            // 
            colRadio.HeaderText = "Radio";
            colRadio.MinimumWidth = 6;
            colRadio.Name = "colRadio";
            colRadio.ReadOnly = true;
            colRadio.Width = 125;
            // 
            // colAltura
            // 
            colAltura.HeaderText = "Altura";
            colAltura.MinimumWidth = 6;
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            colAltura.Width = 125;
            // 
            // colGeneratriz
            // 
            colGeneratriz.HeaderText = "Generatriz";
            colGeneratriz.MinimumWidth = 6;
            colGeneratriz.Name = "colGeneratriz";
            colGeneratriz.ReadOnly = true;
            colGeneratriz.Width = 125;
            // 
            // colArea
            // 
            colArea.HeaderText = "Area";
            colArea.MinimumWidth = 6;
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.Width = 125;
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.MinimumWidth = 6;
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            colVolumen.Width = 125;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 517);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgbConos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtAltura;
        private Label label2;
        private TextBox txtRadio;
        private Label label1;
        private DataGridView dgbConos;
        private DataGridViewTextBoxColumn colRadio;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colGeneratriz;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colVolumen;
        private ErrorProvider errorProvider1;
    }
}