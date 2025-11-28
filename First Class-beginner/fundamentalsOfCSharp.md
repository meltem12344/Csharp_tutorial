# C# ve .NET Temelleri – Ders Notları

## 1. C# ve .NET Arasındaki Fark
**C#**  
Bir programlama dilidir.

**.NET**  
Windows üzerinde uygulama geliştirmek için kullanılan bir framework’tür.

**Framework (Yazılım İskeleti)**  
Belirli görevler için hazırlanmış kütüphane ve fonksiyonlardan oluşan yapılardır.

**.NET’in Bileşenleri**
- **CLR (Common Language Runtime)**
- **Class Library**

---

## 2. CLR (Common Language Runtime) Nedir?
CLR, bellekte bulunan ve görevi **IL (Intermediate Language)** kodunu **Makine Koduna (Native Code)** dönüştürmek olan bir yapıdır.

### Neden CLR'a İhtiyacımız Var?
- C/C++ gibi diller yalnızca Windows üzerinde derlenebiliyordu.
- Java’da olduğu gibi, C# kodları da önce **IL (Ara Kod)** olarak derlenir.
- Daha sonra bu IL kodu çalışma anında **JIT (Just-in-Time Compilation)** ile Native Code’a çevrilir.

### Sonuç
C# ile yazılmış bir uygulama, **CLR yüklü herhangi bir makinede** çalıştırılabilir.

---

## 3. .NET Uygulama Mimarisi
C# uygulamaları, birbiriyle iletişim kurarak çalışan **Class (Sınıf)** yapılarından oluşur.

### Class (Sınıf) Nedir?
İçerisinde **veriler (attributes)** ve **metotlar (methods)** bulunan bir yapıdır.

### Örnek: “Buzdolabı (Fridge)” Class’ı
**Attributes (Özellikler):**
- Marka  
- Renk  
- Boyut  

**Methods (Metotlar):**
- Soğutma işlemi  
- Kapıyı açma  
- Kapıyı kapatma  

---

## Namespace (İsim Uzayı)
Bir proje içinde çok sayıda sınıf olabilir.  
Birbiriyle ilgili sınıfların tek bir çatı altında toplanmasını sağlar.

Örnek:
- Grafik işlemleri için bir namespace
- Veritabanı işlemleri için ayrı bir namespace

---

## Assembly Nedir?
Namespace’ler çok artınca, bunları saklayan derlenmiş dosyalar devreye girer.

**Assembly = .exe veya .dll dosyasıdır.**  
Kodun derlenmiş halini disk üzerinde temsil eder.

---

## Visual Studio Code uygulamasında direkt c# dosyası açarak pratik yapamadım neden?

Çünkü yukarıda da bahsettiğim gibi c#'ta kodu çalıştırırken **ilk önce derlenmesi şart sonrasında çalıştırılıyor kodlar.** Burada derleme yapılırken bir kaç bilginin bilinmesi gerekiyor mesela **çalışacağı .NET sürümü ne?**, **hangi paketler kullanılıyor**, **konsol uygulaması mı? yoksa web mi?** gibi bilgiler tutulan bir dosyanın da bulunması gerekiyor bu nedenle proje oluşturmalıyız bunu nasıl yapıyoruz VS Code'da?

1. Boş bir klasör oluştur pc'nde.
2. Bu klasörü VS Code'da aç.
3. Yeni terminal aç.
4. Terminale ==> **dotnet new console -n NameofThefolder** bu kodu yaz. Proje ortamınız hazır oldu.
5. Şimdi default olarak açılan c# dosyamıza erişelim bunu yapmak için yukarıdaki kodda NameofThefolder kısmına yazdığımız klasör isminin içine girelim ==>
    **cd NameofThefolder** kodu ile.
6. Bu klasörün içinde program.cs adında bir dosya olacak bu otomatik oluşturuluyor. çalıştırmak için **dotnet run** komutunu kullanmamız yeterli olacaktır.

**!!** Ayrıca bu klasörün içinde **MyPractice.csproj** adında bir dosya olacak işte bu kodların hepsini çalıştırma amacımız bu dosyanın oluşturulması, peki ne var bu dosyada? En başta değindiğimiz gibi içinde hangi .NET sürümünü kullanacağımız, konsol uygulaması mı web mi gibi derlenirken mutlaka olması gereken bilgiler var.

Son olarak Visiual Studio'da tek bir cs dosyası açman demek arkada sen görmeden bir proje oluşturulması demektir. VS Code'da ise bunu tek bir cs dosyası açarak yapamayız.

---

## Tür dönüşümleri?
1. İmplicit type conversion => direkt olarak izin verilen bir dönüşümü yapabiliyorsun bu dönüşümde.
Örnek: 
            **byte number = 1;**      (                           00000001)
            **int i = number;**       (00000000 00000000 00000000 00000001)     
      
**!!** Yukarıdaki kodda number ilk önce 1 değeri bir byte'lık bir değişkende tutuluyor. Bu 1 değeri sonrasında int türünde i değişkenine atıyoruz burada herhangi bir memory sorunu olmaz, byte int'dan daha küçük olduğu için veri kaybı olmayacak ve hata almayacağız.



2. Explicit type conversion(casting) => bu veri kaybı sorunundan doğan bir dönüşüm türüdür.
Örnek:
            **int number = 300;**
            **byte i = number;**
**!!** Bu kodda hata var neden mi? byte in alabileceği max değer 255'tir. ama biz bu kodda byte türünde olan i değişkenine 300 değerini atamaya çalışıyoruz veri kaybı oluyor burada program bunu çalıştırmaz hata gösterir bize.

Bu sorunu ortadan kaldırmak için C# dili bize bir seçenek sunuyor eğer biz veri kaybını göze almak istiyorsak değişkenin başına parantez içinde dönüştürüleceği veri tipi yazılır.
Örnek:
            **int number = 300;**
            **byte i = (byte)number;**
            **float f = 1.0f;**
            **int i = (int)f;**

            
3. Conversion between non-compatible types => bazen uyumlu olmayan türler arasında dönüşüm yapmak isteyebiliriz. tabii ki direkt olarak **şu şekilde yapamayız**:
            **string s = "1";**
            **int i = (int)s;**
Convert class ya da Parse methoduyla yapılabilir böyle bir dönüşüm:
Örnek:
            **string s = "1";**
            **int i = Convert.ToInt32(s);** ToByte(), ToInt16()[short], ToInt32()[int], ToInt64()[long]
            **int j = int.Parse(s);**  bu Parse methodu string alır ve onu hedef türe dönüştürür.

---
