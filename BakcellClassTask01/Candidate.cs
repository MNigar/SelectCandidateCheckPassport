using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakcellClassTask01
{
    public class Candidate
    {   public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
       
        public void CandidateEmail(string email)
        {
            if (email == Email)
            {
                Console.WriteLine("Email şexse göndərildi");
            }

        }
        public static void Show(Candidate candidates)
        {
            Console.WriteLine($"Id :{candidates.Id}\n Ad:{candidates.Name}\n Email:{candidates.Email}\n");
        }
        public bool CheckPassport(string passport)
        {
            if (passport =="yes" )
            {
                Console.WriteLine("Buyurun keçin");
                return true;
            }
            if (passport == "no")
            {
                Console.WriteLine("Şexsiyyət vesiqeniz olmadan daxil ola bilmezsiniz");
                return false;
            }
            else
            {
                Console.WriteLine("Yalnış!");
                return false;
            }
        }
    }
    
    

}
