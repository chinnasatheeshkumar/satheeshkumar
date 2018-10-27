using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapisatheeshkumartest.Models;

namespace webapisatheeshkumartest.Controllers
{
    public class PaymentController : ApiController
    {

        [HttpPost]
        public List<PaymentDetail> getPaymentDetails()
        {
            List<PaymentDetail> _dbPaymentDetailsList = new List<PaymentDetail>();

            return _dbPaymentDetailsList;

        }


    }
}
