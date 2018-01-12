using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
   static class Bancomat
    {
      // public event EventHandler<AccountEventArgs> Not_enough_money;
        public static string Address { set; get; }
        public static decimal Current_amount { get; set; }
        public static string Show_address()
        {
            return $"\t Bancomat :\t\n Address : {Address}\n";
        }
        public static string Show_current_amount()
        {
            return $"Current amount : {Current_amount}";
        }
        public static void Put_money(decimal sum)
        {
            Current_amount += sum;
        }
        public static string Withdraw(decimal sum)
        {
            if (Current_amount - sum < 0)
            {
                //if (Not_enough_money != null) { return $"Not enough money at ATM"; }
                return $"Not enough money at ATM";

            }
            else
            if (Current_amount - sum >= 0)
            {
                Current_amount -= sum;
                //var amount = Convert.ToString(Current_amount);
                return $"You can get your {sum}$"+"\r\n" + $"Current amount {Current_amount}$";
                //return amount;
            }
            else return $"Get your money!";
        }
    }
}
