# OverdueDeductionBatch

Bu proje, Oracle veritabanına bağlanarak `APPLY_OVERDUE_DEDUCTIONS` adlı stored procedure’ü çalıştıran basit bir C# batch uygulamasıdır.

Stored procedure, gecikmiş borçları ilgili müşteri bakiyesinden düşer ve `TOTAL_DEBT` alanını sıfırlar.

## Kullanılan Teknolojiler

- C# (.NET)
- Oracle.ManagedDataAccess (ODP.NET)
- Oracle Veritabanı

## Uygulama Akışı

1. Oracle veritabanına bağlantı sağlanır.
2. `APPLY_OVERDUE_DEDUCTIONS` prosedürü çalıştırılır.
3. Console ekranında başarı veya hata mesajı gösterilir.

## Çalıştırma

Veritabanı bağlantısı sağlandıktan sonra aşağıdaki komutla uygulama çalıştırılabilir:

```bash
dotnet run
