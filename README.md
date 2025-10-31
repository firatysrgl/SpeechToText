\# 🗣️ Speech-to-Text (C# Windows Forms)



Bu proje, \*\*C#\*\* kullanılarak geliştirilen bir \*\*konuşma tanıma (speech-to-text)\*\* uygulamasıdır.  



Amaç, mikrofon aracılığıyla konuşulan kelimeleri gerçek zamanlı olarak algılayıp \*\*metne dönüştürmek\*\* ve kullanıcıya anında ekranda göstermektir.  



Proje, \*\*System.Speech.Recognition\*\* kütüphanesini kullanarak Windows işletim sisteminin yerleşik konuşma tanıma altyapısından yararlanır.



-----------------------------------



\## 🚀 Özellikler



\- 🎙️ Mikrofon aracılığıyla ses girişi  

\- 🧠 Microsoft Speech Recognition Engine kullanımı  

\- 📝 Gerçek zamanlı olarak tanınan kelimeleri ekranda gösterme  

\- ▶️ Başlat / ⏹️ Durdur butonlarıyla konuşma kontrolü  

\- ⚙️ Form kapanışında kaynak yönetimi ve temizleme (Dispose işlemi)



-----------------------------------



\## 🧩 Kullanılan Teknolojiler



| Teknoloji | Açıklama |

|------------|-----------|



| \*\*C# (.NET Framework)\*\* | Uygulama dili |



| \*\*Windows Forms\*\* | Arayüz oluşturma altyapısı |



| \*\*System.Speech.Recognition\*\* | Konuşma tanıma için kullanılan API |



| \*\*Visual Studio\*\* | Geliştirme ortamı |



--------------------------



\## ⚙️ Kurulum ve Çalıştırma



\### Gereksinimler

\- Windows işletim sistemi  

\- Visual Studio 2019 veya üzeri  

\- .NET Framework 4.7.2 veya daha yeni  

\- Mikrofon bağlantısı  



\### Adımlar

1\. Projeyi indir veya klonla:

&nbsp;  ```bash

&nbsp;  git clone https://github.com/firatysrgl/speech\_to\_text.git



2\. Visual Studio ile aç.



3\. System.Speech referansının eklendiğinden emin ol.



4\. Projeyi başlat (F5).



------------------------------------

💡 Kullanım



* Uygulama açıldığında “Konuşma Tanıma Motoru Hazır. Başlat’a tıklayın.” mesajı gelir.



* Başlat butonuna tıklayarak konuşmayı başlat.



* Mikrofonla konuştuğunda, tanınan metin RichTextBox üzerinde görüntülenir.



* Durdur butonuna basarak konuşmayı sonlandır.



----------------------------------------

🧠 Teknik Detaylar



* SpeechRecognitionEngine sınıfı sistemin varsayılan mikrofon girişini kullanır.



* DictationGrammar ile serbest konuşma tanıma (herhangi bir kelime sınırlaması olmadan) etkinleştirilmiştir.



* RecognizeAsync(RecognizeMode.Multiple) sürekli dinleme modunu sağlar.



* SpeechRecognized event’i her tanınan cümlede tetiklenir.



* Form kapatılırken recognizer.Dispose() çağrısı ile kaynak sızıntısı önlenir.



---------------------------------------

🧑‍💻 Geliştirici



👨‍💻 Fırat Yunus Yaşaroğlu

🎓 Yazılım Mühendisliği Öğrencisi – Fırat Üniversitesi

💻 Geliştirme Alanları: Java, C#, Spring Boot, .NET, Cybersecurity

📧 E-posta: firat9041@gmail.com



🐙 GitHub: github.com/firatysrgl



💼 LinkedIn: linkedin.com/in/fırat-yunus-yaşaroğlu



---------------------------------------------

📄 Lisans



Bu proje açık kaynak olup MIT Lisansı ile yayınlanmıştır.

Kodun herhangi bir kısmını özgürce inceleyebilir, düzenleyebilir ve geliştirebilirsiniz.





