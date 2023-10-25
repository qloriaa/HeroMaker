using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HeroMaker
{
    public partial class frmCreateHero : Form
    {
        SuperHeroList listOfHeroes = new SuperHeroList();

        int speed, stamina, strength;
        Color cape, suit;
        string symbol;


        public frmCreateHero()
        {
            InitializeComponent();

            hsSpeed.ValueChanged += stats_ValueChanged;
            hsStamina.ValueChanged += stats_ValueChanged;
            hsStrength.ValueChanged += stats_ValueChanged;

            SetGroupsBoxes();
        }

        /// <summary>
        /// Create new SuperHero. Show second form displaying all heroes, and hide this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create new SuperHero
            SuperHero newHero = new SuperHero();

            newHero.Name = txtName.Text;
            newHero.DOB = dtpDOB.Value.Date;
            newHero.Abilities = Abilities();
            newHero.Gender = cmbGender.SelectedItem.ToString();
            newHero.Experience = Convert.ToInt32(numExperience.Value);
            newHero.DarkSide = tbDarkSide.Value;
            newHero.Transport = Transportation();
            newHero.hasSecretID = cbSecretIdentity.Checked;

            newHero.Speed = speed;
            newHero.Stamina = stamina;
            newHero.Strength = strength;
            newHero.Cape = cape.ToString();
            newHero.Suit = suit.ToString();
            newHero.SymbolFilePath = symbol;

            /* get Image from pictureBoc control (pbSymbol)
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSymbol.Image = new Bitmap(OpenFileDialog.FileName);

                symbol = pbSymbol.Image;
            } */

            listOfHeroes.HeroList.Add(newHero);
        }

        /// <summary>
        /// Open new form showing List of Heroes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewList_Click(object sender, EventArgs e)
        {
            // Hide this form, show HeroesList form
            frmHeroesList heroesListForm = new frmHeroesList();
            heroesListForm.Tag = listOfHeroes;
            this.Hide();
            heroesListForm.Show();
        }

        /// <summary>
        /// Open Color Dialog to choose Cape Color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCapeColor_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            ColorDialog.AllowFullOpen = true;
            ColorDialog.SolidColorOnly = true;
            cape = ColorDialog.Color;

            pbCapeColor.BackColor = cape;
        }

        /// <summary>
        /// Open Color Dialog to choose Suit Color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSuitColor_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            ColorDialog.AllowFullOpen = true;
            ColorDialog.SolidColorOnly = true;
            suit = ColorDialog.Color;

            pbSuitColor.BackColor = suit;
        }

        /// <summary>
        /// Open Image List Control to choose a superhero symbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSymbol_Click(object sender, EventArgs e)
        {
            OpenFileDialog.DefaultExt = ".JPG";
            OpenFileDialog.InitialDirectory = Application.ExecutablePath + "./images"; 
            //Application.ExecutablePath +  @"./images/";

            OpenFileDialog.ShowDialog();

            pbSymbol.ImageLocation = OpenFileDialog.FileName;
            pbSymbol.Load();

            symbol = pbSymbol.ImageLocation;
        }

        /// <summary>
        /// Update the value of the Dark Side Propensity attribute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDarkSide_ValueChanged(object sender, EventArgs e)
        {
            lblDarkSideValue.Text = tbDarkSide.Value.ToString();
        }

        /// <summary>
        /// This method makes sure that the values of Speed, Stamina, and Strength
        ///  do not surpass the max added amount of 100.
        /// </summary>
        /// <param name="sender"></param>
        private void SpeedStaminaStrength(string attributeChanged)
        {
            int total = speed + stamina + strength;
            int excess;

            switch (attributeChanged)
            {
                case "Speed":
                    excess = total - 100;
                    excess /= 2;

                    if (excess < stamina)
                    {
                        stamina -= excess;
                    }
                    if (excess < strength)
                    {
                        strength -= excess;
                    }
                    hsStamina.Value = stamina;
                    hsStrength.Value = strength;
                    break;
                case "Stamina":
                    excess = total - 100;
                    excess /= 2;

                    if (excess < speed)
                        speed -= excess;

                    if (excess < strength)
                        strength -= excess;

                    hsSpeed.Value = speed;
                    hsStrength.Value = strength;
                    break;
                case "Strength":
                    excess = total - 100;
                    excess /= 2;

                    if (excess < stamina)
                        stamina -= excess;

                    if (excess < speed)
                        speed -= excess;

                    hsStamina.Value = stamina;
                    hsSpeed.Value = speed;
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Horizontal scroll bar for Speed/Stamina/Strength has been changed to be within 100%. Update labels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stats_ValueChanged(object sender, EventArgs e)
        {
            speed = hsSpeed.Value;
            lblSpeedValue.Text = speed.ToString();
            stamina = hsStamina.Value;
            lblStaminaValue.Text = stamina.ToString();
            strength = hsStrength.Value;
            lblStrengthValue.Text = strength.ToString();

            if ((speed + stamina + strength) > 100)
            {
                SpeedStaminaStrength((sender as HScrollBar).Tag.ToString());
            }
        }

        /// <summary>
        /// Group check boxes and radio buttons in according group box container.
        /// </summary>
        private void SetGroupsBoxes()
        {
            gbAbilities.Controls.Add(cbStrength);
            //   cbStrength.CheckedChanged += Abilities_CheckedChanged;
            gbAbilities.Controls.Add(cbFlight);
            gbAbilities.Controls.Add(cbXRay);
            gbAbilities.Controls.Add(cbInvisibility);
            gbAbilities.Controls.Add(cbTelekinesis);
            gbAbilities.Controls.Add(cbTeleportation);
            gbAbilities.Controls.Add(cbSpeed);
            gbAbilities.Controls.Add(cbElasticity);
            gbAbilities.Controls.Add(cbShapeshifting);
            gbAbilities.Controls.Add(cbPrecognition);

            gbTranportation.Controls.Add(rbCar); // "Custom Mobile"
            gbTranportation.Controls.Add(rbAir); // "Jetpack/Flying"
            gbTranportation.Controls.Add(rbTeleport); // "Teleport"
            gbTranportation.Controls.Add(rbBike); // "Speedbike"

        }

        /// <summary>
        /// Create a list of abilities the hero has. 
        /// </summary>
        /// <returns></returns>
        private List<string> Abilities()
        {
            List<string> abilities = new List<string>();

            if (cbStrength.Checked)
                abilities.Add(cbStrength.Text);
            if (cbFlight.Checked)
                abilities.Add(cbFlight.Text);
            if (cbXRay.Checked)
                abilities.Add(cbXRay.Text);
            if (cbInvisibility.Checked)
                abilities.Add(cbInvisibility.Text);
            if (cbTelekinesis.Checked)
                abilities.Add(cbTelekinesis.Text);
            if (cbTeleportation.Checked)
                abilities.Add(cbTeleportation.Text);
            if (cbSpeed.Checked)
                abilities.Add(cbSpeed.Text);
            if (cbElasticity.Checked)
                abilities.Add(cbElasticity.Text);
            if (cbShapeshifting.Checked)
                abilities.Add(cbShapeshifting.Text);
            if (cbPrecognition.Checked)
                abilities.Add(cbPrecognition.Text);

            return abilities;
        }

        /// <summary>
        /// Determine the preferred method of transportation. only one sleection.
        /// </summary>
        /// <returns></returns>
        private string Transportation()
        {
            if (rbCar.Checked)
                return rbCar.Text;
            else if (rbAir.Checked)
                return rbAir.Text;
            else if (rbTeleport.Checked)
                return rbTeleport.Text;
            else
                return rbBike.Text;
        }
    }
}