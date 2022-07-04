using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public interface IKaryawanRepository
    {
        List<Karyawan> Read();
        void Add(Karyawan karyawan);
        void Update(int id);
        void Delete(int id);
    }
}
