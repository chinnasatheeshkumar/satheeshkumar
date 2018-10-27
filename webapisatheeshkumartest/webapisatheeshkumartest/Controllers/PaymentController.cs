using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapisatheeshkumartest.Data;
using webapisatheeshkumartest.Models;

namespace webapisatheeshkumartest.Controllers
{
    /// <summary>
    /// The controller is used for payments related functionalities
    /// </summary>
    public class PaymentController : ApiController
    {
        private PaymentsEntities Entities = new PaymentsEntities();

        /// <summary>
        /// Fetch the Payment Details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Payment/getPaymentDetails")]
        public List<PaymentDetail> getPaymentDetails()
        {
            List<PaymentDetail> _PaymentDetailsList = new List<PaymentDetail>();
            try
            {
                var _dbPaymentDetailsList = (from p in Entities.Tables select p).OrderBy(a=>a.ApplicationId).ToList();
                if(_dbPaymentDetailsList != null && _dbPaymentDetailsList.Any())
                {
                    foreach(var item in _dbPaymentDetailsList) { 
                    PaymentDetail payment = new PaymentDetail();
                        payment.Id = item.Id;
                        payment.ApplicationId = item.ApplicationId;
                        payment.Type = item.Type;
                        payment.Summary = item.Summary;
                        payment.Amount = item.Amount;
                        payment.PostingDate = item.PostingDate;
                        payment.IsCleared = item.IsCleared;
                        payment.ClearedDate = item.ClearedDate;
                        _PaymentDetailsList.Add(payment);

                    }
                }
                else
                {
                    //If no data found it will return just BadRequest status code with message
                    Request.CreateResponse(HttpStatusCode.BadRequest, "No Records Found");
                }
            }
            catch
            {
                //If Exception throws it will return just BadRequest status code with message
                Request.CreateResponse(HttpStatusCode.BadRequest, "Some thing went wrong");
            }
            return _PaymentDetailsList;

        }


    }
}
