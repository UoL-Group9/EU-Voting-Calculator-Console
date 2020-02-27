using System;
using System.Collections.Generic;
using System.Text;

namespace EU_Voting_Calculator
{
    public class VotingResult
    {
        public int memberstateyes = 0;
        public int memberstateno = 0;
        public int memberstateabs = 0;

        public double memberstatepop;

        public const int memberstateresult = 27;
        const double memberpopresult = 65;
    }
}
