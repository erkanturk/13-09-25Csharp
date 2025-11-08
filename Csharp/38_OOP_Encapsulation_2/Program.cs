namespace _38_OOP_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev

            /*** Ödev ***
            Bir banka hesabını temsil eden bir uygulama geliştirmek istiyoruz. 
            Bu uygulamada, hesap bakiyesi gizli tutulmalı ve sadece belirli
            işlemlerle (para yatırma ve çekme) değiştirilebilmelidir.
            Kapsülleme (encapsulation) prensibini kullanarak bakiyeye 
            doğrudan erişimi engelleyeceğiz ve işlemler sırasında gerekli kontrolleri yapacağız.

           Kapsülleme (Encapsulation): Verileri dışarıya karşı korumak ve kontrollü 
                    erişim sağlamak için kapsülleme prensibini kullanın.
           Veri Doğrulama: Metotlar içinde girilen tutarların geçerli olup olmadığını kontrol edin.
           Metot İsimlendirme: Metot isimlerinin anlamlı ve eylem odaklı 
            olmasına dikkat edin (örneğin, Deposit, Withdraw).
           */
            #endregion
            Araba araba = new Araba();
            //araba._Hiz=300;
            araba.Hizlanma(0);
            araba.Hizlanma(50);
            araba.Hizlanma(50);
            araba.Hizlanma(50);
            araba.Hizlanma(50);
            araba.Hizlanma(50);
            araba.Hizlanma(50);
            araba.Yavaslama(50);
            araba.Yavaslama(50);
            araba.Yavaslama(50);
            araba.Yavaslama(50);
            araba.Yavaslama(50);
            araba.Yavaslama(50);

        }
    }
}
