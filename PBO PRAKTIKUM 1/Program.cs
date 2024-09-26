public class Hewan
{
    public string nama;
    public int umur;

    public Hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }
    public virtual string Suara()
    {
        return "Hewan ini bersuaraaa dan bernadyaaa";
    }

    public string InfoHewan()
    {
        return $"Nama: {nama}, Umur: {umur}";
    }
}
public class Reptil : Hewan
{
    public double panjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh)
        : base(nama, umur)
    {
        this.panjangTubuh = panjangTubuh;
    }

    public override string Suara()
    {
        return "Reptil ini mengeluarkan suara khas hewan";
    }
}
public class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki)
        : base(nama, umur)
    {
        this.jumlahKaki = jumlahKaki;
    }
    public override string Suara()
    {
        return "Mamalia ini mengeluarkan suara mendesah ah ah";
    }
}

public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki)
        : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Singa ini suaranya RAWWWLLLL";
    }

    public string Mengaum()
    {
        return "KAPAL LAWD"
    }
    public string Infolengkap()
    {
        return $"Nama: {nama}, Umur: {umur}, Jumlah Kaki: {jumlahKaki}";
    }
}

public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki)
        : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Gajah ini mengeluarkan suara trompet om sonata";
    }
}
public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh)
        : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Ular ini mengeluarkan suara desasss desisss";
    }

    public string Merayap()
    {
        return "Sssssssuuuuuiiiiiii";
    }
}
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh)
        : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Buaya ini mengeluarkan suara mengaum rawl";
    }
}
public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine(hewan.Suara());
        }
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // a. Buat objek kebun binatang
//        KebunBinatang kebunBinatang = new KebunBinatang();

//        // b. Buat beberapa objek dari berbagai jenis hewan
//        Singa singa = new Singa("Singa", 5, 4);
//        Gajah gajah = new Gajah("Gajah", 10, 4);
//        Ular ular = new Ular("Ular", 3, 2.5);
//        Buaya buaya = new Buaya("Buaya", 8, 4.2);

//        // c. Tambahkan hewan-hewan tersebut ke kebun binatang
//        kebunBinatang.TambahHewan(singa);
//        kebunBinatang.TambahHewan(gajah);
//        kebunBinatang.TambahHewan(ular);
//        kebunBinatang.TambahHewan(buaya);

//        // d. Panggil method DaftarHewan() untuk menampilkan semua hewan
//        kebunBinatang.DaftarHewan();

//        // e. Demonstrasi penggunaan polymorphism dengan memanggil method Suara() untuk beberapa hewan berbeda
//        Console.WriteLine("Demonstrasi polymorphism:");
//        Console.WriteLine(singa.Suara()); //
//        Console.WriteLine(gajah.Suara()); //
//        Console.WriteLine(ular.Suara()); //
//        Console.WriteLine(buaya.Suara()); //

//        // f. Panggil method khusus seperti Mengaum() untuk Singa
//        Console.WriteLine("Demonstrasi method khusus:");
//        Console.WriteLine(singa.Mengaum());
//        Console.WriteLine(ular.Merayap());
//    }
//}
// Analisis 1
//class Program
//{
//    static void Main(string[] args)
//    {
//        Gajah gajah = new Gajah("Gajah", 10, 4);
//        Ular ular = new Ular("Ular", 3, 2.5);

//        Console.WriteLine(gajah.Suara());
//        Console.WriteLine(ular.Suara());

//    }
//}

// Analisis 2
//class Program
//{
//    static void Main(string[] args)
//    {
//        Singa singa = new Singa("Singa", 5, 4);
//        Console.WriteLine(singa.Mengaum());
//    }
//}

// Analisis 3
//class Program
//{
//    static void Main(string[] args)
//    {
//        Singa singa = new Singa("Singa", 5, 4);
//        Console.WriteLine(singa.Infolengkap());
//    }
//}

// Analisis 4
//class Program
//    {
//        static void Main(string[] args)
//        {
//            Ular ular = new Ular("Ular", 3, 2.5);
//            Console.WriteLine(ular.Merayap());
//        }
//    }
class Program
{
    static void Main(string[] args)
    {
        Reptil reptil = new Buaya("Buaya", 8, 4.2);
        Console.WriteLine(reptil.Suara());
    }
}