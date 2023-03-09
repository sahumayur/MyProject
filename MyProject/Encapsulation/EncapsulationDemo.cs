using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Encapsulation
{
    internal class EncapsulationDemo
    {
        string account_holder_name;
        int account_number;
        string ifsc_code;
        string bank_name;
        string branch_name;

        public string Account_holder_name
        {
            set
            {
                account_holder_name = value;
            }
            get
            {
                return account_holder_name;
            }
        }
        public int Account_number
        {
            set
            {
                account_number = value;
            }
            get
            {
                return account_number;
            } 
        }

        public string Bank_name
        {
            set
            {
                bank_name = value;
            }
            get
            {
                return bank_name;
            }
        }

        public string Branch_name
        {
            set
            {
                branch_name = value;
            }
            get
            {
                return branch_name;
            }
        }

    }
}
