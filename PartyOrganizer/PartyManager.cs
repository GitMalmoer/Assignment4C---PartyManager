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
                if (arrayOfGuests[i] == null)
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
                if(arrayOfGuests[i] != null)
                {
                    guestCounter++;
                }
            }
            return guestCounter;
        }
        public void CalculateCost()
        {
            int totalCost = 0;
            //totalCost = this.costPerPerson * arrayOfGuests
        }
    }
}
