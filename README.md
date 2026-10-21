# Yurt Otomasyonu

C# Windows Forms ve SQL Server ile geliştirilmiş yurt yönetim otomasyonu (NTP dersi projesi).

## Özellikler

- **Yönetici:** öğrenci ekleme, düzenleme ve silme; oda düzenleme ve doluluk durumu; aidat işlemleri; giderler; duyuru ve etkinlik yönetimi; talep ve şikâyetleri yanıtlama; kullanıcı yönetimi
- **Öğrenci:** profil bilgileri, aidat durumu, duyurular, etkinlik takvimi, talep ve şikâyet gönderme, şifre değiştirme

## Gereksinimler

- Visual Studio (.NET Framework 4.6.1)
- SQL Server (Windows kimlik doğrulaması)
- DevExpress WinForms 18.1

## Kurulum

1. SQL Server'da `Yurt_Otomasyonu` adında bir veritabanı oluşturun ve tabloları ekleyin.
2. Uygulama yerel SQL Server örneğine (`Data Source=.`) bağlanır. Farklı bir sunucu kullanıyorsanız formlardaki ve `App.config` içindeki bağlantı cümlelerini değiştirin.
3. `YurtOtomasyonu.sln` dosyasını Visual Studio'da açıp çalıştırın.

`YurtOtomasyonu/Setup1` klasörü, uygulamanın kurulum (MSI) projesidir.
