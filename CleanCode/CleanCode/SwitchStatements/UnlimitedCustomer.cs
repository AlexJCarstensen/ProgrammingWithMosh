using System;

namespace CleanCode.SwitchStatements
{
    public class UnlimitedCustomer : Customer
    {
       
        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var statement = new MonthlyStatement {TotalCost = 54.90f};

            return statement;
        }
    }
}