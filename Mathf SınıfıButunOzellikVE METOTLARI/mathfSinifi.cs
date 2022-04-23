using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathfSinifi : MonoBehaviour
{
    /* float sayi;
     float sayi2;

    float sayi1, sayi2, sayi3, sayi4;
    float girdigimdeger1, girdigimdeger2, girdigimdeger3, girdigimdeger4;

    public float min = -2.0f;
    public float max = 2.0f;
    static float t = 0.0f;

    public float speed = 45f;
    public Light m_isik;

    

    public  Transform m_target;
    float smootTime = 0.34f;
    float yVelocity = 0.0f;
    float xVelocity = 0.0f;

    

    float m_Time = 5f;
    float min = 10f;
    float max = 20f;
    float baslangicZamani;

    */

    private void Start()
    {
        //baslangicZamani = Time.time;
    }

    void Update()
    {

        #region 1 ) Mathf.Abs ()

        /*
         
        Belirttimiz sayının mutlak değerini döndürür.
        
        sayi1 = -5f;
        sayi2 = 20f;

        Debug.Log(  Mathf.Abs(sayi1) ); // -5 olan sayımızı bu Abs () metodu yazıldıktan sonra 5 çıktısını bize verdi.
        Debug.Log(Mathf.Abs(sayi2));

        */

        #endregion


        #region 2 ) Mathf.Acos ( )

        /*
          
          KOSİNÜSÜ olan radyan cinsinden açının ARK KOSİNÜSÜNÜ döndürür.

          Debug.Log( Mathf.Acos(0.5f)); // 0.5 olarak verilmiş radyan cisinden açının  ArkCosinüs değeri 1.0471 'miş.

        */

        #endregion


        #region 3 ) Mathf.Approximately ( )

        /*
         
        İki float değerini karşılaştırır ve AYNILARSA true değerini döndürür.

        Kayan nokta belirsizliği, eşittir operatörünü kullanan kayan noktaları karşılaştırmayı yanlış yapar. 
        Örneğin, (1.0 == 10.0 / 10.0) her seferinde true DÖNDÜRMEYEBİLİR. Yaklaşık(), iki kayan noktayı karşılaştırır ve bunlar
        küçük bir değer (Epsilon) içindeyse true değerini döndürür.

        if (Mathf.Approximately(2f,20.0f/10.0f))
        {
            Debug.Log("Sayilar aynı böyle devam et.");
        }

        */

        #endregion


        #region 4 ) Mathf.Asin ( )

        /*
         
         SİNÜSÜ olan radyan cinsinden açının ARK SİNÜS değerinin döndürür.

        Debug.Log(Mathf.Asin(0.5f)); // 0.5 olarak verilmiş radyan cinsinden açının ArkSinüs değeri 0.5235 'miş.

        */

        #endregion


        #region 5 ) Mathf.Atan ( ) 

        /*
         
        Tanjanti olan radyan cinsinden açının ARK TANJANTINI döndürür.

        radyan = derece * ( pi/180 )
        Radyanın sembolü yoktur.
        Açı derece cinsinden ölçülür.

         

      Debug.Log( Mathf.Atan(0.5f)); // 0.5 olarak verilmiş radyan cinsinden açının Ark Tanjantı 0.4636 'ymış.

        */

        #endregion


        #region 6 ) Mathf.Atan2 ( )

        /*

        Tanjantı olan radyan cinsinden açıyı döndürür.( y / x ).
        Dönüş değeri, sıfırdan başlayan ve ( x, y ) ile biten bir 2B vektör ile x ekseni arasındaki açıdır.
        Not : Bu işlev, x ' in sıfır olduğu durumları dikkate alır ve sıfıra bölme istisnası atmak yerine doğru açıyı döndürür.

        Debug.Log( Mathf.Atan2(1f, 0.5f)); // tanjant : 1 / 0.5 olmuş oluyor.

        ÇIKTI olarak 1.1071 değerini aldım.

        */

        #endregion


        #region 7 ) Mathf.Ceil ( )

        /*
         
       Girdiğimiz sayıdan büyük en küçük sayıyı döndürür.

        sayi1 = 1.4f;
        sayi2 = -3.4f;
        

        Debug.Log(Mathf.Ceil(sayi1));  Sayi 1.4 olarak girdik çıktı olarak 2 değerini bize verdi.
        Debug.Log(Mathf.Ceil(sayi2));   Sayi -3.4 olarak girdik çıktı olarak -3 değerini bize verdi.


        */
        #endregion


        #region 8 ) Mathf.CeilToInt ( )

        /*
        
        Girdiğimiz sayıdan ( float )  büyük en küçük TAM SAYIYI ( İNT ) bize verir.

        sayi3 = 2.2f;
        Debug.Log(  Mathf.CeilToInt(sayi3));

        */

        #endregion


        #region 9 ) Mathf.Clamp ( )

        /*

        value : Minimum ve maksimum değerlerle tanımlanan aralık içinde sınırlandırılacak kayan nokta ( float yani ) değeri.
        min   : Karşılaştırılacak minimum kayan nokta değeri
        max   : Karşılaştırılacak maksimum kayan nokta değeri.

        Verilen değeri MİNİMUM kayan nokta ve MAKSİMUM float  değerleri arasında SIKIŞTIRIR. 
        Minimum ve Maksimum aralıktaysa  DEĞER neyse onu döndürür.

        Verilen ( Girilen ) float değer minumumdan küçükse MİNİMUM değeri döndürür. Verilen değer maksimum değerden büyükse
        MAKSİMUM değeri döndürür.

        

        girdigimdeger1 = 20f;
        Debug.Log(Mathf.Clamp(girdigimdeger1, 25, 45F));
        Girdiğim sayı minimum(25) sayıdan küçük olduğu için DİREK BANA MİNİMUM SAYIYI YANİ 25 çıktısını verdi.

        girdigimdeger2 = 47f;
        Debug.Log(Mathf.Clamp(girdigimdeger2, 20f, 50f));
        Girdiğim değer maksimum ve minimum değerler arasında olduğu için girdiğim sayı neyse çıktı olarak bize onu verdi.

        */

        #endregion


        #region 10 ) Mathf.Clamp01 ( )

        /*
         
        0 ile 1 arasındaki değeri KISTIRIR ve değeri döndürür.

        Değer NEGATİF ise SIFIR DÖNDÜRÜLÜR. Değer BİRDEN BÜYÜKSE BİR DÖNDÜRÜLÜR ! ! ! ! ! 

        Debug.Log(Mathf.Clamp01(-2F)); // -2 girmemize ragmen 0 çıktısını bize verdi.
        Debug.Log(Mathf.Clamp01(74f)); //  74 girmemize ragmen 1 çıktısını bize verdi.

        */

        #endregion


        #region 11 ) Mathf.ClosestPowerOfTwo ( )

        /*
         
         ClosestPower of Two :  2 sayının en yakın kuvvetini döndürür.

      2 sayısının en yakın ÜSSÜNÜN değerini döndürür. Aşağıdaki kodlara  bak daha iyi anlarsın.

        
        Debug.Log( Mathf.ClosestPowerOfTwo(9));  // Çıktı olarak 8 verir. Çünkü 9 sayı 2 ^3 = 8 ' e EN YAKINDIR.
        Debug.Log(Mathf.ClosestPowerOfTwo(27)); // Çıktı olarak 32 'yi verir.Çünkü 27 sayı 2 ^ 5 =32 'e EN YAKINDIR.

        */

        #endregion


        #region 12 ) Mathf.CorrelatedColorTemperatureToRGB ( )

        /*

        Kelvin cinsinden bir renk sıcaklığını RGB rengine dönüştürün.

        İlişkili bir renk sıcaklığı (Kelvin cinsinden) verildiğinde, RGB eşdeğerini tahmin edin. Eğri sığdırma hatası maksimum 
        0.008'dir.

        İlişkili renk sıcaklığı, Kelvin derece cinsinden verilen yüzey sıcaklığı ile ideal bir siyah cisimden yayılan 
        elektromanyetik radyasyonun renk sıcaklığı olarak tanımlanır.

        Sıcaklık 1000 ila 40000 derece arasında düşmelidir.

        */

        #endregion


        #region 13 ) Mathf.Cos ( )

        /*
          
        f : Radyan cinsinden giriş açısı

         Radyan cinsinden girdiğimiz giriş açısının KOSİNÜSÜNÜ verir.

        
        Debug.Log(   Mathf.Cos(20f)); // çıktı olarak bize 0.4080 değerini verdi

         Bunu şöyle düşünebilirsin  Matematikte hesap yaparken cos20 değerini direk bulan bir metottur !!!!!!!!! 

        */

        #endregion


        #region 14 ) Mathf.Deg2Rad

        /*
         Dereceden radyana dönüştürme sabitidir.
         
        Bu sabit ( pi * 2) / 360 ' a eşittir.Yani pi / 180 ' dir. 

        Çıktı olarak her zaman 0.01745 'i  verir !!!!!!!!!!
        
        Debug.Log(Mathf.Deg2Rad);
        
        */

        #endregion


        #region 15 ) Mathf.DeltaAngle ( ) Tam anlamadın..

        /*

        Derece olarak verilen iki açı arasındaki en kısa farkı hesaplar.

        */

        //Debug.Log(Mathf.DeltaAngle(1000f, 35f)); // Çıktı olarak 115 değerini verdi.
        //Debug.Log(Mathf.DeltaAngle(250f, 10f));  // Çıktı olarak 120 değerini verdi.
        //Debug.Log(Mathf.DeltaAngle(600f, 40f));   // Çıktı olarak 160 değerini verdi.


        #endregion


        #region  16 ) Mathf.Exp ( )

        /*

        Belirtilmiş güce yükseltimiş e değerinin döndürür.
        
         
        Debug.Log(Mathf.Exp(7f));  YANİİİİİİİ :
                                   e ^ 7 = 1096 
                                   e ^ 6 = 403.42
                                   e ^ 5 = 148.41
                                   e ^ 4 = 54.598
                                   e ^ 3 = 20.08
                                   e ^ 2 = 7.38
                                   e ^ 1 = 2.71
                                   e ^ 0 =  1

         YANİ burda eski matematik bilgilerinden YARARLANDIN. Yani burda e değeri e =2.71 DEĞERİDİR HER ZAMAN İÇİN BUNU UNUTMA !

        BİZ bu kodda  şunları yapıyoruz 2.71 ^ 7 = 1096 ' ya eşit olmuş oluyor.
        Örneğin Mathf.Exp ( 6f ) yazdık bu şu sayıyı bize verir : 2.71 ^ 6 = 403.42 

        */

        #endregion


        #region 17 ) Mathf.FloatToHalf ( ) ANLAMADIN

        /*

        val : Dönüştürülecek flaot değeri
        ushort : 16 bitlik işaretsiz bir tamsayıda saklanan dönüştürülmüş yarı kesinlikli float  değeri

        Float değerini 16 bitlik bir gösterime kodlayın.

        Bir kayan nokta değerini yarıya dönüştürmek, hassasiyetini kaybetmesine neden olur ve ayrıca temsil edebileceği maksimum 
        değer aralığını azaltır. Yeni aralık -65.504 ve 65.504 arasındadır. 16 bitlik kayan noktalı sayılar hakkında daha fazla 
        bilgi ve değer aralığı boyunca kesinliğin nasıl değiştiği hakkında bilgi için bkz. Half-precision floating - point format.

        Dönüştürülen kayan nokta değeri tam olarak iki yarı kesinlik değeri arasında düşerse, bu yöntem onu ​​sıfırdan en uzak 
        değere yuvarlar (Sıfırdan uzağa yuvarlama kuralı). Bu, işarete bağlı olarak pozitif veya negatif sonsuza daha yakın olan
        değeri seçer.

        Yalnızca iade edilen ushortu bir depolama biçimi olarak kullanmalısınız. Üzerinde matematiksel işlemler yapmak istiyorsanız
        önce Mathf.HalfToFloat ile tekrar float'a çevirin.

        */

        #endregion


        #region 18 )  Mathf.Floor ( )

        /*
         
         içerisine girdiğimiz sayıdan KÜÇÜK VEYA EŞİT EN BÜYÜK tamsayıyı(float ) döndürür.

       
        Debug.Log(Mathf.Floor(5f));      //  5 çıktısını verdi.
        Debug.Log(Mathf.Floor(5.4f));    //  5 çıktısını verdi.
        Debug.Log(Mathf.Floor(-6.7f));   // -7 çıktısını verdi.
        Debug.Log(Mathf.Floor(-6.0f));   // -6 çıktısını verdi.
        
        */
        #endregion


        #region 19 ) Mathf.FloorToInt ( )

        /*
         
        içerisine girdiğimiz sayıdan KÜÇÜK VEYA EŞİT EN BÜYÜK tamsayıyı (int) döndürür.


        Debug.Log(Mathf.Floor(5f));      //  5 çıktısını verdi.
        Debug.Log(Mathf.Floor(5.4f));    //  5 çıktısını verdi.
        Debug.Log(Mathf.Floor(-6.7f));   // -7 çıktısını verdi.
        Debug.Log(Mathf.Floor(-6.0f));   // -6 çıktısını verdi.

        */
        #endregion


        #region 20 ) Mathf.GammaToLinearSpace ( )

        /*
         
        Verilen değeri gamadan ( sRGB ) doğrusal renk uzayına dönüştürür.

       */

        #endregion


        #region 21 ) Mathf.HalfToFloat ()

        /*
        val : Dönüştürülecek yarı kesinlik değeri.
        Yarı duyarlıklı bir kayan noktayı 32 bit kayan nokta değerine dönüştürün.
        */
        #endregion


        #region 22 ) Mathf.Infinity

        /*

         Pozitif sonsuzluğun temsilidir.
        
         Debug.Log(Mathf.Infinity);

        */

        #endregion


        #region 23 )  Mathf.InverseLerp ( )

        /*

        a     : Aralığın başlangıcı.
        b     : Aralığın sonu.
        value : Hesaplamak istediğiniz aralıktaki nokta.


        value : a 'nin iki arasında nerde olduğunu belirler.

        a ve b değerleri, doğrusal sayısal aralığın başlangıcını ve sonunu tanımlar. Sağladığınız "değer" parametresi, bu aralık 
        içinde bir yerde bulunabilecek bir değeri temsil eder. Bu yöntem, "değer" parametresinin belirtilen aralık içinde nereye
        düştüğünü hesaplar.

       "Değer" parametresi aralık içindeyse, InverseLerp, değerin aralık içindeki konumuyla orantılı olarak SIFIR  ile BİR arasında 
        bir değer döndürür. "Değer" parametresi aralığın dışında kalırsa, InverseLerp, aralığın başlangıcından önce mi yoksa
        sonundan sonra mı olduğuna bağlı olarak sıfır veya bir döndürür.

        */

        //Debug.Log(Mathf.InverseLerp(20f, 40f, 32f)); // aralığın içinde olduğu için 0 ile 1 arasında bir değer döndürdü. ( 0.6 döndü.)
        //Debug.Log(Mathf.InverseLerp(20f, 30f, 50f)); // aralık DIŞINDA BİR DEĞER olduğu 1 olarak çıktısını aldık.

        #endregion


        #region 24 ) Mathf.IsPowerOfTwo ( )

        /*
         
         İçine yazdığımız değer eğer 2 NİN KUVVETİ ( ÜSSÜ ) ise true değerini döndürür.

        Debug.Log(   Mathf.IsPowerOfTwo(20)); // False döndü çünkü 20 2 'nin KUVVETİ ( ÜSSÜ ) DEĞİL ! ! !
        Debug.Log(Mathf.IsPowerOfTwo(128)); // 128 sayısı  2'nin kuvveti ( ÜSSÜ )  olduğu için TRUE DÖNDÜ.
        
         */

        #endregion


        #region 25 ) Mathf.Lerp ( ) **

        /*
         a : Başlangıç değeri
         b : Son değer
         t : İki kayan nokta arasındaki enterpolasyon değeri

        a ve b arasında doğrusal İNTERPOLASYON yapar.

        Parametre olan t [ 0 ,1 ] aralığına sabitlenir.

        

        transform.position = new Vector3(Mathf.Lerp(min, max, t), 1f, 0f);
        t += 0.5f * Time.deltaTime;

        if (t > 1.0F)
        {
            float bne = max;
            max = min;
            min = bne;
            t = 0.0f;
        }

        YANİ  Obje belirttiğimiz saniyede belirttigimiz değerler arasında bir değer üretir.
        Bu kodlarda mesela obje -2 ile 2 arasında gidecek ama bunu bizim kendimizin t saniyede yapacak.

        */


        #endregion


        #region EK BİLGİ  Time.deltaTime 

        /*

        Time.deltaTime bilgisayarınızın bir önceki frame 'i tamamlaması için gereken süreyi veren bir özelliktir.

        Bilgisayarın 10 frame aldığını düşünelim : 

          -- Time.deltaTime 'ı çalıştırdığımızda 1 / 10 = 0.1 değerini döndürür.
             Time.deltaTime ' ı tekrar çalıştırdığımızda çalışma hızı 5 frame ' e düşerse Time.deltaTİme 1 / 5 = 0.2 değerini
              döndürür.

        -- Bir küp nesnesini hareket ettirmek istediğimizi düşünelim. Şu kodu yazalım : 
           transform.TRanslate ( 20 * Time.deltaTime,0f,0f);

        küp birinci aşamada 20 * 0.1 = 2 metre ileri gidecektir.
        küp ikinci aşamada  20 * 0.2 =  4 metre ileri gidecektir.

        BU SAYEDE EŞİT HIZLA GİTMİŞ OLURLAR ! ! !

          Neden eşit hızla ileri gittiklerini şöyle açıklayayım : 
        Time.deltaTime ilk aşamada bilgisayarımız HIZLI çalıştı ve 0.1 döndürdü ( 10 frame aldığını varsaydığımız için )  ancak
        ikinci aşamada bilgisayarımız  YAVAŞLADI  ve 0.2 döndürdü. Bizde bilgisayarımızın çalışma hızı yarıya düştüğü için ileri
        gitme  komutunu 2 kat yüksek değerle verdik. Bunu Time.deltaTime ile yaptık.

        ÖZETLE Time.deltaTime komutlarımızı bilgisayarımız hızlı çalıştıkça daha düşük değerle vermemizi, bilgisayarımız yavaş
        çalıştıkça  daha yüksek değerle vermemizi sağlayarak ortalama olarak aynı değerde çalışmasını sağlar.

        */

        #endregion


        #region 26 ) Mathf.LerpAngle ( )

        /*

        Lerp ile aynıdır.Ancak değerlerin 360 derece civarında sarıldığında doğru şekilde İNTERPOLASYON  yapmasını sağlar.
        t parametresi [ 0,1 ] aralığına sabitlenir.a ve b değişkenlerinin derece cinsinden olduğu varsayılır.

        

      Debug.Log(  Mathf.LerpAngle(20f, 140f, Time.time));

        20f ve 140 f olarak girdin ya belli bir saniyede 140f çıktısı alana kadar artıyor 140 olunca duruyor.

        */

        #endregion


        #region 27 ) Mathf.LinearToGammaSpace ( )

        /*

        Verilen değeri doğrusaldan gama ( sRGB ) renk uzayına dönüştürür.

        */



        #endregion


        #region 28 ) Mathf.Log ( )

        /*

       1) Belirtilen bir tabanda belirtilen bir sayının LOGARİTMASINI döndürür.

          Debug.Log(Mathf.Log(6, 2)); // 2 tabanında 6 nın logaritması

          2.584 çıktısını verdi. 


        2 ) Belirtilen sayının DOĞAL ( temel e ) logaritmasını döndürür.

        e tabanında hesaplar. ( e = 2.7182 ' dir DEĞİŞMEZ HATIRLA .)

        Matematikçiler, pozitif bir x sayısının doğal logaritmasını  Ln(x) ile gösterirler.   

        Ln (x) = Log ( x ) / Log (e ) = log (x ) / 0.434 

        

     Debug.Log(Mathf.Log(100));    // 4.60 çıktısını verdi.

     Debug.Log(Mathf.Log(10));     // 2.30 çıktısını verdi.

        */

        #endregion


        #region 29 )  Mathf.Log10 ( )

        /*
         
              Belirtilen sayının 10 tabanlı logaritmasını döndürür.

        
        Debug.Log(Mathf.Log10(100)); 10 tabanında 100 'ün logaritması

              Çıktı olarak 2 değerini bize verir.

        */

        #endregion


        #region 30 ) Mathf.Max ( )

        /*
      
        İki veya daha fazla değerden en BÜYÜĞÜNÜ döndürür.

      Debug.Log(  Mathf.Max(20f, 40f, 60f));

        */

        #endregion


        #region 31 ) Mathf.Min ( )

        /*
         
        İki veya daha fazla değerden EN KÜÇÜĞÜNÜ döndürür.

        Debug.Log( Mathf.Min(8f, 2f));

        */

        #endregion


        #region 32 ) Mathf.MoveTowards ( )

        /*

        current  : Geçerli değer
        target   : Hareket edilecek değer
        maxDelta : Değere uygulanması gereken maksimum değişiklik

        Geçerli bir değeri hedefe doğru hareket ettirir.
        Bu fonksiyon esasen Mathf.Lerp () ile aynıdır.Ancak bunun yerine fonksiyon hızın asla maxDelta'yı aşmamasını sağlayacaktır.
        maxDelta 'nın negatif değerleri , değeri hedeften uzaklaştırır.

        
       Debug.Log( Mathf.MoveTowards(2f, 100f, 15f));

        // YANİ birinci sayımızın ikinci ( hedef ) sayıya ulaşması için MAKSİMUM sayımızı belirttiğimiz bir metottur.
        
        */

        #endregion


        #region 33 ) Mathf.MoveTowardsAngle ( )

        /*

        MoveTowards () metotuyla aynıdır ancak değerlerin 360 derecelik bir alana sarıldığında doğru şekilde İNTERPOLASYON
        yapmasını sağlar.

        Akım ve hedef değişkenlerinin DERECE CİNSİNDEN olduğu varsayılı. Optimizasyon nedenleriyle , maxDelta'nın negatif değerleri
        desteklenmez ve salınımlara neden olabilir. Akımı hedef açıdan uzağa itmek için bunun yerine açıya 180 ekleyin.

        

        float m_angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 270f, speed * Time.deltaTime);
        Debug.Log(m_angle);
        transform.eulerAngles = new Vector3(0f, m_angle, 0f);

        Objemiz kendi  Rotation y değerinden 270 dereceye belirlediğimiz saniyede ( speed * Time.deltaTime ) gider.

        */

        #endregion


        #region 34 ) Mathf.NegativeInfinity

        // Negatif sonsuzluğun temsilidir.

        #endregion


        #region 35 ) Mathf.NextPowerOfTwo ( )

        /*

        Argümana eşit veya ondan büyük olan 2 'NİN ÜSSÜNÜN 1 FAZLASINI DÖNDÜRÜR.

        Debug.Log(Mathf.NextPowerOfTwo(5)); // 8 çıktısını bize verdi.
        Debug.Log(Mathf.NextPowerOfTwo(12)); // 16 çıktısını bize verdi.
        Debug.Log(Mathf.NextPowerOfTwo(172)); // 256 çıktısını bize verdi.

        */

        #endregion


        #region 36 ) Mathf.PerlinNoise ( ) ** Tam anlamadın 

        /*

        x : Örnek noktanın X koordinatı
        y:  Örnek noktanın Y koordinatı
        
        Float değeri 0.0 ile 1.0 arasındadır.Ancak Dönüş değeri 0.0 'ın biraz altında veya 1.0 'ın üzerinde olabilir.

        2D Perlin GÜRÜLTÜSÜ oluşturun.

     -  Perlin Gürültüsü, bir 2B DÜZLEMDE oluşturulan kayan değerlerin sözde rastgele bir modelidir. ( teknik 3 veya daha fazla
        boyuta genelleştirse de bu Unity 'de UYGULANMAZ. )

     -  Gürültü her noktada tamamen rastgele bir değer İÇERMEZ, bunun yerine değerleri DESEN BOYUNCA kademeli olarak artan ve azalan
        '' DALGALARDAN '' oluşur. Gürültü , DOKU EFEKTLERİNİN TEMELİ olarak kullanılabilir, aynı zamanda animasyon , arazi yükseklik
        haritaları ve diğer birçok şey için de kllanılabilir.

     -  Düzlemdeki herhangi bir noktai uygun X ve Y koordinatları geçirilerek örneklenebilir. Aynı koordinatlar her zaman aynı 
        numune değerini döndürür, ancak düzlem esasen sonsuzdur, bu nedenle numune almak için rastgele bir alan seçerek tekrardan 
        kolaydır.



        

       float nokta=   Mathf.PerlinNoise(12f, 60f);

        Debug.Log(nokta);  // x ve y koordinatları kısmına ne yazarsan çıktı olarak [ 0 , 1 ] değerleri
                           // arasında bir değeri alırsın.

        gameObject.transform.position = new Vector3(0f, nokta, 0f);

        */

        #endregion


        #region 37 ) Mathf.PI =3.141
        //
        #endregion


        #region 38 ) Mathf.PingPong() **

        /*
         
         PingPong, 0 değeri ile uzunluk arasında artan ve azalan bir değer döndürür.
         PingPong değerin KENDİ KENDİNE ARTAN ( t = zaman yani ) bir değer olmasını gerektirir, örneğin Time.time ve 
         Time.unscaledTime.

      m_isik.intensity= Mathf.PingPong(Time.time, 50f);

         Gördüğün gibi Mathf.PingPong () metodu bir özelliğin değerini zamana bağlı olarak ARTIRMAK istediğimiz zamanlarda
         kullanırız.Burda ışık  şiddeti 50 'inci saniye kadar sürekli artacak.
         BAŞKA BİR ÖRNEK OLARAK TA mesela bir objenin büyüklüğünü  atıyorum 5 saniye içinde sürekli ARTIRABİLİRSİN ...
         Gördüğün gibi bunun gibi birçok örnek yapılabilir.

        */

        #endregion


        #region 39 )  Mathf.Pow ( )

        /*

         f :
         p :

        Sonuç olarak f ^ p değerini verir.  HATIRLATMA : üslü sayı===>  2 ^ 3 = 8 ,    2 ^ 4 = 16 gibi düşün.
        

        Debug.Log(Mathf.Pow(1f, 3f)); //  (1f ,1f ) = 1 , ( 1f,2f ) = 1 çıktısını veriyor.
        Debug.Log(Mathf.Pow(2f, 3f)); // (2f,1f) = 2 , (2f,2f ) = 4 çıktısını veriyor. ( 2f,3f ) = 8 çıktısı veriyor.
        Debug.Log(Mathf.Pow(2f, 4f)); // ( 2f,4f ) = 16 çıktısını veriyor.
        Debug.Log(Mathf.Pow(3f, 4f));    // ( 3f,4f ) = 81 çıktısını veriyor

        */

        #endregion


        #region 40 ) Mathf.Rad2Deg

        /*

         Radyan - Derece dönüştürme sabiti ===> 360 / ( PI * 2 ) =  57.29 'a eşittir.

         */

        #endregion


        #region 41 ) Mathf.Repeat ( )

        /*

        repeat : Tekrarlamak.

        Hiçbir zaman uzunluktan büyük ve asla 0 'dan küçük olmayacak şekilde t değerini döngüler.

        Bu modul operatörüne benzer ancak kayan nokta ( float ) sayılarıyla çalışır.

        Örneğin t = 3.0 ve uzunluk = 2.5 , sonuç = 0.5 olur. 
        Örneğin t = 5 ve uzunluk = 2.5 , sonuc = 0.0 olur.

        
        Debug.Log(Time.time);
       transform.position=new Vector3( Mathf.Repeat(Time.time,5),transform.position.y,transform.position.z);

        YANİ girdiğim 2 değer arasında kendini tekrar eder. Genelde şu 2 zamanla aralığında şu olsun gibi yaparız.

        */


        #endregion


        #region 42 ) Mathf.Round ( )

        /*

      En yakın tam sayıya yuvarlanmış f 'i döndürür.

         // Prints 10
        Debug.Log(Mathf.Round(10.0f));

        // Prints 10
        Debug.Log(Mathf.Round(10.2f));

        // Prints 11
        Debug.Log(Mathf.Round(10.7f));

        // Prints 10
        Debug.Log(Mathf.Round(10.5f));

        // Prints 12
        Debug.Log(Mathf.Round(11.5f));

        // Prints -10
        Debug.Log(Mathf.Round(-10.0f));

        // Prints -10
        Debug.Log(Mathf.Round(-10.2f));

        // Prints -11
        Debug.Log(Mathf.Round(-10.7f));

        // Prints -10
        Debug.Log(Mathf.Round(-10.5f));

        // Prints -12
        Debug.Log(Mathf.Round(-11.5f));

        */

        #endregion


        #region 43 ) Mathf.RoundToInt ( )

        // Matf.Round () ile birebir aynıdır.Tek bir fark var. Onu kodun üstüne tıkladığında görürsün zaten.

        #endregion


        #region 44 ) Mathf.Sign ( )

        /*
         
        Sign : İşaret

        f 'in işaretini döndürür.

        f pozitif veya sıfır olduğunda dönüş değeri 1 , f negatif olduğunda -1 'dir.
         
        Debug.Log( Mathf.Sign(-20f)); // -1 ÇIKTISINI verdi.
        Debug.Log(Mathf.Sign(30f));   //  1 ÇIKTISINI verdi.

        */

        #endregion


        #region 45 ) Mathf.Sin ( )

        /*
         
         f : Radyan cinsinden giriş açısı.

        Açının sinüsünü döndürür.

        -1 ile 1 arasında değer döndürür. 


       Debug.Log( Mathf.Sin(36f)); // -0.99 çıktısını verdi.

        */

        #endregion


        #region 46 ) Mathf.SmoothDamp ( ) **

        /*

        current         : Konumum
        target          : Ulaşmaya çalıştığın konum
        currentVelocity :( Mevcut hız.)  Bu değer onu her çağırdığında fonksiyon tarafından değiştirilir.
        smoothTime      : Hedefe ulaşmak için gereken SÜRE.Daha küçük değer hedefe daha hızlı ulaşacaktır.
        maxSpeed        : İsteğe bağlı olarak maksimum hızı sabitlemenizi sağlar.
        deltaTime       : Bu işleve yapılan son çağrıdan bu yana geçen süre.Varsayılan olarak Time.deltaTime.


        Değeri ZAMANLA, istenen bir hedefe doğru KADEMELİ olarak değiştirir.
        Değer, hiçbir zaman aşmayacak olan yaylı sönümleyici benzeri bir fonksiyonla yumuşatılır. İşlev, her türlü değeri,
        KONUMU, RENGİ, SKALERİ yumuşatmak için kullanılabilir.


        */


        //float yenipozisyon = Mathf.SmoothDamp(transform.position.y, m_target.position.y, ref yVelocity, smootTime);

        // transform.position = new Vector3(transform.position.x, yenipozisyon, transform.position.z);

        // Gördüğün gibi Karakterin Hedef objenin yüksekliğine ulaşmak için sürekli ZIPLIYOR.Farklı kodlarla farklı kombinasyonlar
        // yapabilirsin.

        #endregion


        #region 47 ) Mathf.SmoothDampAngle ( ) **

        /*

        Derece olarak verilen bir AÇIYI zamanla istenen HEDEF AÇISINA doğru kademeli olarak değiştirir.

        Değer yaylı sönümleyici benzeri bir fonksiyonla yumuşatılır. İşlev her türlü DEĞERİ, KONUMU, RENGİ, SKALERİ yumuşatmak için
        kullanılabilir.En yaygın kullanım, bir takip kamerasını yumuşatmak içindir.

        

        float yAngle =   Mathf.SmoothDampAngle(transform.eulerAngles.y, m_target.transform.eulerAngles.y, ref yVelocity, smootTime);
        Vector3 pozisyon = m_target.position;
        pozisyon += Quaternion.Euler(0, yAngle, 0) * new Vector3(0, 0, -5f);
        transform.position = pozisyon;
        transform.LookAt(m_target); 

        hedefim Rotation Y sini değiştrdiğinde karakterim hedefin etrafında dönüyor.

        */
        #endregion


        #region 48 ) Mathf.SmoothStep ( ) **

        /*
         
        Limitlerde yumuşatma ile min ve max arasında İNTERPOLASYON yapar.

        Bu fonksiyon, Lerp ' e benzer şekilde min ve max arasında İNTERPOLASYON yapar. Ancak İNTERPOLASYON başlangıçtan itibaren
        KADEMELİ olarak hızlanacak ve sona doğru YAVAŞLAYACAKTIR. Bu doğal görünümlü ANİMASYON, SOLMA VE DİĞER GEÇİŞLER oluşturmak
        için kullanışlıdır.

        
        float t = (Time.time - baslangicZamani) / m_Time;
        
        transform.position = new Vector3(Mathf.SmoothStep(min, max, t), 0, 0);

               Sen Eğer üstteki t kodunu yazmassan direk saniyeyi belirtirsen obje DİREK olarak MAX konumuna GİDER VE DURUR !!!

       YANİ  MANTIK ŞU : 

         t = ( 2 - 0 ) / 5 = 0.4  ==> 0.4 saniyede objem NE KADAR İLERLEYEBİLİRSE O KADAR İLERLEYECEK.
         t = ( 3 - 0 ) / 5 = 0.6  ==> 0.6 saniyede objem NE KADAR İLERLEYEBİLİRSE O KADAR İLERLEMİŞ OLCAK.
 
        VE BÖYLECE KADEMELİ OLARAK İLERLEME SAĞLANMIŞ OLUR !!!!!!!!!!!!!!!!!

        */
        #endregion


        #region 49 ) Mathf.Sqrt ( )

        /*
         
          f 'in KAREKÖKÜNÜ DÖNDÜRÜR.

        Debug.Log( Mathf.Sqrt(25)); // 5 çıktısını verdi.
        Debug.Log(Mathf.Sqrt(49));  // 7 çıktısını verdi.

        */

        #endregion


        #region

        /*

        Radyan cinsinden f açısının tanjantını döndürür.

        */

        Debug.Log(Mathf.Tan(15f));

        #endregion


        #region 16 ) Mathf.Epsilon

        /*

        Küçük bir kayan nokta değeri.
        Bir kayan noktanın ( float ) SIFIRDAN FARKLI olabileceği EN KÜÇÜK değer.

        Herhangi bir sayı ile Epsilon arasındaki bir değer, kesme hataları nedeniyle rastgele bir sayı ile sonuçlanacaktır.

        Debug.Log(  Mathf.Epsilon); //  Çıktı olarak bize 1.4 * 10 ^ -45  değerini verdi.

        */

        #endregion










    }




}
