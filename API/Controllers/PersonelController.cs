using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class PersonelController : ApiController
    {
        [HttpGet]
        public ResponseMessage<List<Personel>> PersonelListesi()
        {
            return PersonelIslemleri.PersonelListesi();
        }
    }
}
