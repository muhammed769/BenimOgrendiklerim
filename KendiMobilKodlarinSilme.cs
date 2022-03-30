using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KendiMobilKodlarinSilme : MonoBehaviour
{

    //  Touch[] a;

    Touch DokunmaSayisi;
    private float Genislik;
    private float Yukseklik;

    Vector3 pozisyonum;

    Gyroscope TelefonunYonununDegistirilmesiniSaglayanSey;


    private LocationService m_LocationServiceYaniKonumServisi;


    private void Awake()
    {
        Genislik = (float)Screen.width / 2.0f;
        Yukseklik = (float)Screen.height / 2.0f;
        pozisyonum = new Vector3(0f, 0f, 0f);
    }

    private void Start()
    {
        TelefonunYonununDegistirilmesiniSaglayanSey = Input.gyro;
        TelefonunYonununDegistirilmesiniSaglayanSey.enabled = true;

    }

    void Update()
    {

     


        #region Input.acceleration ( Unity Documention 'dan AYRICA BAK ��NK� ORDA �NEML� KODLAR VAR.

        /*
         
        Vector3 cihazinSonolculenDogrusalIvmesi = Input.acceleration;
        Debug.Log(cihazinSonolculenDogrusalIvmesi);

        */

        #endregion


        #region Input.anyKey

        /*

                Herhangi bir tu�a BASILI TUTULDU MU bunun kontrol�n� yapar.

         bool TusVeyaFareDugmesineBasildiMi = Input.anyKey;

         if (TusVeyaFareDugmesineBasildiMi)
         {
             Debug.Log("Evet bas�ld�.");
         }

      */
        #endregion


        #region Input.anyKeyDown

        /* HERHANG� B�R TU�A TEK TEK BASILDI MI BUNUN KONTROL�N� YAPAR.

        bool HerhangiBirSeyeTekTekBasildiMi = Input.anyKeyDown;
        if (HerhangiBirSeyeTekTekBasildiMi)
        {
            Debug.Log("Evet Basildi ! ");
        }
            
        */

        #endregion


        #region  Input.backButtonLeavesApp


        /* 
            YAN� Geri d��mesi bast���mda uygulamadan ��k�ls�n m� ��k�lmas�n m� bunun kontrol�n� yapar�z.
            SADECE Android, Windows Phone , Windows Tabletlerde kullan�labilir.

        bool GeriDugmesineBasilincaUygulamadanCikmaDurumu = Input.backButtonLeavesApp;

        if ( GeriDugmesineBasilincaUygulamadanCikmaDurumu )

        {
           // Buraya projeye g�re ilgili kodlar�n� yaz.
        }


        */

        #endregion


        #region  Input.compass ( Detayl� bir konu vakti geldi�inde ��REN. )

        // Pusulaya Eri�im �zelli�i. ( Sadece elde ta��nan cihazlar )
        // Compass pusula = Input.compass;


        #endregion


        #region Input.compensateSensors

        /*

        bool Kontrol = Input.compensateSensors;

        if (Kontrol)
        {
            Debug.Log("Giri� sens�rlerinin ekran y�n� i�in telafi et.");
        }

        else
        {
            Debug.Log("Giri� Sens�rlerinin ekran y�n� i�in telafi ETME.");

              Her �eyi Similatorden denedi�im i�in burda False de�erini d�nd�rd�.Yani giri� sens�rlerini ekran y�n� i�in telafi
              ETMED�.

        }


        */

        #endregion


        #region  Input.compositionString

        /*
         
        string a = Input.compositionString;

        
      Kullan�c� taraf�ndan yaz�lan ge�erli IME olu�turma dizesi.

       �ince, Japonca veya Korece gibi baz� dillerde, bir veya birden �ok karakter olu�turmak i�in birden �ok tu� yaz�larak 
       metin girilir. Bu karakterler, kullan�c� yazarken ekranda g�rsel olarak olu�maktad�r.Metin giri�i i�in Unity'nin 
       yerle�ik GUI sistemini kullan�rken, Unity, kullan�c�lar yazarken kompozisyon dizelerini g�r�nt�lemeye �zen g�sterir. 
       Ancak kendi GUI'nizi uygulamak istiyorsan�z, dizeyi ge�erli imle� konumunda g�r�nt�lemeye dikkat etmeniz gerekir.
       Kompozisyon dizesi yaln�zca IME birle�tirme kullan�ld���nda g�ncellenir.Daha fazla bilgi i�in Input.imeCompositionMode'a
      bak�n. 

        */
        #endregion


        #region  Input.deviceOrientation


        /*

                ��letim sistemi taraf�ndan bildirildi�i �ekliyle cihaz�n Fiziksel y�n�. 7 tane y�n vard�r.BUNLAR : 



          1 ) ***************************

               if (Input.deviceOrientation == DeviceOrientation.FaceDown)
               {
                   Debug.Log("Evet Cihaz ekran a�a�� bakacak �ekilde yere paralel bir �ekilde tutuluyor.");
                   // BURAYA �STED���N KODU YAZAB�L�RS�N.�RNEK EKRAN BU �EK�LDEYSE OYUN M�Z���M HEMEN BA�LAYAB�L�R.
               }

               else
               {
                   Debug.Log("Hay�r Ekran a�a�� bakacak �ekilde TUTULMUYOR.");
               }

         2 ) ***************************

               if (Input.deviceOrientation == DeviceOrientation.FaceUp)
               {
                   Debug.Log("Cihaz ekran yukar� bakacak �ekilde yere paralel bir �ekilde tutuluyor.");
               }

         3) ***************************

               if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
               {
                   Debug.Log(" Evet Cihaz yatay modda, cihaz dik tutuluyor ve ana sayfa d��mesi SA� TARAFTA .");
               }

         
        4 ) ***************************

           
               if (Input.deviceOrientation == DeviceOrientation.LandscapeRight)
               {
                   Debug.Log("Evet cihaz yatay modda, cihaz dik tutuluyor ve ana sayfa d��mesi SOL TARAFTA.");
               }

        5 ) ***************************


               if (Input.deviceOrientation == DeviceOrientation.Portrait)
               {
                   Debug.Log("Evet Cihaz D�KEY modda, cihaz dik tutuluyor ve ana sayfa d��mesi ALTTA.");
               }

        6 ) ***************************

               if (Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
               {
                   Debug.Log("Evet cihaz D�KEY MODDA, ancak BA� A�A�I DURUMDA , cihaz dik tutuluyor ve ana sayfa d��mesi �STTE.");
               }

        7 ) ***************************

               if (Input.deviceOrientation == DeviceOrientation.Unknown)
               {
                   Debug.Log("C�HAZIN Y�N� BEL�RLENEMEZ.");

               }

           */

        #endregion


        #region Input.GetAxis ( )

        /*

        Taraf�ndan tan�mlanan sanal eksenin de�erini d�nd�r�r axisName.

        De�er, klavye ve joystick giri� cihazlar� i�in -1...1 aral���nda olacakt�r.

         Bu de�erin anlam� giri� kontrol�n�n tipine ba�l�d�r, �rne�in bir joystick'in yatay ekseninde 1 de�eri �ubu�un tamamen sa�a itildi�i
           ve - 1 de�eri ise tamamen sola itildi�i anlam�na gelir; 0 de�eri, joystick'in n�tr konumunda oldu�u anlam�na gelir.

         Eksen fareye e�lenirse, de�er farkl�d�r ve - 1...1 aral���nda olmayacakt�r. Bunun yerine, eksen duyarl�l��� ile �arp�lan
          ge�erli fare deltas� olacakt�r.Tipik olarak pozitif bir de�er, farenin sa�a/ a�a�� hareket etti�i ve negatif bir de�er,
          farenin sola / yukar� hareket etti�i anlam�na gelir.

         Bu, kare h�z�ndan ba��ms�zd�r; bu de�eri kullan�rken de�i�en kare h�zlar� konusunda endi�elenmenize gerek yoktur.


        float m_Horizontal =   Input.GetAxis("Horizontal");
        float m_Vertical = Input.GetAxis("Vertical");
        float m_Jump = Input.GetAxis("Jump");
        transform.Translate(m_Horizontal*Time.deltaTime, m_Jump*Time.deltaTime, m_Vertical * Time.deltaTime); 

        */
        #endregion


        #region Input.GetAxisRaw 

        /*
         
        float m_Vertical= Input.GetAxisRaw("Vertical");
        transform.Translate(0f, 0f, m_Vertical*Time.deltaTime);

          Hi�bir YUMU�ATMA F�LTRES� UYGULANMADAN axisName taraf�ndan tan�mlanan sanal eksenin de�erini d�nd�r�r.

          De�er, klavye ve joystick giri�i i�in - 1...1 aral���nda olacakt�r. Giri� d�zg�nle�tirilmedi�inden, klavye giri�i 
          her zaman - 1, 0 veya 1 olacakt�r.Klavye giri� i�lemenin t�m d�zg�nle�tirmesini kendiniz yapmak istiyorsan�z 
          bu kullan��l�d�r.

        */

        #endregion


        #region Input.GetButton ( ) 

        /*

           Butona BASILI TUTULDU�UNDA true de�erini d�nd�r�r.Yani ii�lem yapmas�n� istedi�in butonunun ismini yaz�p
           butona BASILI TUTULDU�UNDA hangi i�lemi yapmak istiyorsan bu metodu kullanabilirsin.

          if (Input.GetButton("Fire1"))
          {
              Debug.Log("Maousun sol Tu�una bas�l� tutuldu.");
          }
          if (Input.GetButton("Jump"))
          {
              Debug.Log("Space ' e  bas�l� tutuldu.");
          }

          */
        #endregion


        #region Input.GetButtonDown ( ) 

        /*

         Kullan�c� TEK TEK BASTI�I butonda TRUE de�erini d�nd�r�r. Yani sen belirlemi� oldu�un butonunun ismini buraya
         yaz�p yap�lmas�n� istedi�in i�lemleri buraya yazabilirsin.

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Butona TEK TEK BASTIM.");
        }

       
        */

        #endregion


        #region  Input.GetButtonUp ( )

        /*

         Belirlemi� oldu�un butondan elini �ekti�inde yap�lmas�n� istedi�in i�lemleri buraya yazabilirsin.

        if ( Input.GetButtonUp("Fire1"))
        {
            Debug.Log("Mausun sol tu�una ARTIK BASMIYORUM.");
            transform.position += new Vector3(1.84f, 0.688f, -32.62f);
        }

        */

        #endregion


        #region Input.GetMouseButton ()

        /*
         
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mausun sol tu�una bas�l� tutuyorum");
        }

        */

        #endregion


        #region Input.GetMouseButtonDown ( ) ve GetMouseButtonUp ( )

        /*

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mausun Sol tu�una TEK TEK bas�yorum.");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mausun sol tu�undan TEK TEK EL�M� �EKT���MDE yap�lmas�n� istedi�im i�lemleri buraya yaz.");
        }

        */

        #endregion


        #region Input.gyro ( Yani Gyroscope )

        /*
         
        Telefonda jiroskop ne demek?
        Ak�ll� telefonlarda da kullan�lan jiroskop, ak�ll� telefonlarda konumu de�i�tirip telefonun sa�a ya da sola ve �ne ya da
        arkaya do�ru d�nd�r�lmesini sa�lamaktad�r.



        Varsay�lan jiroskopu d�nd�r�r.

        Cihaz�n�z�n jiroskop ayr�nt�lar�n� d�nd�rmek i�in bunu kullan�n. �ncelikle cihaz�n�zda bir jiroskop oldu�undan emin olun. 
        Bunu kontrol etmek i�in Input.gyro.enabled'� kullan�n.

        Bir cihaz�n jiroskop ayr�nt�lar�n� bilmek, bir cihaz�n y�n�n� bilmesi gereken �zellikleri dahil etme becerisini sa�lar.
        Yayg�n kullan�mlar, bir kullan�c� cihaz�n� d�nd�r�p hareket ettirdi�inde kamera a��lar�n� veya GameObject'in konumlar�n� 
        de�i�tirmeyi bize sa�lar.

        

       
        1 ) Gyroscope.attitude = Tutum ayg�t�n�n tutumunu ( Yani uzayda y�nelimini ) d�nd�r�r.

        2 ) Gyroscope.enabled = Etkin bir jirroskopun etkin durumunu ayarlar veya al�r.

        3 ) Gyroscope.gravity = Yer�ekimi cihaz�n referans �er�evesinde ifade edilen yer�ekimi ivmesi vekt�r�n� d�nd�r�r.

        4 ) Gyroscope.rotationRate = Cihaz�n jiroskopu taraf�ndan �l��len d�n�� h�z�n� d�nd�r�r.

        5 ) Gyroscope.rotationRateUnbiased = Cihaz�n jiroskopu taraf�ndan �l��ld��� �ekliyle tarafs�z d�n�� h�z�n� d�nd�r�r.

        6 ) Gyroscope.updateInterval = Jiroskop aral���n� saniyeler i�inde ayarlar veya al�r.

        7 ) Gyroscope.userAcceleration = Kullan�c�n�n cihaza verdi�i ivmeyi d�nd�r�r.

        */


        /*
         
        Debug.Log(TelefonunYonununDegistirilmesiniSaglayanSey.userAcceleration);
        Debug.Log(TelefonunYonununDegistirilmesiniSaglayanSey.rotationRate);
        Quaternion a = transform.rotation;
        a = TelefonunYonununDegistirilmesiniSaglayanSey.attitude;
        
        Gibi kodlar� yazabilirsin.Ama sen �uan Similatorden i�lem yapt���n i�in MOB�L TELEFONUNA ge�ti�in zaman GYROSCOPE
        var m� yok mu kod taraf�nda ileti�im kurabiliyo musun ilk �nce bunlara bak sonra burdaki �zelliklerle kodlar�n� yazars�n.
        */
        #endregion


        #region Input.compositionCursorPos Fazla kullanmayaca��n bir �zellik ama yinede bak


        /*

        Vector2 a = Input.compositionCursorPos;

        
           IME'ler taraf�ndan pencereleri a�mak i�in kullan�lan ge�erli metin giri�i konumu.

           Japonca gibi baz� dil IME'leri, kullan�c�n�n do�ru giri� dizelerini se�mesine yard�mc� olmak i�in, 
           kullan�c� metin yazarken pencereleri a�ar. Bu pencerelerin ge�erli imle� konumunda a��lmas� beklenir, 
           bu nedenle IME'nin giri�in nerede g�r�nt�lendi�ini bilmesi gerekir. Unity'nin metin giri�i i�in yerle�ik GUI sistemini
           kullan�rken, Unity IME i�in imle� konumunu ayarlamaya �zen g�sterir. Ancak, metin giri�i i�in kendi GUI'nizi uygulamak 
           istiyorsan�z, bunu IME pencerelerinin do�ru g�r�nmesi i�in mevcut metin giri�i konumuna ayarlaman�z gerekir. 


     IME  ne demek ? 

        Input Method Editor'�n k�saltmas�. Bilgisayar kullan�c�lar�na, klavyelerinde bulunmayan karakter ve sembolleri install eden,
        yaz� girme program�.

        */

        #endregion


        #region  Input.imeCompositionMode

        /*
          IME giri� kompozisyonunun etkinle�tirilmesini ve devre d��� b�rak�lmas�n� kontrol eder.

        Baz� diller, karakter eklemek i�in pencerelerin a��lmas�n� i�eren karma��k giri� y�ntemleri kullan�r. Oyunlar, 
        tu� vuru�lar�n� metin olarak de�il, oyun giri�i olarak yorumlayabilece�inden, oyun oynarken genellikle bu istenmez.
        Varsay�lan olarak Unity, metin alanlar�ndayken IME olu�turmay� etkinle�tirir ve aksi takdirde devre d��� b�rak�r. 
        Ancak, kendi giri� GUI'nizi uygulamak istedi�inizde, imeCompositionMode �zelli�ini kullanarak m�mk�n olan, bunun �zerinde 
        kendiniz kontrol sahibi olmak isteyebilirsiniz.

      
         * 
      

        if (Input.imeCompositionMode == IMECompositionMode.Auto)
        {
            Debug.Log("Evet IME OTOMAT�K.");
        }

        if (Input.imeCompositionMode == IMECompositionMode.Off)
        {
            Debug.Log("IME kapal�.");
        }


       S�MULATOR  'den i�lem yapt���m�z i�in bu 2 koddan �stteki �al��t� YAN� IME s�MULATOR 'DE OTOMAT�K B�R �EK�LDE �ALI�IYORMU� !

        */


        #endregion


        #region Input.imeIsSelected

        /*

        bool IMEsiVarmi = Input.imeIsSelected;

        if (IMEsiVarmi)
        {
            Debug.Log("Evet bu cihaz�n IME 'si var.");
        }
        else
        {
            Debug.Log("Hay�r bu cihaz�n IME'si YOK ! ");  // S�MULATOR'UN IME'si yokmu�.
        }


     
       
          Kullan�c�n�n se�ilmi� bir IME klavye giri� kayna�� var m�? Bunu kontrol eder.

          Bu, kullan�c� klavyesi �u anda IME giri�i i�in yap�land�r�lm��sa true, aksi takdirde false d�nd�r�r.
          Asya dillerini kullananlar genellikle bir tu�a basarak IME d�n��t�rmeyi a��p kapatabildiklerinden, 
          IME'nin etkinle�tirildi�ini  g�steren baz� g�rsel g�stergeler sa�lamak yararl�d�r. Bu, Input.imeIsSelected kontrol
          edilerek yap�labilir !

      */

        #endregion


        #region  Input.inputString

        /*

            foreach (char c in Input.inputString)
            {
                if (c == '\b') // has backspace/delete been pressed? == Geri al Yani sil tu�una bas�ldi mii
                {
                    if (m_Text.text.Length != 0)
                    {
                        m_Text.text = m_Text.text.Substring(0, m_Text.text.Length - 1);
                    }
                }
                else if ((c == '\n') || (c == '\r')) // enter/return
                {
                    print("Kullan�c� ad�n� girdi : " + m_Text.text);
                }
                else
                {
                    m_Text.text += c;
                }
            }
        
        
  
        Bu �er�eveye girilen klavye giri�ini d�nd�r�r. (Sadece oku)

        Dosyada yaln�zca ASCII karakterleri bulunur inputString.

        Dize, i�lenmesi gereken iki �zel karakter i�erebilir: Karakter "\b", geri al, S�L tu�unu temsil eder.
        Karakter "\n"d�n��� veya giri�i temsil eder.

        YAN� kullan�c� uygulamaya ( oyuna ) ad�n� yaz�p giri� yapt� m�  bunu ��reniriz.


         */


        #endregion


        #region Input.IsJoystickPreconfigured ( ) 

        /*

        bool kontrol =  Input.IsJoystickPreconfigured("Submit");

        if (kontrol)
        {
            Debug.Log("Evet do�ru.");  
        
                           Submit JOystick 'i Unity 'nin kendi Project Settings 'de oldu�u i�in burdaki Joystick 'i
                           Daha �nceden yap�land�rm�� zaten. Dolay�s�yla True DE�ER�N� d�nd�rd�.
        }

        else
        {
            Debug.Log("Hay�r yanl��.");
        }

        
            
           JoystickName : Kontrol edilecek Joystick'in ad�
        
           YAN� :  Belirli bir joystick modelinin Unity taraf�ndan �nceden yap�land�r�l�p yap�land�r�lmad���n� KONTROL EDER.

           �nceden yap�land�r�lm�� joystick'ler, d��meler ve eksenler i�in dizinleri a�a��daki s�rayla bildirir. 
           D��meler: A, B, X, Y, sol tampon, sa� tampon, se�, ba�lat, k�lavuz, sol �ubuk bas�n, sa� �ubuk bas�n Eksenler:
           sol �ubuk x, sol �ubuk y, sol tetik, sa� �ubuk x, sa� �ubuk y, sa� tetik, dpad yatay, dpad dikey.

       */


        #endregion


        #region    Input.location


        /*
             Cihaz KONUMUNA eri�im �zelli�i (yaln�zca ELDE  TA�INIR cihazlar)

        LocationService S�n�f�yla ba�lant�l� oldu�u i�in LocationService S�n�f�n�n �zellik ve metodlar� �unlard�r : 

        1 ) isEnabledByUser : Oyunun cihaz�n KONUM hizmetine eri�imine izin verip vermedi�ini KONTROL EDER.

        2)  lastData : Cihaz�n kaydetti�i son co�rafi Konum.

        3 ) status : Konum hizmetinin DURUMUNU  d�nd�r�r.

        4 ) Start ( ) = Konum hizmeti g�ncelle�tirmelerini BA�LATIR ! 

        5 ) Stop ( ) = Konum hizmeti g�ncellemelerini durdurur. Bu oyun ( uygulama ) konum hizmeti gerektirmedi�inde pil g�c�nden
                       TASARRUF etmek i�in kullan��l�d�r.

        */



        /* 

            1 '�N �RNE�� 

          bool konumaIzinVerildiMi = m_LocationServiceYaniKonumServisi.isEnabledByUser;
          if (konumaIzinVerildiMi)
          {
              Debug.Log("Evet");
          }
          else
          {
              Debug.Log("Hay�r.");
          }


              2 'N�N �RNE��

          Debug.Log(m_LocationServiceYaniKonumServisi.lastData); 

            Cihaz�n kaydetti�i  son co�rafi konumu yakalar.Ama biz �uan Bilgisayar�n S�mulatorun'den i�lem yapt���m�z i�in 
            kod hata verdi. 

            Di�er �zellikleride telefondan  i�lem yapt���n zaman GEREKL�YSE BU �ZELLL�KLER� KULLANAB�L�RS�N ....................



          */
        #endregion


        #region  Input.mousePosition


        /*
         
        Piksel koordinatlar�nda ge�erli farenin konumunu yakalar.
        Vector3'�n z bile�eni her zaman 0'd�r. Ekran�n veya pencerenin sol alt k�sm�(0, 0) konumundad�r.
        Ekran�n veya pencerenin sa� �st k�sm� Screen.width, Screen.height konumundad�r.


        
      if (Input.GetButton("Fire1"))
      {
            Vector3 fareninkonumu = Input.mousePosition;

            Debug.Log(fareninkonumu); // Her zaman  farenin Z konumu 0 'd�r. 

            transform.position = fareninkonumu;
      }

        */
        #endregion


        #region  Input.mousePresent

        /*

        bool fareVarligiKontrolu = Input.mousePresent;

        if (fareVarligiKontrolu)
        {
            Debug.Log("Evet Fare yani Maus var.");
        }

        else
        {
            Debug.Log("Hay�r Fare yok.");
        }
            
             
             Bir fare ayg�t�n�n alg�lan�p alg�lanmad���n� KONTROL EDER..

            Windows, Android ve Metro platformlar�nda, bu i�lev ger�ek fare varl��� alg�lamas� yapar, bu nedenle do�ru veya yanl�� 
            d�nd�rebilir. Linux, Mac, WebGL'de bu i�lev her zaman true de�erini d�nd�r�r. iOS ve konsol platformlar�nda bu i�lev 
            her zaman false d�nd�r�r.
             
       */



        #endregion


        #region   Input.mouseScrollDelta

        /*

        Vector2 FareKaydirmaDeltasi = Input.mouseScrollDelta;
        Debug.Log(FareKaydirmaDeltasi);

        float kont= Input.mouseScrollDelta.y;
        Debug.Log(kont);

            
             
            Ge�erli fare kayd�rma deltas�. (Sadece oku)

             Input.mouseScrollDelta , Vector2.y �zelli�inde depolan�r . ( Vector2.x de�eri yok say�l�r.) 
             Input.mouseScrollDelta pozitif (yukar�) veya negatif (a�a��) olabilir. Fare kayd�rma d�nd�r�lmedi�inde de�er s�f�rd�r.
             Merkezi kayd�rma tekerle�ine sahip bir farenin bir PC'de tipik oldu�unu unutmay�n. 

            */
        #endregion


        #region Input.ResetInputAxes

        /*

       Input.ResetInputAxes();


            
            
             T�m giri�i s�f�rlar. ResetInputAxes'dan sonra bir �er�eve i�in t�m eksenler 0'a ve t�m d��meler 0'a d�ner.

             Bu, oynat�c�y� yeniden canland�r�rken yararl� olabilir ve hala bas�l� tutulabilecek tu�lardan herhangi bir girdi 
             istemezsiniz.

             
             */

        #endregion


        // *********************************************************************************************************************

        if (Input.touchCount > 0)
        {


            Touch m_Touch = Input.GetTouch(0); // �ZELL�K VE METODLARINI A�A�IDA ANLATICAZ  �NEML� !!!!!!!!!!!!!!!!!!!!!


            #region   Input.touches

            /*

            var ParmakSayisi = 0;

            a = Input.touches;

           Ekrana dokunulan parmak ' LARI  yakalar.

            */

            #endregion


            #region  Input.touchPressureSupported

            /*

            bool DokunmaBasinci = Input.touchPressureSupported;
            Debug.Log(DokunmaBasinci);

                Biz Simulator 'den bunu denedi�imiz i�in DOKUNMA BASINCI FALSE yani dokunma bas�nc� YOKMU�.

            */
            #endregion


            #region Input.touchCount

            /*
               int DokunmaSayisi = Input.touchCount;
               Debug.Log(DokunmaSayisi);

               Dokunma say�s�n� YAKALAR ! ! ! 

             */
            #endregion


            #region Input.GetTouch ( ) 


            /*  Input.GetTouch ( )  = DOKUNMA YAPISINI D�ND�R�R.

            if (Input.touchCount > 0)
            {
                Touch ilkDokunus = Input.GetTouch(0);

                if (ilkDokunus.phase == TouchPhase.Began)
                {
                    Debug.Log("EKRANA �LK KEZ DOKUNDUM ! ");
                }

                if (ilkDokunus.phase == TouchPhase.Moved)
                {
                    Debug.Log("Ekrana dokunmaya devam ediyorum.");
                }

                if (ilkDokunus.phase == TouchPhase.Ended)
                {
                    Debug.Log("Ekrana ARTIK DOKUNMUYORUM.");
                }

            */

            #endregion


            #region Input.touchSupported

            /*

            Telefonda dokunmatik �zelli�i  VAR MI YOK MU bunu kontrol eder.

            bool telefonundaDokunmatiklikVarmi = Input.touchSupported;

            if (telefonundaDokunmatiklikVarmi)
            {
                Debug.Log("Evet telefonumda DOKUNMAT�K �zelli�i var.");
            }

            else
            {
                Debug.Log("Hay�r telefonumda  DOKUNMAT�K �zelli�i yok.");

                    Sim�lator'den oyunu geli�tirdi�imiz i�in Sim�latorun DOKUNMAT�K �ZELL��� YOKMU� ! !

            }

            */

            #endregion


            #region  Input.multiTouchEnabled

            /*

             Telefonun �oklu dokunu�lar�n�n olup olmad���n� kontrol eden bir �zelliktir.

            bool cokluDokunusOzelligiVarmi = Input.multiTouchEnabled;

            if (cokluDokunusOzelligiVarmi)
            {
                Debug.Log("Evet coklu dokunu� �zelli�i VAR.");

                  Simulator 'de �oklu dokunu� �zelli�i varm��.
            }

            else
            {
                Debug.Log("Hay�r �oklu dokunu� �zelli�i yok.");
            }

            */

            #endregion


            #region Input.simulateMouseWithTouches

            /*  

              Yani dokunu�larla fareyi sim�le etme �zelli�i VAR MI YOK MU kontrol eder.

            bool dokunuslarlaFareyiSimuleEtmeOZelligi = Input.simulateMouseWithTouches;

            if (dokunuslarlaFareyiSimuleEtmeOZelligi)
            {
                Debug.Log("Evet VAR.");

                Simulatorde Dokunuslarla fareyi sim�le etme �zelli�i VARMI� ! !
            }
            else
                Debug.Log("YOK.");


            */

            #endregion


            #region  Input.stylusTouchSupported

            /*

             Stylus touch, bir cihaz veya platform taraf�ndan desteklendi�inde true d�ner.
             Telefona B�R KALEMLE ( VEYA BA�KA B�R ALETLE ) dokunma �zelli�i var m� yok mu KONTROL EDER.

            bool StylusTouchVarmi = Input.stylusTouchSupported;

            if (StylusTouchVarmi)
            {
                Debug.Log("Evet StylusTouch var.");
            }

            else
            {
                Debug.Log("Hay�r StylusTouch yok.");
            }

            */

            #endregion


            #region   1 ) m_Touch.altitudeAngle


            /*
              altitudeAngle = Y�kseklik A��s�

            m_Touch.altitudeAngle;

            0 randyan de�eri, KALEM�N y�zeye paralel oldu�unu, pi/2 ise dik oldu�unu g�sterir.

            */


            #endregion


            #region  2 ) m_Touch.azimuthAngle

            /*

            azimuthAngle = G�ney A��s�

            0 radyan de�eri kalemin cihaz�n x ekseni boyunca i�aret edildi�ini g�sterir.


            float G�neyAcisi = m_Touch.azimuthAngle;
            Debug.Log(G�neyAcisi);

              */
            #endregion


            #region  3 ) m_Touch.deltaPosition ( �NEML� )

            /*

            Vector2 K = m_Touch.deltaPosition;
            Debug.Log(K);

            

            *  Dokunman�n mutlak konumu  periyodik olarak kaydedilir ve KONUM �zelli�inde bulunur.

            *  deltaPosition de�eri en son g�ncellemde kaydedilen DOKUNMA ile �nceki g�ncellemede kaydedilen DOKUNMA KONUMU 
               aras�ndaki FARKI temsil eden P�KSEL KOORD�NATLARINDAK� bir Vector2 'dir.

            *  DeltaTime de�eri, �nceki ve mevcut g�ncellemeler aras�ndaki ge�en S�REY� verir.

            *   deltaPosition.magnitude ' yi deltaTime ' a b�lerek DOKUNU�UN HAREKET HIZINI hesaplayabiliriz.

            */


            #endregion


            #region 4 ) m_Touch.deltaTime

            /*

            float  sure = m_Touch.deltaTime;
            Debug.Log(sure);

            

           * deltaTime degeri �nceki g�ncelleme ile mevcut g�ncelleme aras�ndaki ge�en s�redir.

           * �e�itli dokunma �zellikleri i�in de�erler periyodik olarak g�ncellenir.

           * deltaTime, deltaPosition ' a g�re dokunma konumunun HAREKET HIZINI belirlemek i�in kullan��l�d�r.
           
            */

            #endregion


            #region 5 )  m_Touch.fingerId


            /*
             
            Dokunma i�in benzersiz dizin.

         *  T�m ge�erli dokunu�lar, Input.touches dizisinde veya e�de�er dizi dizini ile Input.GetTouch i�levi kullan�larak rapor
            edilir. 
         *  Ancak dizi indeksinin bir kareden di�erine ayn� olmas� garanti edilmez. Ancak fingerId de�er, s�rekli olarak �er�eveler
            aras�nda ayn� dokunu�a at�fta bulunur. Bu kimlik de�eri, hareketleri analiz ederken �ok kullan��l�d�r ve parmaklar�
            �nceki konuma yak�nl�klar�na vb. g�re tan�mlamaktan daha g�venilirdir.

         *  Touch.fingerId"ilk" dokunma, "ikinci" dokunma vb. ile ayn� de�ildir. Bu, hareket ba��na yaln�zca benzersiz bir kimliktir. 
            FingerId ve ger�ekte ekrandaki parmak say�s� hakk�nda herhangi bir varsay�mda bulunamazs�n�z, ��nk� dokunma yap�s�n�n 
            t�m �er�eve i�in sabit oldu�u ger�e�ini i�lemek i�in sanal dokunu�lar tan�t�lacakt�r (ger�ekte dokunma say�s� a��k�a 
            do�ru olmayabilir, �rne�in, tek bir �er�eve i�inde birden fazla k�lavuz �ekme meydana gelirse).

            
            

            int parmakKimligi = 1;
            m_Touch.fingerId =parmakKimligi;     // Set i�lemini yapt�k.
            parmakKimligi = m_Touch.fingerId;    // Get i�lemini yapt�k.
            Debug.Log(m_Touch.fingerId);


            */

            #endregion


            #region 6 ) m_Touch.maximumPossiblePressure


            /*
             
            Bir platform i�in m�mk�n olan maksimum BASIN� de�eri. Input.touchPressureSupported false d�nd�r�rse,
            bu �zelli�in de�eri her zaman 1.0f olacakt�r.

            
            float platformMaksBasinc = m_Touch.maximumPossiblePressure;
            Debug.Log(platformMaksBasinc); 

            
            Reeder Telefonunda oyunu �al��t�rd���nda 1 ��kt�s�n� ald�n.

            */


            #endregion


            #region 7 ) m_Touch.phase

            /*

            Parmak dokunu�unun a�amas�n� a��klar. Bir dokunu� cihaz taraf�ndan �mr� boyunca takip edilir bu nedenle 
            dokunu�un BA�LANGICI, SONU VE DOKUNU� DEVAM EDERKEN 'ki  hareketlerini yakalar.


            if (TouchPhase.Began == m_Touch.phase)
            {
                Debug.Log("Dokunma ba�lad�.");
            }

            if (TouchPhase.Moved == m_Touch.phase)
            {
                Debug.Log("Dokunma DEVAM ED�YOR.");
            }

            if (TouchPhase.Ended == m_Touch.phase)
            {
                Debug.Log("Dokunma B�TT�");
            }


            */

            #endregion


            #region 8 ) m_Touch.position

            /*
     
               * Dokunman�n ekran alan� piksel koordinatlar�ndaki konumu.

               * Konum, bir dokunmatik konta��n s�r�klendi�i s�rada mevcut konumunu d�nd�r�r. Dokunman�n orijinal konumuna 
                 ihtiyac�n�z varsa, bkz. Touch.rawPosition.

               * Ekran�n veya pencerenin sol alt k�sm� (0, 0) konumundad�r. Ekran�n veya pencerenin sa� �st k�sm� 
                 (Screen.width, Screen.height) konumundad�r.


            

            Vector2 DokunmaninPikselKoordinatlarindakiKonumu = m_Touch.position;
            Debug.Log(DokunmaninPikselKoordinatlarindakiKonumu);

            */


            #endregion


            #region  9 ) m_Touch.pressure

            /*
           
              Bir dokunu�a uygulanan mevcut bas�n� miktar�d�r. 
              1.0 ortalama bir dokunu�un bas�nc� olarak kabul edilir.Input.touchPressureSupported false d�nd�r�rse, bu �zelli�in
              her zaman 1.0f olur.

            

            float DokunusunBasincMiktari = m_Touch.pressure;
            Debug.Log(DokunusunBasincMiktari);

             Reeder Telefonumda 1 ��kt�s�n� ald�m. Yani Telefonumda doku�umun BAS�N� M�KTAR� 1 mi�.

            */
            #endregion


            #region 10 )  m_Touch.radius

            /*
            
              Bir dokunu�un yar��ap�n�n tahmini de�eri. Maksimum dokunma boyutunu elde etmek i�in radiusVariance ekleyin,
              minimum dokunma boyutunu elde etmek i�in ��kar�n.

              Android: S�n�rl� say�da cihazda do�ru �ekilde �al���r.


            
            float dokunusunYaricapDegeri = m_Touch.radius;
            Debug.Log(dokunusunYaricapDegeri);

            Reeder telefonumda Dokunu�umun YARI �AP DE�ER� 0.4993889 'mu�.

            */

            #endregion


            #region 11 )  m_Touch.radiusVariance

            /*

              Bu de�er, dokunma yar��ap�n�n do�rulu�unu belirler. Maksimum dokunma boyutunu elde etmek i�in bu de�eri
              yar��apa ekleyin, minimum dokunma boyutunu elde etmek i�in ��kar�n.

              Android: �o�u cihaz i�in 0 d�nd�r�r.

            
            float DokunmaYaricapininDogrulukDegeri = m_Touch.radiusVariance;
            Debug.Log(DokunmaYaricapininDogrulukDegeri);

                    Reeder telefonumda Dokunma yar�capinin Do�ruluk de�eri 0 m��.

            float DokunmaYaricapi = m_Touch.radius;
            float MaksimumDokunmaBoyutu = DokunmaYaricapi + DokunmaYaricapininDogrulukDegeri;
            Debug.Log(MaksimumDokunmaBoyutu);

                    MaksimumDokunmaBoyutu Reeder Telefonumda 0.4993889 'mu�.

            float MinimumDokunmaBoyutu = DokunmaYaricapi - DokunmaYaricapininDogrulukDegeri;
            Debug.Log(MinimumDokunmaBoyutu);

                     Minimum Dokunma Boyutu DA  Reeder Telefonumda 0.4993889 'mu�.

            */

            #endregion


            #region 12 )  m_Touch.rawPosition

            /*

            DOKUNMAT�K KONTA�IN ekran alan� piksel koordinatlar�ndaki �LK ( HAM ) KONUMU.

            Ham konum, bir dokunma temas�n�n orijinal konumunu d�nd�r�r ve dokunma s�r�klendik�e DE���MEZ. 
            Dokunman�n mevcut konumuna ihtiyac�n�z varsa, Touch.position 'A BAK.

            Ekran�n veya pencerenin sol alt k�sm� (0, 0) konumundad�r. Ekran�n veya pencerenin sa� �st k�sm� 
            (Screen.width, Screen.height) konumundad�r.


            
            Vector2 pixelKoordinatlarindakiIlkKonumu = m_Touch.rawPosition;
            Debug.Log(pixelKoordinatlarindakiIlkKonumu);

            Reeder Telefonumda Dokunmatik KONTA�IN piksel koordinatlar�ndaki �LK ( HAM HAL�YLE ) KONUMU  ( 0,0 ) MI�.

            */

            #endregion


            #region 13 ) m_Touch.tapCount ( Tam anlamad�n. )

            /*

            Musluk say�s�.

             Bu, belirli bir konumdaki parmaktan "�ift t�klamay�" vb. alg�laman�n bir yolu olarak tasarlanm��t�r. 
            Baz� durumlarda, iki parma�a d�n���ml� olarak dokunulabilir ve bu, tek bir parmakla hafif�e vurup ayn� anda
            hareket ediyormu� gibi yanl�� bir �ekilde kaydedilebilir.


            int a = m_Touch.tapCount;

            if (a == 2)
            {
                Debug.Log(" Ekrana 2 ");
            }
            else
            {
                Debug.Log("1 ");
            }

            
            */

            #endregion


            #region 14 ) m_Touch.type

            /*

             Dokunman�n DO�RUDAN m� DOLAYLI m� (  uzaktan ) ya da EKRAN KALEM�NDEN mi yap�ld���n� a��klar.
             
             * Direct : Do�rudan  cihaza dokunma
              
             * Indirect : Dolayl� veya uzaktan cihaza dokunma
             
             * Stylus : Cihazdaki EKRAN KALEM�NDEN dokunma.

            
            if (m_Touch.type == TouchType.Direct)
            {
                Debug.Log("Ekrana direk dokundum.");
            }
          

            Reeder Telefonumda ekrana D�RECT ( D�REK ) dokunma ger�ekle�ti.

            */

            #endregion






        }
    }




}

