using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    interface IKaryawanService
    {
        void Add(Karyawan karyawan);
        void Update(int id);
        void Delete(int id);
        List<Karyawan> Read();
    }
}
