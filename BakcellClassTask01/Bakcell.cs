using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakcellClassTask01
{
    public class Bakcell
    {
        public int Id  { get; set; }
        public string Name { get; set; }

        public void SelectCandidate(int Id)
        {
            Console.WriteLine("Namized seçildi");
        }
        public void SendEmail(string Email)
        {
            Console.WriteLine("Email şəxsə göndərildi");
        }
      
}



}
