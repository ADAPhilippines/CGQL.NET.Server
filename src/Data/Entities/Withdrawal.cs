using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class Withdrawal
    {
        public Withdrawal()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long AddrId { get; set; }

        public decimal Amount { get; set; }

        public long TxId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual StakeAddress AddrStakeAddress { get; set; }

        public virtual Tx Tx { get; set; }

        #endregion

    }
}
