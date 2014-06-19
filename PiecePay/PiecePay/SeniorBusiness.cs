using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiecePay
{
    class SeniorBusiness:Business
    {
        const decimal SENIOR_DISCOUNT = 1.1m;


        public SeniorBusiness(string strName, int intPieces)
            : base(strName, intPieces)
        {

        }

        protected override void FindPay()
        {
            if (Pieces <= intBREAKPOINT_1)
            {
                decPay = Pieces * decPAY_1;
            }
            else if (Pieces <= intBREAKPOINT_2)
            {
                decPay = Pieces * decPAY_2;
            }
            else if (Pieces <= intBREAKPOINT_3)
            {
                decPay = Pieces * decPAY_3;
            }
            else
            {
                decPay = Pieces * decPAY_4 * SENIOR_DISCOUNT;
            } 
        }
    }
}
