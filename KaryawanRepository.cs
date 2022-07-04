using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public class KaryawanRepository : IKaryawanRepository
    {
        public List<Karyawan> RepoKaryawans = new List<Karyawan>();

        //Default Constructor
        public KaryawanRepository()
        {
            //Setup Default Data
            PopulateData();
        }
        void PopulateData()
        {
            RepoKaryawans.Add(new Karyawan { id = 1 , nama = "Reva", alamat = "Bogor"});

            Karyawan karyawan2 = new Karyawan();
            karyawan2.id = 2;
            karyawan2.nama = "Revi";
            karyawan2.alamat = "Tangerang";

            RepoKaryawans.Add(karyawan2);
        }

        public List<Model.Karyawan> Read()
        {
            return RepoKaryawans;
        }

        void IKaryawanRepository.Add(Karyawan karyawan)
        {
            //add new
            RepoKaryawans.Add(karyawan);
        }

        void IKaryawanRepository.Update(int id)
        {
            foreach (Karyawan karyawanObj in RepoKaryawans)
            {
                if (karyawanObj.id == id)
                {
                    Console.WriteLine("ID : {0} - Nama : {1} - Alamatnya : {2}",
                        karyawanObj.id, karyawanObj.nama, karyawanObj.alamat
                    );

                    Console.WriteLine("\nUbah Datanya menjadi ->");
                    Console.Write("Nama : ");
                    karyawanObj.nama = Console.ReadLine();
                    Console.Write("Alamat : ");
                    karyawanObj.alamat = Console.ReadLine();
                }
            }

        }

        void IKaryawanRepository.Delete(int id)
        {
            var delRepoKaryawan = RepoKaryawans.FirstOrDefault(z => z.id == id);
            RepoKaryawans.Remove(delRepoKaryawan);
        }
    }
}
