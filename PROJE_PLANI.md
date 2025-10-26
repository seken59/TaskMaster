# Proje Planı — TaskMaster

Hedef: 4 haftada Microsoft Store'a yüklenebilecek (veya en az MSIX oluşturulabiliyor) bir uygulama ortaya koymak.

Kilometre Taşları:
- M1: Temel UI + görev CRUD + local persist (7 gün)
  - Acceptance: Görev ekleme/düzenleme/silme, veri disk üzerinde kalıcı olmalı
- M2: Filtreleme + arama + unit test (7 gün)
  - Acceptance: Filtreleme çalışmalı, 5+ unit test
- M3: MSIX paketleme + GitHub Actions build (7 gün)
  - Acceptance: CI her commit'te build ediyor, paket üretilebiliyor
- M4: Azure senkronizasyon + yayın hazırlığı (7 gün)
  - Acceptance: Opsiyonel senkronizasyon çalışıyor, Store adayı paketle hazır

Microsoft Developer hesabı için kanıt önerileri:
- Düzenli commit geçmişi (günde veya haftada commit)
- Açık issue ve pull requestler
- CI geçmişi (successful workflow runs)
- En az bir release (v0.1.0) ve Store paketinin ekran görüntüleri
