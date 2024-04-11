namespace AS2324._3G.Prof.AutomobileWF
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
            lblVelocita = new Label();
            btnAccelera = new Button();
            btnFrena = new Button();
            chkAccensione = new CheckBox();
            label1 = new Label();
            chkCinture = new CheckBox();
            btnClacson = new Button();
            lstMonitor = new ListBox();
            grbComandi = new GroupBox();
            label2 = new Label();
            cmbStrada = new ComboBox();
            prbVelocita = new ProgressBar();
            grbComandi.SuspendLayout();
            SuspendLayout();
            // 
            // lblVelocita
            // 
            lblVelocita.AutoSize = true;
            lblVelocita.Location = new Point(631, 301);
            lblVelocita.Name = "lblVelocita";
            lblVelocita.Size = new Size(45, 15);
            lblVelocita.TabIndex = 1;
            lblVelocita.Text = "0 km/h";
            // 
            // btnAccelera
            // 
            btnAccelera.Location = new Point(101, 20);
            btnAccelera.Margin = new Padding(3, 2, 3, 2);
            btnAccelera.Name = "btnAccelera";
            btnAccelera.Size = new Size(82, 22);
            btnAccelera.TabIndex = 2;
            btnAccelera.Text = "Accelera";
            btnAccelera.UseVisualStyleBackColor = true;
            btnAccelera.Click += btnAccelera_Click;
            // 
            // btnFrena
            // 
            btnFrena.Location = new Point(7, 20);
            btnFrena.Margin = new Padding(3, 2, 3, 2);
            btnFrena.Name = "btnFrena";
            btnFrena.Size = new Size(88, 22);
            btnFrena.TabIndex = 3;
            btnFrena.Text = "Frena";
            btnFrena.UseVisualStyleBackColor = true;
            btnFrena.Click += btnFrena_Click;
            // 
            // chkAccensione
            // 
            chkAccensione.AutoSize = true;
            chkAccensione.Location = new Point(51, 95);
            chkAccensione.Margin = new Padding(3, 2, 3, 2);
            chkAccensione.Name = "chkAccensione";
            chkAccensione.Size = new Size(120, 19);
            chkAccensione.TabIndex = 4;
            chkAccensione.Text = "Accendi il motore";
            chkAccensione.UseVisualStyleBackColor = true;
            chkAccensione.CheckedChanged += chkAccensione_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(519, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 5;
            label1.Text = "Vento 10 km/h";
            // 
            // chkCinture
            // 
            chkCinture.AutoSize = true;
            chkCinture.Location = new Point(51, 74);
            chkCinture.Margin = new Padding(3, 2, 3, 2);
            chkCinture.Name = "chkCinture";
            chkCinture.Size = new Size(65, 19);
            chkCinture.TabIndex = 6;
            chkCinture.Text = "Cinture";
            chkCinture.UseVisualStyleBackColor = true;
            // 
            // btnClacson
            // 
            btnClacson.Location = new Point(519, 118);
            btnClacson.Margin = new Padding(3, 2, 3, 2);
            btnClacson.Name = "btnClacson";
            btnClacson.Size = new Size(107, 35);
            btnClacson.TabIndex = 7;
            btnClacson.Text = "Clacson";
            btnClacson.UseVisualStyleBackColor = true;
            // 
            // lstMonitor
            // 
            lstMonitor.FormattingEnabled = true;
            lstMonitor.ItemHeight = 15;
            lstMonitor.Location = new Point(26, 207);
            lstMonitor.Margin = new Padding(3, 2, 3, 2);
            lstMonitor.Name = "lstMonitor";
            lstMonitor.Size = new Size(664, 79);
            lstMonitor.TabIndex = 8;
            // 
            // grbComandi
            // 
            grbComandi.Controls.Add(btnAccelera);
            grbComandi.Controls.Add(btnFrena);
            grbComandi.Location = new Point(460, 47);
            grbComandi.Margin = new Padding(3, 2, 3, 2);
            grbComandi.Name = "grbComandi";
            grbComandi.Padding = new Padding(3, 2, 3, 2);
            grbComandi.Size = new Size(189, 57);
            grbComandi.TabIndex = 9;
            grbComandi.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 122);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Strada";
            // 
            // cmbStrada
            // 
            cmbStrada.FormattingEnabled = true;
            cmbStrada.Items.AddRange(new object[] { "Autostrada (130 km/h)", "Extraurbana (90 km/h)", "Urbana (50 km/h)" });
            cmbStrada.Location = new Point(99, 118);
            cmbStrada.Margin = new Padding(3, 2, 3, 2);
            cmbStrada.Name = "cmbStrada";
            cmbStrada.Size = new Size(147, 23);
            cmbStrada.TabIndex = 11;
            // 
            // prbVelocita
            // 
            prbVelocita.Location = new Point(27, 301);
            prbVelocita.Margin = new Padding(3, 2, 3, 2);
            prbVelocita.Name = "prbVelocita";
            prbVelocita.Size = new Size(598, 22);
            prbVelocita.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(prbVelocita);
            Controls.Add(cmbStrada);
            Controls.Add(label2);
            Controls.Add(grbComandi);
            Controls.Add(lstMonitor);
            Controls.Add(btnClacson);
            Controls.Add(chkCinture);
            Controls.Add(label1);
            Controls.Add(chkAccensione);
            Controls.Add(lblVelocita);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Spagnoli Enrico; AS 23/24 3G Lab 2.2; 04/04/24; Simulatore di un automobile";
            grbComandi.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblVelocita;
        private Button btnAccelera;
        private Button btnFrena;
        private CheckBox chkAccensione;
        private Label label1;
        private CheckBox chkCinture;
        private Button btnClacson;
        private ListBox lstMonitor;
        private GroupBox grbComandi;
        private Label label2;
        private ComboBox cmbStrada;
        private ProgressBar prbVelocita;
    }
}
