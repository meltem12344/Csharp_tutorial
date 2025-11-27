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
