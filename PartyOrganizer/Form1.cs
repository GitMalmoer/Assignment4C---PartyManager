namespace PartyOrganizer
{
    public partial class Form1 : Form
    {
        PartyManager partyManager;
        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            this.Text = ("Party Manager made by Marcin Junka");
            grpNewParty.Enabled = true;
            grpInviteGuest.Enabled = false; // group box invite guest must be disabled.
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            int b;
            bool ok = int.TryParse(txtMaxGuests.Text, out b);
            if (ok)
            {
                partyManager = new PartyManager(b);
            }
            
            if(SetCostAndFee()) // checks if values fee and cost are good
            {
                grpNewParty.Enabled = false;
                grpInviteGuest.Enabled = true;
            }
            else
            {
                grpNewParty.Enabled = true;
                grpInviteGuest.Enabled = false;
            }

            



        }
        bool SetCostAndFee()
        {
            double cost = 0;
            double fee = 0;
            bool CostOK = double.TryParse(txtCostPerson.Text, out cost);
            if(!CostOK)
            {
                MessageBox.Show("Wrong Cost per person");

            }
            else
            partyManager.SetCost(cost);

            bool FeeOK = double.TryParse(txtFeePerson.Text, out fee);
            if(!FeeOK)
            {
                MessageBox.Show("Wrong fee per person");
            }
            else
            {
                partyManager.SetFee(fee);
            }
            return CostOK && FeeOK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text.ToUpper();
            string fullName = ($"{lastName}, {name}");
            partyManager.AddToArray(fullName);
            lstGuests.Items.Clear(); // make sure that every time button is clicked the list is cleared.
            ShowList();
            lblNumberGuests.Text = partyManager.GuestCounter().ToString();
            lblTotalCost.Text = partyManager.CalculateTotalCost().ToString();
            lblTotalFees.Text = partyManager.CalculateTotalFee().ToString();
            lblSurplusDeficit.Text = partyManager.Revenue().ToString();
        }

        void ShowList()
        {
            for (int i = 0; i < partyManager.getMaxNumberofGuests(); i++)
            {
                if (partyManager.GetValueFromArray(i) == null) // checks if value [i] in array is null
                {
                    break;// if its null ends the loop
                }
                else // if not null then adds to list value [i] from array
                {
                    lstGuests.Items.Add($"{i + 1} {partyManager.GetValueFromArray(i)}"); // if its not empty then shows value from array
                }
            }
            
            // important info for myself:
            //The value null represents the absence of any object,
            //while the empty string is an object of type String with zero characters.
            //If you try to compare the two, they are not the same.
            // remember that value in lbl must be string
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // string selectedItem = lstGuests.SelectedItem.ToString();
            //lblSurplusDeficit.Text = selectedItem;
            //partyManager.DeleteFromArray(selectedItem);

            partyManager.MoveElementsOneSteepToLeft(partyManager.SelectedItemIndex);
            lstGuests.Items.Clear();
            ShowList();
        }

        private void lstGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstGuests.SelectedIndex;
            partyManager.SelectedItemIndex = index;
        }
    }
}