namespace HeroMaker
{
    partial class frmHeroesList
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
            lblHeroStats = new Label();
            lbHeroes = new ListBox();
            pbSymbol = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSymbol).BeginInit();
            SuspendLayout();
            // 
            // lblHeroStats
            // 
            lblHeroStats.BackColor = SystemColors.ControlLightLight;
            lblHeroStats.BorderStyle = BorderStyle.FixedSingle;
            lblHeroStats.Location = new Point(448, 56);
            lblHeroStats.Margin = new Padding(4, 0, 4, 0);
            lblHeroStats.Name = "lblHeroStats";
            lblHeroStats.Size = new Size(596, 400);
            lblHeroStats.TabIndex = 0;
            lblHeroStats.Text = "label1";
            // 
            // lbHeroes
            // 
            lbHeroes.FormattingEnabled = true;
            lbHeroes.ItemHeight = 36;
            lbHeroes.Location = new Point(58, 56);
            lbHeroes.Margin = new Padding(4, 3, 4, 3);
            lbHeroes.Name = "lbHeroes";
            lbHeroes.Size = new Size(331, 400);
            lbHeroes.TabIndex = 1;
            lbHeroes.SelectedIndexChanged += lbHeroes_SelectedIndexChanged;
            // 
            // pbSymbol
            // 
            pbSymbol.Location = new Point(537, 520);
            pbSymbol.Name = "pbSymbol";
            pbSymbol.Size = new Size(223, 184);
            pbSymbol.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSymbol.TabIndex = 2;
            pbSymbol.TabStop = false;
            // 
            // frmHeroesList
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 829);
            Controls.Add(pbSymbol);
            Controls.Add(lbHeroes);
            Controls.Add(lblHeroStats);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHeroesList";
            Text = "frmHeroesList";
            Load += frmHeroesList_Load;
            ((System.ComponentModel.ISupportInitialize)pbSymbol).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeroStats;
        private ListBox lbHeroes;
        private PictureBox pbSymbol;
    }
}