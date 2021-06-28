using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Pen
{
    public class ModelBiodata<Type>
    {
        private Type Nama { get; set; }
        private Type Agama { get; set; }
        private Type Pendidikan { get; set; }
        private Type AlamatLengkap { get; set; }
        private Type Namaorangtua { get; set; }
        private Type jenisKelamin { get; set; }
        private Type TanggalLahir { get; set; }

        public void BiodataPengguna(Type NamaLengkap, Type Agamaa, Type PendidikanAkhir, Type Alamat, Type NamaOrtu, Type Kelamin, Type TglLahir)
        {
            Nama = NamaLengkap;
            Agama = Agamaa;
            Pendidikan = PendidikanAkhir;
            AlamatLengkap = Alamat;
            Namaorangtua = NamaOrtu;
            jenisKelamin = Kelamin;
            TanggalLahir = TglLahir;
        }


    }
}