using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;


namespace JQueryAjaxCRUD_PopUp_Dialog.Models
{
    public class TransactionDBContext :DbContext
    {

        public TransactionDBContext(DbContextOptions<TransactionDBContext> options) : base(options)
        { }


        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
