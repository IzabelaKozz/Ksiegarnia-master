using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ksiegarnia.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "CartId", "CoverImagePath", "Description", "FavoriteId", "Price", "Title" },
                values: new object[] { 2, "James Clear", null, "2.jpg", "Nasz mózg nieustannie pracuje. Przetwarza ogromną ilość bodźców, wydobywa z nich istotne w danej chwili informacje, pozwala nam też koordynować konkretne zachowania. Gdybyśmy mieli robić to wszystko świadomie, nie sposób byłoby właściwie skupić się na czymkolwiek. Dlatego właśnie ogromna większość procesów mentalnych zachodzi nieświadomie. Nowej czynności uczymy się przy współudziale uwagi. W miarę nabierania sprawności czynność ta staje się coraz bardziej zautomatyzowana.\r\n\r\nRównież nawyki mają funkcję przystosowawczą, nasz mózg najbardziej lubi bowiem rytuały. Jest mu wtedy wygodniej pracować, poświęcać większość uwagi na inne sprawy. Dlatego czynność powtarzana regularnie staje się po pewnym czasie nawykowa. Nawykiem może być na przykład poranne i wieczorne mycie zębów, może nim stać się także codzienna gimnastyka. Istnieją rzecz jasna i takie nawyki, które okazują się dla nas szkodliwe. Może to być choćby palenie papierosów, podjadanie w środku nocy lub nerwowe obgryzanie paznokci.\r\n\r\n\"Atomowe nawyki\" to książka, która pomoże Ci uświadomić sobie, jaki mechanizm stoi za tego typu zachowaniami. Jej lektura uświadomi również, jak odróżniać dobre zwyczaje od tych szkodliwych. Autor prezentuje tu oryginalną, lecz popartą naukowymi dowodami metodę kształtowania dobrych przyzwyczajeń i wyzbywania się złych. W oparciu o najnowsze zdobycze nauk kognitywnych i behawioralnych James Clear stworzył jeden z pierwszych (jak sam pisze) modeli ludzkiego zachowania, w którym nawyki wynikają zarówno z bodźców zewnętrznych, jak i z wewnętrznych emocji.\r\n\r\nAtomowy model nawyków składa się z czterech kroków: wskazówki, pragnienia, reakcji i nagrody. Z kroków tych wynikają cztery prawa zmiany zachowania. Odnosząc je do samego siebie, czytelnik może zorientować się, jak działa nawyk, nad którym pragnie pracować oraz na jakim etapie i w jaki sposób nawyk ten można bądź wzmacniać, bądź też stopniowo się od niego uwalniać. Wiele spośród pojawiających się na kartach książki terminów jest doskonale znanych czytelnikom, zwłaszcza studentom i absolwentom psychologii lub kognitywistyki. Koncepcja czterech kroków oraz prawa zmian zachowania prezentują w pełni oryginalne podejście do zagadnienia zachowań nawykowych.", null, 29.55m, "Atomowe nawyki. Drobne zmiany, niezwykłe efekty" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);
        }
    }
}
