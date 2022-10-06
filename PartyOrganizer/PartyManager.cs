using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyOrganizer
{
     class PartyManager
    {
        private int maxNumberOfGuests;
        private double costPerPerson = 0;
        private double feePerPerson = 0;
        private string firstName;
        private string lastName;
        private string name;
        private string[] arrayOfGuests;
        private int selectedItemIndex;
        
        
        
        public int SelectedItemIndex
        {
            get { return selectedItemIndex; }
            
            set
            {
                selectedItemIndex = value;
            }
        }
        

        public PartyManager(int maxNumberOfGuests)
        {
            this.maxNumberOfGuests = maxNumberOfGuests;
            arrayOfGuests = new string[maxNumberOfGuests] ;
        }
        public void SetCost(double cost)
        {
            this.costPerPerson = cost;
        }
        public void SetFee(double fee)
        {
            this.feePerPerson = fee;
        }
        public void AddToArray(string name)
        {
            for (int i = 0; i < this.maxNumberOfGuests; i++)
           {
                if (string.IsNullOrEmpty(arrayOfGuests[i]))
                {
                    arrayOfGuests[i] = name;
                    break;
                }
            }
        }
        public string GetValueFromArray(int number)
        {
            return this.arrayOfGuests[number];
        }

        public int getMaxNumberofGuests()
        {
            return maxNumberOfGuests;
        }
        public double GuestCounter()
        {
            int guestCounter = 0; // never declare this as instance int. Value needs to be 0 every time you run method.
            for(int i = 0;i<arrayOfGuests.Length;i++)
            {
                if(arrayOfGuests[i] != null && arrayOfGuests[i] != string.Empty)
                {
                    guestCounter++;
                }
            }
            return guestCounter;
        }
        public double CalculateTotalCost()
        {
            // txtCostPerson.Text doesnt need to be checked by tryparse because it was allready checked
            // by method SetCostAndFee()
            double totalCost = GuestCounter() * this.costPerPerson;
            return totalCost;
        }
        public double CalculateTotalFee()
        {
            double totalFee = GuestCounter() * this.feePerPerson;
            return totalFee;
        }
        public double Revenue()
        {
            double revenue = 0;
            revenue = CalculateTotalFee() - CalculateTotalCost();
            return revenue;

        }
        public void MoveElementsOneSteepToLeft(int index) // return index from list 
        {
            
            for (int i = index + 1;i< arrayOfGuests.Length; i++)
            {
                arrayOfGuests[i - 1] = arrayOfGuests[i];
                arrayOfGuests[i] = String.Empty;
            }
        }

    }
}
