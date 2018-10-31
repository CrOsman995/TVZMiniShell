namespace WindowsFormsApp1.Forms
{
    partial class Main
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
            this.btnUcitajDirektorije = new System.Windows.Forms.Button();
            this.lbDirektoriji = new System.Windows.Forms.ListBox();
            this.tbBiljeske = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcitajDirektorije
            // 
            this.btnUcitajDirektorije.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajDirektorije.Location = new System.Drawing.Point(232, 12);
            this.btnUcitajDirektorije.Name = "btnUcitajDirektorije";
            this.btnUcitajDirektorije.Size = new System.Drawing.Size(137, 30);
            this.btnUcitajDirektorije.TabIndex = 0;
            this.btnUcitajDirektorije.Text = "Učitaj direktorije";
            this.btnUcitajDirektorije.UseVisualStyleBackColor = true;
            this.btnUcitajDirektorije.Click += new System.EventHandler(this.btnUcitajDirektorije_Click);
            // 
            // lbDirektoriji
            // 
            this.lbDirektoriji.FormattingEnabled = true;
            this.lbDirektoriji.Location = new System.Drawing.Point(12, 48);
            this.lbDirektoriji.Name = "lbDirektoriji";
            this.lbDirektoriji.Size = new System.Drawing.Size(588, 199);
            this.lbDirektoriji.TabIndex = 1;
            this.lbDirektoriji.SelectedIndexChanged += new System.EventHandler(this.lbDirektoriji_SelectedIndexChanged);
            // 
            // tbBiljeske
            // 
            this.tbBiljeske.Location = new System.Drawing.Point(12, 342);
            this.tbBiljeske.Name = "tbBiljeske";
            this.tbBiljeske.Size = new System.Drawing.Size(588, 50);
            this.tbBiljeske.TabIndex = 2;
            this.tbBiljeske.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(109, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 41);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Spremi bilješke";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bilješke:";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Enabled = false;
            this.tbNaziv.Location = new System.Drawing.Point(12, 286);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.ReadOnly = true;
            this.tbNaziv.Size = new System.Drawing.Size(588, 28);
            this.tbNaziv.TabIndex = 5;
            this.tbNaziv.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv datoteke";
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNote.Location = new System.Drawing.Point(300, 398);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(185, 41);
            this.btnDeleteNote.TabIndex = 7;
            this.btnDeleteNote.Text = "Obriši bilješku";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.btnDeleteNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbBiljeske);
            this.Controls.Add(this.lbDirektoriji);
            this.Controls.Add(this.btnUcitajDirektorije);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajDirektorije;
        private System.Windows.Forms.ListBox lbDirektoriji;
        private System.Windows.Forms.RichTextBox tbBiljeske;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteNote;
    }
}