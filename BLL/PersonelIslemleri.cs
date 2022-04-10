using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PersonelIslemleri
    {
        public static ResponseMessage<List<Personel>> PersonelListesi() {
            ResponseMessage<List<Personel>> response = new ResponseMessage<List<Personel>>();
            try
            {
                response.ResultTable = UnitOfWork.Context.Personel.ToList();
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }
    }
}
