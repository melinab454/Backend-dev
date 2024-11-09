namespace Araştırma_Ödevi;

// 1. Veritabanı ve RDBMS Nedir?
// Veritabanı(Database): Veritabanı, verilerin düzenli bir şekilde depolandığı, yönetildiği ve erişildiği bir sistemdir.Veritabanları, büyük miktarda veriyi saklamak, düzenlemek, erişmek ve güncellemek için kullanılan yazılımlardır.Veritabanları genellikle bir yönetim sistemi aracılığıyla erişilir ve veri üzerinde sorgulama, ekleme, güncelleme ve silme gibi işlemler yapılabilir.

// İlişkisel Veritabanı Yönetim Sistemi (RDBMS): RDBMS, verileri tablolar halinde depolayan ve bu tablolarda yer alan veriler arasında ilişkiler kurarak verileri yöneten bir yazılım sistemidir. İlişkisel veritabanları, verileri satırlarda ve sütunlarda depolar.Bu tablolarda yer alan veriler birbirleriyle ilişkili olabilir ve ilişkiler SQL (Structured Query Language) dilinde sorgulanabilir.

// Temel Özellikler:

// Tablo Yapısı: Veriler, satırlar (kayıtlar) ve sütunlar (alanlar) şeklinde düzenlenir.
// İlişkiler: Tablolar arasındaki ilişkiler, anahtarlar (primary key, foreign key) ile tanımlanır.
// Veri Bütünlüğü: Veri doğruluğunu ve tutarlılığını sağlamak için kurallar ve kısıtlamalar kullanılır.
// SQL Desteği: Veritabanına veri eklemek, güncellemek, sorgulamak ve silmek için SQL kullanılır.
// ACID Özellikleri: Atomiklik, Tutarlılık, İzlenebilirlik (Durum Tutarlılığı), Dayanıklılık gibi veritabanı işlemleriyle ilgili güvenilirlik özellikleri sağlar.
// 2. SQL ve Veri Yönetimi
// SQL (Structured Query Language): SQL, ilişkisel veritabanları ile iletişim kurmak için kullanılan bir sorgulama dilidir.SQL, veri ekleme, silme, güncelleme, sorgulama gibi işlemleri kolaylıkla yapabilmeyi sağlar. Veritabanı yönetim sistemleri (RDBMS) SQL dilini kullanarak veritabanlarını yönetir.

// SQL’in Temel Komutları:

// SELECT: Veritabanındaki verileri sorgulamak için kullanılır.
// INSERT: Yeni veriler eklemek için kullanılır.
// UPDATE: Var olan verileri güncellemek için kullanılır.
// DELETE: Verileri silmek için kullanılır.
// CREATE TABLE: Yeni bir tablo oluşturmak için kullanılır.
// ALTER TABLE: Var olan tabloyu değiştirmek için kullanılır.
// DROP TABLE: Bir tabloyu veritabanından silmek için kullanılır.
// SQL'in Önemi: SQL, veritabanı yönetim sistemlerinin kalbi olduğu için, verilerin sorgulanması ve yönetilmesi için vazgeçilmezdir. Veritabanı yöneticileri ve geliştiriciler SQL kullanarak veritabanlarını oluşturur, bakımını yapar ve sorguları yönetir.

// 3. Dapper Nedir?
// Dapper:
// Dapper, .NET ortamında çalışan, hafif ve hızlı bir Object-Relational Mapping (ORM) aracıdır. SQL sorgularını doğrudan yazmayı ve çalıştırmayı sağlar ancak verileri C# nesnelerine dönüştürmek için hızlı bir yöntem sunar. Dapper, Entity Framework gibi ağır ORM araçlarına göre daha basittir ve performans açısından daha verimlidir.

// Avantajlar:

// Hızlı ve Hafif: Dapper, çok az bellek ve işlem gücü kullanarak veri işlemlerini yapar.
// Doğrudan SQL: ORM katmanını basitleştirir ve geliştiriciye doğrudan SQL yazma özgürlüğü verir.
// Kolay Kullanım: Basit API'lerle, nesnelerle veritabanı işlemleri yapabilmeyi sağlar.
// Performans: Dapper, özellikle büyük veri setleri ile çalışırken yüksek performans sağlar.
// Dezavantajlar:

// Sınırlı Özellikler: Dapper, Entity Framework gibi tam özellikli ORM sistemlerine kıyasla daha az özellik sunar.
// Kodun Yönetimi: SQL sorguları doğrudan yazıldığı için kodun bakımını yapmak zorlaşabilir.
// Veritabanı Bağımlılığı: Dapper, veritabanı şeması ile doğrudan çalıştığı için, şema değişikliklerinde güncellemeler gerekebilir.
// 4. Veri Normalizasyonu
// Veri Normalizasyonu: Veri normalizasyonu, veritabanlarında verinin tekrarlanmasını azaltmak ve veri tutarsızlıklarını önlemek amacıyla veri yapısının düzenlenmesidir. Normalizasyon, veritabanının daha verimli ve tutarlı olmasını sağlar.

// Faydaları:

// Veri Tutarlılığı: Veri tekrarı azaltılır, böylece veri tutarlılığı artırılır.
// Veri Güncellenebilirliği: Verinin güncellenmesi gerektiğinde, sadece bir yerde güncelleme yapılır.
// Depolama Verimliliği: Gereksiz veri tekrarı önlenerek, depolama alanı verimli kullanılır.
// Performans İyileştirmesi: Gereksiz verilerin ortadan kaldırılması, sorgu sürelerinin kısalmasına yardımcı olabilir.
// Normalizasyon Seviyeleri:

// Birinci Normal Form (1NF): Tabloların her bir hücresinin atomik(bölünemez) değerler içermesi gerektiğini belirtir.
// İkinci Normal Form (2NF): 1NF'yi sağlar ve her bir sütunun, anahtar üzerinde tam fonksiyonel bağımlılık göstermesini sağlar.
// Üçüncü Normal Form(3NF) : 2NF'yi sağlar ve bir sütunun, diğer sütunlar tarafından dolaylı yoldan bağımlı olmamasını sağlar.
// 5. SQL Injection Nedir?
// SQL Injection(SQLi) Saldırısı: SQL Injection, kötü niyetli bir kullanıcının, veritabanı sorgularına zararlı SQL kodları enjekte etmesiyle yapılan bir saldırıdır.Bu saldırı, zayıf güvenlik önlemleriyle korunmayan uygulamalarda SQL sorgularına müdahale ederek, hassas verilere erişmeye veya veri manipülasyonu yapmaya olanak sağlar.

// Korunma Yöntemleri:

// Hazırlanmış İfadeler (Prepared Statements): SQL sorgularını dinamik olarak oluşturmak yerine, sorguları önceden tanımlanmış şekilde hazırlamak.
// Parametreli Sorgular: Kullanıcı giriş verilerini doğrudan SQL sorgusuna eklemek yerine, parametreli sorgular kullanarak SQL enjeksiyonuna karşı koruma sağlamak.
// Veri Doğrulama ve Temizleme: Kullanıcı girişlerini doğrulamak ve geçerli veriler dışında bir şey kabul etmemek.
// En Az Yetki İlkesi (Least Privilege): Veritabanı kullanıcısının yalnızca ihtiyacı olan verilere erişim hakkı olması sağlanmalıdır.
// Hata Mesajlarını Gizleme: Detaylı hata mesajları, saldırganların sistem hakkında bilgi edinmesine yardımcı olabilir, bu yüzden hata mesajları sınırlandırılmalıdır.
// SQL Injection, güvenlik açıklarını kullanarak veritabanı sistemine zarar verebileceği için çok ciddi bir güvenlik tehdidi oluşturur.
