using ConsoleApp1.Model;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    //implement interface
    public class KaryawanService : IKaryawanService
    {
        public IKaryawanRepository iKaryawanRepository;

        public KaryawanService()
        {
            iKaryawanRepository = new KaryawanRepository();
        }

        public void Add(Karyawan karyawan)
        {
            iKaryawanRepository.Add(karyawan);
        }

        public void Update(int id)
        {
            iKaryawanRepository.Update(id);
        }
        public void Delete(int id)
        {
            iKaryawanRepository.Delete(id);

            //throw new NotImplementedException();
        }


        public List<Karyawan> Read()
        {
            return iKaryawanRepository.Read();

            //throw new NotImplementedException();
        }
    }

    //implement all member explicitly
    public class KaryawanService2 : IKaryawanService
    {
        void IKaryawanService.Add(Karyawan karyawan)
        {
            throw new NotImplementedException();
        }

        void IKaryawanService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Karyawan> IKaryawanService.Read()
        {
            throw new NotImplementedException();
        }

        void IKaryawanService.Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
