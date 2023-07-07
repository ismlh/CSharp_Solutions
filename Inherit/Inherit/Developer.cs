﻿namespace Inherit
{
    public class Developer : Employee
    {
        private decimal commisson = 1.0m;
        public Developer(int id, string Name, int looggedHours, decimal Wage) : base(id, Name, looggedHours, Wage) { }
        protected override decimal calcBaseSalary()
        {
            return base.calcBaseSalary();
        }
        protected override decimal calcNetSalary()
        {
            return base.calcNetSalary() * commisson;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCommision : {this.commisson}";
        }
    }
}
