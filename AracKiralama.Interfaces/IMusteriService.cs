using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Entities;

namespace AracKiralama.Interfaces
{
    public interface IMusteriService:IGenericService<Musteri>
    {
        Musteri MusteriGiris(string eposta, string sifre);
    }
}
