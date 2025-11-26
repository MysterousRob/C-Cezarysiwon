# Zadanie 3

Zdefiniuj w poniższej klasie `VendingMachine`:
- pola prywatne `_coin1`, `_coin2`, `_coin5` typu całkowitego, które zawierają liczbę monet o nominałach 1, 2 i 5,
- właściwość `Amount` do odczytu, która zwraca wartość wszystkich monet w automacie,
- metodę `InsertCoin` z parametrem typu int, który jest wartościa monety: 1, 2 lub 5.
  Metoda ignoruje pozostałe argumenty np. 6 7, 3 itd.
## Przykład użycia
```csharp
VendingMachine machine = new VendingMachine();
machine.InsertCoin(5);
machine.InsertCoin(1);
machine.InsertCoin(7);
Console.WriteLine(machine.Amount); // 6
```

Utwórz metodę statyczną o nazwie `VendingMachine`.
W niej przedstaw działanie klasy `VendingMachine`.