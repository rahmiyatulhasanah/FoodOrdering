using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FoodOrdering
{
    public partial class frm_item : Form
    {
        #region Harga
        const double harga_kwetiau = 15000;
        const double harga_nasigoreng = 15000;
        const double harga_buburayam = 10000;
        const double harga_bakso = 10000;
        const double harga_mieayam = 10000;
        const double harga_mieayambakso = 15000;
        const double harga_capcin = 7000;
        const double harga_jus = 8000;
        const double harga_milkshake = 10000;
        const double harga_kopisusu = 10000;
        const double harga_vanillalatte = 10000;
        const double harga_hotchoco = 10000;
        #endregion
        public frm_item()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Yakin ngga jadi mesan?", "Teras Kartini",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes) { Application.Exit(); }
        }

        private void frm_item_Load_1(object sender, EventArgs e)
        {
            cmb_payment.Items.Add(" ");
            cmb_payment.Items.Add(" Cash");
            cmb_payment.Items.Add(" e-Money");
            EnableTextBoxes();
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        #region Checkbox Makanan
        private void chk_kwetiau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_kwetiau.Checked == true)
            {
                text_kwetiau.Enabled = true;
                text_kwetiau.Text = "0";
                text_kwetiau.Focus();
            }
            else
            {
                text_kwetiau.Enabled = false;
                text_kwetiau.Text = "0";
            }
        }

        private void chk_bakso_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_bakso.Checked == true)
            {
                text_bakso.Enabled = true;
                text_bakso.Text = "0";
                text_bakso.Focus();
            }
            else
            {
                text_bakso.Enabled = false;
                text_bakso.Text = "0";
            }
        }

        private void chk_nasigoreng_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_nasigoreng.Checked == true)
            {
                text_nasigoreng.Enabled = true;
                text_nasigoreng.Text = "0";
                text_nasigoreng.Focus();
            }
            else
            {
                text_nasigoreng.Enabled = false;
                text_nasigoreng.Text = "0";
            }
        }

        private void chk_buryam_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_buryam.Checked == true)
            {
                text_buryam.Enabled = true;
                text_buryam.Text = "0";
                text_buryam.Focus();
            }
            else
            {
                text_buryam.Enabled = false;
                text_buryam.Text = "0";
            }
        }

        private void chk_mieayam_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mieayam.Checked == true)
            {
                text_mieayam.Enabled = true;
                text_mieayam.Text = "0";
                text_mieayam.Focus();
            }
            else
            {
                text_mieayam.Enabled = false;
                text_mieayam.Text = "0";
            }
        }

        private void chk_mieayambakso_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mieayambakso.Checked == true)
            {
                text_mieayambakso.Enabled = true;
                text_mieayambakso.Text = "0";
                text_mieayambakso.Focus();
            }
            else
            {
                text_mieayambakso.Enabled = false;
                text_mieayambakso.Text = "0";
            }
        }
        #endregion
        /* ============================== */
        #region Checkbox Minuman
        private void chk_capcin_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_capcin.Checked == true)
            {
                text_capcin.Enabled = true;
                text_capcin.Text = "0";
                text_capcin.Focus();
            }
            else
            {
                text_capcin.Enabled = false;
                text_capcin.Text = "0";
            }
        }

        private void chk_jus_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_jus.Checked == true)
            {
                text_jus.Enabled = true;
                text_jus.Text = "0";
                text_jus.Focus();
            }
            else
            {
                text_jus.Enabled = false;
                text_jus.Text = "0";
            }
        }

        private void chk_milkshake_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_milkshake.Checked == true)
            {
                text_milkshake.Enabled = true;
                text_milkshake.Text = "0";
                text_milkshake.Focus();
            }
            else
            {
                text_milkshake.Enabled = false;
                text_milkshake.Text = "0";
            }
        }

        private void chk_kopisusu_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_kopisusu.Checked == true)
            {
                text_kopisusu.Enabled = true;
                text_kopisusu.Text = "0";
                text_kopisusu.Focus();
            }
            else
            {
                text_kopisusu.Enabled = false;
                text_kopisusu.Text = "0";
            }
        }

        private void chk_vanillalatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_vanillalatte.Checked == true)
            {
                text_vanillalatte.Enabled = true;
                text_vanillalatte.Text = "0";
                text_vanillalatte.Focus();
            }
            else
            {
                text_vanillalatte.Enabled = false;
                text_vanillalatte.Text = "0";
            }
        }

        private void chk_hotchoco_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hotchoco.Checked == true)
            {
                text_hotchoco.Enabled = true;
                text_hotchoco.Text = "0";
                text_hotchoco.Focus();
            }
            else
            {
                text_hotchoco.Enabled = false;
                text_hotchoco.Text = "0";
            }
        }

        #endregion

        private void cmb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment.Text == " Cash")
            {
                text_name.Enabled = true;
                text_address.Enabled = true;
                text_phone.Enabled = true;
                text_payment.Enabled = false;
                text_payment.Text = "";
                text_payment.Focus();
            }
            else if (cmb_payment.Text == " e-Money")
            {
                text_name.Enabled = true;
                text_address.Enabled = true;
                text_phone.Enabled = true;
                text_payment.Enabled = true;
                text_payment.Text = "0814-2345-0898";
            }
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            double[] itemcosts = new double[100];
            itemcosts[0] = Convert.ToDouble(text_kwetiau.Text) * harga_kwetiau;
            itemcosts[1] = Convert.ToDouble(text_nasigoreng.Text) * harga_nasigoreng;
            itemcosts[2] = Convert.ToDouble(text_buryam.Text) * harga_buburayam;
            itemcosts[3] = Convert.ToDouble(text_bakso.Text) * harga_bakso;
            itemcosts[4] = Convert.ToDouble(text_mieayam.Text) * harga_mieayam;
            itemcosts[5] = Convert.ToDouble(text_mieayambakso.Text) * harga_mieayambakso;
            itemcosts[6] = Convert.ToDouble(text_capcin.Text) * harga_capcin;
            itemcosts[7] = Convert.ToDouble(text_jus.Text) * harga_jus;
            itemcosts[8] = Convert.ToDouble(text_milkshake.Text) * harga_milkshake;
            itemcosts[9] = Convert.ToDouble(text_kopisusu.Text) * harga_kopisusu;
            itemcosts[10] = Convert.ToDouble(text_vanillalatte.Text) * harga_vanillalatte;
            itemcosts[11] = Convert.ToDouble(text_hotchoco.Text) * harga_hotchoco;

            double total;
            if (cmb_payment.Text == " Cash")
            {
                total = itemcosts[0] + itemcosts[1] + itemcosts[2] + itemcosts[3] +
                    itemcosts[4] + itemcosts[5] + itemcosts[6] + itemcosts[7] + itemcosts[8] + itemcosts[9] +
                    itemcosts[10] + itemcosts[11] + itemcosts[12];

                tb_total.Text = "Rp " + Convert.ToString(total);
            }
            else
            {
                total = itemcosts[0] + itemcosts[1] + itemcosts[2] + itemcosts[3] +
                    itemcosts[4] + itemcosts[5] + itemcosts[6] + itemcosts[7] + itemcosts[8] + itemcosts[9] +
                    itemcosts[10] + itemcosts[11] + itemcosts[12];
                tb_total.Text = "Rp " + Convert.ToString(total);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetCheckbox();
            ResetTextbox();
        }

        private void ResetCheckbox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void ResetTextbox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oke, makasi udah order. Ditunggu ya, " + Convert.ToString(text_name.Text) + 
                ". Pesanan kamu bakal kami antarin ke '" + Convert.ToString(text_address.Text) + "'. Kami bakal ngehubungi '"
                + Convert.ToString(text_phone.Text) + "' kalo pesenan kamu udah sampai! :)");
        }
    }
}
 