using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Ticket
    {
        public int Id { get; set; }
        public DateTime Date_of_payment { get; set; }
        public DateTime Time_payment { get; set; }
        public char Ticket_control_number { get; set; }
        public float Payment_amount { get; set; }
        public int Player_Id { get; set; }
        public int System { get; set; }
        public int Workpeople_Id { get; set; }
        public int Code_betting_shop_Id { get; set; }

        

        public Ticket(int id, DateTime date_of_payment, DateTime time_payment, char ticket_control_number, float payment_amountint, int player_Id, int system, int workpeople_Id, int code_betting_shop_Id)
        {
            Id = id;
            Date_of_payment = date_of_payment;
            Time_payment = time_payment;
            Ticket_control_number = ticket_control_number;
            Payment_amount = payment_amountint;
            Player_Id = player_Id;
            System = system;
            Workpeople_Id = workpeople_Id;
            Code_betting_shop_Id = code_betting_shop_Id;

        }




    }
   
       

}
