# 📦 EasyMap

**EasyMap** is a lightweight and simple object mapper for .NET.

It allows you to map data between two objects with minimal configuration — no magic, no heavy dependencies, just clean and predictable behavior.

---

## 🆕 Updates

### Update 1 — v0.1.3

* Added **dynamic object creation** via `CreateCustomObject`
* Allows building objects from key-value pairs
* Useful for flexible and runtime scenarios

Example:

```csharp
using EasyMap;

var factory = new ObjectFactory();

var obj = factory.CreateCustomObject(new Dictionary<string, object?>
{
    ["Name"] = "Alex",
    ["Age"] = 25
});
```

---

## ✨ Features

* Simple and minimal API
* No external dependencies
* Reflection-based mapping
* Copies only matching properties (by name and type)
* Dynamic object creation support
* Safe and predictable behavior

---

## 🚀 Installation

Install via NuGet:

```bash
dotnet add package EasyMap
```

---

## 🧩 Usage

### Define your models

```csharp
public class UserDto
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class UserEntity
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

---

### Map objects

```csharp
using EasyMap;

var mapper = new MapData<UserDto, UserEntity>();

var dto = new UserDto
{
    Name = "Alex",
    Age = 25
};

UserEntity entity = mapper.Map(dto);
```

---

## ⚙️ How it works

EasyMap:

* Creates a new instance of the destination type
* Finds properties with:
  * the same name
  * the same type
* Copies values from source to destination

Properties that do not match are ignored.

---

## ❗ Limitations

* No nested object mapping
* No custom mapping rules (yet)
* No support for different property names
* Uses reflection (not optimized for high-performance scenarios)

---

## 📄 License

MIT License

---

# 🇷🇺 EasyMap (Русская версия)

**EasyMap** — это простой и лёгкий маппер объектов для .NET.

Позволяет переносить данные между объектами без сложной настройки — без магии и лишних зависимостей.

---

## 🆕 Обновления

### Обновление 1 — v0.1.3

* Добавлено создание **динамических объектов** через `CreateCustomObject`
* Позволяет собирать объект из набора ключ-значение
* Полезно для гибких и runtime-сценариев

Пример:

```csharp
using EasyMap;

var factory = new ObjectFactory();

var obj = factory.CreateCustomObject(new Dictionary<string, object?>
{
    ["Name"] = "Alex",
    ["Age"] = 25
});
```

---

## ✨ Возможности

* Простой и понятный API
* Без внешних зависимостей
* Маппинг через reflection
* Копирование только совпадающих свойств (по имени и типу)
* Поддержка создания динамических объектов
* Предсказуемое поведение

---

## 🚀 Установка

Установка через NuGet:

```bash
dotnet add package EasyMap
```

---

## 🧩 Использование

### Определяем модели

```csharp
public class UserDto
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class UserEntity
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

---

### Маппинг

```csharp
using EasyMap;

var mapper = new MapData<UserDto, UserEntity>();

var dto = new UserDto
{
    Name = "Alex",
    Age = 25
};

UserEntity entity = mapper.Map(dto);
```

---

## ⚙️ Как это работает

EasyMap:

* Создаёт новый объект целевого типа
* Находит свойства с:
  * одинаковым именем
  * одинаковым типом
* Копирует значения

Несовпадающие свойства игнорируются.

---

## ❗ Ограничения

* Нет поддержки вложенных объектов
* Нет кастомных правил маппинга
* Нет поддержки разных имён свойств
* Использует reflection (не для high-performance сценариев)

---

## 📄 Лицензия

MIT License

