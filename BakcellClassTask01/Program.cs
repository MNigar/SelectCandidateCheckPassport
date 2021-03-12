using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakcellClassTask01
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate candidate = new Candidate();
            candidate.Id = 1;
            candidate.Email = "nigar4t@live.com";
            candidate.Name = "Nigar";
            Candidate.Show(candidate);
            Company bakcell = new Company();
            for (; ;)
            {
                Console.WriteLine("Namizedin Idsini seçin");
                int Id = Convert.ToInt32(Console.ReadLine());
                if (Id != candidate.Id)
                {
                    Console.WriteLine("Yalnis Id");
                }
                else
                {
                    bakcell.SelectCandidate(Id);
                    bakcell.SendEmail(candidate.Email);
                    Console.WriteLine("Namizedin müsahibeye qebulu");
                    Console.WriteLine("Şəxsiyyət vəsiqəsi təqdim edildi?(yes/no)");
                    string answer = Console.ReadLine();
                    candidate.CheckPassport(answer);
                }

            }

        }
    }
}
