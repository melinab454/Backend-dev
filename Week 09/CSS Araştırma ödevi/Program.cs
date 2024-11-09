using System.Runtime.InteropServices;

namespace CSS_Araştırma_ödevi;

// ___CSS Seçicileri ve Kullanımı___

// Temel Seçiciler: 
    
// 1. Element Seçicisi
// Element seçicisi, belirli bir HTML etiketine göre stil uygular.Örneğin, tüm<p> etiketlerine stil uygulamak için:

p
 {
    color: blue;
    font-size: 16px;
}
  
// Bu stil, sayfadaki tüm paragrafların metin rengini mavi yapar ve yazı boyutunu 16 piksel olarak ayarlar



// 2.Class Seçicisi
// Class seçicisi, belirli bir sınıfa sahip olan öğelere stil uygular. Class adı, bir noktadan (.) sonra yazılır. Örneğin, .highlight sınıfına sahip öğelere stil uygulamak için:


.highlight
{
    background-color: yellow;
font - weight: bold;
}
// Bu stil, class= "highlight" olan tüm öğelerin arka planını sarı yapar ve metni kalınlaştırır.



// 3.ID Seçicisi
// ID seçicisi, belirli bir ID'ye sahip olan öğelere stil uygular. ID adı, bir kesik çizgiden (#) sonra yazılır. Örneğin, #main-title ID'sine sahip öğeye stil uygulamak için:


#main-title 
{
    font - size: 24px;
    text - align: center;
}
//    Bu stil, id = "main-title" olan öğenin yazı boyutunu 24 piksel yapar ve metni ortalar.

// Özet
// Element Seçicisi: Belirli bir HTML etiketini seçer (örneğin, p).
// Class Seçicisi: Belirli bir sınıfa sahip öğeleri seçer (.class).
// ID Seçicisi: Belirli bir ID'ye sahip öğeleri seçer (#id).
// Bu seçiciler, CSS ile web sayfalarını stilize etmek için oldukça etkilidi



// Birleşik Seçiciler: 


// 1.Element Seçici
// Belirli bir HTML elementini seçmek için kullanılır. Örneğin, p tüm paragrafları seçer.

Örnek:

p
{
color: blue;
}

// Bu kod, tüm <p> etiketlerinin metin rengini mavi yapar.

// 2. Class Seçici
// Bir sınıf adı ile belirli öğeleri seçer. Sınıf adı, öğenin class niteliğiyle belirtilir ve önüne nokta (.) konur.
 
.highlight
{
    background-color: yellow;
}

// Bu kod, class= "highlight" olan tüm öğelerin arka plan rengini sarı yapar.

// 3. ID Seçici
// Belirli bir öğeyi seçmek için kullanılır. Her öğe için benzersiz olmalıdır ve önüne # sembolü konur.

Örnek:

# header 
{
    font - size: 24px;
}

// Bu kod, id="header" olan öğenin yazı boyutunu 24 piksel yapar.

// Birleşik Seçiciler
// Birden fazla seçicinin bir araya gelmesiyle oluşturulur. Bu, belirli öğeleri daha spesifik bir şekilde hedeflemeyi sağlar.

// 1. Element ve Class Birleşik Seçici
// Belirli bir elementin belirli bir sınıfa sahip olduğunu seçer.

p.highlight
{
    font - weight: bold;
}

// Bu kod, class= "highlight" olan tüm<p> etiketlerinin yazı tipini kalın yapar.

// 2. Element ve ID Birleşik Seçici
// Belirli bir elementin belirli bir ID’ye sahip olduğunu seçer.

div#main 
{
    padding: 20px;
}

// Bu kod, id = "main" olan <div> etiketine 20 piksel dolgu ekler.

// 3. Class ve ID Birleşik Seçici
// Bir sınıfa ve bir ID’ye sahip öğeleri seçer.

#footer .link 
{
color: green;
}

// Bu kod, id = "footer" olan öğenin içinde bulunan class= "link" olan tüm öğelerin metin rengini yeşil yapar.

// Sonuç
// Bu seçiciler, CSS ile sayfa stilini kontrol etmenin temel yollarıdır. Birleşik seçiciler, daha karmaşık stiller oluşturmak için güçlü bir araçtır.


// Pseudo class: 

// 1.
// Öğenin fare ile üzerine gelindiğinde uygulanacak stilleri tanımlar. Genellikle bağlantılar ve butonlar gibi etkileşimli öğelerde kullanılır.

Örnek:

a: hover
{
color: red;
    text - decoration: underline;
}
// Bu kod, fare bağlantının üzerine geldiğinde metin rengini kırmızı yapar ve altını çizer.


// 2.
// Kullanıcı bir öğe üzerinde odaklandığında (örneğin, bir form alanına tıkladığında) uygulanacak stilleri belirler. Klavye navigasyonu veya tıklama ile tetiklenebilir.

Örnek:


input: focus
{
border: 2px solid blue;
    background - color: lightyellow;
}
// Bu kod, bir form alanı üzerine odaklandığında (tıklandığında veya klavye ile seçildiğinde) kenarlığını mavi yapar ve arka plan rengini açık sarı yapar.

// 3.
// Bir öğe tıklanırken veya aktifken uygulanacak stilleri tanımlar. Genellikle butonlar ve bağlantılar için kullanılır.

Örnek:


button: active
{
    background - color: darkgray;
transform: translateY(2px);
}
// Bu kod, bir butona tıklandığında arka plan rengini  gri yapar ve butonu biraz aşağı doğru kaydırır.

// Kullanım Birliktelikleri
// Bu pseudo-class’lar genellikle birlikte kullanılabilir, böylece bir öğenin farklı durumları için stiller tanımlanabilir.

// Örnek:


a
 {     color: blue; koyu
text - decoration: none; }

 a: hover
 {
color: red;
}

a: focus
 {
outline: 2px dashed orange;
}

a: active
 {
color: green;
}
// Bu kodda, bağlantı normalde mavi renkte görünür, fare ile üzerine gelindiğinde kırmızı olur, odaklandığında turuncu kesik bir çerçeve alır ve tıklandığında yeşil renge dönüşür.

// Özet
// Pseudo-class seçicileri, kullanıcı etkileşimlerine yanıt vermek için stil tanımlarken çok kullanışlıdır. Bu sayede, web sayfalarında daha dinamik ve kullanıcı dostu bir deneyim oluşturabilirsiniz.















// ___Box Model ve Layout___

// Box Model:

// CSS'de kutu modeli (box model), bir öğenin nasıl görüntülendiğini ve etkileşimde bulunduğunu tanımlayan dört temel bileşenden oluşur: içerik, padding (iç boşluk), border (kenar) ve margin (dış boşluk). 

// 1. Content (İçerik)
// Bu, öğenin kendisi olan içeriği temsil eder. Metin, resimler veya diğer HTML öğeleri içerir. İçerik alanı, width ve height özellikleriyle kontrol edilir.

// 2. Padding (İç Boşluk)
// Padding, içerikle kenar arasında bulunan boşluktur. Padding, içeriğin etrafında yer alır ve öğenin arka plan rengini etkiler. Padding, her dört kenar (üst, sağ, alt, sol) için ayrı ayrı ayarlanabilir.

Örnek:
.box
{
padding: 20px;
}

// 3.Border(Kenar)
// Border, öğenin dış kenarını temsil eder. Border, padding ve margin arasında yer alır. Kenar, kalınlığı, stili ve rengi ile kontrol edilir.

Örnek:

.box
{
border: 2px solid black;
}

// 4.Margin(Dış Boşluk)
// Margin, öğenin dışındaki boşluktur. Margin, öğenin etrafındaki diğer öğelerle olan mesafeyi belirler ve öğenin arka plan rengini etkilemez. Margin de her kenar için ayrı ayrı ayarlanabilir.

Örnek:
.box
 {
margin: 15px;
}

// Box Model Diyagramı
// Aşağıda bir kutu modeli diyagramı gösterilmektedir:

+---------------------------+

| Margin |

| +---------------------+  |

|  | Border |  |

|  | +-------------+    |  |

|  |  | Padding |    |  |

|  |  | +---------+ |    |  |

|  |  | | Content | |    |  |

|  |  | +---------+ |    |  |

|  | +-------------+    |  |

| +---------------------+  |
+---------------------------+


// Örnek Kullanım
// Tam bir örnek üzerinden açıklayacak olursak:

.box
{
width: 200px;            /* İçerik genişliği */
height: 100px;          /* İçerik yüksekliği */
padding: 20px;          /* İç boşluk */
border: 2px solid black; /* Kenar */
margin: 15px;           /* Dış boşluk */
    background - color: lightgray; /* Arka plan rengi */
}

// Bu durumda, öğe toplamda 200px + 220px (padding) + 22px (border) + 2*15px (margin) genişliğinde ve yüksekliğinde yer kaplayacaktır.

// özet
// Kutu modeli, CSS ile tasarım yaparken öğelerin nasıl yerleştirileceğini ve boyutlandırılacağını anlamak için temel bir kavramdır. İçerik, padding, border ve margin arasındaki ilişkileri bilmek, etkili bir stil oluşturmanıza yardımcı olur.


// Display Özellikleri:
// 1.Block
// block öğeleri, yeni bir satırda başlar ve tüm genişliği kaplar. Bir block öğesi, yukarıdaki ve aşağıdaki öğelerle arasında boşluk bırakır.

Örnek:
< div class= "block" > Block Element </ div >
< div class= "block" > Another Block Element</>

.block
{
    display: block;
background - color: lightblue;
margin: 10px 0;
padding: 10px;
}

// 2.Inline
// inline öğeleri, satır içinde diğer öğelerle birlikte görünür. Yalnızca içeriği kadar genişlik kaplar ve üstte ve altta boşluk bırakmaz.

Örnek:

< span class= "inline" > Inline Element 1</>
<span class= "inline" > Inline Element 2</span>
 

.inline 
{
    display: inline;
background - color: lightgreen;
padding: 5px;
}


// 3.Inline - Block
// inline - block, inline öğelerin özelliklerini taşırken, block öğeleri gibi genişlik ve yükseklik ayarlarına izin verir. Yani, yan yana görünürler, ancak boyutları kontrol edilebilir.

Örnek:
< div class= "inline-block" > Inline Block 1</>
<div class= "inline-block" > Inline Block 2</div>

.inline-block 
{
    display: inline - block;
background - color: lightcoral;
width: 100px;
height: 50px;
margin: 5px;
}



// 4.None
// none, öğeyi tamamen gizler. Sayfada yer kaplamaz ve görünmez hale gelir.

Örnek:

< div class= "none" > This will be hidden</>

.none
 {
    display: none;
}


//  Tam Örnek
// Aşağıda tüm bu öğeleri bir arada gösteren bir örnek bulunmaktadır:


< !DOCTYPE html >
< html lang = "tr" >
< head >
    < meta charset = "UTF-8" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < title > Display Types </ title >
    < style >
        .block
        {
display: block;
    background - color: lightblue;
margin: 10px 0;
padding: 10px;
}
        .inline
        {
            display: inline;
background - color: lightgreen;
padding: 5px;
        }
        .inline - block
        {
display: inline - block;
    background - color: lightcoral;
width: 100px;
height: 50px;
margin: 5px;
}
        .none {

            display: none;
        }
    </ style >
</ head >
< body >

    < div class= "block" > Block Element 1</>
    <div class= "block" > Block Element 2</div>

    <span class= "inline" > Inline Element 1</span>
    <span class= "inline" > Inline Element 2</span>

    <div class= "inline-block" > Inline Block 1</div>
    <div class= "inline-block" > Inline Block 2</div>

    < class= "none" > This element is hidden.</ div >

</ body >
</ html >


// Özet
// Bu örnek, block, inline, inline-block ve none değerlerinin nasıl çalıştığını ve her birinin sayfadaki yerleşimini gösterir. Bu değerler, öğelerin düzenini ve etkileşimini kontrol etmek için kritik öneme sahiptir





// Positioning

// CSS'de position özelliği, bir öğenin sayfadaki konumunu belirler. İşte static, relative, absolute, fixed ve sticky değerlerinin açıklamaları ve kullanımı:

// 1.Static
// Açıklama: Varsayılan konumlandırma türüdür.Öğeler, normal akışa göre yer alır ve top, right, bottom, left gibi özellikler etkisizdir.
// Ne Zaman Kullanılır: Öğelerin standart akışta yer alması gerektiğinde kullanılır. Örneğin, sayfadaki başlıklar veya paragraflar gibi.

// 2. Relative
// Açıklama: Öğenin normal konumuna göre konumlandırılmasını sağlar. top, right, bottom, veya left kullanılarak öğe bulunduğu yerden kaydırılabilir, ancak diğer öğeler bu kaydırmayı dikkate almaz.
// Ne Zaman Kullanılır: Diğer öğeleri referans alarak iç içe yerleştirmek veya bir öğeyi biraz kaydırmak gerektiğinde kullanılır. Örneğin, bir başlığın altında yer alan içeriği yukarı doğru kaydırmak.

// 3. Absolute
// Açıklama: Öğeyi en yakın position özelliği tanımlı olan üst öğeye göre konumlandırır. Sayfanın akışından bağımsızdır ve belirtilen konumda görünür.
// Ne Zaman Kullanılır: Belirli bir noktada görünmesi gereken öğeler için kullanılır. Örneğin, açılır menüler veya araç ipuçları gibi öğeleri konumlandırmak için idealdir.

// 4. Fixed
// Açıklama: Öğeyi tarayıcı penceresine göre konumlandırır; sayfa kaydırıldığında yerini korur. Diğer öğelere bağlı değildir.
// Ne Zaman Kullanılır: Sayfanın üstünde veya altında sabit kalacak öğeler (örneğin, sabit başlıklar veya alt bilgiler) için kullanılır.

// 5. Sticky
// Açıklama: Öğeyi "yapışkan" bir şekilde konumlandırır. Kullanıcı sayfayı kaydırdığında belirli bir kaydırma noktasına ulaştığında relative konumundan fixed konumuna geçer.
// Ne Zaman Kullanılır: Kullanıcı sayfayı kaydırdığında belirli bir noktada yapışık kalması gereken başlıklar veya menüler için kullanılır. Örneğin, sayfanın üst kısmında kalması gereken bir navigasyon menüsü.


// Özet
// Her bir konumlandırma türü, farklı durumlarda kullanışlıdır ve tasarımda esneklik sağlar. Hangi türün kullanılacağı, projenizin ihtiyaçlarına ve öğelerin nasıl etkileşimde bulunması gerektiğine bağlıdır. Bu konumlandırma türlerini iyi anlamak, web sayfalarınızı daha etkili bir şekilde tasarlamanıza yardımcı olur.















// ____Renkler ve Arka Planlar___

// RENKLER
// 1.Renk Özellikleri
// a.color
// Açıklama: Metin rengini belirler.

Kullanım:

p
{
    color: blue; /* Metin rengi mavi */
}

// b.background - color
// Açıklama: Öğenin arka plan rengini belirler.
Kullanım:

div
{
    background - color: lightgray; /* Arka plan rengi açık gri */
}

// 2.Renk Değerleri
// a.Hex(Hexadecimal)
// Açıklama: Renk kodları, # sembolü ile başlar ve ardından altı haneli (örn. #RRGGBB) bir değer gelir. RR kırmızı, GG yeşil ve BB mavi renk bileşenlerini temsil eder.
Örnek:

color: #ff5733; /* Kırmızımsı turuncu */

// b.RGB(Red, Green, Blue)
// Açıklama: Renkler, rgb(red, green, blue) fonksiyonu kullanılarak tanımlanır. Her bir renk bileşeni 0 ile 255 arasında bir değer alır.
Örnek

color: rgb(255, 87, 51); /* Kırmızımsı turuncu */


// c.HSL(Hue, Saturation, Lightness)
// Açıklama: Renk, hsl(hue, saturation %, lightness %) fonksiyonu ile tanımlanır. Hue, 0-360 derece arasında renk tonunu; saturation, renk doygunluğunu; lightness ise parlaklığı temsil eder.
Örnek
color: hsl(14, 100 %, 60 %); /* Kırmızımsı turuncu */




// 3.Renk Seçimi için Kısa Rehber
// a. Renk Teorisi
// Renk Çemberi: Renkler arasındaki ilişkileri anlamak için kullanın. Tamamlayıcı renkler (zıt) veya analojik renkler (yan yana) kullanarak estetik tasarımlar oluşturabilirsiniz.
// b. Doygunluk ve Parlaklık
// Renklerin doygunluğunu ve parlaklığını ayarlayarak farklı duygusal etkiler yaratabilirsiniz. Daha doygun renkler enerjik, daha soluk renkler ise sakin bir his verebilir.
// c. Renk Paletleri
// Renk paletleri oluşturun. Belirli bir tema veya his vermek için 3-5 renk seçin. Örneğin, ana renk, tamamlayıcı renk ve tonlar.
// d. Erişilebilirlik
// Renk kontrastına dikkat edin. Yazı ve arka plan renkleri arasında yeterli kontrast sağlamak, metnin okunabilirliğini artırır. WCAG standartlarına uygun kontrast oranını sağlamak önemlidir.
// e. Deneme ve Yanılma
// Farklı renk kombinasyonlarını deneyin. CSS renk seçim araçları veya online palet oluşturucular kullanarak farklı kombinasyonları görselleştirebilirsiniz.


Örnek Uygulama
// Aşağıda renk özelliklerini ve değerlerini gösteren basit bir HTML ve CSS örneği:


<!DOCTYPE html>
<html lang = "tr" >
< head >
    < meta charset= "UTF-8" >
    < meta name= "viewport" content= "width=device-width, initial-scale=1.0" >
    < title > Renk Özellikleri</>
    <>
        body
        {
            background-color: #f0f0f0; /* Sayfa arka plan rengi */
            font - family: Arial, sans-serif;
        }
        h1
         {
            color: rgb(34, 139, 34); /* Orman yeşili */
        }
        p
        {
            color: hsl(210, 50 %, 50 %); /* Orta mavi */
background - color: #ffffff; /* Beyaz arka plan */
            padding: 10px;
border - radius: 5px;
        }
        .highlight
        {
            background-color: #ffeb3b; /* Sarı arka plan */
            color: #000000; /* Siyah metin */
        }
    </ style >
</ head >
< body >

    < h1 > Renk Özellikleri </ h1 >
    < p > Bu bir paragrafa örnek.</>
    <p class= "highlight" > Bu paragrafa vurgulama eklenmiştir.</p>

</body>
</html>




// ÖZET
// Renkler, web tasarımında önemli bir rol oynar ve doğru kullanımla görsel estetik sağlanabilir. Renklerin doğru seçimi, kullanıcı deneyimini ve erişilebilirliği artırır.



//___Yazı Tipleri ve Metin Stilleri___
// -Font Özellikleri-
// 1. font-family
// Açıklama: Yazı tipini belirler. Birden fazla yazı tipi belirtilerek, ilk bulunan yazı tipinin kullanılması sağlanabilir.

p 
{
    font-family: 'Arial', sans - serif; /* Arial yazı tipini kullanır, yoksa sans-serif ailesinden bir yazı tipi seçer */
}

// 2.font - size
// Açıklama: Yazı tipinin boyutunu ayarlar. Boyut, px, em, rem, veya % gibi birimler kullanılarak belirlenebilir.

h1
{
    font-size: 2em; /* Başlık 2 katı normal yazı boyutunda olur */
}

// 3.font - weight
// Açıklama: Yazı tipinin kalınlığını belirler. normal, bold, bolder, lighter veya 100-900 arasında sayısal değerler alabilir.

strong
{
    font-weight: bold; /* Kalın yazı tipi kullanır */
}

// 4.font - style
// Açıklama: Yazı tipinin stilini ayarlar. normal, italic, veya oblique gibi değerler alabilir.

em
{
    font-style: italic; /* İtalik yazı stili uygular */
}


// 5.line - height
// Açıklama: Satır yüksekliğini belirler.Bu özellik, metin bloğundaki satırlar arasındaki boşluğu kontrol eder. Genellikle sayılar veya birimler (px, em) ile belirlenir.

body
{
    line-height: 1.5; /* Satır yüksekliğini normal boyutun 1.5 katı olarak ayarlar */
}


// Örnek CSS Kullanımı
// h1 
// {
//     font-family: 'Georgia', serif;
// font - size: 2.5em;
// font - weight: bold;
// font - style: normal;
// line - height: 1.2;
// }

// p
// {
// font-family: 'Arial', sans - serif;
// font - size: 1em;
// font - weight: normal;
// font - style: italic;
// line - height: 1.5;
// }

// -Metin Sitileri-

h2
{
    text - align: center; /* Başlık ortalanır */
}

h1
{
    text-transform: uppercase; /* Başlık tamamen büyük harf olur */
}

a
 {
    text-decoration: underline; /* Bağlantının altı çizilir */
}

p
{
    letter-spacing: 1px; /* Paragraftaki harfler arasına 1 piksel boşluk eklenir */
}


// ___Kapsayıcı ve Kenarlık Özellikleri____

// -Kenarlık-



// 1.border
// Açıklama: Kenarlığın genel tanımını yapar. Kenarlığın genişliği, stili ve rengi bir arada belirlenebilir.


div
 {
    border: 2px solid black; /* 2 piksel kalınlığında, düz (solid) ve siyah bir kenarlık */
}

// 2.border - radius
// Açıklama: Kenarların yuvarlaklığını ayarlar.Piksel veya yüzde cinsinden değer alabilir.

button
{
    border-radius: 10px; /* Kenarları 10 piksel yuvarlak yapar */
}

// 3.border - width
// Açıklama: Kenarlığın kalınlığını belirler.Piksel cinsinden değer alabilir. Farklı kenarlar için farklı kalınlıklar da ayarlanabilir.

h1
{
    border-width: 5px 0; /* Üst ve alt kenar 5 piksel, sağ ve sol kenar 0 piksel kalınlığında */
}
// 4.border - style
// Açıklama: Kenarlığın stilini belirler.none, solid, dashed, dotted, double, groove, ridge, inset, outset gibi değerler alabilir.

p
{
    border-style: dashed; /* Kesik çizgi stilinde kenarlık */
}
// 5.border - color
// Açıklama: Kenarlığın rengini belirler.Renk adı, hex kodu veya rgb/rgba formatında değer alabilir.

section
 {
    border-color: blue; /* Kenarlık rengi mavi */
}

// -Kutunun Kenarları-

// 1.Margin
// Tanım: Bir öğenin dışındaki boşlukları tanımlar. Diğer öğelerle arasındaki mesafeyi ayarlamak için kullanılır.
// Kullanım: Dışarıdan gelen alan, yani kenar boşluğu sağlar.
// 2. Padding
// Tanım: Bir öğenin içindeki boşluğu tanımlar. İçerikle kenar arasındaki mesafeyi ayarlamak için kullanılır.
// Kullanım: İçerik ile kenar arasındaki alan, yani iç boşluk sağlar.
// 3. Border
// Tanım: Bir öğenin çevresinde görünen çizgi veya çerçevedir. Kenarlığın kalınlığını, stilini ve rengini ayarlamak için kullanılır.
// Kullanım: Öğenin etrafında görsel bir sınır oluşturur.
// örnek
.box
{
margin: 20px;  /* Kutunun dışındaki boşluk (20 piksel) */
padding: 15px;  /* Kutunun içindeki boşluk (15 piksel) */
border: 2px solid black; /* Kutunun çevresinde 2 piksel kalınlığında düz siyah kenarlık */
background - color: lightgray; /* Kutunun arka plan rengi */
}

// ___Responsive Design(Duyarlı Tasarım)____

// -Media Queries-


// Kullanım
// @media kuralı, belirli bir koşulun sağlanması durumunda uygulanacak stil kurallarını tanımlamak için kullanılır. Genellikle ekran genişliği, yüksekliği, çözünürlüğü gibi özellikler üzerinden koşul tanımlanır.

// Genel Sözdizimi

@media(koşul)
{
    /* Stil kuralları burada */
}

// Örnek Kullanımlar
// 1. Ekran Genişliği
// Aşağıdaki örnekte, ekran genişliği 600 pikselden küçük olduğunda h1 başlık boyutu değişir.


h1
{
    font-size: 24px; /* Normal boyut */
}

@media(max - width: 600px)
{
    h1
    {
        font - size: 18px; /* Ekran 600 pikselden küçükse boyut 18 piksel olur */
    }
}
// 2.Çoklu Koşullar
// Aşağıdaki örnekte, hem genişlik hem de yükseklik için koşullar belirlenmiştir.


@media(max - width: 800px) and(max - height: 600px)
{
    body
    {
        background - color: lightblue; /* Ekran 800x600 pikselden küçükse arka plan rengi mavi olur */
    }
}
// 3.Cihaz Yönelimi
// Cihazın dikey veya yatay konumuna göre stil değişiklikleri yapmak da mümkündür.


@media(orientation: landscape)
{
    .container
    {
        flex - direction: row; /* Yatayda kutuları yan yana diz */
    }
}

@media(orientation: portrait)
{
    .container
    {
        flex - direction: column; /* Dikeyde kutuları üst üste diz */
    }
}


// -Viewport Units-


// 1.vw(viewport width)
// Tanım: Viewport'un genişliğinin yüzde birini temsil eder. Örneğin, 1vw değeri, viewport'un toplam genişliğinin %1'ine eşittir.
// Kullanım: Genellikle genişliği ayarlamak için kullanılır.
// Örnek:

h1
{
    font-size: 5vw; /* Ekran genişliğinin %5'i kadar font boyutu */
}
// 2.vh(viewport height)
// Tanım: Viewport'un yüksekliğinin yüzde birini temsil eder. 1vh, viewport'un toplam yüksekliğinin %1'ine eşittir.
// Kullanım: Genellikle yüksekliği ayarlamak için kullanılır.
// Örnek:


section
 {
    height: 50vh; /* Ekran yüksekliğinin %50'si kadar yükseklik */
}
// 3.vmin
// Tanım: Viewport'un genişliği veya yüksekliğinden hangisi daha küçükse onun yüzde birini temsil eder. Yani, 1vmin, en küçük boyutun %1'ine eşittir.
// Kullanım: Duyarlı tasarımlarda, en küçük boyutla orantılı öğeler için idealdir.
// Örnek:


.box
{
    width: 20vmin; /* En küçük boyutun %20'si kadar genişlik */
height: 20vmin; /* En küçük boyutun %20'si kadar yükseklik */
}
// 4.vmax
// Tanım: Viewport'un genişliği veya yüksekliğinden hangisi daha büyükse onun yüzde birini temsil eder. Yani, 1vmax, en büyük boyutun %1'ine eşittir.
// Kullanım: Duyarlı tasarımlarda, en büyük boyutla orantılı öğeler için idealdir.
// Örnek:


.header
{
    font-size: 10vmax; /* En büyük boyutun %10'u kadar font boyutu */
}