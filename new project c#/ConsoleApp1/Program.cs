public class HelloWorld
{
     String halo = "halo";
    int angkaSatu;
    int angkaDua;

    public void fungsiDalamKelas()
    {
        String haloJuga = "haloo";

    }
    public void operasiTambah(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine(angkaSatuPar + angkaDuaPar);

    }
     public void operasikurang(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine(angkaSatuPar - angkaDuaPar);

    }
     public void operasiKali(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine(angkaSatuPar * angkaDuaPar);

    }
      public void operasiBagi(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine(angkaSatuPar / angkaDuaPar);

    }



    public static void Main()
    {
        Console.WriteLine("Merdeka");
        HelloWorld inisiasiHello = new HelloWorld();

        Console.WriteLine(inisiasiHello.halo);

        inisiasiHello.fungsiDalamKelas();

        inisiasiHello.operasiTambah(2,1);
        inisiasiHello.operasikurang(4,2);
        inisiasiHello.operasiKali(3,2);
        inisiasiHello.operasiBagi(4,2);
    }

}
