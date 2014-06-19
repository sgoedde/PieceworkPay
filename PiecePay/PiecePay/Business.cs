using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiecePay
{
    class Business
    {
        protected string strName;
        protected decimal decPay;
        protected int intPieces;
        protected int intBREAKPOINT_1 = 199;
        protected int intBREAKPOINT_2 = 399;
        protected int intBREAKPOINT_3 = 599;
        protected decimal decPAY_1 = .50M;
        protected decimal decPAY_2 = .55M;
        protected decimal decPAY_3 = .60M;
        protected decimal decPAY_4 = .65M;

        protected static int intCount = 0;
        protected static int intTotalPieces = 0;
        protected static decimal decTotalPay = 0;
        protected static decimal decAverage;

        public string Name
        {
            get
            {
                return strName;
            }
            set
            {
                strName = value;
            }
        }

        public decimal Pay
        {
            get
            {
                return decPay;
            }
            set
            {
                decPay = value;
            }
        }

        public int Pieces
        {
            get
            {
                return intPieces;
            }
            set
            {
                intPieces = value;
            }
        }

        public static decimal TotalPay
        {
            get
            {
                return decTotalPay;
            }
        }

        public static int TotalPieces
        {
            get
            {
                return intTotalPieces;
            }
        }

        public static int Count
        {
            get
            {
                return intCount;
            }
            set
            {
                intCount = value;
            }
        }

        public Business(string strName, int intPieces)
        {
            Name = strName;
            Pieces = intPieces;
            FindPay();
            SummaryTotals();
        }

        protected virtual void FindPay()
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
                decPay = Pieces * decPAY_4;
            } 
        }

        protected void SummaryTotals()
        {
            decTotalPay += decPay;
            intTotalPieces += intPieces;
            intCount++;
            decAverage = decTotalPay / intCount;
        }

        public static decimal Average
        {
            get
            {
                return decAverage;
            }
        }
    }
}
