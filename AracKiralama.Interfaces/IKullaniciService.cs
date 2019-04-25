using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.DTO.DTO;
using AracKiralama.Entities;


namespace AracKiralama.Interfaces
{
   // [ServiceContract]
    public interface IKullaniciService:IGenericService<Kullanici>
    {
        // [OperationContract]
        Kullanici KullaniciGiris(string eposta, string sifre);

     

    }
}
