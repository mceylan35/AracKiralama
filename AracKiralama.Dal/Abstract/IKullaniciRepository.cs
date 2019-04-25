using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Entities;
using AracKiralama.DTO.DTO;



namespace AracKiralama.Dal.Abstract
{
    public interface IKullaniciRepository:IGenericRepository<Kullanici>
    {
        Kullanici KullaniciGiris(string eposta, string sifre);
    }
}
