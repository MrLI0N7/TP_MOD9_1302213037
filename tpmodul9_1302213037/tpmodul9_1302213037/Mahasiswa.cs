namespace tpmodul9_1302213037
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string nim { get; set; }
        public Mahasiswa() { }
        public Mahasiswa(string nama, string nim)
        {
            this.Nama = nama;
            this.nim = nim;
        }
    }
}
