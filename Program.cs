using System;
namespace Program
{

    class dosen
    {
        private int id;
        private string nama;
        private int Nik;
        private string gender;
        private string course;

        public void Dosen()
        {
            this.id = 1;
            this.nama = "Bayu Nadya Kusuma S.T, M.Eng";
            this.Nik = 170501;
            this.gender = "Laki- Laki";
            this.course = "Pemrograman";
        }

        public void attDosen(string name, int nik)
        {
            this.nama = name;
            this.Nik = nik;
        }

        public void addCourse(string course)
        {
            this.course = course;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public void setID(int ID)
        {
            this.id = ID;
        }

        public override string ToString()
        {
            return "ID     : " + this.id + "\n" +
                    "Nama   : " + this.nama + "\n" +
                    "NIK    : " + this.Nik + "\n" +
                    "Gender : " + this.gender + "\n" +
                    "Course : " + this.course + "\n";
        }

    }
}

namespace Program
{

    class program
    {
        static void Main(string[] args)
        {

            dosen dosenDefault = new dosen();
            Console.WriteLine("\n========== DEFAULT DOSEN ==========\n");
            dosenDefault.Dosen();
            Console.WriteLine(dosenDefault.ToString());

            dosen dosentambahan = new dosen();
            Console.WriteLine("\n========== DOSEN TAMBAHAN ==========\n");
            dosentambahan.setID(2);
            dosentambahan.attDosen("Majid Rahardi, S.Kom., M.Eng", 333333);
            dosentambahan.setGender("Laki- Laki");
            dosentambahan.addCourse("Komunikasi Data");
            Console.WriteLine(dosentambahan.ToString());

            Mahasiswa mahasiswa = new Mahasiswa();
            Console.WriteLine("\n========== BIODATA MAHASISWA ==========\n");
            mahasiswa.BioDataMahasiswa();
            Console.WriteLine(mahasiswa.ToString());

        }
    }
}

namespace Program
{
    class Mahasiswa
    {
        private string nama;
        private string gender;
        private string Biodata;
        private string NIM;
        public void BioDataMahasiswa()
        {
            this.nama = "DESKA DANU PERMADI";
            this.NIM = "21.11.4109";
            this.gender = "LAKI LAKI";
            this.Biodata = "TEMPAT, TANGGAL LAHIR : PALEMBANG - SUMATERA SELATAN , 26 DESEMBER 2002.\n          ALAMAT                : LIMAN SARI, OKU TIMUR, SUMATERA SELATAN.\n          PENDIDIKAN TERAKHIR = MAHASISWA DI UNIVERSITAS AMIKOM YOGYAKARTA";
        }

        public override string ToString()
        {
            return "Nama    : " + this.nama + "\n" +
                    "NIM     : " + this.NIM + "\n" +
                    "Gender  : " + this.gender + "\n" +
                    "Biodata : " + this.Biodata + "\n";
        }
    }
}