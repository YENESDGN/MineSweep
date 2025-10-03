# Mayın Tarlası (C# WinForms)

Klasik Mayın Tarlası oyununu C# ve Windows Forms ile geliştirilmiş basit ve eğlenceli bir masaüstü uygulaması.

## Özellikler
- Kolay anlaşılır arayüz (WinForms)
- Dinamik mayın yerleşimi ve sayaçlar
- Sağ tık ile bayrak yerleştirme, çift tık ile hızlı açma
- Oyun bitti/kazandın durum ekranları

## Ekran Görüntüsü
(Screenshot eklemek için `MayinTarlasi` çalışırken bir görüntü alıp bu bölüme ekleyin.)

## Proje Yapısı
- `MayinTarlasi.sln`: Çözüm dosyası
- `MayinTarlasi/`: WinForms proje klasörü
  - `Form1.cs`, `Form1.Designer.cs`, `Form1.resx`: Ana form ve bileşenler
  - `Program.cs`: Giriş noktası
  - `Properties/`: Derleme, kaynak ve ayarlar
  - `App.config`: Uygulama yapılandırması

## Gereksinimler
- Windows 10/11
- .NET Framework 4.8 (proje `v4.8` hedefliyor)
- Visual Studio 2019/2022 (önerilir)

## Kurulum ve Çalıştırma
1. Bu depoyu klonlayın veya indirin.
2. `MayinTarlasi.sln` dosyasını Visual Studio ile açın.
3. Üst menüden `Build > Build Solution` ile derleyin.
4. `Debug > Start Debugging` (F5) ile çalıştırın.

## Oynanış
- Sol tık: Hücreyi açar.
- Sağ tık: Bayrak koyar/kaldırır.
- Açık bir hücrenin etrafındaki bayrak sayısı, hücrenin sayısına eşitse çift tık ile çevresini hızlıca açabilirsiniz.
- Tüm mayınlar doğru işaretlenip güvenli hücreler açıldığında oyunu kazanırsınız.

## Katkı
- Hata/öneri için `Issues` oluşturun.
- Küçük iyileştirmeler için `Pull Request` gönderebilirsiniz.

## Lisans
Bu proje `MIT` lisansı ile sunulmaktadır. Ayrıntılar için `LICENSE` dosyasına bakın.
