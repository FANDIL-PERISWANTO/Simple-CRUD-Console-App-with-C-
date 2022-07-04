using ConsoleApp1.Model;
using ConsoleApp1.Repository;
using ConsoleApp1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List Karyawan
            List<Karyawan> listKaryawans = new List<Karyawan>();
            int IdChange = 0;
            //manual();
            //repository();
            interfacer();

            //==================================================
            //MANUAL

            void manual(){

                tampil();

                //First Karyawan
                Karyawan karyawan1 = new Karyawan();
                karyawan1.id = 1;
                karyawan1.nama = "Alpha";
                karyawan1.alamat = "Bekasi";

                //Add first karyawan to List Karyawan
                listKaryawans.Add(karyawan1);

                tampil();
                foreach (Karyawan karyawanObj in listKaryawans)
                {
                    Console.WriteLine("ID : {0} - Nama : {1} - Alamatnya : {2}",
                        karyawanObj.id, karyawanObj.nama, karyawanObj.alamat
                    );
                }

                //Second Karyawan
                Karyawan karyawan2 = new Karyawan();
                karyawan2.id = 2;
                karyawan2.nama = "Beta";
                karyawan2.alamat = "Jakarta";
                listKaryawans.Add(karyawan2);

                tampil();
                foreach (Karyawan karyawanObj in listKaryawans)
                {
                    Console.WriteLine("ID : {0} - Nama : {1} - Alamatnya : {2}",
                        karyawanObj.id, karyawanObj.nama, karyawanObj.alamat
                    );
                }

                //UPDATE Karyawan
                Console.Write("\n\nID berapa yang ingin diubah? (1-2)? ");
                 IdChange = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(IdChange);
                var updateData = listKaryawans.FirstOrDefault(a => a.id == IdChange);
                foreach (Karyawan karyawanObj in listKaryawans)
                {
                    if (karyawanObj.id == IdChange)
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

                //Tampil Data setelah di update
                tampil();
                foreach (Karyawan karyawanObj in listKaryawans)
                {
                    Console.WriteLine("ID : {0} - Nama : {1} - Alamatnya : {2}",
                        karyawanObj.id, karyawanObj.nama, karyawanObj.alamat
                    );
                }

                Console.WriteLine("\r\n");
            }
            //==================================================
            //REPOSITORY

            void repository()
            {

                //Call Repostory
                IKaryawanRepository ikaryawanRepository = new KaryawanRepository();

                //READ data from Repositorypos
                List<Karyawan> listKarywanRepo = ikaryawanRepository.Read();

                //Display data repo to Console
                Console.WriteLine("List Karyawan dari Repository :");
                foreach (Karyawan karyawanObj in listKarywanRepo)
                {
                    Console.WriteLine("ID : {0} - Nama : {1} - Alamatnya : {2}",
                        karyawanObj.id, karyawanObj.nama, karyawanObj.alamat
                    );
                }

                //ADD new data karyawan to Repo
                Karyawan karyawanObjRepo = new Karyawan();
                karyawanObjRepo.id = 3;
                karyawanObjRepo.nama = "Refosola";
                karyawanObjRepo.alamat = "Bandung";

                //Call "Add" method using Repo
                ikaryawanRepository.Add(karyawanObjRepo);

                //Display Data repo to console, after add new data
                Console.WriteLine("List Karyawan dari repository (Default Data(Populate) + New Data) :");
                foreach (Karyawan karyawanObj in listKarywanRepo)
                {
                    Console.WriteLine("ID : {0} - Nama : {1} - Alamatnya : {2}",
                        karyawanObj.id, karyawanObj.nama, karyawanObj.alamat
                    );
                }

                //UPDATE repo data
                Console.Write("\n\nID berapa yang ingin diubah? (1-3)? ");
                 IdChange = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(IdChange);
             

                //Call "Update" method using Repo
                ikaryawanRepository.Update(IdChange);

                //Display data after updated
                Console.WriteLine("\nList Karyawan Setelah di Updated");
                foreach (Karyawan karyawanObj in listKarywanRepo)
                {
                    Console.WriteLine("ID : {0} - Nama : {1} - Alamatnya : {2}",
                        karyawanObj.id, karyawanObj.nama, karyawanObj.alamat
                    );
                }

                //DELETE repo data
                //id=1
                ikaryawanRepository.Delete(1);

                Console.WriteLine("\r\n");
                //Display data to Console, after delete dafault data (id=1)
                Console.WriteLine("List Karyawan dari Repository (Default Data + New Data) after deleted data(id=1) : ");
                foreach(Karyawan karyawanObj in listKarywanRepo)
                {
                    Console.WriteLine("ID : {0} - Nama : {1} - Alamatnya : {2}",
                        karyawanObj.id, karyawanObj.nama, karyawanObj.alamat
                    );
                }

                Console.WriteLine("\r\n");
            }
            //==================================================
            //INTERFACE (service)

            void interfacer(){
                //call interface
                IKaryawanService aKaryawanService = new KaryawanService();

                //READ data from interface
                List<Karyawan> listKaryawanInterface = aKaryawanService.Read();

                //Display data to Console
                Console.WriteLine("List karyawan dari interface :");
                foreach(Karyawan karyawanObj in listKaryawanInterface)
                {
                    Console.WriteLine("ID: {0} - Nama: {1} - Alamat: {2}", karyawanObj.id, karyawanObj.nama, karyawanObj.alamat);
                }

                //Add new data karyawan via interface
                Console.WriteLine("\n(ADD)\nData Karyawan Baru: ");

                Karyawan addKaryawaninterface1 = new Karyawan();
                addKaryawaninterface1.id = 3;
                Console.Write("Nama: ");
                addKaryawaninterface1.nama = Console.ReadLine();
                Console.Write("Alamat: ");
                addKaryawaninterface1.alamat = Console.ReadLine();

                //Call ADD using interface
                aKaryawanService.Add(addKaryawaninterface1);
                
                Console.WriteLine("\r\n");

                //Display data to Console, after add new data
                Console.WriteLine("List Karyawan dari Service (Default Data + New Data) :");
                foreach (Karyawan karyawanObj in listKaryawanInterface)
                {
                    Console.WriteLine("ID: {0} - Nama: {1} - Alamat: {2}", karyawanObj.id, karyawanObj.nama, karyawanObj.alamat);
                }


                //UPDATE interface data
                Console.Write("\n(UPDATE)\nID berapa yang ingin diubah? (1-3)? ");
                IdChange = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(IdChange);


                //Call "Update" method using Repo
                aKaryawanService.Update(IdChange);

                //Display data after updated
                Console.WriteLine("\nList Karyawan Setelah di Updated");
                foreach (Karyawan karyawanObj in listKaryawanInterface)
                {
                    Console.WriteLine("ID : {0} - Nama : {1} - Alamatnya : {2}",
                        karyawanObj.id, karyawanObj.nama, karyawanObj.alamat
                    );
                }


                //Delete one of defaults data
                //id = 1
                Console.WriteLine("\n(DELETE)\nId karyawan yang ingin di hapus?(1-3)");
                IdChange = Convert.ToInt32(Console.ReadLine());

                aKaryawanService.Delete(IdChange);

                Console.WriteLine("\r\n");
                //Display data to Console, after delete default data
                Console.WriteLine("List Karyawan dari Service (Default Data + New Data) after delete data :");
                foreach (Karyawan karyawanObj in listKaryawanInterface)
                {
                    Console.WriteLine("ID: {0} - Nama: {1} - Alamat: {2}", karyawanObj.id, karyawanObj.nama, karyawanObj.alamat);
                }

                Console.WriteLine("\r\n");
            }


            Console.WriteLine("FANDIL PERISWANTO");
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }

        //Display list karyawan
        static  void  tampil()
        {
            Console.WriteLine("List Karyawan : ");
        }
        
    }
}
