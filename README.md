# Mayın Tarlası

Klasik Mayın Tarlası oyununun C# ile geliştirilmiş masaüstü uygulaması.

## Sürümler

### Avalonia (Cross-Platform) - Önerilen
Modern, responsive tasarımlı ve **Linux, Windows, macOS** üzerinde çalışan sürüm.

**Klasör:** `MayinTarlasi.Avalonia/`

**Özellikler:**
- Cross-platform (Linux, Windows, macOS)
- Modern ve flat tasarım
- Responsive arayüz
- Koyu tema
- Animasyonlu butonlar
- 68 hücre, 15 mayın

**Gereksinimler:**
- .NET 8.0 SDK

**Çalıştırma:**
```bash
cd MayinTarlasi.Avalonia
dotnet restore
dotnet run
```

### WinForms (Sadece Windows)
Orijinal Windows Forms sürümü.

**Gereksinimler:**
- Windows 10/11
- .NET Framework 4.8
- Visual Studio 2019/2022

**Çalıştırma:**
1. `MayinTarlasi.sln` dosyasını Visual Studio ile açın.
2. `Build > Build Solution` ile derleyin.
3. `Debug > Start Debugging` (F5) ile çalıştırın.

## Oynanış
- Hücrelere tıklayarak mayın arayın
- Yeşil = Güvenli hücre
- Kırmızı = Mayın bulundu
- 15 mayını bulduğunuzda oyunu kazanırsınız
- "Yeni Oyun" butonu ile yeniden başlayabilirsiniz

## Proje Yapısı
```
MayinTarlasi/
├── MayinTarlasi.Avalonia/     # Cross-platform sürüm
│   ├── MainWindow.axaml       # Ana pencere UI
│   ├── MainWindow.axaml.cs    # Oyun mantığı
│   ├── Styles.axaml           # Modern stiller
│   └── ...
├── Form1.cs                   # WinForms sürümü
├── Form1.Designer.cs
└── MayinTarlasi.sln
```

## Katkı
- Hata/öneri için `Issues` oluşturun.
- Küçük iyileştirmeler için `Pull Request` gönderebilirsiniz.

## Lisans
Bu proje `MIT` lisansı ile sunulmaktadır. Ayrıntılar için `LICENSE` dosyasına bakın.
