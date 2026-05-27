# Лабораторна робота №1 — Породжувальні патерни (C# / .NET 8)

Реалізація **6 породжувальних патернів проєктування** мовою C# згідно з вимогами
лабораторної роботи.

## Структура

```
CreationalPatterns/
├── CreationalPatterns.csproj
├── Program.cs            # демонстрація всіх 6 патернів
└── Creational/
    ├── Singleton/        # 1. Singleton — Logger
    ├── FactoryMethod/    # 2. Factory Method — Logistics → Transport
    ├── AbstractFactory/  # 3. Abstract Factory — GUI Factory
    ├── Builder/          # 4. Builder — Computer + Director
    ├── Prototype/        # 5. Prototype — Shape (Circle/Rectangle)
    └── ObjectPool/       # 6. Object Pool — ConnectionPool
```

## Патерни

| # | Патерн           | Сценарій у проєкті                                  |
|---|------------------|-----------------------------------------------------|
| 1 | Singleton        | `Logger` — єдиний екземпляр (через `Lazy<T>`)       |
| 2 | Factory Method   | `Logistics` створює `Transport` (Truck / Ship)      |
| 3 | Abstract Factory | `IGUIFactory` створює родину Button + Checkbox      |
| 4 | Builder          | `ComputerDirector` + `*ComputerBuilder` → `Computer`|
| 5 | Prototype        | `Shape.Clone()` для Circle та Rectangle             |
| 6 | Object Pool      | `ConnectionPool` перевикористовує `DatabaseConnection` |

## Запуск

```bash
dotnet run
```

Вимоги: **.NET SDK 8.0+**.

## Автор

Олександр (BlackVarmir), група 244А, ЧНУ ім. Юрія Федьковича.
