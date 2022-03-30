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

     


        #region Input.acceleration ( Unity Documention 'dan AYRICA BAK ÇÜNKÜ ORDA ÖNEMLÝ KODLAR VAR.

        /*
         
        Vector3 cihazinSonolculenDogrusalIvmesi = Input.acceleration;
        Debug.Log(cihazinSonolculenDogrusalIvmesi);

        */

        #endregion


        #region Input.anyKey

        /*

                Herhangi bir tuþa BASILI TUTULDU MU bunun kontrolünü yapar.

         bool TusVeyaFareDugmesineBasildiMi = Input.anyKey;

         if (TusVeyaFareDugmesineBasildiMi)
         {
             Debug.Log("Evet basýldý.");
         }

      */
        #endregion


        #region Input.anyKeyDown

        /* HERHANGÝ BÝR TUÞA TEK TEK BASILDI MI BUNUN KONTROLÜNÜ YAPAR.

        bool HerhangiBirSeyeTekTekBasildiMi = Input.anyKeyDown;
        if (HerhangiBirSeyeTekTekBasildiMi)
        {
            Debug.Log("Evet Basildi ! ");
        }
            
        */

        #endregion


        #region  Input.backButtonLeavesApp


        /* 
            YANÝ Geri düðmesi bastýðýmda uygulamadan çýkýlsýn mý çýkýlmasýn mý bunun kontrolünü yaparýz.
            SADECE Android, Windows Phone , Windows Tabletlerde kullanýlabilir.

        bool GeriDugmesineBasilincaUygulamadanCikmaDurumu = Input.backButtonLeavesApp;

        if ( GeriDugmesineBasilincaUygulamadanCikmaDurumu )

        {
           // Buraya projeye göre ilgili kodlarýný yaz.
        }


        */

        #endregion


        #region  Input.compass ( Detaylý bir konu vakti geldiðinde ÖÐREN. )

        // Pusulaya Eriþim özelliði. ( Sadece elde taþýnan cihazlar )
        // Compass pusula = Input.compass;


        #endregion


        #region Input.compensateSensors

        /*

        bool Kontrol = Input.compensateSensors;

        if (Kontrol)
        {
            Debug.Log("Giriþ sensörlerinin ekran yönü için telafi et.");
        }

        else
        {
            Debug.Log("Giriþ Sensörlerinin ekran yönü için telafi ETME.");

              Her þeyi Similatorden denediðim için burda False deðerini döndürdü.Yani giriþ sensörlerini ekran yönü için telafi
              ETMEDÝ.

        }


        */

        #endregion


        #region  Input.compositionString

        /*
         
        string a = Input.compositionString;

        
      Kullanýcý tarafýndan yazýlan geçerli IME oluþturma dizesi.

       Çince, Japonca veya Korece gibi bazý dillerde, bir veya birden çok karakter oluþturmak için birden çok tuþ yazýlarak 
       metin girilir. Bu karakterler, kullanýcý yazarken ekranda görsel olarak oluþmaktadýr.Metin giriþi için Unity'nin 
       yerleþik GUI sistemini kullanýrken, Unity, kullanýcýlar yazarken kompozisyon dizelerini görüntülemeye özen gösterir. 
       Ancak kendi GUI'nizi uygulamak istiyorsanýz, dizeyi geçerli imleç konumunda görüntülemeye dikkat etmeniz gerekir.
       Kompozisyon dizesi yalnýzca IME birleþtirme kullanýldýðýnda güncellenir.Daha fazla bilgi için Input.imeCompositionMode'a
      bakýn. 

        */
        #endregion


        #region  Input.deviceOrientation


        /*

                Ýþletim sistemi tarafýndan bildirildiði þekliyle cihazýn Fiziksel yönü. 7 tane yön vardýr.BUNLAR : 



          1 ) ***************************

               if (Input.deviceOrientation == DeviceOrientation.FaceDown)
               {
                   Debug.Log("Evet Cihaz ekran aþaðý bakacak þekilde yere paralel bir þekilde tutuluyor.");
                   // BURAYA ÝSTEDÝÐÝN KODU YAZABÝLÝRSÝN.öRNEK EKRAN BU ÞEKÝLDEYSE OYUN MÜZÝÐÝM HEMEN BAÞLAYABÝLÝR.
               }

               else
               {
                   Debug.Log("Hayýr Ekran aþaðý bakacak þekilde TUTULMUYOR.");
               }

         2 ) ***************************

               if (Input.deviceOrientation == DeviceOrientation.FaceUp)
               {
                   Debug.Log("Cihaz ekran yukarý bakacak þekilde yere paralel bir þekilde tutuluyor.");
               }

         3) ***************************

               if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
               {
                   Debug.Log(" Evet Cihaz yatay modda, cihaz dik tutuluyor ve ana sayfa düðmesi SAÐ TARAFTA .");
               }

         
        4 ) ***************************

           
               if (Input.deviceOrientation == DeviceOrientation.LandscapeRight)
               {
                   Debug.Log("Evet cihaz yatay modda, cihaz dik tutuluyor ve ana sayfa düðmesi SOL TARAFTA.");
               }

        5 ) ***************************


               if (Input.deviceOrientation == DeviceOrientation.Portrait)
               {
                   Debug.Log("Evet Cihaz DÝKEY modda, cihaz dik tutuluyor ve ana sayfa düðmesi ALTTA.");
               }

        6 ) ***************************

               if (Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
               {
                   Debug.Log("Evet cihaz DÝKEY MODDA, ancak BAÞ AÞAÐI DURUMDA , cihaz dik tutuluyor ve ana sayfa düðmesi ÜSTTE.");
               }

        7 ) ***************************

               if (Input.deviceOrientation == DeviceOrientation.Unknown)
               {
                   Debug.Log("CÝHAZIN YÖNÜ BELÝRLENEMEZ.");

               }

           */

        #endregion


        #region Input.GetAxis ( )

        /*

        Tarafýndan tanýmlanan sanal eksenin deðerini döndürür axisName.

        Deðer, klavye ve joystick giriþ cihazlarý için -1...1 aralýðýnda olacaktýr.

         Bu deðerin anlamý giriþ kontrolünün tipine baðlýdýr, örneðin bir joystick'in yatay ekseninde 1 deðeri çubuðun tamamen saða itildiði
           ve - 1 deðeri ise tamamen sola itildiði anlamýna gelir; 0 deðeri, joystick'in nötr konumunda olduðu anlamýna gelir.

         Eksen fareye eþlenirse, deðer farklýdýr ve - 1...1 aralýðýnda olmayacaktýr. Bunun yerine, eksen duyarlýlýðý ile çarpýlan
          geçerli fare deltasý olacaktýr.Tipik olarak pozitif bir deðer, farenin saða/ aþaðý hareket ettiði ve negatif bir deðer,
          farenin sola / yukarý hareket ettiði anlamýna gelir.

         Bu, kare hýzýndan baðýmsýzdýr; bu deðeri kullanýrken deðiþen kare hýzlarý konusunda endiþelenmenize gerek yoktur.


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

          Hiçbir YUMUÞATMA FÝLTRESÝ UYGULANMADAN axisName tarafýndan tanýmlanan sanal eksenin deðerini döndürür.

          Deðer, klavye ve joystick giriþi için - 1...1 aralýðýnda olacaktýr. Giriþ düzgünleþtirilmediðinden, klavye giriþi 
          her zaman - 1, 0 veya 1 olacaktýr.Klavye giriþ iþlemenin tüm düzgünleþtirmesini kendiniz yapmak istiyorsanýz 
          bu kullanýþlýdýr.

        */

        #endregion


        #region Input.GetButton ( ) 

        /*

           Butona BASILI TUTULDUÐUNDA true deðerini döndürür.Yani iiþlem yapmasýný istediðin butonunun ismini yazýp
           butona BASILI TUTULDUÐUNDA hangi iþlemi yapmak istiyorsan bu metodu kullanabilirsin.

          if (Input.GetButton("Fire1"))
          {
              Debug.Log("Maousun sol Tuþuna basýlý tutuldu.");
          }
          if (Input.GetButton("Jump"))
          {
              Debug.Log("Space ' e  basýlý tutuldu.");
          }

          */
        #endregion


        #region Input.GetButtonDown ( ) 

        /*

         Kullanýcý TEK TEK BASTIÐI butonda TRUE deðerini döndürür. Yani sen belirlemiþ olduðun butonunun ismini buraya
         yazýp yapýlmasýný istediðin iþlemleri buraya yazabilirsin.

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Butona TEK TEK BASTIM.");
        }

       
        */

        #endregion


        #region  Input.GetButtonUp ( )

        /*

         Belirlemiþ olduðun butondan elini çektiðinde yapýlmasýný istediðin iþlemleri buraya yazabilirsin.

        if ( Input.GetButtonUp("Fire1"))
        {
            Debug.Log("Mausun sol tuþuna ARTIK BASMIYORUM.");
            transform.position += new Vector3(1.84f, 0.688f, -32.62f);
        }

        */

        #endregion


        #region Input.GetMouseButton ()

        /*
         
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mausun sol tuþuna basýlý tutuyorum");
        }

        */

        #endregion


        #region Input.GetMouseButtonDown ( ) ve GetMouseButtonUp ( )

        /*

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mausun Sol tuþuna TEK TEK basýyorum.");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mausun sol tuþundan TEK TEK ELÝMÝ ÇEKTÝÐÝMDE yapýlmasýný istediðim iþlemleri buraya yaz.");
        }

        */

        #endregion


        #region Input.gyro ( Yani Gyroscope )

        /*
         
        Telefonda jiroskop ne demek?
        Akýllý telefonlarda da kullanýlan jiroskop, akýllý telefonlarda konumu deðiþtirip telefonun saða ya da sola ve öne ya da
        arkaya doðru döndürülmesini saðlamaktadýr.



        Varsayýlan jiroskopu döndürür.

        Cihazýnýzýn jiroskop ayrýntýlarýný döndürmek için bunu kullanýn. Öncelikle cihazýnýzda bir jiroskop olduðundan emin olun. 
        Bunu kontrol etmek için Input.gyro.enabled'ý kullanýn.

        Bir cihazýn jiroskop ayrýntýlarýný bilmek, bir cihazýn yönünü bilmesi gereken özellikleri dahil etme becerisini saðlar.
        Yaygýn kullanýmlar, bir kullanýcý cihazýný döndürüp hareket ettirdiðinde kamera açýlarýný veya GameObject'in konumlarýný 
        deðiþtirmeyi bize saðlar.

        

       
        1 ) Gyroscope.attitude = Tutum aygýtýnýn tutumunu ( Yani uzayda yönelimini ) döndürür.

        2 ) Gyroscope.enabled = Etkin bir jirroskopun etkin durumunu ayarlar veya alýr.

        3 ) Gyroscope.gravity = Yerçekimi cihazýn referans çerçevesinde ifade edilen yerçekimi ivmesi vektörünü döndürür.

        4 ) Gyroscope.rotationRate = Cihazýn jiroskopu tarafýndan ölçülen dönüþ hýzýný döndürür.

        5 ) Gyroscope.rotationRateUnbiased = Cihazýn jiroskopu tarafýndan ölçüldüðü þekliyle tarafsýz dönüþ hýzýný döndürür.

        6 ) Gyroscope.updateInterval = Jiroskop aralýðýný saniyeler içinde ayarlar veya alýr.

        7 ) Gyroscope.userAcceleration = Kullanýcýnýn cihaza verdiði ivmeyi döndürür.

        */


        /*
         
        Debug.Log(TelefonunYonununDegistirilmesiniSaglayanSey.userAcceleration);
        Debug.Log(TelefonunYonununDegistirilmesiniSaglayanSey.rotationRate);
        Quaternion a = transform.rotation;
        a = TelefonunYonununDegistirilmesiniSaglayanSey.attitude;
        
        Gibi kodlarý yazabilirsin.Ama sen þuan Similatorden iþlem yaptýðýn için MOBÝL TELEFONUNA geçtiðin zaman GYROSCOPE
        var mý yok mu kod tarafýnda iletiþim kurabiliyo musun ilk önce bunlara bak sonra burdaki özelliklerle kodlarýný yazarsýn.
        */
        #endregion


        #region Input.compositionCursorPos Fazla kullanmayacaðýn bir özellik ama yinede bak


        /*

        Vector2 a = Input.compositionCursorPos;

        
           IME'ler tarafýndan pencereleri açmak için kullanýlan geçerli metin giriþi konumu.

           Japonca gibi bazý dil IME'leri, kullanýcýnýn doðru giriþ dizelerini seçmesine yardýmcý olmak için, 
           kullanýcý metin yazarken pencereleri açar. Bu pencerelerin geçerli imleç konumunda açýlmasý beklenir, 
           bu nedenle IME'nin giriþin nerede görüntülendiðini bilmesi gerekir. Unity'nin metin giriþi için yerleþik GUI sistemini
           kullanýrken, Unity IME için imleç konumunu ayarlamaya özen gösterir. Ancak, metin giriþi için kendi GUI'nizi uygulamak 
           istiyorsanýz, bunu IME pencerelerinin doðru görünmesi için mevcut metin giriþi konumuna ayarlamanýz gerekir. 


     IME  ne demek ? 

        Input Method Editor'ün kýsaltmasý. Bilgisayar kullanýcýlarýna, klavyelerinde bulunmayan karakter ve sembolleri install eden,
        yazý girme programý.

        */

        #endregion


        #region  Input.imeCompositionMode

        /*
          IME giriþ kompozisyonunun etkinleþtirilmesini ve devre dýþý býrakýlmasýný kontrol eder.

        Bazý diller, karakter eklemek için pencerelerin açýlmasýný içeren karmaþýk giriþ yöntemleri kullanýr. Oyunlar, 
        tuþ vuruþlarýný metin olarak deðil, oyun giriþi olarak yorumlayabileceðinden, oyun oynarken genellikle bu istenmez.
        Varsayýlan olarak Unity, metin alanlarýndayken IME oluþturmayý etkinleþtirir ve aksi takdirde devre dýþý býrakýr. 
        Ancak, kendi giriþ GUI'nizi uygulamak istediðinizde, imeCompositionMode özelliðini kullanarak mümkün olan, bunun üzerinde 
        kendiniz kontrol sahibi olmak isteyebilirsiniz.

      
         * 
      

        if (Input.imeCompositionMode == IMECompositionMode.Auto)
        {
            Debug.Log("Evet IME OTOMATÝK.");
        }

        if (Input.imeCompositionMode == IMECompositionMode.Off)
        {
            Debug.Log("IME kapalý.");
        }


       SÝMULATOR  'den iþlem yaptýðýmýz için bu 2 koddan üstteki çalýþtý YANÝ IME sÝMULATOR 'DE OTOMATÝK BÝR ÞEKÝLDE ÇALIÞIYORMUÞ !

        */


        #endregion


        #region Input.imeIsSelected

        /*

        bool IMEsiVarmi = Input.imeIsSelected;

        if (IMEsiVarmi)
        {
            Debug.Log("Evet bu cihazýn IME 'si var.");
        }
        else
        {
            Debug.Log("Hayýr bu cihazýn IME'si YOK ! ");  // SÝMULATOR'UN IME'si yokmuþ.
        }


     
       
          Kullanýcýnýn seçilmiþ bir IME klavye giriþ kaynaðý var mý? Bunu kontrol eder.

          Bu, kullanýcý klavyesi þu anda IME giriþi için yapýlandýrýlmýþsa true, aksi takdirde false döndürür.
          Asya dillerini kullananlar genellikle bir tuþa basarak IME dönüþtürmeyi açýp kapatabildiklerinden, 
          IME'nin etkinleþtirildiðini  gösteren bazý görsel göstergeler saðlamak yararlýdýr. Bu, Input.imeIsSelected kontrol
          edilerek yapýlabilir !

      */

        #endregion


        #region  Input.inputString

        /*

            foreach (char c in Input.inputString)
            {
                if (c == '\b') // has backspace/delete been pressed? == Geri al Yani sil tuþuna basýldi mii
                {
                    if (m_Text.text.Length != 0)
                    {
                        m_Text.text = m_Text.text.Substring(0, m_Text.text.Length - 1);
                    }
                }
                else if ((c == '\n') || (c == '\r')) // enter/return
                {
                    print("Kullanýcý adýný girdi : " + m_Text.text);
                }
                else
                {
                    m_Text.text += c;
                }
            }
        
        
  
        Bu çerçeveye girilen klavye giriþini döndürür. (Sadece oku)

        Dosyada yalnýzca ASCII karakterleri bulunur inputString.

        Dize, iþlenmesi gereken iki özel karakter içerebilir: Karakter "\b", geri al, SÝL tuþunu temsil eder.
        Karakter "\n"dönüþü veya giriþi temsil eder.

        YANÝ kullanýcý uygulamaya ( oyuna ) adýný yazýp giriþ yaptý mý  bunu öðreniriz.


         */


        #endregion


        #region Input.IsJoystickPreconfigured ( ) 

        /*

        bool kontrol =  Input.IsJoystickPreconfigured("Submit");

        if (kontrol)
        {
            Debug.Log("Evet doðru.");  
        
                           Submit JOystick 'i Unity 'nin kendi Project Settings 'de olduðu için burdaki Joystick 'i
                           Daha önceden yapýlandýrmýþ zaten. Dolayýsýyla True DEÐERÝNÝ döndürdü.
        }

        else
        {
            Debug.Log("Hayýr yanlýþ.");
        }

        
            
           JoystickName : Kontrol edilecek Joystick'in adý
        
           YANÝ :  Belirli bir joystick modelinin Unity tarafýndan önceden yapýlandýrýlýp yapýlandýrýlmadýðýný KONTROL EDER.

           Önceden yapýlandýrýlmýþ joystick'ler, düðmeler ve eksenler için dizinleri aþaðýdaki sýrayla bildirir. 
           Düðmeler: A, B, X, Y, sol tampon, sað tampon, seç, baþlat, kýlavuz, sol çubuk basýn, sað çubuk basýn Eksenler:
           sol çubuk x, sol çubuk y, sol tetik, sað çubuk x, sað çubuk y, sað tetik, dpad yatay, dpad dikey.

       */


        #endregion


        #region    Input.location


        /*
             Cihaz KONUMUNA eriþim özelliði (yalnýzca ELDE  TAÞINIR cihazlar)

        LocationService Sýnýfýyla baðlantýlý olduðu için LocationService Sýnýfýnýn özellik ve metodlarý þunlardýr : 

        1 ) isEnabledByUser : Oyunun cihazýn KONUM hizmetine eriþimine izin verip vermediðini KONTROL EDER.

        2)  lastData : Cihazýn kaydettiði son coðrafi Konum.

        3 ) status : Konum hizmetinin DURUMUNU  döndürür.

        4 ) Start ( ) = Konum hizmeti güncelleþtirmelerini BAÞLATIR ! 

        5 ) Stop ( ) = Konum hizmeti güncellemelerini durdurur. Bu oyun ( uygulama ) konum hizmeti gerektirmediðinde pil gücünden
                       TASARRUF etmek için kullanýþlýdýr.

        */



        /* 

            1 'ÝN ÖRNEÐÝ 

          bool konumaIzinVerildiMi = m_LocationServiceYaniKonumServisi.isEnabledByUser;
          if (konumaIzinVerildiMi)
          {
              Debug.Log("Evet");
          }
          else
          {
              Debug.Log("Hayýr.");
          }


              2 'NÝN ÖRNEÐÝ

          Debug.Log(m_LocationServiceYaniKonumServisi.lastData); 

            Cihazýn kaydettiði  son coðrafi konumu yakalar.Ama biz þuan Bilgisayarýn SÝmulatorun'den iþlem yaptýðýmýz için 
            kod hata verdi. 

            Diðer özellikleride telefondan  iþlem yaptýðýn zaman GEREKLÝYSE BU ÖZELLLÝKLERÝ KULLANABÝLÝRSÝN ....................



          */
        #endregion


        #region  Input.mousePosition


        /*
         
        Piksel koordinatlarýnda geçerli farenin konumunu yakalar.
        Vector3'ün z bileþeni her zaman 0'dýr. Ekranýn veya pencerenin sol alt kýsmý(0, 0) konumundadýr.
        Ekranýn veya pencerenin sað üst kýsmý Screen.width, Screen.height konumundadýr.


        
      if (Input.GetButton("Fire1"))
      {
            Vector3 fareninkonumu = Input.mousePosition;

            Debug.Log(fareninkonumu); // Her zaman  farenin Z konumu 0 'dýr. 

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
            Debug.Log("Hayýr Fare yok.");
        }
            
             
             Bir fare aygýtýnýn algýlanýp algýlanmadýðýný KONTROL EDER..

            Windows, Android ve Metro platformlarýnda, bu iþlev gerçek fare varlýðý algýlamasý yapar, bu nedenle doðru veya yanlýþ 
            döndürebilir. Linux, Mac, WebGL'de bu iþlev her zaman true deðerini döndürür. iOS ve konsol platformlarýnda bu iþlev 
            her zaman false döndürür.
             
       */



        #endregion


        #region   Input.mouseScrollDelta

        /*

        Vector2 FareKaydirmaDeltasi = Input.mouseScrollDelta;
        Debug.Log(FareKaydirmaDeltasi);

        float kont= Input.mouseScrollDelta.y;
        Debug.Log(kont);

            
             
            Geçerli fare kaydýrma deltasý. (Sadece oku)

             Input.mouseScrollDelta , Vector2.y özelliðinde depolanýr . ( Vector2.x deðeri yok sayýlýr.) 
             Input.mouseScrollDelta pozitif (yukarý) veya negatif (aþaðý) olabilir. Fare kaydýrma döndürülmediðinde deðer sýfýrdýr.
             Merkezi kaydýrma tekerleðine sahip bir farenin bir PC'de tipik olduðunu unutmayýn. 

            */
        #endregion


        #region Input.ResetInputAxes

        /*

       Input.ResetInputAxes();


            
            
             Tüm giriþi sýfýrlar. ResetInputAxes'dan sonra bir çerçeve için tüm eksenler 0'a ve tüm düðmeler 0'a döner.

             Bu, oynatýcýyý yeniden canlandýrýrken yararlý olabilir ve hala basýlý tutulabilecek tuþlardan herhangi bir girdi 
             istemezsiniz.

             
             */

        #endregion


        // *********************************************************************************************************************

        if (Input.touchCount > 0)
        {


            Touch m_Touch = Input.GetTouch(0); // ÖZELLÝK VE METODLARINI AÞAÐIDA ANLATICAZ  ÖNEMLÝ !!!!!!!!!!!!!!!!!!!!!


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

                Biz Simulator 'den bunu denediðimiz için DOKUNMA BASINCI FALSE yani dokunma basýncý YOKMUÞ.

            */
            #endregion


            #region Input.touchCount

            /*
               int DokunmaSayisi = Input.touchCount;
               Debug.Log(DokunmaSayisi);

               Dokunma sayýsýný YAKALAR ! ! ! 

             */
            #endregion


            #region Input.GetTouch ( ) 


            /*  Input.GetTouch ( )  = DOKUNMA YAPISINI DÖNDÜRÜR.

            if (Input.touchCount > 0)
            {
                Touch ilkDokunus = Input.GetTouch(0);

                if (ilkDokunus.phase == TouchPhase.Began)
                {
                    Debug.Log("EKRANA ÝLK KEZ DOKUNDUM ! ");
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

            Telefonda dokunmatik özelliði  VAR MI YOK MU bunu kontrol eder.

            bool telefonundaDokunmatiklikVarmi = Input.touchSupported;

            if (telefonundaDokunmatiklikVarmi)
            {
                Debug.Log("Evet telefonumda DOKUNMATÝK özelliði var.");
            }

            else
            {
                Debug.Log("Hayýr telefonumda  DOKUNMATÝK özelliði yok.");

                    Simülator'den oyunu geliþtirdiðimiz için Simülatorun DOKUNMATÝK ÖZELLÝÐÝ YOKMUÞ ! !

            }

            */

            #endregion


            #region  Input.multiTouchEnabled

            /*

             Telefonun çoklu dokunuþlarýnýn olup olmadýðýný kontrol eden bir özelliktir.

            bool cokluDokunusOzelligiVarmi = Input.multiTouchEnabled;

            if (cokluDokunusOzelligiVarmi)
            {
                Debug.Log("Evet coklu dokunuþ özelliði VAR.");

                  Simulator 'de çoklu dokunuþ özelliði varmýþ.
            }

            else
            {
                Debug.Log("Hayýr Çoklu dokunuþ özelliði yok.");
            }

            */

            #endregion


            #region Input.simulateMouseWithTouches

            /*  

              Yani dokunuþlarla fareyi simüle etme özelliði VAR MI YOK MU kontrol eder.

            bool dokunuslarlaFareyiSimuleEtmeOZelligi = Input.simulateMouseWithTouches;

            if (dokunuslarlaFareyiSimuleEtmeOZelligi)
            {
                Debug.Log("Evet VAR.");

                Simulatorde Dokunuslarla fareyi simüle etme özelliði VARMIÞ ! !
            }
            else
                Debug.Log("YOK.");


            */

            #endregion


            #region  Input.stylusTouchSupported

            /*

             Stylus touch, bir cihaz veya platform tarafýndan desteklendiðinde true döner.
             Telefona BÝR KALEMLE ( VEYA BAÞKA BÝR ALETLE ) dokunma özelliði var mý yok mu KONTROL EDER.

            bool StylusTouchVarmi = Input.stylusTouchSupported;

            if (StylusTouchVarmi)
            {
                Debug.Log("Evet StylusTouch var.");
            }

            else
            {
                Debug.Log("Hayýr StylusTouch yok.");
            }

            */

            #endregion


            #region   1 ) m_Touch.altitudeAngle


            /*
              altitudeAngle = Yükseklik Açýsý

            m_Touch.altitudeAngle;

            0 randyan deðeri, KALEMÝN yüzeye paralel olduðunu, pi/2 ise dik olduðunu gösterir.

            */


            #endregion


            #region  2 ) m_Touch.azimuthAngle

            /*

            azimuthAngle = Güney Açýsý

            0 radyan deðeri kalemin cihazýn x ekseni boyunca iþaret edildiðini gösterir.


            float GüneyAcisi = m_Touch.azimuthAngle;
            Debug.Log(GüneyAcisi);

              */
            #endregion


            #region  3 ) m_Touch.deltaPosition ( ÖNEMLÝ )

            /*

            Vector2 K = m_Touch.deltaPosition;
            Debug.Log(K);

            

            *  Dokunmanýn mutlak konumu  periyodik olarak kaydedilir ve KONUM özelliðinde bulunur.

            *  deltaPosition deðeri en son güncellemde kaydedilen DOKUNMA ile önceki güncellemede kaydedilen DOKUNMA KONUMU 
               arasýndaki FARKI temsil eden PÝKSEL KOORDÝNATLARINDAKÝ bir Vector2 'dir.

            *  DeltaTime deðeri, önceki ve mevcut güncellemeler arasýndaki geçen SÜREYÝ verir.

            *   deltaPosition.magnitude ' yi deltaTime ' a bölerek DOKUNUÞUN HAREKET HIZINI hesaplayabiliriz.

            */


            #endregion


            #region 4 ) m_Touch.deltaTime

            /*

            float  sure = m_Touch.deltaTime;
            Debug.Log(sure);

            

           * deltaTime degeri önceki güncelleme ile mevcut güncelleme arasýndaki geçen süredir.

           * Çeþitli dokunma özellikleri için deðerler periyodik olarak güncellenir.

           * deltaTime, deltaPosition ' a göre dokunma konumunun HAREKET HIZINI belirlemek için kullanýþlýdýr.
           
            */

            #endregion


            #region 5 )  m_Touch.fingerId


            /*
             
            Dokunma için benzersiz dizin.

         *  Tüm geçerli dokunuþlar, Input.touches dizisinde veya eþdeðer dizi dizini ile Input.GetTouch iþlevi kullanýlarak rapor
            edilir. 
         *  Ancak dizi indeksinin bir kareden diðerine ayný olmasý garanti edilmez. Ancak fingerId deðer, sürekli olarak çerçeveler
            arasýnda ayný dokunuþa atýfta bulunur. Bu kimlik deðeri, hareketleri analiz ederken çok kullanýþlýdýr ve parmaklarý
            önceki konuma yakýnlýklarýna vb. göre tanýmlamaktan daha güvenilirdir.

         *  Touch.fingerId"ilk" dokunma, "ikinci" dokunma vb. ile ayný deðildir. Bu, hareket baþýna yalnýzca benzersiz bir kimliktir. 
            FingerId ve gerçekte ekrandaki parmak sayýsý hakkýnda herhangi bir varsayýmda bulunamazsýnýz, çünkü dokunma yapýsýnýn 
            tüm çerçeve için sabit olduðu gerçeðini iþlemek için sanal dokunuþlar tanýtýlacaktýr (gerçekte dokunma sayýsý açýkça 
            doðru olmayabilir, örneðin, tek bir çerçeve içinde birden fazla kýlavuz çekme meydana gelirse).

            
            

            int parmakKimligi = 1;
            m_Touch.fingerId =parmakKimligi;     // Set iþlemini yaptýk.
            parmakKimligi = m_Touch.fingerId;    // Get iþlemini yaptýk.
            Debug.Log(m_Touch.fingerId);


            */

            #endregion


            #region 6 ) m_Touch.maximumPossiblePressure


            /*
             
            Bir platform için mümkün olan maksimum BASINÇ deðeri. Input.touchPressureSupported false döndürürse,
            bu özelliðin deðeri her zaman 1.0f olacaktýr.

            
            float platformMaksBasinc = m_Touch.maximumPossiblePressure;
            Debug.Log(platformMaksBasinc); 

            
            Reeder Telefonunda oyunu çalýþtýrdýðýnda 1 çýktýsýný aldýn.

            */


            #endregion


            #region 7 ) m_Touch.phase

            /*

            Parmak dokunuþunun aþamasýný açýklar. Bir dokunuþ cihaz tarafýndan ömrü boyunca takip edilir bu nedenle 
            dokunuþun BAÞLANGICI, SONU VE DOKUNUÞ DEVAM EDERKEN 'ki  hareketlerini yakalar.


            if (TouchPhase.Began == m_Touch.phase)
            {
                Debug.Log("Dokunma baþladý.");
            }

            if (TouchPhase.Moved == m_Touch.phase)
            {
                Debug.Log("Dokunma DEVAM EDÝYOR.");
            }

            if (TouchPhase.Ended == m_Touch.phase)
            {
                Debug.Log("Dokunma BÝTTÝ");
            }


            */

            #endregion


            #region 8 ) m_Touch.position

            /*
     
               * Dokunmanýn ekran alaný piksel koordinatlarýndaki konumu.

               * Konum, bir dokunmatik kontaðýn sürüklendiði sýrada mevcut konumunu döndürür. Dokunmanýn orijinal konumuna 
                 ihtiyacýnýz varsa, bkz. Touch.rawPosition.

               * Ekranýn veya pencerenin sol alt kýsmý (0, 0) konumundadýr. Ekranýn veya pencerenin sað üst kýsmý 
                 (Screen.width, Screen.height) konumundadýr.


            

            Vector2 DokunmaninPikselKoordinatlarindakiKonumu = m_Touch.position;
            Debug.Log(DokunmaninPikselKoordinatlarindakiKonumu);

            */


            #endregion


            #region  9 ) m_Touch.pressure

            /*
           
              Bir dokunuþa uygulanan mevcut basýnç miktarýdýr. 
              1.0 ortalama bir dokunuþun basýncý olarak kabul edilir.Input.touchPressureSupported false döndürürse, bu özelliðin
              her zaman 1.0f olur.

            

            float DokunusunBasincMiktari = m_Touch.pressure;
            Debug.Log(DokunusunBasincMiktari);

             Reeder Telefonumda 1 çýktýsýný aldým. Yani Telefonumda dokuþumun BASÝNÇ MÝKTARÝ 1 miþ.

            */
            #endregion


            #region 10 )  m_Touch.radius

            /*
            
              Bir dokunuþun yarýçapýnýn tahmini deðeri. Maksimum dokunma boyutunu elde etmek için radiusVariance ekleyin,
              minimum dokunma boyutunu elde etmek için çýkarýn.

              Android: Sýnýrlý sayýda cihazda doðru þekilde çalýþýr.


            
            float dokunusunYaricapDegeri = m_Touch.radius;
            Debug.Log(dokunusunYaricapDegeri);

            Reeder telefonumda Dokunuþumun YARI ÇAP DEÐERÝ 0.4993889 'muþ.

            */

            #endregion


            #region 11 )  m_Touch.radiusVariance

            /*

              Bu deðer, dokunma yarýçapýnýn doðruluðunu belirler. Maksimum dokunma boyutunu elde etmek için bu deðeri
              yarýçapa ekleyin, minimum dokunma boyutunu elde etmek için çýkarýn.

              Android: Çoðu cihaz için 0 döndürür.

            
            float DokunmaYaricapininDogrulukDegeri = m_Touch.radiusVariance;
            Debug.Log(DokunmaYaricapininDogrulukDegeri);

                    Reeder telefonumda Dokunma yarýcapinin Doðruluk deðeri 0 mýþ.

            float DokunmaYaricapi = m_Touch.radius;
            float MaksimumDokunmaBoyutu = DokunmaYaricapi + DokunmaYaricapininDogrulukDegeri;
            Debug.Log(MaksimumDokunmaBoyutu);

                    MaksimumDokunmaBoyutu Reeder Telefonumda 0.4993889 'muþ.

            float MinimumDokunmaBoyutu = DokunmaYaricapi - DokunmaYaricapininDogrulukDegeri;
            Debug.Log(MinimumDokunmaBoyutu);

                     Minimum Dokunma Boyutu DA  Reeder Telefonumda 0.4993889 'muþ.

            */

            #endregion


            #region 12 )  m_Touch.rawPosition

            /*

            DOKUNMATÝK KONTAÐIN ekran alaný piksel koordinatlarýndaki ÝLK ( HAM ) KONUMU.

            Ham konum, bir dokunma temasýnýn orijinal konumunu döndürür ve dokunma sürüklendikçe DEÐÝÞMEZ. 
            Dokunmanýn mevcut konumuna ihtiyacýnýz varsa, Touch.position 'A BAK.

            Ekranýn veya pencerenin sol alt kýsmý (0, 0) konumundadýr. Ekranýn veya pencerenin sað üst kýsmý 
            (Screen.width, Screen.height) konumundadýr.


            
            Vector2 pixelKoordinatlarindakiIlkKonumu = m_Touch.rawPosition;
            Debug.Log(pixelKoordinatlarindakiIlkKonumu);

            Reeder Telefonumda Dokunmatik KONTAÐIN piksel koordinatlarýndaki ÝLK ( HAM HALÝYLE ) KONUMU  ( 0,0 ) MIÞ.

            */

            #endregion


            #region 13 ) m_Touch.tapCount ( Tam anlamadýn. )

            /*

            Musluk sayýsý.

             Bu, belirli bir konumdaki parmaktan "çift týklamayý" vb. algýlamanýn bir yolu olarak tasarlanmýþtýr. 
            Bazý durumlarda, iki parmaða dönüþümlü olarak dokunulabilir ve bu, tek bir parmakla hafifçe vurup ayný anda
            hareket ediyormuþ gibi yanlýþ bir þekilde kaydedilebilir.


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

             Dokunmanýn DOÐRUDAN mý DOLAYLI mý (  uzaktan ) ya da EKRAN KALEMÝNDEN mi yapýldýðýný açýklar.
             
             * Direct : Doðrudan  cihaza dokunma
              
             * Indirect : Dolaylý veya uzaktan cihaza dokunma
             
             * Stylus : Cihazdaki EKRAN KALEMÝNDEN dokunma.

            
            if (m_Touch.type == TouchType.Direct)
            {
                Debug.Log("Ekrana direk dokundum.");
            }
          

            Reeder Telefonumda ekrana DÝRECT ( DÝREK ) dokunma gerçekleþti.

            */

            #endregion






        }
    }




}

