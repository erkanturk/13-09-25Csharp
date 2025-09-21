namespace _08_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* TryCatch: Fırlatılan Exception'ları yakalayarak programın akışını durdurmadan hata durumunda ne yapılması gerektiğini tanımlarız
         * TryCatch yapıları syntax hatalarını yakalamaz bu tip hatalar build kısmında yani sistem çalıştırılırken derleme tarafında hatayı gösterir 
         * Daha çok kodsal hatalarda bize yardımcı olur.
        */
        #region Örnek1 
        //try
        //{
        //    Console.WriteLine("Lütfen bir sayı giriniz");
        //    double sayi = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("ikinci sayıyı giriniz");
        //    double sayi2 = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine(sayi/sayi2);
        //}
        //catch (Exception)
        //{

        //    Console.WriteLine("Hata ");
        //}
        //Console.WriteLine("Test");
        #endregion

        #region Catch örnekleri
        //try
        //{
        //    Console.WriteLine("Lütfen bir sayı giriniz");
        //    int sayi = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("ikinci sayıyı giriniz");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());
        //    int sonuc = sayi/sayi2;
        //    Console.WriteLine(sonuc);
        //}
        //catch (FormatException)//Format hataları için kullanılır
        //{
        //    Console.WriteLine("Format hatası");
        //}
        //catch (DivideByZeroException)//Sıfıra bölünme hatasında kullanılır
        //{
        //    Console.WriteLine("Sıfıra bölünme hatası");
        //}
        //catch (Exception)//Geriye kalan tüm hataları yakalamak için kullanılır.
        //{

        //    throw;
        //}
        #endregion
        #region Örnek2
        //try
        //{
        //    Console.WriteLine("Lütfen bir sayı giriniz");
        //    int sayi = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("ikinci sayıyı giriniz");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());
        //    int sonuc = sayi/sayi2;
        //    Console.WriteLine(sonuc);
        //}
        //catch (Exception ex)
        //{

        //    Console.WriteLine(ex.Message);
        //}

        #endregion

        #region Finaly
            
            try
            {
                Console.WriteLine("1.sayı ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.sayi");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi/sayi2);
                Console.WriteLine("test");
               

            }
            catch (Exception)
            {

                Console.WriteLine("hata");
            }
            finally
            {

                Console.WriteLine("Hata durumunda da hata olmasada çalışırım");
              
            }
            //finaly her koşulda çalışır bir hata durumunda da çalışır hata almama durumunda da çalışır 
            //mutlaka yapılması gereken hata durumu yada hata olmama durumunda bir işlem var ise finaly çalışmalıdır.
            #endregion
        }
    }
}
