using System;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commission (string name, string address, string phone, string socSecNumber, double rate, double commissionRate) : base(name, address, phone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
        }

        public void addSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | " +
                    $"Total sales: {_totalSales}";
        }

        public override double Pay()
        {
            var payment = base.Pay() + (_totalSales * _commissionRate);
            _commissionRate = 0;
            return payment;
        }
    }
}