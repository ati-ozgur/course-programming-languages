## Auto boxing


### C# Autoboxing

- Boxing = wrapping a value type inside an object
- Unboxing = extracting it back


```cs
int x = 10;
object o = x;      // boxing
int y = (int)o;    // unboxing
```

### Java Autoboxing (Java 5+)


- Java has primitives (int, double) and wrapper classes (Integer, Double).

- Autoboxing automatically converts between them.

```java
int x = 10;
Integer i = x;   // autoboxing
int y = i;       // unboxing
```

Daha önce 

```java
// Java 1.4 and earlier
int x = 10;
Integer i = Integer.valueOf(x);
int y = i.intValue();
```

Özellikle koleksiyonlar primitive değerleri kabul etmedikleri için kod daha karışık oluyordu.
auto-boxing daha rahat okunur ve kısa kod yazmamıza olanak verir.



### Javascript Autoboxing 

JavaScript primitive values ve Nesne karşılıkları

- number --> Number
- string --> String
- boolean --> Boolean
- ..

JS bu primitif değerleri method kullandığımı zaman otomatikmen nesne karşılıklarına çevirir.


```js
let s = "hello";
console.log(s.toUpperCase());
// aslında aşağıdakine benzeyen bir şey olur
new String("hello").toUpperCase();
```

**C#/Java'ya göre Anahtar farklar**

- Boxing (kutulama) geçici ve görünmezdir
- Nesneler genellikle gözlemlenemez
- JS çalıştırma motorları agresif bir şekilde optimizasyon yapar

