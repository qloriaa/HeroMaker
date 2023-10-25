namespace HeroMaker
{
    partial class frmCreateHero
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
            btnCreate = new Button();
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            gbAbilities = new GroupBox();
            cbTelekinesis = new CheckBox();
            cbPrecognition = new CheckBox();
            cbShapeshifting = new CheckBox();
            cbTeleportation = new CheckBox();
            cbSpeed = new CheckBox();
            cbElasticity = new CheckBox();
            cbInvisibility = new CheckBox();
            cbXRay = new CheckBox();
            cbFlight = new CheckBox();
            cbStrength = new CheckBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            lblExperience = new Label();
            numExperience = new NumericUpDown();
            lblCape = new Label();
            ColorDialog = new ColorDialog();
            lblDarkSidePropensity = new Label();
            tbDarkSide = new TrackBar();
            gbStats = new GroupBox();
            hsStrength = new HScrollBar();
            hsStamina = new HScrollBar();
            hsSpeed = new HScrollBar();
            lblStrengthValue = new Label();
            lblStrength = new Label();
            lblStaminaValue = new Label();
            lblStamina = new Label();
            lblSpeedValue = new Label();
            lblSpeed = new Label();
            pbCapeColor = new PictureBox();
            gbTranportation = new GroupBox();
            rbAir = new RadioButton();
            rbBike = new RadioButton();
            rbTeleport = new RadioButton();
            rbCar = new RadioButton();
            lblSuit = new Label();
            pbSuitColor = new PictureBox();
            pbSymbol = new PictureBox();
            lblSymbol = new Label();
            OpenFileDialog = new OpenFileDialog();
            cbSecretIdentity = new CheckBox();
            lblDarkSideValue = new Label();
            btnViewList = new Button();
            gbAbilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDarkSide).BeginInit();
            gbStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCapeColor).BeginInit();
            gbTranportation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSuitColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSymbol).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(589, 1052);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(203, 71);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Hero";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(288, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(565, 48);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Design Your Superhero !!";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(13, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 37);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 44);
            txtName.TabIndex = 3;
            // 
            // gbAbilities
            // 
            gbAbilities.Controls.Add(cbTelekinesis);
            gbAbilities.Controls.Add(cbPrecognition);
            gbAbilities.Controls.Add(cbShapeshifting);
            gbAbilities.Controls.Add(cbTeleportation);
            gbAbilities.Controls.Add(cbSpeed);
            gbAbilities.Controls.Add(cbElasticity);
            gbAbilities.Controls.Add(cbInvisibility);
            gbAbilities.Controls.Add(cbXRay);
            gbAbilities.Controls.Add(cbFlight);
            gbAbilities.Controls.Add(cbStrength);
            gbAbilities.Location = new Point(13, 144);
            gbAbilities.Name = "gbAbilities";
            gbAbilities.Size = new Size(541, 391);
            gbAbilities.TabIndex = 4;
            gbAbilities.TabStop = false;
            gbAbilities.Text = "Special Abilities";
            // 
            // cbTelekinesis
            // 
            cbTelekinesis.AutoSize = true;
            cbTelekinesis.Location = new Point(18, 325);
            cbTelekinesis.Name = "cbTelekinesis";
            cbTelekinesis.Size = new Size(182, 41);
            cbTelekinesis.TabIndex = 9;
            cbTelekinesis.Text = "Telekinesis";
            cbTelekinesis.UseVisualStyleBackColor = true;
            // 
            // cbPrecognition
            // 
            cbPrecognition.AutoSize = true;
            cbPrecognition.Location = new Point(276, 325);
            cbPrecognition.Name = "cbPrecognition";
            cbPrecognition.Size = new Size(198, 41);
            cbPrecognition.TabIndex = 8;
            cbPrecognition.Text = "Precognition";
            cbPrecognition.UseVisualStyleBackColor = true;
            // 
            // cbShapeshifting
            // 
            cbShapeshifting.AutoSize = true;
            cbShapeshifting.Location = new Point(276, 256);
            cbShapeshifting.Name = "cbShapeshifting";
            cbShapeshifting.Size = new Size(211, 41);
            cbShapeshifting.TabIndex = 7;
            cbShapeshifting.Text = "Shapeshifting";
            cbShapeshifting.UseVisualStyleBackColor = true;
            // 
            // cbTeleportation
            // 
            cbTeleportation.AutoSize = true;
            cbTeleportation.Location = new Point(276, 65);
            cbTeleportation.Name = "cbTeleportation";
            cbTeleportation.Size = new Size(205, 41);
            cbTeleportation.TabIndex = 6;
            cbTeleportation.Text = "Teleportation";
            cbTeleportation.UseVisualStyleBackColor = true;
            // 
            // cbSpeed
            // 
            cbSpeed.AutoSize = true;
            cbSpeed.Location = new Point(276, 127);
            cbSpeed.Name = "cbSpeed";
            cbSpeed.Size = new Size(127, 41);
            cbSpeed.TabIndex = 5;
            cbSpeed.Text = "Speed";
            cbSpeed.UseVisualStyleBackColor = true;
            // 
            // cbElasticity
            // 
            cbElasticity.AutoSize = true;
            cbElasticity.Location = new Point(276, 190);
            cbElasticity.Name = "cbElasticity";
            cbElasticity.Size = new Size(153, 41);
            cbElasticity.TabIndex = 4;
            cbElasticity.Text = "Elasticity";
            cbElasticity.UseVisualStyleBackColor = true;
            // 
            // cbInvisibility
            // 
            cbInvisibility.AutoSize = true;
            cbInvisibility.Location = new Point(18, 256);
            cbInvisibility.Name = "cbInvisibility";
            cbInvisibility.Size = new Size(162, 41);
            cbInvisibility.TabIndex = 3;
            cbInvisibility.Text = "Invisibility";
            cbInvisibility.UseVisualStyleBackColor = true;
            // 
            // cbXRay
            // 
            cbXRay.AutoSize = true;
            cbXRay.Location = new Point(18, 190);
            cbXRay.Name = "cbXRay";
            cbXRay.Size = new Size(203, 41);
            cbXRay.TabIndex = 2;
            cbXRay.Text = "X-Ray Vision";
            cbXRay.UseVisualStyleBackColor = true;
            // 
            // cbFlight
            // 
            cbFlight.AutoSize = true;
            cbFlight.Location = new Point(18, 127);
            cbFlight.Name = "cbFlight";
            cbFlight.Size = new Size(114, 41);
            cbFlight.TabIndex = 1;
            cbFlight.Text = "Flight";
            cbFlight.UseVisualStyleBackColor = true;
            // 
            // cbStrength
            // 
            cbStrength.AutoSize = true;
            cbStrength.Location = new Point(18, 65);
            cbStrength.Name = "cbStrength";
            cbStrength.Size = new Size(150, 41);
            cbStrength.TabIndex = 0;
            cbStrength.Text = "Strength";
            cbStrength.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(590, 158);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(113, 37);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            cmbGender.Location = new Point(727, 156);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(329, 45);
            cmbGender.TabIndex = 8;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDOB.Location = new Point(437, 81);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(81, 37);
            lblDOB.TabIndex = 9;
            lblDOB.Text = "DOB:";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(538, 79);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(519, 44);
            dtpDOB.TabIndex = 10;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExperience.Location = new Point(590, 236);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(264, 37);
            lblExperience.TabIndex = 11;
            lblExperience.Text = "Years of Experience:";
            // 
            // numExperience
            // 
            numExperience.Location = new Point(872, 234);
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(184, 44);
            numExperience.TabIndex = 12;
            // 
            // lblCape
            // 
            lblCape.AutoSize = true;
            lblCape.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCape.Location = new Point(590, 313);
            lblCape.Name = "lblCape";
            lblCape.Size = new Size(159, 37);
            lblCape.TabIndex = 13;
            lblCape.Text = "Cape Color:";
            // 
            // ColorDialog
            // 
            ColorDialog.Color = SystemColors.ButtonHighlight;
            // 
            // lblDarkSidePropensity
            // 
            lblDarkSidePropensity.AutoSize = true;
            lblDarkSidePropensity.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDarkSidePropensity.Location = new Point(11, 977);
            lblDarkSidePropensity.Name = "lblDarkSidePropensity";
            lblDarkSidePropensity.Size = new Size(274, 37);
            lblDarkSidePropensity.TabIndex = 15;
            lblDarkSidePropensity.Text = "Dark Side Propensity:";
            // 
            // tbDarkSide
            // 
            tbDarkSide.BackColor = SystemColors.Control;
            tbDarkSide.LargeChange = 1;
            tbDarkSide.Location = new Point(13, 1033);
            tbDarkSide.Name = "tbDarkSide";
            tbDarkSide.Size = new Size(541, 90);
            tbDarkSide.TabIndex = 10;
            tbDarkSide.ValueChanged += tbDarkSide_ValueChanged;
            // 
            // gbStats
            // 
            gbStats.Controls.Add(hsStrength);
            gbStats.Controls.Add(hsStamina);
            gbStats.Controls.Add(hsSpeed);
            gbStats.Controls.Add(lblStrengthValue);
            gbStats.Controls.Add(lblStrength);
            gbStats.Controls.Add(lblStaminaValue);
            gbStats.Controls.Add(lblStamina);
            gbStats.Controls.Add(lblSpeedValue);
            gbStats.Controls.Add(lblSpeed);
            gbStats.Location = new Point(11, 555);
            gbStats.Name = "gbStats";
            gbStats.Size = new Size(541, 395);
            gbStats.TabIndex = 16;
            gbStats.TabStop = false;
            gbStats.Text = "Speed-Stamina-Strength";
            // 
            // hsStrength
            // 
            hsStrength.LargeChange = 5;
            hsStrength.Location = new Point(20, 316);
            hsStrength.Name = "hsStrength";
            hsStrength.Size = new Size(500, 50);
            hsStrength.SmallChange = 5;
            hsStrength.TabIndex = 26;
            hsStrength.Tag = "Strength";
            hsStrength.Value = 33;
            // 
            // hsStamina
            // 
            hsStamina.LargeChange = 5;
            hsStamina.Location = new Point(20, 206);
            hsStamina.Name = "hsStamina";
            hsStamina.Size = new Size(500, 50);
            hsStamina.SmallChange = 5;
            hsStamina.TabIndex = 25;
            hsStamina.Tag = "Stamina";
            hsStamina.Value = 34;
            // 
            // hsSpeed
            // 
            hsSpeed.LargeChange = 5;
            hsSpeed.Location = new Point(18, 117);
            hsSpeed.Name = "hsSpeed";
            hsSpeed.Size = new Size(500, 50);
            hsSpeed.SmallChange = 5;
            hsSpeed.TabIndex = 23;
            hsSpeed.Tag = "Speed";
            hsSpeed.UseWaitCursor = true;
            hsSpeed.Value = 33;
            // 
            // lblStrengthValue
            // 
            lblStrengthValue.AutoSize = true;
            lblStrengthValue.Location = new Point(133, 265);
            lblStrengthValue.Name = "lblStrengthValue";
            lblStrengthValue.Size = new Size(47, 37);
            lblStrengthValue.TabIndex = 24;
            lblStrengthValue.Text = "33";
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStrength.Location = new Point(18, 265);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(125, 37);
            lblStrength.TabIndex = 23;
            lblStrength.Text = "Strength:";
            // 
            // lblStaminaValue
            // 
            lblStaminaValue.AutoSize = true;
            lblStaminaValue.Location = new Point(133, 169);
            lblStaminaValue.Name = "lblStaminaValue";
            lblStaminaValue.Size = new Size(47, 37);
            lblStaminaValue.TabIndex = 21;
            lblStaminaValue.Text = "34";
            // 
            // lblStamina
            // 
            lblStamina.AutoSize = true;
            lblStamina.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStamina.Location = new Point(18, 169);
            lblStamina.Name = "lblStamina";
            lblStamina.Size = new Size(122, 37);
            lblStamina.TabIndex = 20;
            lblStamina.Text = "Stamina:";
            // 
            // lblSpeedValue
            // 
            lblSpeedValue.AutoSize = true;
            lblSpeedValue.Location = new Point(133, 73);
            lblSpeedValue.Name = "lblSpeedValue";
            lblSpeedValue.Size = new Size(47, 37);
            lblSpeedValue.TabIndex = 18;
            lblSpeedValue.Text = "33";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeed.Location = new Point(18, 73);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(102, 37);
            lblSpeed.TabIndex = 17;
            lblSpeed.Text = "Speed:";
            // 
            // pbCapeColor
            // 
            pbCapeColor.BorderStyle = BorderStyle.FixedSingle;
            pbCapeColor.Location = new Point(754, 300);
            pbCapeColor.Name = "pbCapeColor";
            pbCapeColor.Size = new Size(302, 50);
            pbCapeColor.TabIndex = 17;
            pbCapeColor.TabStop = false;
            pbCapeColor.Click += pbCapeColor_Click;
            // 
            // gbTranportation
            // 
            gbTranportation.Controls.Add(rbAir);
            gbTranportation.Controls.Add(rbBike);
            gbTranportation.Controls.Add(rbTeleport);
            gbTranportation.Controls.Add(rbCar);
            gbTranportation.Location = new Point(589, 761);
            gbTranportation.Name = "gbTranportation";
            gbTranportation.Size = new Size(467, 205);
            gbTranportation.TabIndex = 18;
            gbTranportation.TabStop = false;
            gbTranportation.Text = "Preferred Transport";
            // 
            // rbAir
            // 
            rbAir.AutoSize = true;
            rbAir.Location = new Point(18, 135);
            rbAir.Name = "rbAir";
            rbAir.Size = new Size(217, 41);
            rbAir.TabIndex = 3;
            rbAir.TabStop = true;
            rbAir.Text = "Jetpack/Flying";
            rbAir.UseVisualStyleBackColor = true;
            // 
            // rbBike
            // 
            rbBike.AutoSize = true;
            rbBike.Location = new Point(297, 135);
            rbBike.Name = "rbBike";
            rbBike.Size = new Size(175, 41);
            rbBike.TabIndex = 2;
            rbBike.TabStop = true;
            rbBike.Text = "Speedbike";
            rbBike.UseVisualStyleBackColor = true;
            // 
            // rbTeleport
            // 
            rbTeleport.AutoSize = true;
            rbTeleport.Location = new Point(297, 67);
            rbTeleport.Name = "rbTeleport";
            rbTeleport.Size = new Size(146, 41);
            rbTeleport.TabIndex = 1;
            rbTeleport.TabStop = true;
            rbTeleport.Text = "Teleport";
            rbTeleport.UseVisualStyleBackColor = true;
            // 
            // rbCar
            // 
            rbCar.AutoSize = true;
            rbCar.Location = new Point(18, 67);
            rbCar.Name = "rbCar";
            rbCar.Size = new Size(225, 41);
            rbCar.TabIndex = 0;
            rbCar.TabStop = true;
            rbCar.Text = "Custom Mobile";
            rbCar.UseVisualStyleBackColor = true;
            // 
            // lblSuit
            // 
            lblSuit.AutoSize = true;
            lblSuit.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuit.Location = new Point(590, 384);
            lblSuit.Name = "lblSuit";
            lblSuit.Size = new Size(141, 37);
            lblSuit.TabIndex = 19;
            lblSuit.Text = "Suit Color:";
            // 
            // pbSuitColor
            // 
            pbSuitColor.BorderStyle = BorderStyle.FixedSingle;
            pbSuitColor.Location = new Point(754, 371);
            pbSuitColor.Name = "pbSuitColor";
            pbSuitColor.Size = new Size(302, 50);
            pbSuitColor.TabIndex = 20;
            pbSuitColor.TabStop = false;
            pbSuitColor.Click += pbSuitColor_Click;
            // 
            // pbSymbol
            // 
            pbSymbol.BorderStyle = BorderStyle.FixedSingle;
            pbSymbol.Location = new Point(755, 442);
            pbSymbol.Name = "pbSymbol";
            pbSymbol.Size = new Size(300, 300);
            pbSymbol.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSymbol.TabIndex = 22;
            pbSymbol.TabStop = false;
            pbSymbol.Click += pbSymbol_Click;
            // 
            // lblSymbol
            // 
            lblSymbol.AutoSize = true;
            lblSymbol.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSymbol.Location = new Point(591, 455);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new Size(113, 37);
            lblSymbol.TabIndex = 21;
            lblSymbol.Text = "Symbol:";
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "picture";
            // 
            // cbSecretIdentity
            // 
            cbSecretIdentity.AutoSize = true;
            cbSecretIdentity.Location = new Point(585, 977);
            cbSecretIdentity.Name = "cbSecretIdentity";
            cbSecretIdentity.Size = new Size(470, 41);
            cbSecretIdentity.TabIndex = 10;
            cbSecretIdentity.Text = "The Superhero has a secret identity";
            cbSecretIdentity.UseVisualStyleBackColor = true;
            // 
            // lblDarkSideValue
            // 
            lblDarkSideValue.AutoSize = true;
            lblDarkSideValue.Location = new Point(288, 981);
            lblDarkSideValue.Name = "lblDarkSideValue";
            lblDarkSideValue.Size = new Size(32, 37);
            lblDarkSideValue.TabIndex = 27;
            lblDarkSideValue.Text = "0";
            // 
            // btnViewList
            // 
            btnViewList.Location = new Point(807, 1052);
            btnViewList.Name = "btnViewList";
            btnViewList.Size = new Size(258, 71);
            btnViewList.TabIndex = 28;
            btnViewList.Text = "View Hero List";
            btnViewList.UseVisualStyleBackColor = true;
            btnViewList.Click += btnViewList_Click;
            // 
            // frmCreateHero
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 1161);
            Controls.Add(btnViewList);
            Controls.Add(lblDarkSideValue);
            Controls.Add(cbSecretIdentity);
            Controls.Add(pbSymbol);
            Controls.Add(lblSymbol);
            Controls.Add(pbSuitColor);
            Controls.Add(lblSuit);
            Controls.Add(gbTranportation);
            Controls.Add(pbCapeColor);
            Controls.Add(gbStats);
            Controls.Add(tbDarkSide);
            Controls.Add(lblDarkSidePropensity);
            Controls.Add(lblCape);
            Controls.Add(numExperience);
            Controls.Add(lblExperience);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(gbAbilities);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Controls.Add(btnCreate);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmCreateHero";
            Text = "Hero Maker";
            gbAbilities.ResumeLayout(false);
            gbAbilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDarkSide).EndInit();
            gbStats.ResumeLayout(false);
            gbStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCapeColor).EndInit();
            gbTranportation.ResumeLayout(false);
            gbTranportation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSuitColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSymbol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private GroupBox gbAbilities;
        private CheckBox cbXRay;
        private CheckBox cbFlight;
        private CheckBox cbStrength;
        private CheckBox cbInvisibility;
        private CheckBox cbShapeshifting;
        private CheckBox cbTeleportation;
        private CheckBox cbSpeed;
        private CheckBox cbElasticity;
        private CheckBox cbTelekinesis;
        private CheckBox cbPrecognition;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblDOB;
        private DateTimePicker dtpDOB;
        private Label lblExperience;
        private NumericUpDown numExperience;
        private Label lblCape;
        private ColorDialog ColorDialog;
        private Label lblDarkSidePropensity;
        private TrackBar tbDarkSide;
        private GroupBox gbStats;
        private Label lblSpeed;
        private Label lblSpeedValue;
        private Label lblStrengthValue;
        private Label lblStrength;
        private Label lblStaminaValue;
        private Label lblStamina;
        private PictureBox pbCapeColor;
        private GroupBox gbTranportation;
        private RadioButton rbAir;
        private RadioButton rbBike;
        private RadioButton rbTeleport;
        private RadioButton rbCar;
        private Label lblSuit;
        private PictureBox pbSuitColor;
        private PictureBox pbSymbol;
        private Label lblSymbol;
        private ImageList imglSymbols;
        private HScrollBar hsStrength;
        private HScrollBar hsStamina;
        private HScrollBar hsSpeed;
        private OpenFileDialog OpenFileDialog;
        private CheckBox cbSecretIdentity;
        private Label lblDarkSideValue;
        private Button btnViewList;
    }
}