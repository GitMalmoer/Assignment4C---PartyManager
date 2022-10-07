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
            lblTotalCost.Text = String.Empty;
            lblTotalFees.Text = String.Empty;
            lblSurplusDeficit.Text = String.Empty;
            lblNumberGuests.Text = String.Empty;
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            if (CreateObjectList() && SetCostAndFee()) // checks if values given are good
            {
                grpInviteGuest.Enabled = true;
                lstGuests.Items.Clear();
                int numberofguests = partyManager.getMaxNumberofGuests();
                MessageBox.Show($"Party list for {numberofguests} guests created!");
            }
            else
            {
                grpInviteGuest.Enabled = false;
                lstGuests.Items.Clear();
            }
        }

        private bool CreateObjectList()
        {
            int b;
            bool ok = int.TryParse(txtMaxGuests.Text, out b);
            if (ok && b > 0)
            {
                partyManager = new PartyManager(b);
                return ok;
            }
            else
            {
                MessageBox.Show("Wrong number of guests");
                return false;
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
            SetName();
            partyManager.AddToArray(partyManager.Name);
            ShowList();
            SetCalculationLabels();
        }

        private void SetName()
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text.ToUpper();
            string fullName = ($"{lastName}, {name}");
            partyManager.Name = fullName;
        }

        private void SetCalculationLabels()
        {
            lblNumberGuests.Text = partyManager.GuestCounter().ToString();
            lblTotalCost.Text = partyManager.CalculateTotalCost().ToString();
            lblTotalFees.Text = partyManager.CalculateTotalFee().ToString();
            lblSurplusDeficit.Text = partyManager.Revenue().ToString();
        }

        void ShowList()
        {
            lstGuests.Items.Clear();
            for (int i = 0; i < partyManager.getMaxNumberofGuests(); i++)
            {
                if (partyManager.GetValueFromArray(i) == null || partyManager.GetValueFromArray(i) == String.Empty) // checks if value [i] in array is null
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
            //partyManager.DeleteFromArray(selectedItem); this doesnt work because listbox stirng looks like: number firstname lastname
            // the number is not in array

            partyManager.MoveElementsOneSteepToLeft(partyManager.SelectedItemIndex);
            lstGuests.Items.Clear();
            ShowList();
           lstGuests.SelectedIndex = partyManager.SelectedItemIndex - 1; // selected index moves after removal -1
            SetCalculationLabels();
        }

        private void lstGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstGuests.SelectedIndex;
            partyManager.SelectedItemIndex = index;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            SetName(); // pushes fullname from textboxes to instance string in PartyManager class
            int index = lstGuests.SelectedIndex;
            partyManager.SelectedItemIndex = index; // pushes(setter) the selected item to class int selectedItemIndex

            partyManager.ChangeValue(index);
            ShowList();
        }
    }
}