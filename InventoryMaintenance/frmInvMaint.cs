using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        // Wes Johnson

        private List<InvItem> invItems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Wes Johnson

            List<InvItem> load = InvItemDB.GetItems();
            invItems = load;


            // Wes Johnson
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            // Wes Johnson

            var fillList = invItems;
            foreach(var invItems in fillList)
            {
                lstItems.Items.Add(invItems.GetDisplayText(", "));
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Wes Johnson

            frmNewItem newItem = new frmNewItem();

            // Wes Johnson

            newItem.GetNewItem();

            // Wes Johnson

            if (newItem.item != null)
            {
                invItems.Add(newItem.item);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                // Wes Johnson

                DialogResult result = MessageBox.Show(
                    "Are you certain you wish to delete this?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo
                    );

                // Wes Johnson

                if (result == DialogResult.Yes)
                {
                    invItems.RemoveAt(i);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }



            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
