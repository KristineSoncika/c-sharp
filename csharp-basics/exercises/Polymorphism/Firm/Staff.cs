using System;

namespace Firm
{
    public class Staff
    {
        private StaffMember[] _staffList;

        public Staff()
        {
            _staffList = new StaffMember[8];
            _staffList[0] = new Executive("Sam", "123 Main Line", "555-0469", "123-45-6789", 2423.07);
            _staffList[1] = new Employee("Carla", "456 Off Line", "555-0101", "987-65-4321", 1246.15);
            _staffList[2] = new Employee("Woody", "789 Off Rocker", "555-0000", "010-20-3040", 1169.23);
            _staffList[3] = new Hourly("Diane", "678 Fifth Ave.", "555-0690", "958-47-3625", 10.55);
            _staffList[4] = new Volunteer("Norm", "987 Suds Blvd.", "555-8374");
            _staffList[5] = new Volunteer("Cliff", "321 Duds Lane", "555-7282");
            _staffList[6] = new Commission("Anie", "456 Eagle Drive", "555-5346", "546-34-9675", 6.25, 0.2);
            _staffList[7] = new Commission("Barry", "276 Honey Road", "555-9845", "130-23-1078", 9.75, 0.15);

            ((Executive)_staffList[0]).AwardBonus(500.00);
            ((Hourly)_staffList[3]).AddHours(40);
            ((Commission)_staffList[6]).AddHours(35);
            ((Commission)_staffList[6]).addSales(400);
            ((Commission)_staffList[7]).AddHours(40);
            ((Commission)_staffList[7]).addSales(950);
        }

        public void Payday()
        {
            foreach (var staff in _staffList)
            {
                Console.WriteLine(staff);
                var amount = staff.Pay();
                if (amount == 0.00)
                {
                    Console.WriteLine("Thanks!");
                    Console.WriteLine("-----------------------------------");
                }  
                else
                {
                    Console.WriteLine("Paid: " + amount);
                    Console.WriteLine("-----------------------------------");
                }
            }
        }
    }
}