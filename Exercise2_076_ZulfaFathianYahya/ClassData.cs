using Newtonsoft.Json;
using RestSharp;
using Service_076_ZulfaFathianYahya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_076_ZulfaFathianYahya
{
    class ClassData
    {
        string baseUrl = "http://localhost:1920/";

        public void insertMahasiswa(string nim, string nama, string prodi, string angkatan)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.nama = nama;
            mhs.nim = nim;
            mhs.prodi = prodi;
            mhs.angkatan = angkatan;

            var data = JsonConvert.SerializeObject(mhs); //Convert to Json
            var postData = new WebClient();
            postData.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = postData.UploadString(baseUrl + "CreateMahasiswa", data);
        }

        public Mahasiswa search(string nim)
        {
            var json = new WebClient().DownloadString("http://localhost:1920/Mahasiswa/" + nim);
            var data = JsonConvert.DeserializeObject<Mahasiswa>(json);
            return data;
        }

        public string Jumlahdata ()
        {
            var json = new WebClient().DownloadString("http://localhost:1920/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            int i = data.Count();
            string sum = i.ToString();
            return sum;
        }

        public List<Mahasiswa> getAllData()
        {
            List<Mahasiswa> data = new List<Mahasiswa>();
            try
            {
                var json = new WebClient().DownloadString("http://localhost:1920/Mahasiswa");
                data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }


            return data;

        }

        public string updateDatabase(Mahasiswa mhs)
        {
            string msg = "Sukses";
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("UpdateMahasiswaByNIM", Method.PUT);
                request.AddJsonBody(mhs);
                client.Execute(request);
            }
            catch (Exception er)
            {
                msg = "Gagal";
                Console.WriteLine(er);
                Console.ReadLine();

            }


            return msg;
        }

        public bool deleteMahasiswa(string nim)
        {
            bool deleted = false;
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("DeleteMahasiswa/" + nim, Method.DELETE);
                client.Execute(request);
            }
            catch (Exception ex)
            {

            }
            return deleted;
        }
    }
}
