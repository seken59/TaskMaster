# TaskMaster

TaskMaster, Windows için hedeflenmiş modern bir görev yönetimi uygulamasıdır. Amaç, Microsoft Store'a paketlenip yayınlanabilecek, gösterilebilir bir proje sunmaktır — bu sayede Microsoft Developer hesabı yenileme sürecinde güçlü bir faaliyet kanıtı sağlanır.

Özellikler (minimum uygulanacak):
- Görev oluşturma / düzenleme / silme
- Görev listesi, filtreleme (tümü, tamamlanan, tamamlanmamış)
- Basit lokal veri depolama (SQLite veya JSON)
- MSIX ile paketlenebilir Windows uygulaması (WinUI 3 veya .NET MAUI seçenekleri)
- Opsiyonel: Azure Functions + Cosmos DB veya Table Storage ile senkronizasyon

Teknoloji seçeneği (öneri):
- UI: WinUI 3 (Windows App SDK) veya .NET MAUI (Windows hedefi)
- Backend (opsiyonel): Azure Functions + Cosmos DB
- Paketleme: MSIX / MSIX Bundle
- CI/CD: GitHub Actions (build + unit tests + pack)

Hızlı başlangıç (dev ortamı):
1. Gereksinimler:
   - Windows 10/11
   - Visual Studio 2022/2023 (Desktop development with C++ ve Universal Windows Platform / Windows App SDK workload)
   - .NET 7+ SDK (veya proje hedefi ne ise)
   - Windows App SDK (WinUI 3)
2. Repo'yu klonla ve çözümü Visual Studio'da aç:
   - git clone <repo-url>
   - Visual Studio ile aç, gerekli workload'ları yükle
3. İlk çalıştırma:
   - Debug yapılandırmasında çalıştır ve MainWindow'a eriş

Yayınlama (özet):
- MSIX paket oluştur: Visual Studio -> Project -> Create App Packages... veya MSIX Packaging Tool
- Store başvurusu: Uygulama > Yeni uygulama > paket yükle
- Gerekenler: Gizlilik politikası, destek URL'si, uygulama açıklaması, ikonlar, açıklama ekran görüntüleri

Geliştirme süreci önerisi:
- Sprint 1 (1 hafta): Temel CRUD + local storage + UI
- Sprint 2 (1 hafta): Filtreleme, arama, basit tests
- Sprint 3 (1 hafta): MSIX paketleme, CI setup
- Sprint 4 (1 hafta): Azure sync (opsiyonel) + final polish + release hazırlığı

İletişim:
Projeyi GitHub'da tut ve her sprint sonunda bir release oluştur — bu Microsoft tarafına aktif geliştirme kanıtı olarak gösterilebilir.