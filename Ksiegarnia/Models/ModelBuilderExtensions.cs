﻿namespace Ksiegarnia.Models
{
    // Data/ModelBuilderExtensions.cs
    using Microsoft.EntityFrameworkCore;

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "Święta na świecie", Author = "Sofie Maria Brand", Description = "Kto z was chciałby dostać pod choinkę zęby morsa albo zgniłego ziemniaka? Co by było, gdyby przyjechał do was Mikołaj na saniach, które ciągną kangury?\r\n\r\nOkazuje się, że pachnąca żywicą choinka, karp i łamanie się opłatkiem to niejedyne sposoby obchodzenia Gwiazdki. Jak wygląda ona w innych zakątkach świata?\r\n\r\nW Meksyku w stajence zamiast choinek są kaktusy. We Włoszech w ogóle nie ma Mikołaja - prezenty roznosi Befana, uśmiechnięta stara wiedźma, która lata na miotle z workiem na plecach! Islandzkim dzieciom w czasie świąt towarzyszą zaś psotne skrzaty: złodziej naleśników, oblizywacz łyżek, trzaskacz drzwiami, węszyciel szpar i rabuś… parówek.\r\n\r\nW Norwegii na wigilijnym stole króluje danie, które potwornie cuchnie, ale smakuje cudownie. To lutefisk, czyli ryba suszona na słońcu i wietrze. W Rosji z kolei najważniejszą potrawą jest słodka kasza, którą dawniej wszyscy domownicy jedli z jednej miski. Po kolacji należało rzucić łyżką w sufit. Po co? Przeczytajcie!\r\n\r\nZobaczcie, jak wspaniale obchodzi się święta w różnych częściach świata!", Price = 39.99M, CoverImagePath = "1.jpg"},
                new Book { BookId = 2, Title = "Atomowe nawyki. Drobne zmiany, niezwykłe efekty", Author = "James Clear", Description = "Nasz mózg nieustannie pracuje. Przetwarza ogromną ilość bodźców, wydobywa z nich istotne w danej chwili informacje, pozwala nam też koordynować konkretne zachowania. Gdybyśmy mieli robić to wszystko świadomie, nie sposób byłoby właściwie skupić się na czymkolwiek. Dlatego właśnie ogromna większość procesów mentalnych zachodzi nieświadomie. Nowej czynności uczymy się przy współudziale uwagi. W miarę nabierania sprawności czynność ta staje się coraz bardziej zautomatyzowana.\r\n\r\nRównież nawyki mają funkcję przystosowawczą, nasz mózg najbardziej lubi bowiem rytuały. Jest mu wtedy wygodniej pracować, poświęcać większość uwagi na inne sprawy. Dlatego czynność powtarzana regularnie staje się po pewnym czasie nawykowa. Nawykiem może być na przykład poranne i wieczorne mycie zębów, może nim stać się także codzienna gimnastyka. Istnieją rzecz jasna i takie nawyki, które okazują się dla nas szkodliwe. Może to być choćby palenie papierosów, podjadanie w środku nocy lub nerwowe obgryzanie paznokci.\r\n\r\n\"Atomowe nawyki\" to książka, która pomoże Ci uświadomić sobie, jaki mechanizm stoi za tego typu zachowaniami. Jej lektura uświadomi również, jak odróżniać dobre zwyczaje od tych szkodliwych. Autor prezentuje tu oryginalną, lecz popartą naukowymi dowodami metodę kształtowania dobrych przyzwyczajeń i wyzbywania się złych. W oparciu o najnowsze zdobycze nauk kognitywnych i behawioralnych James Clear stworzył jeden z pierwszych (jak sam pisze) modeli ludzkiego zachowania, w którym nawyki wynikają zarówno z bodźców zewnętrznych, jak i z wewnętrznych emocji.\r\n\r\nAtomowy model nawyków składa się z czterech kroków: wskazówki, pragnienia, reakcji i nagrody. Z kroków tych wynikają cztery prawa zmiany zachowania. Odnosząc je do samego siebie, czytelnik może zorientować się, jak działa nawyk, nad którym pragnie pracować oraz na jakim etapie i w jaki sposób nawyk ten można bądź wzmacniać, bądź też stopniowo się od niego uwalniać. Wiele spośród pojawiających się na kartach książki terminów jest doskonale znanych czytelnikom, zwłaszcza studentom i absolwentom psychologii lub kognitywistyki. Koncepcja czterech kroków oraz prawa zmian zachowania prezentują w pełni oryginalne podejście do zagadnienia zachowań nawykowych.", Price = 29.55M, CoverImagePath = "2.jpg" }
            );
        }
    }

}