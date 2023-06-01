Tablo oluşturma scripti ;

CREATE TABLE [dbo].[Kitaplar] (
    [KitapId]     INT          NOT NULL,
    [KitapAdı]    VARCHAR (50) NOT NULL,
    [KitapYazar]  VARCHAR (50) NOT NULL,
    [SayfaSayısı] INT          NOT NULL
);


Kaynak kodların içinde Main.cs içindeki connection stringe kendi değerlerinizi girmelisiniz.

Yazara göre ve kitaba göre filtrelemek için öncelikle tüm listeyi görüntülemelisiniz.
