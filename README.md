# KELAS XI RPL

Kumpulan materi, latihan, dan tugas untuk kelas XI Rekayasa Perangkat Lunak (RPL).

## Struktur repository

- `kelas/` — latihan dan materi pembelajaran harian.
- `tugas/lks/` — tugas LKS dan proyek latihan.
- `tugas/rumah-pdf/` — tugas rumah dan referensi PDF.
- `proyek/video/` — proyek yang mengikuti materi video, termasuk Windows Forms.

## Teknologi

Sebagian besar materi menggunakan C# dan .NET, termasuk proyek Console dan Windows Forms. Beberapa proyek dapat memakai Visual Studio serta NuGet.

## Cara menjalankan proyek .NET

1. Buka file `.sln` atau `.slnx` dari latihan yang ingin dijalankan di Visual Studio.
2. Pulihkan dependensi NuGet bila diminta.
3. Pilih proyek sebagai *Startup Project*, lalu tekan `F5`.

Untuk proyek berbasis .NET SDK, alternatifnya:

```bash
dotnet restore
dotnet run
```

## Kontribusi

Gunakan pesan commit yang menjelaskan perubahan, misalnya `feat: tambah latihan percabangan` atau `docs: perbarui panduan tugas`. Jangan commit folder build atau pengaturan lokal IDE; aturan ini tersedia di `.gitignore`.

## Catatan

Repository ini berisi materi pembelajaran. Setiap tugas dapat memiliki dependensi, konfigurasi, dan instruksi sendiri.
